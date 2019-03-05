using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Apoteka.DTOs;
using Apoteka.Entiteti;

namespace Apoteka.DTOs
{
    public class NezeljeniEfektiView
    {
        public  string opisEfekta { get; set; }
        public string idLeka { get; set; }
        //public  LekView idLeka { get; set; }

        public NezeljeniEfektiView(NezeljeniEfekti n)
        {
            opisEfekta = n.opisEfekta;
            idLeka = n.idLeka.komercijalniNaziv;
           // idLeka = new LekView(n.idLeka);
        }
        public NezeljeniEfektiView()
        {

        }
    }
}
