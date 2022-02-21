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
        public bool status;
        public Level priority;
        public string submitter { get; set; }
        public string assigned { get; set; }
        public List<string> watching { get; set; }

        public Ticket(int ticketID, string summary, bool status, Level priority, string submitter, string assigned, List<string> watching) {
            this.ticketID = ticketID;
            this.summary = summary;
            this.status = status;
            this.priority = priority;
            this.submitter = submitter;
            this.assigned = assigned;
            this.watching = watching;
        }

        public Ticket() {}

        public string getStatus() {
            return status? "Open" : "Closed";
        }

        public void setStatus(string status) {
            this.status = status.ToLower() == "open" ? true : false;
        }

        // TODO: set & get priority
    }
}