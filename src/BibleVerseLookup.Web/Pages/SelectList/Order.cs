using System;

namespace BibleVerseLookup.Web.Pages.SelectList
{
	public class Order
	{
		public int Id { get; set; }
		public DateTime OrderedAt { get; set; }
		public string Username { get; set; }
		public OrderStatus Status { get; set; } = OrderStatus.New;

		public override string ToString() => $"Id: {Id}; Ordered At: {OrderedAt}; User Name: {Username}; Status:{Status}";


	}

	public enum OrderStatus
	{
		New,
		Pending,
		Shipped,
		Delivered
	}
}
