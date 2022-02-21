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

            string file = "Tickets.csv";
            string choice;

            do {
                Console.WriteLine("Press 1 to read ticket data");
                Console.WriteLine("Press 2 to create new ticket file");
                Console.WriteLine("Press any other key to exit");

                choice = Console.ReadLine();

                if (choice == "1"){
                    StreamReader sr = new StreamReader(file);

                    while (!sr.EndOfStream) {
                        string line = sr.ReadLine();

                        string[] arr = line.Split(',');
                        string watching = String.Join(',', arr[6].Split('|'));
                        Console.WriteLine($"Ticket ID: {arr[0]}\nSummary: {arr[1]}\nStatus: {arr[2]}\nPriority: {arr[3]}\nSubmitter: {arr[4]}\nAssigned: {arr[5]}\nWatching: {watching}");
                    }
                    sr.Close();
                }

                if (choice == "2") {
                    StreamWriter sw = new StreamWriter(file);                    
                    string[] line = {"Ticket ID", "Summary", "Status", "Priority", "Submitter", "Assigned", "Watching"};
                    string[] newEntry = new string[7];

                    for (int i = 0; i < 6; i++) {
                        Console.WriteLine(line[i] + ": ");
                        newEntry[i] = Console.ReadLine();
                    }

                    Console.WriteLine(line[6] + ": ");
                    string resp;
                    List<string> watching = new List<string>();
                    do {
                        watching.Add(Console.ReadLine());
                        Console.WriteLine("Add another watcher? (Y/N)");
                        resp = Console.ReadLine().ToUpper();
                    } while (resp == "Y");

                    newEntry[6] = String.Join('|', watching);
                    sw.WriteLine(String.Join(',', newEntry));
                    sw.Close();
                }
            } while (choice == "1" || choice == "2");

            logger.Info("Program ended");
        }
    }
}
