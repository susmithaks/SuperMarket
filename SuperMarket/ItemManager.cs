using SuperMarket.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarket
{
    public class ItemManager
    {
        SuperMarketContext dbcontext = new SuperMarketContext();


        public void AddItem()
        {

            Console.WriteLine("Enter the Item Name");
            String Itmname = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter the Item Quanitity");
            int ItmQuantity = Convert.ToInt32(Console.ReadLine());
            ItemDetails itemDetails = new ItemDetails()
            {
                Name = Itmname,
                Quanitity = ItmQuantity,

            };
            dbcontext.ItemDetails.Add(itemDetails);
            dbcontext.SaveChanges();
        }
        
        public void UpdateItem()
        {
            Console.WriteLine("Enter the itemID Which u want to update");
            int Updateid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the new itemname that u want to change");
            string Updatename = Convert.ToString(Console.ReadLine());
            var Result = dbcontext.ItemDetails.FirstOrDefault(s => s.Id == Updateid);
            if (Result != null) ;
            Result.Name = Updatename;
            dbcontext.SaveChanges();

        }
        public void DeleteItem()
        {
            Console.WriteLine("Enter the itemID Which u want to Delete");
            int DeleteID = Convert.ToInt32(Console.ReadLine());
            var Result = dbcontext.ItemDetails.FirstOrDefault(s => s.Id == DeleteID);
            if (Result != null)
                dbcontext.ItemDetails.Remove(Result);
                dbcontext.SaveChanges();
            
        }
        public void ViewItem()
        {
            var a = dbcontext.ItemDetails.ToList();
            Console.WriteLine(" ID   | Name   |  Quantity");
            foreach (var ItemDetails in a)
            {
               
                Console.WriteLine(ItemDetails.Id + "   |   " + ItemDetails.Name + "   |   " + ItemDetails.Quanitity + "   |   ");

            }



        }


            

        

    }
}
