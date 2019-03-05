using Apoteka.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apoteka.DTOs
{
    public class LekView
    {
        public string komercijalniNaziv { get; set; }
        public string hemijskiNaziv { get; set; }
        public string nacinDoziranjaZaOdrasle { get; set; }
        public string nacinDoziranjaZaDecu { get; set; }
        public string nacinDoziranjaZaTrudnice { get; set; }
        public int cenaLeka { get; set; }
        public int? procenatParticipacije { get; set; }
        public string izdavanjeNaRecept { get; set; }
        public string dejstvoLeka { get; set; }
        public string tip { get; set; }
       public ProizvodjacView pripadaProizvodjacu { get; set; }

        public IList<IndikacijeView> listaIndikacija { get; set; }
        public IList<KontraIndikacijeView> listaKontraindikacija { get; set; }
        public IList<NezeljeniEfektiView> listaNezeljenihEfekata { get; set; }

        //public IList<PakovanjeView> listaPakovanja { get; set; }

       //public IList<ProdajnoMestoView> prodajnaMesta { get; set; }


        public LekView() { }
        public LekView(Lek l)
        {
            this.listaIndikacija = new List<IndikacijeView>();
            this.listaKontraindikacija = new List<KontraIndikacijeView>();
            this.listaNezeljenihEfekata = new List<NezeljeniEfektiView>();
            //this.listaPakovanja = new List<PakovanjeView>();
            //this.prodajnaMesta = new List<ProdajnoMestoView>();
            this.komercijalniNaziv = l.komercijalniNaziv;
            this.hemijskiNaziv = l.hemijskiNaziv;
            this.nacinDoziranjaZaDecu = l.nacinDoziranjaZaDecu;
            this.nacinDoziranjaZaOdrasle = l.nacinDoziranjaZaOdrasle;
            this.nacinDoziranjaZaTrudnice = l.nacinDoziranjaZaTrudnice;
            this.cenaLeka = l.cenaLeka;
            this.procenatParticipacije = l.procenatParticipacije;
            this.izdavanjeNaRecept = l.izdavanjeNaRecept;
            this.dejstvoLeka = l.dejstvoLeka;
            String tipL;
            if (l.GetType() == typeof(Entiteti.Antibiotik))
                tipL = "ANTIBIOTIK";
            else if (l.GetType() == typeof(Entiteti.Analgetik))
                tipL = "ANALGETIK";
            else if (l.GetType() == typeof(Entiteti.Antipiretik))
                tipL = "ANTIPIRETIK";
            else
                tipL = "DIURETIK";
            this.tip = tipL;
            this.pripadaProizvodjacu = new ProizvodjacView(l.pripadaProizvodjacu);

            foreach(Indikacije ind in l.listaIndikacija)
            {
                this.listaIndikacija.Add(new IndikacijeView(ind));
            }
            foreach(Kontraindikacije kInd in l.listaKontraindikacija)
            {
                this.listaKontraindikacija.Add(new KontraIndikacijeView(kInd));
            }
            foreach(NezeljeniEfekti ne in l.listaNezeljenihEfekata)
            {
                this.listaNezeljenihEfekata.Add(new NezeljeniEfektiView(ne));
            }

           /* foreach(Pakovanje p in l.listaPakovanja)
            {
                this.listaPakovanja.Add(new PakovanjeView(p));
            }*/

           /* foreach(ProdajnoMesto pm in l.listaProdajnihMesta)
            {
                this.prodajnaMesta.Add(new ProdajnoMestoView(pm));
            }*/
        }
    }
}
