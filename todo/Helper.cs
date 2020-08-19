using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
namespace BibleVerseLookup.Web.Core
{
	public static class Helpers
	{
		public static IHtmlContent ViewPort(this IHtmlHelper instance, string size, Microsoft.AspNetCore.Hosting.IHostingEnvironment env)
		{
			if (env.EnvironmentName == "Development")
			{
				return instance.Raw("<sup> " + size + "</sup>");
			}
			else
			{
				return instance.Raw("");
			}
		}
  }
}