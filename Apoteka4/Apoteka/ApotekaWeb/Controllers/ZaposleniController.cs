using Apoteka;
using Apoteka.DTOs;
using Apoteka.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace ApotekaWeb.Controllers
{
    public class ZaposleniController : ApiController
    {
        public IEnumerable<ZaposleniView> Get()
        {
            DataProvider provider = new DataProvider();
            return provider.GetZaposleni();
        }
        public ZaposleniView Get(int id)
        {
            DataProvider provider = new DataProvider();
            return provider.GetZaposleniView(id);
        }
        public int Post([FromBody]Zaposleni r)
        {
            DataProvider provider = new DataProvider();
            return provider.AddZaposleni(r);
        }
        public int Put(int id, [FromBody]Zaposleni r)
        {
            DataProvider provider = new DataProvider();
            return provider.UpdateZaposleni(id, r);
        }
        public int Delete(int id)
        {
            DataProvider provider = new DataProvider();
            return provider.RemoveZaposleni(id);
        }
    }
}