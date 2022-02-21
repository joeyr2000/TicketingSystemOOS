using System;
using System.Collections.Generic;

namespace TicketingSystem
{

    public class Ticket {
        public enum Level {
            Low,
            Medium,
            High
        }
        public int ticketID { get; set; }
        public string summary { get; set; }
        public bool status { get; set; }
        public Level priority { get; set; }
        public string submitter { get; set; }
        public string assigned { get; set; }
        public List<string> watching { get; set; }
    }
}