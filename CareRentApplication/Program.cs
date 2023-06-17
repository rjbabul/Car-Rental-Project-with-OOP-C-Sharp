// See https://aka.ms/new-console-template for more information


using CareRentApplication.Company;
using CareRentApplication.DataBase;

Car acar = new Car()
{

    CarId = 1000,
    CarName ="MicroBus",
    CarModel="Hunda 100cc",
    CompanyName="Hundai",
    CarPrice = 1000000,
    CarDescription ="this is Car Description"
};



Car acar1 = new Car()
{

    CarId = 1001,
    CarName = "Zeep Car ",
    CarModel = "Zeep 13 HP",
    CompanyName = "Alon Mask",
    CarPrice = 256000,
    CarDescription = "this is ZeepCar"
};



Agent aAgent = new Agent();

aAgent.AddCar(acar);

aAgent.AddCar(acar1);

/*DataBaseAppication db = new DataBaseAppication();
db.cars.Add(acar);
db.cars.Add(acar1);

int successCount = db.SaveChanges();

if (successCount > 0)
{
    Console.WriteLine("Successful operation!");

}
*/
int exit = 1;
while (exit != 0)
{

    Console.WriteLine("\n\nClick 1 for Insert Car: ");
    Console.WriteLine("Click 2 for View Car List: ");
    Console.WriteLine("Click 3 for Order Car : ");
    Console.WriteLine("Click 0 for ExitSystem: \n\n");
    Console.Write("Please Insert your Response: ");
    string input = Console.ReadLine();
    int x = int.Parse(input);
  
    if (x == 0)
    {
       
        exit = 0;
        break;
    }
    else if (x == 2)
    {
        aAgent.ViewCars();
    }
    else if (x == 1)
    {
        int newCarId, newCarPrice;
        string newCarName, newCarDescription, newCarModel, newCompanyName;
        Console.Write("Insert Car Id : ");
        input = Console.ReadLine();
        x = int.Parse(input);
        newCarId = x;
        Console.Write("Insert Car Name : "); newCarName = Console.ReadLine();
        Console.Write("Insert Car Model : "); newCarModel = Console.ReadLine();
        Console.Write("Insert Company Name : "); newCompanyName = Console.ReadLine();

        Console.Write("Insert Car Price : ");
        input = Console.ReadLine();
        x = int.Parse(input);
        newCarPrice = x;
        Console.Write("Insert Car Description : "); newCarDescription = Console.ReadLine();
        acar = new Car
        {
            CarId = newCarId,
            CarName = newCarName,
            CarModel = newCarModel,
            CompanyName = newCompanyName,
            CarPrice = newCarPrice,
            CarDescription = newCarDescription

        };
        aAgent.AddCar(acar);
        Console.WriteLine("Car Insert Successfully");
    }

    else if (x == 3)
    {
        int ordercarid, amount, TotalPrice;

        Console.Write("Insert Car Model : ");
        input = Console.ReadLine();
        x = int.Parse(input);
        ordercarid =x;
        TotalPrice = aAgent.GetPrice(ordercarid);
        if (TotalPrice == 0)
        {
            Console.WriteLine("Sorry This car is now unavaileable.\n");
            break;
        }
        else
        {
            Console.Write("\nPlease give Amount : ");
            input = Console.ReadLine();
            x = int.Parse(input);
            amount = x;
            aAgent.OrderCar(ordercarid,amount);
        }
        
    }
    exit = x;
    
}

Console.WriteLine("Thanks for visiting this company----!");

