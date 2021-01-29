using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gurzo_timea_tunde_project.Models
{
    public class Participant
  
    {
        public int ID { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public string Studii { get; set; }
        public int TrainingID { get; set; }
        public Curs Training { get; set; } // navigation property
    }
}
