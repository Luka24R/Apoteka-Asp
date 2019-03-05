using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Apoteka.DTOs;
using Apoteka.Entiteti;

namespace Apoteka.DTOs
{
    public class KontraIndikacijeView
    {
        public  string opisKontraindikacije { get; set; }
        public string idLeka { get; set; }
       // public  LekView idLeka { get; set; }

        public KontraIndikacijeView(Kontraindikacije k)
        {
            opisKontraindikacije = k.opisKontraindikacije;
            idLeka = k.idLeka.komercijalniNaziv;
        //    idLeka = new LekView(k.idLeka);
        }
         public KontraIndikacijeView()
        {

        }
    }
}
