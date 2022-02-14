using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Ejercicio_1_3.Models
{
   public class Personas
    {
        [PrimaryKey, AutoIncrement]
        public int codigo { get; set; }

        [MaxLength(100)]
        public String nombres { get; set; }

        [MaxLength(100)]
        public String apellidos { get; set; }

        public int edades { get; set; }

        [MaxLength(100)]
        public String correos { get; set; }

        [MaxLength(100)]
        public String direccion { get; set; }
    }
}
