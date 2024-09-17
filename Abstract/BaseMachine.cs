using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4Closing.Abstract
{
    internal abstract class BaseMachine // Abstract Class was defined to give inheritance
    {
        protected BaseMachine() // Production Date default constructor definition was made to save the production date when production is produced
        {
            ProductionDate = DateTime.Now;
        }
        public DateTime ProductionDate { get; set; }
        public int SerialNumber { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string OperatingSystem { get; set; }

        public virtual void PrintInfo() // Product information printed using Polymorphism
        {
            Console.WriteLine($"Production Date: {ProductionDate} Serial Number: {SerialNumber} Product Name: {Name} Description: {Description} Operation System: {OperatingSystem} ");
        }

        public abstract void GetProductName(); // Defined Abstract method that other classes can access and use
    }
}
