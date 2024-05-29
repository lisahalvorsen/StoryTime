using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP_UKE_2
{
    public class Bok
    {
        public string Tittel { get; set; }
        public string Utgivelsesår { get; set; }
        public string Forfatter { get; set; }
        public string Beskrivelse { get; set; }

        public Bok(string tittel, string utgivelsesår, string forfatter, string beskrivelse)
        {
            Tittel = tittel;
            Utgivelsesår = utgivelsesår;
            Forfatter = forfatter;
            Beskrivelse = beskrivelse;
        }
    }
}
    