using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalApplication.Models
{
    public class CarRental
    {
        public List<Rental> ListOfCarRentals = new List<Rental>()
        {

            new Rental(1, "Ford", "a1234"),
            new Rental(2, "Opel", "b4557"),
            new Rental(3, "Nissan", "c891")
        };

        public void DisplayRentals(bool sortAsc = true)
        {
            List<Rental> sortedList = ListOfCarRentals.OrderBy(x => x.CarRegistration).ToList();

            if (!sortAsc)
            {
                sortedList = ListOfCarRentals.OrderByDescending(x => x.CarRegistration).ToList();
            }

            foreach (Rental rentalItem in sortedList)
            {
                Console.WriteLine($"{rentalItem.RentalID}, {rentalItem.CarModel}, {rentalItem.CarRegistration}");
            }
        }
    }
}
