using System.Collections;
using System.Net.Security;
using System.Reflection.Emit;

namespace ConsoleApp11411
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] Menu = new string[] {"1. Paytaxt Salati",  "2. Mimoxza"};
            User user1 = new Admin();
            Waiter user2 = new Waiter();
            user2.Menu = Menu;
            user2.TakeOrder(1);
            user2.OrderShow();
            
          
        }
        public abstract class User
        {
            public string Name { get; set; }
            public int Password { get; set; }

            public abstract void Introduce();            
        }
        class Admin : User
        {
            public override void Introduce()
            {
                Console.WriteLine(Name);
            }
            public void GetReport()
            {

            }
        }
        class Waiter : User
        {
            public string[] Menu { get; set; }
            ArrayList OrderList;
            public void GiveMenu()
            {
                for (int i =0; i < Menu.Length; i++)
                {
                    Console.WriteLine(Menu[i]);
                }
            }
            public void TakeOrder(int a)
            {
                OrderList.Add(Menu[a - 1]);

            }
            public void OrderShow()
            {
                for (int j = 0; j < OrderList.Count; j++)
                {
                    Console.WriteLine(OrderList[j]);
                }
            }
            
            
            
            
            public override void Introduce()
            {
                Console.WriteLine(Name);
            }
        }
    }
}