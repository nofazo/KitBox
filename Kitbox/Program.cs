using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kitbox
{
    class CupBoard
    {
        public double width;
        public double depth;
        public int lockerNumber;
        public List<Locker> lockerList;
        public Extrusion extrusion;
        //liste cornière après

        public CupBoard (double width, double depth, int lockerNumber)
        {
            this.width = width;
            this.depth = depth;
            this.lockerNumber = lockerNumber;
        }

        public double GetPrice()
        {
            double lockerPrice = 0;
            foreach (Locker locker in lockerList)
            {
                lockerPrice += locker.GetPrice();
            }

            double extrusionPrice = extrusion.GetPrice();

            return lockerPrice + extrusionPrice ;
        }
    }

    class Extrusion
    {
        public string color;
        public double height;
        public double price;

        public Extrusion (string color, double height, double price)
        {
            this.color = color;
            this.height = height;
            this.price = price;
        }

        public double GetPrice()
        {
            return price;
        }

    }


    class Locker
    {
        public double lockerHeight;
        public string color;
        public List<Accessory> accessoryList;

        public Locker (double lockerHeight, string color)
        {
            this.lockerHeight = lockerHeight;
            this.color = color;
        }

        public double GetPrice()
        {
            double result = 0;

            foreach (Accessory elem in accessoryList)
            {
                result += elem.GetPrice();
            }

            return result;
        }

    }

    public abstract class Accessory
    {
       // public double price;
       // public bool isMajor;

        public abstract double GetPrice();
        public abstract bool IsMajor();
    }

    public class Door : Accessory
    {
        public double height;
        public double width;
        public string color;
        public string material;
        public double price;
        public bool isMajor = false;

        public Door (double height, double width, string color, string material)
        {
            this.height = height;
            this.width = width;
            this.color = color;
            this.material = material;
        }

        public override double GetPrice()
        {
            return price;
        }

        public override bool IsMajor()
        {
            return isMajor;
        }
    }

    public class Cleat: Accessory
    {
        public double height;
        public double price;
        public bool isMajor = true;

        public Cleat(double height)
        {
            this.height = height;
        }

        public override double GetPrice()
        {
            return price;
        }

        public override bool IsMajor()
        {
            return isMajor;
        }
    }

    public class Rail : Accessory
    {
        public double price;
        public bool isMajor = true;

        public Rail()
        {

        }

        public override double GetPrice()
        {
            return price;
        }

        public override bool IsMajor()
        {
            return isMajor;
        }
    }

    public class Panel : Accessory
    {
        public string color;
        public double price;
        public bool isMajor = true;

        public Panel(string color)
        {
            this.color = color;
        }

        public override double GetPrice()
        {
            return price;
        }

        public override bool IsMajor()
        {
            return isMajor;
        }

    }

}
