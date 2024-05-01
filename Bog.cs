using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BogTitler
{
    public class Bog : IBog
    {
        public int Id { get; set; }
        public string Titel { get; set; }
        public string Forfatter { get; set; }
        public string Genre { get; set; }
        public string Emne { get; set; }

        public Bog()
        {


        }
    }
}
