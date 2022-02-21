using System;
using System.IO;
using System.Collections.Generic;
using NLog.Web;

namespace TicketingSystem
{
    class Program
    {
        private static NLog.Logger logger = NLogBuilder.ConfigureNLog(Directory.GetCurrentDirectory() + "\\nlog.config").GetCurrentClassLogger();
        static void Main(string[] args)
        {
            logger.Info("Program started");
            string filePath = Directory.GetCurrentDirectory() + "\\Tickets.csv";
            TicketFile ticketFile = new TicketFile(filePath);

            string file = "Tickets.csv";
            string choice;

            do {
                Console.WriteLine("Press 1 to read ticket data");
                Console.WriteLine("Press 2 to create new ticket");
                Console.WriteLine("Press any other key to exit");

                choice = Console.ReadLine();

                if (choice == "1"){
                    // TODO: Read ticket data
                }

                if (choice == "2") {
                    StreamWriter sw = new StreamWriter(file);                    
                    // TODO: If file exists, write new ticket
                    sw.Close();
                }
            } while (choice == "1" || choice == "2");

            logger.Info("Program ended");
        }
    }
}
