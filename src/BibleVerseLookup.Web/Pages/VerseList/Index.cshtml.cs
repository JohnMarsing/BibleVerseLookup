using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BibleVerseLookup.Web.Pages.VerseList
{
	public class IndexModel : PageModel
	{
		public string Verse { get; set; } = "???";

		public string Title { get; set; } = "Landing Page";

		public void OnGet(string verse)
		{
			Verse = verse;
		}
	}
}