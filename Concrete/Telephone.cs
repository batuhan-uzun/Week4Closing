using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week4Closing.Abstract;

namespace Week4Closing.Concrete
{
    internal class Telephone : BaseMachine
    {
        public bool TrLicense { get; set; }

        public override void PrintInfo() // PrintInfo method reused with Polymorphism method
        {
            base.PrintInfo();
            Console.WriteLine($"Usb Ports: {(TrLicense ? "TR License Available" : "TR License Not Available")}");
        }

        public override void GetProductName() // Abstract method named GetProductName() was used
        {
            Console.WriteLine($"Telephone Name: {Name}");
        }
    }
}
