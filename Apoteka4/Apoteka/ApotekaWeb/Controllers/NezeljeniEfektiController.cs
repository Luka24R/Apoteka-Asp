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
    public class NezeljeniEfektiController : ApiController
    {
        public NezeljeniEfektiView Get(string opis)
        {
            DataProvider provider = new DataProvider();
            return provider.GetNezeljeniefektiView(opis);
        }

        public List<NezeljeniEfektiView> Get()
        {
            DataProvider provider = new DataProvider();

            return provider.GetNezeljeniefekti();
        }
        public int Delete(string opis)
        {
            DataProvider provider = new DataProvider();

            return provider.RemoveNezeljeniefekti(opis);
        }

        public int Post([FromBody]NezeljeniEfektiView p)
        {
            DataProvider provider = new DataProvider();

            return provider.AddNezeljeniefekti(p);
        }

        public int Put(string opis, [FromBody] NezeljeniEfekti p)
        {
            DataProvider provider = new DataProvider();

            return provider.UpdateNezeljeniefekti(opis, p);
        }
    }
}
