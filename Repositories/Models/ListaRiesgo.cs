using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Models
{
    public class ListaRiesgo
    {
        public string nombre { get; set; }

        public string lista { get; set; }
        public int porcentajeSimilitud { get; set; }
    }
}
