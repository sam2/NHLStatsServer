using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NhlStatsDtos;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace NHLStatsWebAPICore.Controllers
{
    [Route("api/[controller]")]
    public class NHLStatsController : Controller
    {
        INHLStatsDatabase m_db = new NHLFakeData();

        // GET: api/values
        [HttpGet]
        public IEnumerable<NhlGameDto> Get()
        {
            return m_db.GetAllGames();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public NhlGameDto Get(int id)
        {
            return m_db.GetGame(id);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
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
