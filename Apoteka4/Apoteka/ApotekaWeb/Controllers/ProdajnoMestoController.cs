using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Apoteka.DTOs;
using Apoteka;
using Apoteka.Entiteti;

namespace ApotekaWeb.Controllers
{
    public class ProdajnoMestoController : ApiController
    {
        public ProdajnoMestoView Get(int id)
        {
            DataProvider provider = new DataProvider();
            return provider.GetProdajnoMestoView(id);
        }

        public List<ProdajnoMestoView> Get()
        {
            DataProvider provider = new DataProvider();



            return provider.GetProdajnaMesta();
        }

        public int Post([FromBody]ProdajnoMesto p)
        {
            DataProvider provider = new DataProvider();

            return provider.AddProdajnoMesto(p);
        }

        public int Delete(int id)
        {
            DataProvider provider = new DataProvider();

            return provider.RemoveProdajnoMesto(id);
        }

        public int Put(int id, [FromBody]ProdajnoMesto p)
        {
            DataProvider provider = new DataProvider();
            return provider.UpdateProdajnoMesto(id, p);
        }
    }
}
