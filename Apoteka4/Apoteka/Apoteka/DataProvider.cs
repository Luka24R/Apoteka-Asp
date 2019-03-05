using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Apoteka.Entiteti;
using Apoteka.DTOs;
using NHibernate.Linq;
using NHibernate;

namespace Apoteka
{
    public class DataProvider
    {
        public LekView GetLekView(string komercNaziv)
        {
            ISession s = DataLayer.GetSession();
            Lek p = s.Query<Lek>()
                               .Where(pp => pp.komercijalniNaziv==komercNaziv).Select(ss => ss).FirstOrDefault();
            if (p == null) return new LekView();
            /*string tipL;
            if (p.GetType() == typeof(Entiteti.Antibiotik))
                tipL = "ANTIBIOTIK";
            else if (p.GetType() == typeof(Entiteti.Analgetik))
                tipL = "ANALGETIK";
            else if (p.GetType() == typeof(Entiteti.Antipiretik))
                tipL = "ANTIPIRETIK";
            else
                tipL = "DIURETIK";*/


            return new LekView(p); // { tip=tipL };
        }
        public int AddLek(Lek l)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                if (l.tip == "ANTIPIRETIK")
                {
                    Antipiretik a = new Antipiretik();
                    a.cenaLeka = l.cenaLeka;
                    a.dejstvoLeka = l.dejstvoLeka;
                    a.hemijskiNaziv = l.hemijskiNaziv;
                    a.izdavanjeNaRecept = l.izdavanjeNaRecept;
                    a.komercijalniNaziv = l.komercijalniNaziv;
                    a.listaIndikacija = l.listaIndikacija;
                    a.listaKontraindikacija = l.listaKontraindikacija;
                    a.listaNezeljenihEfekata = l.listaNezeljenihEfekata;
                    a.listaPakovanja = l.listaPakovanja;
                    a.listaProdaja = l.listaProdaja;
                    a.listaProdajnihMesta = l.listaProdajnihMesta;
                    a.listRecepata = l.listRecepata;
                    a.nacinDoziranjaZaDecu = l.nacinDoziranjaZaDecu;
                    a.nacinDoziranjaZaOdrasle = l.nacinDoziranjaZaOdrasle;
                    a.nacinDoziranjaZaTrudnice = l.nacinDoziranjaZaTrudnice;
                    a.pripadaProizvodjacu = l.pripadaProizvodjacu;
                    a.procenatParticipacije = l.procenatParticipacije;
                    a.tip = l.tip;
                    s.Save(a);
                    s.Flush();
                    s.Close();
                    return 1;
                }
                if (l.tip == "ANALGETIK")
                {
                    Analgetik a = new Analgetik();
                    a.cenaLeka = l.cenaLeka;
                    a.dejstvoLeka = l.dejstvoLeka;
                    a.hemijskiNaziv = l.hemijskiNaziv;
                    a.izdavanjeNaRecept = l.izdavanjeNaRecept;
                    a.komercijalniNaziv = l.komercijalniNaziv;
                    a.listaIndikacija = l.listaIndikacija;
                    a.listaKontraindikacija = l.listaKontraindikacija;
                    a.listaNezeljenihEfekata = l.listaNezeljenihEfekata;
                    a.listaPakovanja = l.listaPakovanja;
                    a.listaProdaja = l.listaProdaja;
                    a.listaProdajnihMesta = l.listaProdajnihMesta;
                    a.listRecepata = l.listRecepata;
                    a.nacinDoziranjaZaDecu = l.nacinDoziranjaZaDecu;
                    a.nacinDoziranjaZaOdrasle = l.nacinDoziranjaZaOdrasle;
                    a.nacinDoziranjaZaTrudnice = l.nacinDoziranjaZaTrudnice;
                    a.pripadaProizvodjacu = l.pripadaProizvodjacu;
                    a.procenatParticipacije = l.procenatParticipacije;
                    a.tip = l.tip;
                    s.Save(a);
                    s.Flush();
                    s.Close();
                    return 1;
                }
                if (l.tip == "ANTIBIOTIK")
                {
                    Antibiotik a = new Antibiotik();
                    a.cenaLeka = l.cenaLeka;
                    a.dejstvoLeka = l.dejstvoLeka;
                    a.hemijskiNaziv = l.hemijskiNaziv;
                    a.izdavanjeNaRecept = l.izdavanjeNaRecept;
                    a.komercijalniNaziv = l.komercijalniNaziv;
                    a.listaIndikacija = l.listaIndikacija;
                   
                    a.listaKontraindikacija = l.listaKontraindikacija;
                    a.listaNezeljenihEfekata = l.listaNezeljenihEfekata;
                    a.listaPakovanja = l.listaPakovanja;
                    a.listaProdaja = l.listaProdaja;
                    a.listaProdajnihMesta = l.listaProdajnihMesta;
                    a.listRecepata = l.listRecepata;
                    a.nacinDoziranjaZaDecu = l.nacinDoziranjaZaDecu;
                    a.nacinDoziranjaZaOdrasle = l.nacinDoziranjaZaOdrasle;
                    a.nacinDoziranjaZaTrudnice = l.nacinDoziranjaZaTrudnice;
                    a.pripadaProizvodjacu = l.pripadaProizvodjacu;
                    a.procenatParticipacije = l.procenatParticipacije;
                    a.tip = l.tip;
                    s.Save(a);
                    s.Flush();
                    s.Close();
                    return 1;
                }
                if (l.tip == "DIURETIK")
                {
                    Diuretik a = new Diuretik();
                    a.cenaLeka = l.cenaLeka;
                    a.dejstvoLeka = l.dejstvoLeka;
                    a.hemijskiNaziv = l.hemijskiNaziv;
                    a.izdavanjeNaRecept = l.izdavanjeNaRecept;
                    a.komercijalniNaziv = l.komercijalniNaziv;
                    a.listaIndikacija = l.listaIndikacija;
                    a.listaKontraindikacija = l.listaKontraindikacija;
                    a.listaNezeljenihEfekata = l.listaNezeljenihEfekata;
                    a.listaPakovanja = l.listaPakovanja;
                    a.listaProdaja = l.listaProdaja;
                    a.listaProdajnihMesta = l.listaProdajnihMesta;
                    a.listRecepata = l.listRecepata;
                    a.nacinDoziranjaZaDecu = l.nacinDoziranjaZaDecu;
                    a.nacinDoziranjaZaOdrasle = l.nacinDoziranjaZaOdrasle;
                    a.nacinDoziranjaZaTrudnice = l.nacinDoziranjaZaTrudnice;
                    a.pripadaProizvodjacu = l.pripadaProizvodjacu;
                    a.procenatParticipacije = l.procenatParticipacije;
                    a.tip = l.tip;
                    s.Save(a);
                    s.Flush();
                    s.Close();
                    return 1;
                }
                return -1;
               
            }
            catch (Exception ec)
            {
                return -1;
            }
        }
        public int RemoveLek(string komercNaziv)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Lek l = s.Get<Lek>(komercNaziv);
                s.Delete(l);
                s.Flush();
                s.Close();

                return 1;
            }
            catch (Exception ec)
            {
                return -1;
            }
        }
        public int UpdateLek(string komN, Lek l)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Lek ll = s.Get<Lek>(komN);

                ll.cenaLeka = l.cenaLeka;
                ll.dejstvoLeka = l.dejstvoLeka;
                ll.hemijskiNaziv = l.hemijskiNaziv;
                ll.izdavanjeNaRecept = l.izdavanjeNaRecept;
                ll.nacinDoziranjaZaDecu = l.nacinDoziranjaZaDecu;
                ll.nacinDoziranjaZaOdrasle = l.nacinDoziranjaZaOdrasle;
                ll.nacinDoziranjaZaTrudnice = l.nacinDoziranjaZaTrudnice;
                ll.procenatParticipacije = l.procenatParticipacije;
                ll.pripadaProizvodjacu = l.pripadaProizvodjacu;
                ll.tip = l.tip;
                

                s.SaveOrUpdate(ll);

                s.Flush();
                s.Close();

                return 1;
            }
            catch (Exception ec)
            {
                return -1;
            }
        }


        public ProizvodjacView GetProizvodjacView(int i)
        {

            ISession s = DataLayer.GetSession();
            Proizvodjac p = s.Query<Proizvodjac>()
                               .Where(pp=>pp.idProizvodjaca==i).Select(ss=>ss).FirstOrDefault();
            if (p == null) return new ProizvodjacView();
            return new ProizvodjacView(p);

        }
        public int AddProizvodjac(Proizvodjac p)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                s.Save(p);

                s.Flush();
                s.Close();

                return 1;
            }
            catch (Exception ec)
            {
              
                return -1;
            }
        }
        public int RemoveProizvodjac(int i)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Proizvodjac p = s.Get<Proizvodjac>(i);
                s.Delete(p);
                s.Flush();
                s.Close();

                return 1;
            }
            catch (Exception ec)
            {
                return -1;
            }
        }
        public int UpdateProizvodjac(int id, Proizvodjac p)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Proizvodjac pp = s.Get<Proizvodjac>(id);
               
                pp.imeProizvodjaca = p.imeProizvodjaca;
                s.SaveOrUpdate(pp);

                s.Flush();
                s.Close();

                return 1;
            }
            catch (Exception ec)
            {
                return -1;
            }
        }
        public ReceptView GetReceptView(int serBroj)
        {
            /**ISession s = DataLayer.GetSession();
            Proizvodjac p = s.Query<Proizvodjac>()
                               .Where(pp=>pp.idProizvodjaca==i).Select(ss=>ss).FirstOrDefault();
            if (p == null) return new ProizvodjacView();
            return new ProizvodjacView(p);*/
            ISession s = DataLayer.GetSession();
            Recept r = s.Query<Recept>()
                        .Where(rr => rr.serijskiBroj == serBroj).Select(rrr => rrr).FirstOrDefault();
            if (r == null) return new ReceptView();
            return new ReceptView(r);
        }
        public int AddRecept(Recept r)
        {
             try
            {
                ISession s = DataLayer.GetSession();

                s.Save(r);

                s.Flush();
                s.Close();

                return 1;
            }
            catch (Exception ec)
            {
                return -1;
            }
        }
        public int RemoveRecept(int sb)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Recept p = s.Get<Recept>(sb);
                s.Delete(p);
                s.Flush();
                s.Close();

                return 1;
            }
            catch (Exception ec)
            {
                return -1;
            }
        }
        public int UpdateRecept(int sb, Recept r)
        {
            
              try
            {
                ISession s = DataLayer.GetSession();

                Recept pp = s.Get<Recept>(sb);

                pp.tip = r.tip;
                pp.oblikPakovanja = r.oblikPakovanja;
                pp.kolicinaLeka = r.kolicinaLeka;
                pp.idLekara = r.idLekara;
                pp.datumRealizacije = r.datumRealizacije;
                pp.datumIzdavanja = r.datumIzdavanja;
                pp.idZaposlenog = r.idZaposlenog;
                pp.idProdajnogMesta = r.idProdajnogMesta;
                s.SaveOrUpdate(pp);

                s.Flush();
                s.Close();

                return 1;
            }
            catch (Exception ec)
            {
                return -1;
            }
        }

        public ProdajnoMestoView GetProdajnoMestoView(int i)
        {

            ISession s = DataLayer.GetSession();
            ProdajnoMesto p = s.Query<ProdajnoMesto>()
                               .Where(pp => pp.idProdajnogMesta == i).Select(ss => ss).FirstOrDefault();
            if (p == null) return new ProdajnoMestoView();
            return new ProdajnoMestoView(p);

        }

        public List<ProdajnoMestoView> GetProdajnaMesta()
        {
            ISession s = DataLayer.GetSession();

            IEnumerable<ProdajnoMesto> prmesta = s.Query<ProdajnoMesto>()
                                                //.Where(p => (p.Tip == "LUTKE" || p.Tip == "DODACI ZA LUTKE"))
                                                //.OrderBy(p => p.Tip).ThenBy(p => p.Naziv.Length)
                                                .Select(p => p);

            List<ProdajnoMestoView> ret = new List<ProdajnoMestoView>();
            ProdajnoMesto[] pr = prmesta.ToArray();

            foreach (ProdajnoMesto p in pr)
                ret.Add(new ProdajnoMestoView(p));
            return ret;

        }

        public int AddProdajnoMesto(ProdajnoMesto p)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                s.Save(p);

                s.Flush();
                s.Close();

                return 1;
            }
            catch (Exception ec)
            {
                return -1;
            }
        }

        public int RemoveProdajnoMesto(int i)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                ProdajnoMesto p = s.Get<ProdajnoMesto>(i);

                s.Delete(p);
                s.Flush();
                s.Close();

                return 1;
            }
            catch (Exception ec)
            {
                return -1;
            }
        }

        public int UpdateProdajnoMesto(int id, ProdajnoMesto p)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                ProdajnoMesto pp = s.Get<ProdajnoMesto>(id);
                pp.adresaProdajnogMesta = p.adresaProdajnogMesta;
                pp.mestoProdajnogMesta = p.mestoProdajnogMesta;
                pp.nazivProdajnogMesta = p.nazivProdajnogMesta;
                pp.idProdajnogMesta = id;


                s.SaveOrUpdate(pp);

                s.Flush();
                s.Close();

                return 1;
            }
            catch (Exception ec)
            {
                return -1;
            }
        }


        public PakovanjeView GetPakovanjeView(int i)
        {

            ISession s = DataLayer.GetSession();
            Pakovanje p = s.Query<Pakovanje>()
                               .Where(pp => pp.idPakovanja == i).Select(ss => ss).FirstOrDefault();
            if (p == null) return new PakovanjeView();
           
            return new PakovanjeView(p);

        }

        public List<PakovanjeView> GetPakovanja()
        {
            ISession s = DataLayer.GetSession();

            IEnumerable<Pakovanje> pakovanja = s.Query<Pakovanje>()
                                               
                                                .Select(p => p);

            List<PakovanjeView> ret = new List<PakovanjeView>();
            Pakovanje[] pa = pakovanja.ToArray();

            foreach (Pakovanje p in pa)
                ret.Add(new PakovanjeView(p));
            return ret;

        }

        public int RemovePakovanje(int i)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Pakovanje p = s.Get<Pakovanje>(i);

                s.Delete(p);
                s.Flush();
                s.Close();

                return 1;
            }
            catch (Exception ec)
            {
                return -1;
            }
        }

        public int AddPakovanje(Pakovanje p)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                if (p.tipPakovanja == "SIRUP")
                {
                    Sirup a = new Sirup();
                    a.kolicina = p.kolicina;
                    a.pakujeLek = p.pakujeLek;
                    a.tipPakovanja = p.tipPakovanja;
                    a.sastav = p.sastav;
                    
                    s.Save(a);
                    s.Flush();
                    s.Close();
                    return 1;
                }
               
                if (p.tipPakovanja == "TABLETA")
                {
                    Tableta a = new Tableta();
                    a.kolicina = p.kolicina;
                    a.pakujeLek = p.pakujeLek;
                    a.tipPakovanja = p.tipPakovanja;
                    a.sastav = p.sastav;

                    s.Save(a);
                    s.Flush();
                    s.Close();
                    return 1;
                }
                
                if (p.tipPakovanja == "INEKCIJA")
                {
                    Inekcija a = new Inekcija();
                    a.kolicina = p.kolicina;
                    a.pakujeLek = p.pakujeLek;
                    a.tipPakovanja = p.tipPakovanja;
                    a.sastav = p.sastav;

                    s.Save(a);
                    s.Flush();
                    s.Close();
                    return 1;
                }
               
                if (p.tipPakovanja == "PRASAK")
                {
                    Prasak a = new Prasak();
                    a.kolicina = p.kolicina;
                    a.pakujeLek = p.pakujeLek;
                    a.tipPakovanja = p.tipPakovanja;
                    a.sastav = p.sastav;

                    s.Save(a);
                    s.Flush();
                    s.Close();
                    return 1;
                }

                return -1;
            }
            catch (Exception ec)
            {
                return -1;
            }
        }
        public int UpdatePakovanje(int id, Pakovanje p)
        {

            try
            {
                ISession s = DataLayer.GetSession();

                Pakovanje pp = s.Get<Pakovanje>(id);

                pp.kolicina = p.kolicina;
                pp.sastav = p.sastav;
               
                pp.tipPakovanja = p.tipPakovanja;
                pp.pakujeLek = p.pakujeLek;

                s.SaveOrUpdate(pp);

                s.Flush();
                s.Close();

                return 1;
            }
            catch (Exception ec)
            {
                return -1;
            }
        }



        public IEnumerable<ZaposleniView> GetZaposleni()
        {
            ISession s = DataLayer.GetSession();

            IEnumerable<Zaposleni> zaposleni = s.Query<Zaposleni>()
                                                .Select(p => p);

            List<ZaposleniView> ret = new List<ZaposleniView>();
            Zaposleni[] pa = zaposleni.ToArray();

            foreach (Zaposleni p in pa)
                ret.Add(new ZaposleniView(p));
            return ret;
        }

        public IEnumerable<FarmaceutView> GetFarmaceuti()
        {
           
            ISession s = DataLayer.GetSession();

            IEnumerable<Farmaceut> farmaceuti = s.Query<Farmaceut>()
                                                
                                                .Select(p => p);

            List<FarmaceutView> ret = new List<FarmaceutView>();
            Farmaceut[] pa = farmaceuti.ToArray();

            foreach (Farmaceut p in pa)
                ret.Add(new FarmaceutView(p));
            return ret;
        }

        public ZaposleniView GetZaposleniView(int idZaposlenog)
        {
            ISession s = DataLayer.GetSession();
            Zaposleni p = s.Query<Zaposleni>()
                               .Where(pp => pp.idZaposlenog == idZaposlenog).Select(ss => ss).FirstOrDefault();
            if (p == null) return new ZaposleniView();
            return new ZaposleniView(p);
        }

        public FarmaceutView GetFarmaceutView(int idZaposlenog)
        {
            ISession s = DataLayer.GetSession();
            Farmaceut p = s.Query<Farmaceut>()
                               .Where(pp => pp.idZaposlenog == idZaposlenog).Select(ss => ss).FirstOrDefault();
            if (p == null) return new FarmaceutView();
            return new FarmaceutView(p);
        }

        public int AddZaposleni(Zaposleni l)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                s.Save(l);

                s.Flush();
                s.Close();

                return 1;
            }
            catch (Exception ec)
            {
                return -1;
            }
        }

        public int AddFarmaceut(Farmaceut l)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                s.Save(l);

                s.Flush();
                s.Close();

                return 1;
            }
            catch (Exception ec)
            {
                return -1;
            }
        }

        public int RemoveZaposleni(int idZaposlenog)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Zaposleni l = s.Get<Zaposleni>(idZaposlenog);
                s.Delete(l);
                s.Flush();
                s.Close();

                return 1;
            }
            catch (Exception ec)
            {
                return -1;
            }
        }

        public int RemoveFarmaceut(int idZaposlenog)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Farmaceut l = s.Get<Farmaceut>(idZaposlenog);
                s.Delete(l);
                s.Flush();
                s.Close();

                return 1;
            }
            catch (Exception ec)
            {
                return -1;
            }
        }

        public int UpdateZaposleni(int idZaposlenog, Zaposleni z)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Zaposleni zap = s.Get<Zaposleni>(idZaposlenog);

                zap.adresaZaposlenog = z.adresaZaposlenog;
                zap.brojTelefona = z.brojTelefona;
                zap.datumRodjenja = z.datumRodjenja;
                zap.ime = z.ime;
                zap.prezime = z.prezime;
                zap.maticniBroj = z.maticniBroj;

                s.SaveOrUpdate(zap);

                s.Flush();
                s.Close();

                return 1;
            }
            catch (Exception ec)
            {
                return -1;
            }
        }

        public int UpdateFarmaceut(int idZaposlenog, Farmaceut z)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Farmaceut zap = s.Get<Farmaceut>(idZaposlenog);

                zap.adresaZaposlenog = z.adresaZaposlenog;
                zap.brojTelefona = z.brojTelefona;
                zap.datumRodjenja = z.datumRodjenja;
                zap.ime = z.ime;
                zap.prezime = z.prezime;
                zap.maticniBroj = z.maticniBroj;

                zap.datumObnoveLicence = z.datumObnoveLicence;
                zap.datumDiplomiranja = z.datumDiplomiranja;

                s.SaveOrUpdate(zap);

                s.Flush();
                s.Close();

                return 1;
            }
            catch (Exception ec)
            {
                return -1;
            }
        }






        public List<IndikacijeView> GetIndikacije()
        {
            ISession s = DataLayer.GetSession();

            IEnumerable<Indikacije> indikacije = s.Query<Indikacije>()
                                                .Select(p => p);

            List<IndikacijeView> ret = new List<IndikacijeView>();
            Indikacije[] pa = indikacije.ToArray();

            foreach (Indikacije p in pa)
                ret.Add(new IndikacijeView(p));
            return ret;

        }

        public IndikacijeView GetIndikacijeView(string opis)
        {
            ISession s = DataLayer.GetSession();
            Indikacije p = null;
            try
            {
                p = s.Query<Indikacije>()
                                   .Where(pp => pp.opisIndikacije == opis).Select(ss => ss).FirstOrDefault();
            }
            catch (Exception ec)
            { 
            }
            if (p == null) return new IndikacijeView();
            return new IndikacijeView(p);
        }


        public int AddIndikacije(IndikacijeView i)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Indikacije ind = new Indikacije();
                Lek l = s.Load<Lek>(i.idLeka);
                ind.opisIndikacije = i.opisIndikacije;
                ind.idLeka = l;

                    s.Save(ind);
                    s.Flush();
                    s.Close();
                    return 1;
            }
            catch (Exception ec)
            {
                return -1;
            }
        }
        public int RemoveIndikacije(string opis)
        {
            try
            {
                ISession s = DataLayer.GetSession();

               
                Indikacije ind=s.Query<Indikacije>()
                               .Where(pp => pp.opisIndikacije == opis).Select(ss => ss).FirstOrDefault();
                s.Delete(ind);
                s.Flush();
                s.Close();

                return 1;
            }
            catch (Exception ec)
            {
                return -1;
            }
        }
        public int UpdateIndikacije(string opis, Indikacije i)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                //Indikacije ii = s.Get<Indikacije>(opis);
                Indikacije ii = s.Query<Indikacije>()
                               .Where(pp => pp.opisIndikacije == opis).Select(ss => ss).FirstOrDefault();
                ii.idLeka = i.idLeka;

                s.SaveOrUpdate(ii);

                s.Flush();
                s.Close();

                return 1;
            }
            catch (Exception ec)
            {
                return -1;
            }
        }



        public List<KontraIndikacijeView> GetKontraindikacije()
        {
            ISession s = DataLayer.GetSession();

            IEnumerable<Kontraindikacije> kindikacije = s.Query<Kontraindikacije>()
                                                .Select(p => p);

            List<KontraIndikacijeView> ret = new List<KontraIndikacijeView>();
            Kontraindikacije[] pa = kindikacije.ToArray();

            foreach (Kontraindikacije p in pa)
                ret.Add(new KontraIndikacijeView(p));
            return ret;

        }

        public KontraIndikacijeView GetKontraindikacijeView(string opis)
        {
            ISession s = DataLayer.GetSession();
            Kontraindikacije p = null;
            try
            {
                p = s.Query<Kontraindikacije>()
                                   .Where(pp => pp.opisKontraindikacije == opis).Select(ss => ss).FirstOrDefault();
            }
            catch (Exception ec)
            {
            }
            if (p == null) 
                return new KontraIndikacijeView();
            return new KontraIndikacijeView(p);
        }


        public int AddKontraindikacije(KontraIndikacijeView k)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Kontraindikacije kind = new Kontraindikacije();
                Lek l = s.Load<Lek>(k.idLeka);
                kind.opisKontraindikacije = k.opisKontraindikacije;
                kind.idLeka = l;

                s.Save(kind);
                s.Flush();
                s.Close();
                return 1;
            }
            catch (Exception ec)
            {
                return -1;
            }
        }
        public int RemoveKontraindikacije(string opis)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                //Indikacije ind = s.Get<Indikacije>(opis);
                Kontraindikacije kind = s.Query<Kontraindikacije>()
                               .Where(pp => pp.opisKontraindikacije == opis).Select(ss => ss).FirstOrDefault();
                s.Delete(kind);
                s.Flush();
                s.Close();

                return 1;
            }
            catch (Exception ec)
            {
                return -1;
            }
        }
        public int UpdateKontraindikacije(string opis, Kontraindikacije k)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                //Kontraindikacije kk = s.Get<Kontraindikacije>(opis);
                Kontraindikacije kk = s.Query<Kontraindikacije>()
                              .Where(pp => pp.opisKontraindikacije == opis).Select(ss => ss).FirstOrDefault();
                kk.idLeka = k.idLeka;

                s.SaveOrUpdate(kk);

                s.Flush();
                s.Close();

                return 1;
            }
            catch (Exception ec)
            {
                return -1;
            }
        }


        public List<NezeljeniEfektiView> GetNezeljeniefekti()
        {
            ISession s = DataLayer.GetSession();

            IEnumerable<NezeljeniEfekti> ef = s.Query<NezeljeniEfekti>()
                                                .Select(p => p);

            List<NezeljeniEfektiView> ret = new List<NezeljeniEfektiView>();
            NezeljeniEfekti[] pa = ef.ToArray();

            foreach (NezeljeniEfekti p in pa)
                ret.Add(new NezeljeniEfektiView(p));
            return ret;

        }

        public NezeljeniEfektiView GetNezeljeniefektiView(string opis)
        {
            ISession s = DataLayer.GetSession();
            NezeljeniEfekti p = null;
            try
            {
                p = s.Query<NezeljeniEfekti>()
                                   .Where(pp => pp.opisEfekta == opis).Select(ss => ss).FirstOrDefault();
            }
            catch (Exception ec)
            {
            }
            if (p == null) return new NezeljeniEfektiView();
            return new NezeljeniEfektiView(p);
        }


        public int AddNezeljeniefekti(NezeljeniEfektiView n)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                NezeljeniEfekti nn= new NezeljeniEfekti();
                Lek l = s.Load<Lek>(n.idLeka);
                nn.opisEfekta = n.opisEfekta;
                nn.idLeka = l;

                s.Save(nn);
                s.Flush();
                s.Close();
                return 1;
            }
            catch (Exception ec)
            {
                return -1;
            }
        }
        public int RemoveNezeljeniefekti(string opis)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                //Indikacije ind = s.Get<Indikacije>(opis);
                NezeljeniEfekti ef = s.Query<NezeljeniEfekti>()
                               .Where(pp => pp.opisEfekta == opis).Select(ss => ss).FirstOrDefault();
                s.Delete(ef);
                s.Flush();
                s.Close();

                return 1;
            }
            catch (Exception ec)
            {
                return -1;
            }
        }
        public int UpdateNezeljeniefekti(string opis, NezeljeniEfekti nef)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                //NezeljeniEfekti eef = s.Get<NezeljeniEfekti>(opis);
                NezeljeniEfekti eef = s.Query<NezeljeniEfekti>()
                               .Where(pp => pp.opisEfekta == opis).Select(ss => ss).FirstOrDefault();
                eef.idLeka = nef.idLeka;

                s.SaveOrUpdate(eef);

                s.Flush();
                s.Close();

                return 1;
            }
            catch (Exception ec)
            {
                return -1;
            }
        }

        


    }
}
