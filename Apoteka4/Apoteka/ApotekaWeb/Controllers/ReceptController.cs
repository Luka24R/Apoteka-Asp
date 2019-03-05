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
    public class ReceptController : ApiController
    {
        public ReceptView Get(int id)
        {
            DataProvider provider = new DataProvider();
            return provider.GetReceptView(id);
        }
        public int Post([FromBody]Recept r)
        {
            DataProvider provider = new DataProvider();
            return provider.AddRecept(r);
        }
        public int Put(int id, [FromBody]Recept r)
        {
            DataProvider provider = new DataProvider();
            return provider.UpdateRecept(id, r);
        }
        public int Delete(int id)
        {
            DataProvider provider = new DataProvider();
            return provider.RemoveRecept(id);
        }
    }
}
