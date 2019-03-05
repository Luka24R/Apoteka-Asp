using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Apoteka;
using Apoteka.DTOs;
using Apoteka.Entiteti;

namespace ApotekaWeb.Controllers
{
    public class ProizvodjacController : ApiController
    {
        // GET api/proizvodjac/5
        public ProizvodjacView Get(int id)
        {
            DataProvider provider = new DataProvider();
            return provider.GetProizvodjacView(id);
        }
        // POST api/
        public int Post([FromBody]Proizvodjac p)
        {
            DataProvider provider = new DataProvider();

            return provider.AddProizvodjac(p);
        }
        // PUT api/proizvodjac/5
        public int Put(int id, [FromBody]Proizvodjac v)
        {
            DataProvider provider = new DataProvider();
            return provider.UpdateProizvodjac(id, v);
        }

        // DELETE api/proizvodjac/5
        public int Delete(int id)
        {
            DataProvider provider = new DataProvider();

            return provider.RemoveProizvodjac(id);
        }
    }
}
