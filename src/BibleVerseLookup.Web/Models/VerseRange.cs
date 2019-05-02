namespace BibleVerseLookup.Web.Models
{
	public class VerseRange
	{
		public string Book { get; set; }
		public byte ChapterBeg { get; set; }
		public byte VerseBeg { get; set; }
		public byte ChapterEnd { get; set; }
		public byte VerseEnd { get; set; }
	}
}
