using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Apoteka.Entiteti;
using Apoteka.DTOs;
using Apoteka;

namespace ApotekaWeb.Controllers
{
    public class PakovanjeController : ApiController
    {
        public PakovanjeView Get(int id)
        {
            DataProvider provider = new DataProvider();
            return provider.GetPakovanjeView(id);
        }

        public List<PakovanjeView> Get()
        {
            DataProvider provider = new DataProvider();
            
            return provider.GetPakovanja();
        }
        public int Delete(int id)
        {
            DataProvider provider = new DataProvider();

            return provider.RemovePakovanje(id);
        }

        public int Post([FromBody]Pakovanje p)
        {
            DataProvider provider = new DataProvider();

            return provider.AddPakovanje(p);
        }

        public int Put(int id,[FromBody] Pakovanje p)
        {
            DataProvider provider = new DataProvider();

            return provider.UpdatePakovanje(id, p);
        }
    }
}
