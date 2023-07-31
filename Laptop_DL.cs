using app.BL;
using app.Forms;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app.DL
{
    public class Laptop_DL
    {
        private static List<Laptop> laptoplist = new List<Laptop>();
        private static List<Laptop> laptops = new List<Laptop>();
        public static List<Laptop> List { get { return laptoplist; } set { laptoplist = value; } }
        public static bool Addlaptop(Laptop item, string path)
        {
            laptoplist.Add(item);
            storeintofile(item, path);
            return true;
        }
        public static bool deletelaptop(string company, string name, string modelno)
        {
            foreach (Laptop product in laptoplist)
            {
                if (product.Name == name && product.Company == company && product.ModelNo == modelno)
                {
                    laptoplist.Remove(product);
                    return true;
                }
            }
            return false;
        }
        public static Laptop getitemfromlist(string company, string name, string modelno)
        {
            foreach (Laptop product in laptoplist)
            {
                if (product.Name == name && product.Company == company && product.ModelNo == modelno)
                {
                    return product;
                }
            }
            return null;
        }
        public static List<Laptop> viewlaptoplist()
        {
            return laptoplist;
        }
        public static int recommendeditems(double price)
        {
            foreach (Laptop product in Laptop_DL.List)
            {
                
            }
            return 0;
        }
        public static List<Laptop> viewitemfromcompany(string company)
        {
            foreach (Laptop product in laptoplist)
            {
                if (product.Company.Equals(company))
                {
                    laptops.Add(product);
                }
            }
            return laptops;
        }
        public static List<Laptop> viewitemfromseriesname(string name)
        {
            foreach (Laptop product in laptoplist)
            {
                if (product.Name == name)
                {
                    laptops.Add(product);
                }
            }
            return laptops;
        }
        public static List<Laptop> viewitemfromyear(int year)
        {
            foreach (Laptop product in laptoplist)
            {
                if (product.Yearlaunch.Equals(year))
                {
                    laptops.Add(product);
                }
            }
            return laptops;
        }
        public static List<Laptop> viewitemfromgeneration(string generation)
        {
            foreach (Laptop product in laptoplist)
            {
                if (product.Generation.Equals(generation))
                {
                    laptops.Add(product);
                }
            }
            return laptops;
        }
        public static List<Laptop> viewitemfromcore(string core)
        {
            foreach (Laptop product in laptoplist)
            {
                if (product.Core.Equals(core))
                {
                    laptops.Add(product);
                }
            }
            return laptops;
        }
        public static List<Laptop> viewitemfromdisplay(string display)
        {
            foreach (Laptop product in laptoplist)
            {
                if (product.Display.Equals(display))
                {
                  laptops.Add(product);
                }
            }
            return laptops;
        }
        public static List<Laptop> viewitemfromscreensize(string size)
        {
            foreach (Laptop product in laptoplist)
            {
                if (product.dpdimensions.Equals(size))
                {
                    laptops.Add(product);
                }
            }
            return laptops;
        }
        public static List<Laptop> viewitemfromram(string ram)
        {
            foreach (Laptop product in laptoplist)
            {
                if (product.Ram.Equals(ram))
                {
                   laptops.Add(product);
                }
            }
            return laptops;
        }
        public static List<Laptop> viewitemfrombatterytype(string type)
        {
            foreach (Laptop product in laptoplist)
            {
                if (product.BatteryType.Equals(type))
                {
                   laptops.Add(product);
                }
            }
            return laptops;
        }
        public static List<Laptop> viewitemfromtime(float Btime)
        {
            foreach (Laptop product in laptoplist)
            {
                if (product.Battery.Equals(Btime))
                {
                   laptops.Add(product);
                }
            }
            return laptops;
        }
        public static List<Laptop> viewitemfromprocessor(float processor)
        {
            foreach (Laptop product in laptoplist)
            {
                if (product.Processorspeed.Equals(processor))
                {
                   laptops.Add(product);
                }
            }
            return laptops;
        }
        public static List<Laptop> viewitemfromprice(float price)
        {
            foreach (Laptop product in laptoplist)
            {
                if (product.Price.Equals(price))
                {
                   laptops.Add(product);
                }
            }
            return laptops;
        }
        public static List<Laptop> viewitemfrommodel(string modelno)
        {
            foreach (Laptop product in laptoplist)
            {
                if (product.ModelNo.Equals(modelno))
                {
                   laptops.Add(product);
                }
            }
            return laptops;
        }
        public static List<Laptop> viewitemfromstatus(string status)
        {
            foreach (Laptop product in laptoplist)
            {
                if (product.Status.Equals(status))
                {
                   laptops.Add(product);
                }
            }
            return laptops;
        }
        public static List<Laptop> viewitemfromspecificdiscount(float amount)
        {
            foreach (Laptop product in laptoplist)
            {
                if (product.Discount == amount)
                {
                   laptops.Add(product);
                }
            }
            return laptops;
        }
        public static List<Laptop> viewitemfromdiscount()
        {
            foreach (Laptop product in laptoplist)
            {
                if (product.Discount > 0)
                {
                   laptops.Add(product);
                }
            }
            return laptops;
        }
        public static bool storeintofile(Laptop product, string path)
        {
            StreamWriter file = new StreamWriter(path, true);
            file.WriteLine(product.Company + "," + product.Name + "," + product.Yearlaunch + "," + product.Core + "," + product.Display + "," + product.dpdimensions + "," + product.Ram + "," + product.Battery + "," + product.BatteryType + "," + product.Price + "," + product.Noofitems + "," + product.ModelNo + "," + product.Generation + "," + product.Status + "," + product.Processorspeed);
            file.Flush();
            file.Close();
            return true;
        }
        public static List<Laptop> read_from_file(List<Laptop> list, string path)
        {
            StreamReader file = new StreamReader(path);
            string record;
            if (File.Exists(path))
            {
                while ((record = file.ReadLine()) != null)
                {
                    string[] splittedrecord = record.Split(',');
                    string company = splittedrecord[0];
                    string name = splittedrecord[1];
                    int year = int.Parse(splittedrecord[2]);
                    string core = splittedrecord[3];
                    string display = splittedrecord[4];
                    string dpdimensions = splittedrecord[5];
                    string ram = splittedrecord[6];
                    int battery = int.Parse(splittedrecord[7]);
                    string batterytype = splittedrecord[8];
                    float price = float.Parse(splittedrecord[9]);
                    int noofitems = int.Parse(splittedrecord[10]);
                    string model = splittedrecord[11];
                    string generation = splittedrecord[12];
                    string status = splittedrecord[13];
                    float processor = float.Parse(splittedrecord[14]);
                    Laptop product = new Laptop(processor, generation, company, name, year, core, display, dpdimensions, ram, batterytype, battery, price, noofitems, model, status);
                    list.Add(product);
                }
            }
            return list;
        }
    }
}
