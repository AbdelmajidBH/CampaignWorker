using CampaignWorker.Domain.Abstractions;
using CampaignWorker.Domain.Dto;
using CampaignWorker.Infrastructure.DbContexts;
using System.Collections.Generic;
using System.Linq;

namespace CampaignWorker.Infrastructure.Repository
{
    public class SqlRepository : IRepository
    {
        private readonly CampaignWorkerContext _context;

        public SqlRepository(CampaignWorkerContext context)
        {
            _context = context;
        }

        public void Delete(int id)
        {
            var compain = _context.Campaigns.SingleOrDefault(c => c.Id == id);
            _context.Campaigns.Remove(compain);
            _context.SaveChanges();
        }

        public IEnumerable<CampaignDto> GetAll()
        {
            return _context.Campaigns.ToList();
        }

        public CampaignDto GetById(int id)
        {
            return _context.Campaigns.SingleOrDefault(c => c.Id == id);
        }

        public void Insert(CampaignDto campaign)
        {
            _context.Campaigns.Add(campaign);
            _context.SaveChanges();
        }

        public void Update(CampaignDto campaign)
        {
            //var c = _context.Campaigns.SingleOrDefault(c => c.Id == campaign.Id);
            _context.Campaigns.Update(campaign);
            _context.SaveChanges();
        }
    }
}
