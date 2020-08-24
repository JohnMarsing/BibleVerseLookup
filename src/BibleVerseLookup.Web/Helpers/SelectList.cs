using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BibleVerseLookup.Web.Helpers
{
	public static class SelectList
  {
    public static List<SelectListItem> Create<TEnum>
        (bool includeEmptyOption = false)
    {
      var type = typeof(TEnum);
      if (!type.IsEnum)
      {
        throw new ArgumentException("type must be an enum",  nameof(type));
      }

      //ToDo: can I convert this to 'EnumReplacement'?
      var result =
          Enum
              .GetValues(type)
              .Cast<TEnum>()
              .Select(v =>
                  new SelectListItem(
                  v.ToString(),
                  v.ToString()
                  )
              )
              .ToList();
      
      if (includeEmptyOption) 
      {
        // Insert the empty option at the beginning
        result.Insert(0, new SelectListItem("Pick An Option", "")
        );
      }

      return result;
    }
  }
}
