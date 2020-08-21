using System;
using System.Collections.Generic;
using System.Linq;

namespace BibleVerseLookup.Web.Extensions
{
  // https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/linq/how-to-add-custom-methods-for-linq-queries
  public static class LINQExtensions
  {
    public static IQueryable<T> If<T>(
      this IQueryable<T> query,
      bool should,
      params Func<IQueryable<T>, IQueryable<T>>[] transforms)
    {
      return should
          ? transforms.Aggregate(query,
              (current, transform) => transform.Invoke(current))
          : query;
    }

    public static IEnumerable<T> If<T>(
      this IEnumerable<T> query,
      bool should,
      params Func<IEnumerable<T>, IEnumerable<T>>[] transforms)
    {
      return should
          ? transforms.Aggregate(query,
              (current, transform) => transform.Invoke(current))
          : query;
    }
  }
}
