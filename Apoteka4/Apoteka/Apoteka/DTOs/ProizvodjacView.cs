using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Apoteka.Entiteti;

namespace Apoteka.DTOs
{
    public class ProizvodjacView
    {
        public int idProizvodjaca { get; protected set; }
        public string imeProizvodjaca { get; set; }


        //public IList<LekView> listaLekova { get; set; }

        public ProizvodjacView() { }
        public ProizvodjacView(Proizvodjac p)
        {
            
            //this.listaLekova = new List<LekView>();
            this.idProizvodjaca=p.idProizvodjaca;
            this.imeProizvodjaca=p.imeProizvodjaca;
            /*foreach(Lek l in p.listaLekova)
            {
                this.listaLekova.Add(new LekView(l));
            }*/
        }

    }
}
