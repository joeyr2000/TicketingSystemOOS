using System;
using System.Collections.Generic;
using NLog.Web;
using System.IO;
using System.Linq;


namespace TicketingSystem
{

    public class TicketFile {
        public string filePath { get; set; }
        public List<Ticket> tickets;
        private static NLog.Logger logger = NLogBuilder.ConfigureNLog(Directory.GetCurrentDirectory() + "\\nlog.config").GetCurrentClassLogger();

        public TicketFile(string filePath) {
            this.filePath = filePath;

            tickets = new List<Ticket>();
            StreamReader sr = new StreamReader(filePath);
            sr.ReadLine();
            while (!sr.EndOfStream) {
                string[] line = sr.ReadLine().Split(',');
                Ticket ticket = new Ticket();

                ticket.ticketID = Int32.Parse(line[0]);
                ticket.summary = line[1];
                ticket.status = line[2] == "Open" ? true : false;
                ticket.submitter = line[4];
                ticket.assigned = line[5];

                // TODO: set priority & watching
            }
        }
    }
}