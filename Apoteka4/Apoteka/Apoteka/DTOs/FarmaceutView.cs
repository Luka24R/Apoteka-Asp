using Apoteka.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apoteka.DTOs
{
    public class FarmaceutView : ZaposleniView
    {
        public DateTime datumObnoveLicence { get; set; }
        public DateTime datumDiplomiranja { get; set; }

        public FarmaceutView()
        {
        
        }

        public FarmaceutView(Farmaceut f)
            : base(f)
        {
          
           /* this.idZaposlenog = f.idZaposlenog;
            this.adresaZaposlenog = f.adresaZaposlenog;
            this.brojTelefona = f.brojTelefona;
            this.datumRodjenja = f.datumRodjenja;
            this.ime = f.ime;
            this.prezime = f.prezime;
            this.maticniBroj = f.maticniBroj;*/

            this.datumObnoveLicence = f.datumObnoveLicence;
            this.datumDiplomiranja = f.datumDiplomiranja;
        }
    }
}
