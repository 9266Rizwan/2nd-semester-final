using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app.BL
{
    public class Laptop
    {
        protected string company;
        protected string name;
        protected int yearlaunch;
        protected string core;
        protected string display;
        protected string Dpdimensions;
        protected string ram;
        protected string batterytype;
        protected int battery;
        private string camera;
        private float processorspeed;
        private string generation;
        protected string modelno;
        protected float price;
        protected float usdollars;
        protected int noofitems;
        protected string status;
        protected float discount;
        protected float euro;
        protected float dollarrate = 286.95F;
        protected float eurorate = 308.58F;
        public Laptop(float processor, string generation, string company, string name, int yearlaunch, string core, string display, string Dpdimensions, string ram, string batterytype, int battery, float price, int noofitems, string modelno, string status)
        {
            this.company = company;
            this.name = name;
            this.yearlaunch = yearlaunch;
            this.core = core;
            this.display = display;
            this.Dpdimensions = Dpdimensions;
            this.ram = ram;
            this.batterytype = batterytype;
            this.battery = battery;
            this.price = price;
            this.noofitems = noofitems;
            this.processorspeed = processor;
            this.generation = generation;
            this.modelno = modelno;
            this.status = status;
        }
        public string Company { get { return company; } set { this.company = value; } }
        public string Name { get { return name; } set { this.name = value; } }
        public int Yearlaunch { get { return yearlaunch; } set { this.yearlaunch = value; } }
        public string Core { get { return core; } set { this.core = value; } }
        public string Display { get { return display; } set { this.display = value; } }
        public string dpdimensions { get { return Dpdimensions; } set { this.Dpdimensions = value; } }
        public string Ram { get { return ram; } set { this.ram = value; } }
        public string BatteryType { get { return batterytype; } set { this.batterytype = value; } }
        public int Battery { get { return battery; } set { this.battery = value; } }
        public float Price { get { return price; } set { this.price = value; } }
        public float Dollar { get { return usdollars; } set { this.usdollars = price * dollarrate; } }
        public float Euro { get { return euro; } set { this.euro = price * eurorate; } }
        public int Items { get { return noofitems; } set { this.noofitems = value; } }
        public string Camera { get { return camera; } set { this.camera = value; } }
        public float Processorspeed { get { return processorspeed; } set { this.processorspeed = value; } }
        public string Generation { get { return generation; } set { this.generation = value; } }
        public string ModelNo { get { return modelno; } set { this.modelno = value; } }
        public string Status { get { return status; } set { this.status = value; } }
        public float Discount { get { return discount; } set { this.discount = price - (price * (discount / 100)); } }
        public int Noofitems { get { return noofitems; } set { noofitems = value; } }
    }
}
