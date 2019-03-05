using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Apoteka;
using Apoteka.Entiteti;
using Apoteka.DTOs;
using System.Web;
using System.Web.Mvc;

namespace ApotekaWeb.Controllers
{
    public class LekController : ApiController
    {

        // GET api/lek
        /*public IEnumerable<Lek> Get()
        {
            DTOManager provider = new DTOManager();

            IEnumerable<Lek> lekovi = provider.GetLekovi();

            //return new [] {
            //    new Vojnik() {Naziv="test"}
            //};

            return lekovi;
        }*/
        
        //GET api/lek/komercijalni naziv
        public LekView Get(string komN)
        {
            DataProvider provider = new DataProvider();
            return provider.GetLekView(komN);
        }

        // POST api/
        public int Post([FromBody]Lek p)
        {
            DataProvider provider = new DataProvider();

            return provider.AddLek(p);
        }
        // PUT api/proizvodjac/komerNaizv
        public int Put(string komN, [FromBody]Lek v)
        {
            DataProvider provider = new DataProvider();
            return provider.UpdateLek(komN, v);
        }

        // DELETE api/proizvodjac/komerNaizv
        public int Delete(string s)
        {
            DataProvider provider = new DataProvider();

            return provider.RemoveLek(s);
        }
    }
}
