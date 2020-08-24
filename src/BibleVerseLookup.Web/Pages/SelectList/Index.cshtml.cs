using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
//using static BibleVerseLookup.Web.Helpers.SelectList;
//using BibleVerseLookup.Web.Helpers

namespace BibleVerseLookup.Web.Pages.SelectList
{
	public class IndexModel : PageModel
	{
    [TempData]
    public string Message { get; set; }

    static Order State { get; } = new Order
    {
      Id = 1,
      Username = "John.Marsing",
      OrderedAt = DateTime.Now,
      Status = OrderStatus.New
    };

    [BindProperty] public Order Current { get; set; }
    public List<SelectListItem> Statuses { get; }
        = BibleVerseLookup.Web.Helpers.SelectList.Create<OrderStatus>();

    public void OnGet()
    {
      Message = "";
      Current = State;
    }

    public void OnPost()
    {
      State.Status = Current.Status;
      Current = State;
      Message = "State Dump... <br />" + State.ToString();
    }
  }
}
