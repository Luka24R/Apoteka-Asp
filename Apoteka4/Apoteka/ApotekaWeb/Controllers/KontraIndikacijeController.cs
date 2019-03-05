using Apoteka;
using Apoteka.DTOs;
using Apoteka.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ApotekaWeb.Controllers
{
    public class KontraIndikacijeController : ApiController
    {
        public KontraIndikacijeView Get(string opis)
        {
            DataProvider provider = new DataProvider();
            return provider.GetKontraindikacijeView(opis);
        }

        public List<KontraIndikacijeView> Get()
        {
            DataProvider provider = new DataProvider();

            return provider.GetKontraindikacije();
        }
        public int Delete(string opis)
        {
            DataProvider provider = new DataProvider();

            return provider.RemoveKontraindikacije(opis);
        }

        public int Post([FromBody]KontraIndikacijeView p)
        {
            DataProvider provider = new DataProvider();

            return provider.AddKontraindikacije(p);
        }

        public int Put(string opis, [FromBody] Kontraindikacije p)
        {
            DataProvider provider = new DataProvider();

            return provider.UpdateKontraindikacije(opis, p);
        }
    }
}
