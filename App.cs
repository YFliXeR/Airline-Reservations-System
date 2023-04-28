using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    class Program
    {   
        static void Main(string[] args)
        {
            //Declare and initialize variables for seat number, baggage weight, and total fees
            int seat = 0, weight = 0, total_fees = 0;

            //Declare a list to keep track of reserved seats
            List<int> Chart = new List<int>();

            //Calculate extra fees and total fees
            int extra = (weight - 10) * 5;
            int total = (Chart.Count * 500) + total_fees;

            // Start a loop to allow the user to reserve seats
            while (seat != -1)
            {
                // Prompt the user to enter a seat number                
                Console.WriteLine();
                Console.Write("Enter seat number (-1 to end): ");
                seat = Convert.ToInt32(Console.ReadLine());

                // If the user enters -1, exit the loop
                if (seat == -1) break;

            // Check if the seat is available
            if (!Chart.Contains(seat))
            {
                // Prompt the user to enter the weight of the baggage
                Console.Write("Enter the weight of the bag: ");
                weight = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                // If the baggage weight is allowed, confirm the reservation
                if (weight <= 20)
                {
                    Console.WriteLine("Reservation is confirmed for seat no. " + seat);

                    // Add the seat to the reserved seats list
                    Chart.Add(seat);    

                    // Calculate the extra fees for the baggage weight
                    extra = (weight - 10) * 5;

                    // Add the extra fees to the total fees
                    total_fees += extra;

                    // Calculate the total income for all reserved seats
                    total = (Chart.Count * 500) + total_fees;

                    // Display the extra fees and total fees
                    Console.WriteLine("Fees for extra weight: " + extra);
                    Console.WriteLine("Total fees: " + (500 + extra));
                }
                // If the baggage weight is not allowed, cancel the reservation
                else if (weight > 20)
                {
                    Console.WriteLine("Reservation cancelled due to unallowed baggage weight");
                }
            }
            // If the seat is already reserved, cancel the reservation
            else if (Chart.Contains(seat))
            {
                Console.WriteLine("Reservation cancelled due to unavailable seat number");
            }
 
            }
            // Display a summary of reserved seats and total income from all reserved seats
            Console.WriteLine("The flight has " + Chart.Count + " reserved seats with total income " + total);


        }   
    }

}


 

