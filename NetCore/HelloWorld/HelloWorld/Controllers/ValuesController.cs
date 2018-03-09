using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HelloWorld.Models;
using HelloWorld.DataModel;

namespace HelloWorld.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        // GET api/values
        [HttpGet]
        public List<OperationIndexData> Get()
        {
            List<OperationIndexData> list = new List<OperationIndexData>();
            String []farmList = {"阿拉善","埃塞","黑山","康保","凉城","坝上","新林","牦牛坪","尚义","太阳山","同煤",
                        "王子山","小草湖","泽清岭","张北","崇礼","新华","达坂城","团结","四平","偏关","代县","李子箐","平度",
                        "如东","宁乡","Colorado","Hill","Ralls"};
            for (int i = 2; i < farmList.Length + 2; i++)
            {
                list.Add(new OperationIndexData(farmList[i - 2],
                        (40 - i) * 0.25f,
                        (38 - i) * 0.1f + 2,
                        i * 0.1f + 3,
                        i * 0.3f,
                        i * 0.25f,
                        i * 0.3f));
            }

            return list;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]Test value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
