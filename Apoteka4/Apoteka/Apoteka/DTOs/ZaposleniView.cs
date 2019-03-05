using Apoteka.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apoteka.DTOs
{
    public class ZaposleniView
    {
        public int idZaposlenog { get; set; }
        public string adresaZaposlenog { get; set; }
        public string brojTelefona { get; set; }
        public DateTime datumRodjenja { get; set; }
        public string ime { get; set; }
        public string prezime { get; set; }
        public string maticniBroj { get; set; }
        public ProdajnoMestoView radi { get; set; }

        public ZaposleniView()
        {

        }

        public ZaposleniView(Zaposleni z)
        {
            this.idZaposlenog = z.idZaposlenog;
            this.adresaZaposlenog = z.adresaZaposlenog;
            this.brojTelefona = z.brojTelefona;
            this.datumRodjenja = z.datumRodjenja;
            this.ime = z.ime;
            this.prezime = z.prezime;
            this.maticniBroj = z.maticniBroj;
           this.radi = new ProdajnoMestoView(z.radi);
        }


    }
}
