using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poiis2._0
{
    public class Customer : Person
    {
        public Customer(string name) : base(name) { }
        List<string> OrderHistory { get; set; } = new List<string>();

        public void MakeOrder(string dish, int quantity)
        {
            OrderHistory.Add(dish);
        }

        public void ShowHistoryOrders()
        {
            foreach (string d in OrderHistory)
            {
                Console.WriteLine(d);
            }
        }

        public void LeaveReview(Dish dish, string review)
        {
            Console.WriteLine($"Покупатель {Name} оставляет отзыв о блюде {dish.GetName()}: {review}");
        }
    }


}
