using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Laptop_Shop
{

    class Laptop
    {
        // instance of class Battery
        private Battery battery;

        // The fields
        private string model;
        private string manufacturer;
        private string processor;
        private int ram; 
        private string graphicsCard;
        private int hdd;
        private double batteryLife;
        private string screenSize;
        private decimal price;

        // The constructors
        public Laptop(string model, decimal price)
        {
            this.Model = model;
            this.Price = price;
        }
        public Laptop(string model, string manufacturer, string processor, string graphicsCard, decimal price)
            : this(model, price)
        {
            this.Manufacturer = manufacturer;
            this.Processor = processor;
            this.GraphicsCard = graphicsCard;
        }
        public Laptop(string model, string manufacturer, string processor, int ram, string graphicsCard, int hdd, string screenSize, Battery battery, double batteryLife, decimal price)
            : this(model, manufacturer, processor, graphicsCard, price)
        {
            this.HDD = hdd;
            this.RAM = ram;
            this.Battery = battery;
            this.BatteryLife = batteryLife;
            this.ScreenSize = screenSize;
        }

        // The property
        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The model field cannot be empty");
                }
                this.model = value;
            }
        }
        public string Manufacturer
        {
            get
            {
                return this.manufacturer;
            }
            set
            {
                if (value!=null&&value.Length < 1)
                {
                    throw new ArgumentException("The manufacturer field cannot be empty");
                }
                this.manufacturer = value;
            }
        }
        public string Processor
        {
            get
            {
                return this.processor;
            }
            set
            {
                if (value != null && value.Length < 1)
                {
                    throw new ArgumentException("The processor field cannot be empty");
                }
                else
                {
                    this.processor = value;
                }
            }
        }
        public string GraphicsCard
        {
            get
            {
                return this.graphicsCard;
            }
            set
            {
                if (value != null && value.Length < 1)
                {
                    throw new ArgumentException("The graphics card field cannot be empty");
                }
                else
                {
                    this.graphicsCard = value;
                }
            }
        }
        public double BatteryLife
        {
            get 
            { 
                return this.batteryLife; 
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The battery life cannot be negative");
                }
                else { this.batteryLife = value; }
            }
        }
        public string ScreenSize
        {
            get 
            {
                return this.screenSize;
            }
            set
            {
                if (value != null && value.Length < 1)
                {
                    throw new ArgumentException("The graphics card field cannot be empty");
                }
                else
                {
                    this.screenSize = value;
                }
            }
        }
        public decimal Price
        {
            get 
            {
                return this.price;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("The price cannot be a 0 or smaller");
                }
                else
                {
                    this.price = value;
                }
            }
        }
        public Battery Battery
        {
            get
            {
                return this.battery;
            }
            set
            {
                    this.battery = value;
            }
        }
        public int RAM
        {
            get { return this.ram; }
            set
            {
                if (value<0)
                {
                    throw new ArgumentException("The RAM field cannot be negative");
                }
                else { this.ram = value; }
            }
        }
        public int HDD
        {
            get { return this.hdd; }
            set
            {
                if (value<0)
                {
                    throw new ArgumentException("The HDD field cannot be negative");
                }
                else
                {
                    this.hdd = value;
                }
            }
        }
        

        //override -> ToString
        public override string ToString()
        {
            if (this.Processor == null || this.Processor.Length<1)
            {
                return String.Format("Model: {0}\nPrice: {1:0.00} lv.",  this.Model, this.Price);
            }
            else if (this.ScreenSize == null || this.ScreenSize.Length<1)
            {
                return String.Format("Model: {1}\nManufacturer: {0}\nProcessor: {2}\nGraphic card: {3}\nPrice: {4:0.00} lv.", this.Manufacturer, this.Model, this.Processor, this.GraphicsCard, this.Price);
            }
            else
            {
                return String.Format("Model: {1}\nManufacturer: {0}\nProcessor: {2}\nRAM: {8} GB\nGraphic card: {3}\nHDD: {9} GB SSD\nScreen size: {6}\nBattery {4}\nBattery life: {5} hours\nPrice: {7:0.00} lv.", this.Manufacturer, this.Model, this.Processor, this.GraphicsCard, this.Battery, this.BatteryLife, this.ScreenSize, this.Price, this.RAM, this.HDD);
            }
            
        }
    }

}
