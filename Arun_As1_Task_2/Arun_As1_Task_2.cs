/*Author: Arun Kanjirathingal Joyson
  Date: 30 January 2025
  Project: Arun_As1_Task_2

  Description:
  This program calculates how much Joe spent on Raptors game tickets.
  Joe can buy one of three ticket types: Purple, Green, or Blue. 
  It calculates the total money spent and the average price per ticket based on user input.

  Concepts used: Enums, methods, user input, loops, conditional checks, and formatted output.*/
using System;

namespace BasketballTickets
{
    class Program
    {
        // Enum for ticket types with their respective prices
        enum TicketType
        {
            Purple = 50,   // Price for Purple tickets
            Green = 80,    // Price for Green tickets
            Blue = 100     // Price for Blue tickets
        }

        static void Main(string[] args)
        {
            // Declaring variables to store the number of tickets bought
            int purpleTickets = 0;
            int greenTickets = 0;
            int blueTickets = 0;

            // Asking the user for input for each ticket type
            Console.WriteLine("Welcome to the Raptors ticketing system!");

            purpleTickets = GetTicketCount("Purple");
            greenTickets = GetTicketCount("Green");
            blueTickets = GetTicketCount("Blue");

            // Calculating the total cost
            decimal totalCost = CalculateTotalCost(purpleTickets, greenTickets, blueTickets);

            // Calculating the total number of tickets bought
            int totalTickets = purpleTickets + greenTickets + blueTickets;

            // Calculating the average price of tickets
            decimal averagePrice = CalculateAveragePrice(totalCost, totalTickets);

            // Displaying the results
            DisplayTicketSummary(purpleTickets, greenTickets, blueTickets, totalCost, totalTickets, averagePrice);
        }

        // Method to get the number of tickets for a specific ticket type (Purple, Green, or Blue)
        static int GetTicketCount(string ticketType)
        {
            int ticketCount = 0;
            Console.Write($"Enter the number of {ticketType} tickets bought: ");
            while (!int.TryParse(Console.ReadLine(), out ticketCount) || ticketCount < 0)
            {
                Console.WriteLine("Please enter a valid non-negative number.");
                Console.Write($"Enter the number of {ticketType} tickets bought: ");
            }
            return ticketCount;
        }

        // Method to calculate the total cost of tickets
        static decimal CalculateTotalCost(int purpleTickets, int greenTickets, int blueTickets)
        {
            return (purpleTickets * (decimal)TicketType.Purple) +
                   (greenTickets * (decimal)TicketType.Green) +
                   (blueTickets * (decimal)TicketType.Blue);
        }

        // Method to calculate the average price of tickets
        static decimal CalculateAveragePrice(decimal totalCost, int totalTickets)
        {
            return totalTickets > 0 ? totalCost / totalTickets : 0;
        }

        // Method to display the ticket summary
        static void DisplayTicketSummary(int purpleTickets, int greenTickets, int blueTickets, decimal totalCost, int totalTickets, decimal averagePrice)
        {
            Console.WriteLine("\nTicket Summary:");
            Console.WriteLine($"Purple tickets: {purpleTickets} @ ${(decimal)TicketType.Purple} each");
            Console.WriteLine($"Green tickets: {greenTickets} @ ${(decimal)TicketType.Green} each");
            Console.WriteLine($"Blue tickets: {blueTickets} @ ${(decimal)TicketType.Blue} each");
            Console.WriteLine($"\nTotal cost: {totalCost:C}");
            Console.WriteLine($"Total tickets bought: {totalTickets}");
            Console.WriteLine($"Average ticket price: ${averagePrice:F2}");

            Console.WriteLine("\nThank you for using the Raptors ticketing system! Enjoy the game!");
        }
    }
}
