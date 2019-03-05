using Apoteka;
using Apoteka.DTOs;
using Apoteka.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace ApotekaWeb.Controllers
{
    public class FarmaceutController : ApiController
    {
        public IEnumerable<FarmaceutView> Get()
        {
            DataProvider provider = new DataProvider();
 
            return provider.GetFarmaceuti();
        }
        public FarmaceutView Get(int id)
        {
            DataProvider provider = new DataProvider();
            return provider.GetFarmaceutView(id);
        }
        public int Post([FromBody]Farmaceut r)
        {
            DataProvider provider = new DataProvider();
            return provider.AddFarmaceut(r);
        }
        public int Put(int id, [FromBody]Farmaceut r)
        {
            DataProvider provider = new DataProvider();
            return provider.UpdateFarmaceut(id, r);
        }
        public int Delete(int id)
        {
            DataProvider provider = new DataProvider();
            return provider.RemoveFarmaceut(id);
        }
    }
}