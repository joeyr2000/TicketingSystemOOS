using System;
using System.Collections.Generic;

namespace TicketingSystem
{

    public class TicketFile {
        public string filePath { get; set; }
        public List<Ticket> tickets;

        public TicketFile(string filePath) {
            this.filePath = filePath;
        }
    }
}