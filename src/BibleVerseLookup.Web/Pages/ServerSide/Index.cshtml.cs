using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using BibleVerseLookup.Web.Models;

namespace BibleVerseLookup.Web.Pages.ServerSide
{
	public class IndexModel : PageModel
	{
		[BindProperty]
		public VerseRange VerseRange { get; set; }

		[BindProperty]
		public bool AutoSuggested { get; set; }


		public void OnGet(TestCase test = TestCase.None, bool autosuggested = true)
		{

			switch (test)
			{
				case TestCase.None:
					break;

				case TestCase.Gen_1_1_1:
					VerseRange = new VerseRange { Book = "Genesis", ChapterBeg = 1, VerseBeg = 1, ChapterEnd = 1, VerseEnd = 1 };
					break;

				case TestCase.Gen_1_1_2:
					VerseRange = new VerseRange { Book = "Genesis", ChapterBeg = 1, VerseBeg = 1, ChapterEnd = 1, VerseEnd = 2 };
					break;

				case TestCase.Gen_1_2_2_1:
					VerseRange = new VerseRange { Book = "Genesis", ChapterBeg = 1, VerseBeg = 2, ChapterEnd = 2, VerseEnd = 1 };
					break;

				case TestCase.Gen_1_3_2_1:
					VerseRange = new VerseRange { Book = "Genesis", ChapterBeg = 1, VerseBeg = 3, ChapterEnd = 2, VerseEnd = 1 };
					break;

				default:
					break;
			}

			AutoSuggested = autosuggested;


		}

		public IActionResult OnPostNormal(VerseRange verseRange)
		{
			string verseUrl = $"{verseRange.Book}-{verseRange.ChapterBeg}-{verseRange.VerseBeg}-{verseRange.ChapterEnd}-{verseRange.VerseEnd}";
			return RedirectToPage(Anchors.VerseList.Index, new { verse = verseUrl });
		}

		public IActionResult OnPostReset()
		{
			VerseRange = new VerseRange { Book = "Genesis", ChapterBeg = 1, VerseBeg = 1, ChapterEnd = 2, VerseEnd = 3 };
			return RedirectToPage(Anchors.ServerSide.Index);
		}

	}
}
