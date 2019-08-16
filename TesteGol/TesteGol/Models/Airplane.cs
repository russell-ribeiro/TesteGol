using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TesteGol.Models
{
    public class Airplane
    {
        public int ID { get; set; }
        public string Code { get; set; }
        public string Model { get; set; }
        public int QtdPassengers { get; set; }
        public DateTime CreationDate { get; set; }
    }
}