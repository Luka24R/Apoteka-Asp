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
    public class IndikacijeController : ApiController
    {
        public List<IndikacijeView> Get()
        {
            DataProvider provider = new DataProvider();
            List<IndikacijeView> indikacije = provider.GetIndikacije();
            return indikacije;
        }

        public IndikacijeView Get(string opis)
        {
            DataProvider provider = new DataProvider();
            return provider.GetIndikacijeView(opis);
        }

        public int Post([FromBody]IndikacijeView p)
        {
            DataProvider provider = new DataProvider();
            return provider.AddIndikacije(p);
        }
        public int Put(string opis, [FromBody]Indikacije p)
        {
            DataProvider provider = new DataProvider();
            return provider.UpdateIndikacije(opis, p);
        }
        public int Delete(string opis)
        {
            DataProvider provider = new DataProvider();
            return provider.RemoveIndikacije(opis);
        }
    }
}
