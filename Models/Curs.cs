using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace gurzo_timea_tunde_project.Models
{
    public class Curs
    {
        public int ID { get; set; }
        [Display(Name = "Denumire curs")]
        public string Denumire{ get; set; }
        public string Studii { get; set; }
        public string Descriere { get; set; }
        [Column(TypeName = "decimal(6, 2)")]
        public decimal Pret { get; set; }
        public ICollection<Trainer>Trainers { get; set; }


    }
}
