using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week4Closing.Abstract;

namespace Week4Closing.Concrete
{
    internal class Computer : BaseMachine
    {
        int _UsbPorts; // Using Encapsulation, Usb Port 2 or 4 is set to be defined as -1 by default when an external value is entered
        public int UsbPorts
        {
           get
            {
                return _UsbPorts;
            }
            set
            {
                if (_UsbPorts == 2 || value == 4)
                _UsbPorts = value;
                else
                {
                    _UsbPorts = -1;
                    Console.WriteLine("Incorrect input port number is set to -1 by default, the number of usb ports can be 2 or 4");
                }
            }
        }
        public bool Bluetooth { get; set; }

        public override void PrintInfo() // PrintInfo method reused with Polymorphism method
        {
            base.PrintInfo();
            Console.WriteLine($"Usb Ports: {UsbPorts} Bluetooth Available?: {(Bluetooth ? "Yes" : "No")}");
        }

        public override void GetProductName() // Abstract method named GetProductName() was used
        {
            Console.WriteLine($"Computer Name: {Name}");
        }
    }
}
