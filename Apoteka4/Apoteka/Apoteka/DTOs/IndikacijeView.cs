using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Apoteka.DTOs;
using Apoteka.Entiteti;

namespace Apoteka.DTOs
{
    public class IndikacijeView
    {
        public  string opisIndikacije { get; set; }
        public string idLeka { get; set; }
       // public  LekView idLeka { get; set; }

        public IndikacijeView(Indikacije i)
        {
           opisIndikacije = i.opisIndikacije;
            idLeka = i.idLeka.komercijalniNaziv;
        //   idLeka = new LekView(i.idLeka);
        }
        public IndikacijeView()
        {

        }
    }
}
