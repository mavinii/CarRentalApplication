using CarRentalApplication.Models;
using System;

namespace CarRentalApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** Rental Car Application ****");
            Console.WriteLine("");

            CarRental carRental = new CarRental();
            carRental.DisplayRentals();
        }
    }
}
