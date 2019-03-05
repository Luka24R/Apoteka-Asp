using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Apoteka.DTOs;
using Apoteka.Entiteti;

namespace Apoteka.DTOs
{
    public class ReceptView
    {
        public int serijskiBroj { get; set; }
        public string tip { get; set; }
        public DateTime datumIzdavanja { get; set; }
        public string oblikPakovanja { get; set; }
        public int kolicinaLeka { get; set; }
        public DateTime datumRealizacije { get; set; }
        public int idLekara { get; set; }
        /*public virtual Lek zaLek { get; set; }
        public virtual Zaposleni idZaposlenog { get; set; }
        public virtual ProdajnoMesto idProdajnogMesta { get; set; }*/
        
        public LekView zaLek { get; set; }
        public ZaposleniView idZaposlenog {get; set;}
        public ProdajnoMestoView idProdajnogMesta { get; set; }

        public ReceptView (Recept r)
        {
            serijskiBroj = r.serijskiBroj;
            tip = r.tip;
            datumIzdavanja = r.datumIzdavanja;
            oblikPakovanja = r.oblikPakovanja;
            kolicinaLeka = r.kolicinaLeka;
            datumRealizacije = r.datumRealizacije;
            idLekara = r.idLekara;

            zaLek = new LekView(r.zaLek);
            idZaposlenog = new ZaposleniView(r.idZaposlenog);
            idProdajnogMesta = new ProdajnoMestoView(r.idProdajnogMesta);
        }
        public ReceptView()
        {

        }
    }
}
