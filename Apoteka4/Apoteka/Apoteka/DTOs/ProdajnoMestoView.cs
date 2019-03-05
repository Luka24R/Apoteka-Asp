using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Apoteka.Entiteti;

namespace Apoteka.DTOs
{
    public class ProdajnoMestoView
    {
        public int idProdajnogMesta { get; set; }
        public String nazivProdajnogMesta { get; set; }
        public String mestoProdajnogMesta { get; set; }
        public string adresaProdajnogMesta { get; set; }
       
       // public virtual IList<ZaposleniView> listaZaposlenih { get; set; }

        public virtual IList<LekView> listaLekova { get; set; }

      // public virtual IList<ReceptView> listaIzdatihRecepata { get; set; }
        public ProdajnoMestoView(ProdajnoMesto m)
        {
            this.idProdajnogMesta = m.idProdajnogMesta;
            this.nazivProdajnogMesta = m.nazivProdajnogMesta;
            this.mestoProdajnogMesta = m.mestoProdajnogMesta;
            this.adresaProdajnogMesta = m.adresaProdajnogMesta;


            this.listaLekova = new List<LekView>();
            foreach (Lek l in m.listaLekova)
                listaLekova.Add(new LekView(l));

            /*this.listaIzdatihRecepata = new List<ReceptView>();
            foreach (Recept l in m.listaIzdatihRecepata)
                this.listaIzdatihRecepata.Add(new ReceptView(l));*/

            
            /*  this.listaZaposlenih = new List<ZaposleniView>();
            foreach (Zaposleni l in m.listaZaposlenih)
                this.listaZaposlenih.Add(new ZaposleniView(l));*/
                
        }

        public ProdajnoMestoView()
        {

        }
    }
}
