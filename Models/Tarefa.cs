using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Agenda.Models
{
    public class Tarefa
    {
        public int Id { get; set; }

        public String Titulo { get; set; }
        [Display(Name = "Descrição")]
        public String Descricao { get; set; }

        [DataType(DataType.Date)]
        public DateTime Data { get; set; }

        [Display(Name = "Inicio")]
        [DataType(DataType.Time)]
        public DateTime HorarioInicio { get; set; }

        [Display(Name = "Fim")]
        [DataType(DataType.Time)]
        public DateTime HorarioFim { get; set; }
    }
}
