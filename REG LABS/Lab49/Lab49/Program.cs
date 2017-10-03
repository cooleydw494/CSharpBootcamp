using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab49
{
    class Program
    {
        static void Main(string[] args)
         {
            CarDealer dealer = new CarDealer();
            Consumer michael = new Consumer("Michael");
            Consumer nick = new Consumer("Nick");

            dealer.NewCarInfo += michael.NewCarIsHere;

            dealer.NewCar("Mercedes");

            dealer.NewCarInfo += nick.NewCarIsHere;

            dealer.NewCar("Ferrari");

            dealer.NewCarInfo -= michael.NewCarIsHere;

            dealer.NewCar("Toyota");
            
        }
    }
}
