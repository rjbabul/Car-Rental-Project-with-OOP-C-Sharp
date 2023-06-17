using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareRentApplication.Company
{
    public class Agent
    {
        public List<Car> cars { get; set; }
        

        public int VarPercentage { get; set; }

        public Agent()
        {
            cars = new List<Car>();
        }

      
        public void AddCar(Car car)
        {
            cars.Add(car);
            this.VarPercentage = 10;
        }
 
        
        public void ViewCars()
        {
            int c = 1;
            foreach (Car item in cars)
            {
                Console.WriteLine("\nItem No : " + c++);
                Console.WriteLine("Car Name: " + item.CarName + "\nCar Id : " + item.CarId);
                Console.WriteLine("Car Model: " + item.CarModel + "\nCar Price : " + item.CarPrice);
                Console.WriteLine("Company Name : " + item.CompanyName + "\nDescription : " + item.CarDescription);
                Console.WriteLine("\n_______________________________________\n");
            }
        }

        public int GetPrice(int id)
        {
            bool isAvaiable = false;
            int totalPrice = 0;
            foreach (Car item in cars)
            {
               if (id == item.CarId)
                {
                    
                    Console.WriteLine("\n\nCar Name: " + item.CarName + "\nCar Id : " + item.CarId);
                    Console.WriteLine("Car Model: " + item.CarModel + "\nCar Price : " + item.CarPrice);
                    Console.WriteLine("Company Name : " + item.CompanyName + "\nDescription : " + item.CarDescription);
                    Console.WriteLine("Vat is :" + 10 + "%\n");
                    totalPrice = item.CarPrice + (int)(item.CarPrice * 0.10);
                    Console.WriteLine("Total Price with vat is :" + totalPrice);
                    isAvaiable = true;
                }
            }
            if (isAvaiable)
                return totalPrice;
            else
                return 0;
        }


        public void OrderCar(int id, int amount)
        {
            foreach (Car item in cars)
            {
                if (id == item.CarId)
                {

                    Console.WriteLine("\n\n______________________________\n\nOrder Confirmed.......\n");

                    Console.WriteLine("Car Name: " + item.CarName + "\nCar Id : " + item.CarId);
                    Console.WriteLine("Car Model: " + item.CarModel + "\nCar Price : " + item.CarPrice);
                    Console.WriteLine("Company Name : " + item.CompanyName + "\nDescription : " + item.CarDescription);
                    Console.WriteLine("Vat is :" + 10 + "%");
                    int TotalPrice = item.CarPrice + (int)(item.CarPrice * 0.1);
                    Console.WriteLine("Total price  is :" + 10 + "%");

                    Console.WriteLine("Paid Amount is :" + amount);
                    int due = TotalPrice - amount;
                    Console.WriteLine("Due price  is :" + due+"\n");
                    
                }
            }
        }
    }
}
