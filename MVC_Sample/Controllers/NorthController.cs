using MVC_Sample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Results;
//using System.Web.Mvc;

namespace MVC_Sample.Controllers
{
    public class NorthController : BaseController
    {
        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET bk/api/values/{id}
        [HttpGet]
        public JsonResult<DataResult<int>> Categories(int id)
        {
            try
            {
                //呼叫service
                return Ok(id, "成功");
            }
            catch (Exception ex)
            {
                LogError("發生例外",ex);
                return Error(id, HttpStatusCode.InternalServerError, "伺服器失敗");
            }
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpDelete]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete]
        public void Delete([FromUri]int id)
        {
            //return Ok(id, "successfull");
        }
    }
}
