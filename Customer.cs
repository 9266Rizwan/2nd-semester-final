using app.DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app.BL
{
    public class Customer : User
    {
        private List<Laptop> cartlist = new List<Laptop>();
        public Customer(string name, string email, string password, string role) : base(name, email, password, role) { }
        public List<Laptop> Cartlist { get { return cartlist; } set { cartlist = value; } }
        public bool Addintocartlist(Laptop product)
        {
            cartlist.Add(product);
            Laptop_DL.storeintofile(product, this.Email);
            return true;
        }
        public bool deletefromcartlist(Laptop product)
        {
            foreach (Laptop item in cartlist)
            {
                if (item.Company.Equals(product.Company) && item.ModelNo.Equals(product.ModelNo))
                {
                    cartlist.Remove(item);
                    return true;
                }
            }
            return false;
        }
        public int showchartlist()
        {
            foreach (Laptop item in cartlist)
            {
                //Laptop_UI.viewLaptop(item);
            }
            return 0;
        }
        public double totalbill()
        {
            double total = 0;
            foreach (Laptop item in cartlist)
            {
                total = total + item.Price;
            }
            return total;
        }
    }
}
