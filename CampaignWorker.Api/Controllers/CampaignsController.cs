using CampaignWorker.Domain.Abstractions;
using CampaignWorker.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CampaignWorker.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CampaignsController : ControllerBase
    {

        private readonly ICampaignHandler _handler;

        public CampaignsController(ICampaignHandler handler)
        {
            _handler = handler;
        }

        // GET: api/<CampaignsController>
        [HttpGet]
        public IEnumerable<Campaign> Get()
        {
            return _handler.GetAll();
        }

        // GET api/<CampaignsController>/5
        [HttpGet("{id}")]
        public Campaign Get(int id)
        {
            return _handler.GetById(id);
        }

        // POST api/<CampaignsController>
        [HttpPost]
        public void Post([FromBody] Campaign campaign)
        {
            _handler.Insert(campaign);
            Get();
        }

        // PUT api/<CampaignsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {

        }

        // DELETE api/<CampaignsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _handler.Delete(id);
            Get();
        }
    }
}
