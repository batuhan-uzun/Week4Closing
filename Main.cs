using System.ComponentModel;
using System.Reflection;
using System.Xml.Linq;
using Week4Closing.Abstract;
using Week4Closing.Concrete;

Base:

Console.WriteLine("Press '1' to produce a telephone and '2' to produce a computer");
int choice = Convert.ToInt32(Console.ReadLine()); // Information about whether the user wanted to produce a Computer or a Phone was kept
string reproduction; // Information about whether the user wants to produce again after producing a product was kept

if (choice == 1)
{
    Telephone telephone = new Telephone(); // Created an object of type telephone, retrieved the information from the user and printed it on the screen with methods
    Console.WriteLine("Enter Serial Number: ");
    telephone.SerialNumber = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter Telephone Name: ");
    telephone.Name = Console.ReadLine();
    Console.WriteLine("Enter Description: ");
    telephone.Description = Console.ReadLine();
    Console.WriteLine("Enter Operating System: ");
    telephone.OperatingSystem = Console.ReadLine();
    Console.WriteLine("Enter TR License Status (True or False): ");
    telephone.TrLicense = Convert.ToBoolean(Console.ReadLine());

    telephone.PrintInfo();
    telephone.GetProductName();

Reproduction:

    Console.WriteLine("Telephone successfully manufactured, would you like to produce another product?");
    reproduction = Console.ReadLine();
    if (reproduction.ToLower() == "yes")
        goto Base;
    else if (reproduction.ToLower() == "no")
    {
        Console.WriteLine("Have a nice day!");
        Environment.Exit(0);
    }
    else
    {
        Console.WriteLine("Please enter Yes or No!");
        goto Reproduction;
    }
}

else if (choice == 2)
{
    Computer computer = new Computer(); // Created an object of type computer, retrieved the information from the user and printed it on the screen with methods
    Console.WriteLine("Enter Serial Number: ");
    computer.SerialNumber = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter Computer Name: ");
    computer.Name = Console.ReadLine();
    Console.WriteLine("Enter Description: ");
    computer.Description = Console.ReadLine();
    Console.WriteLine("Enter Operating System: ");
    computer.OperatingSystem = Console.ReadLine();
    Console.WriteLine("Enter Number of Usb Ports: ");
    computer.UsbPorts = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Bluetooth is available? (True or False): ");
    computer.Bluetooth = Convert.ToBoolean(Console.ReadLine());

    computer.PrintInfo();
    computer.GetProductName();

Reproduction:

    Console.WriteLine("Computer successfully manufactured, would you like to produce another product?");
    reproduction = Console.ReadLine();
    if (reproduction.ToLower() == "yes")
        goto Base;
    else if (reproduction.ToLower() == "no")
    {
        Console.WriteLine("Have a nice day!");
        Environment.Exit(0);
    }
    else
    {
        Console.WriteLine("Please enter Yes or No!");
        goto Reproduction;
    }
}

else
{
    Console.WriteLine("Please enter 1 or 2!");
    goto Base;
}