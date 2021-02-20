using CampaignWorker.Domain.Abstractions;
using CampaignWorker.Domain.Adapters;
using CampaignWorker.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CampaignWorker.Domain.Hanlers
{
    public class CampaignHandler : ICampaignHandler
    {

        private readonly IRepository _repository;

        public CampaignHandler(IRepository repository)
        {
            _repository = repository;
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }

        public IEnumerable<Campaign> GetAll()
        {
            return _repository.GetAll()
                              .ToList()
                              .ToCampaigns();
        }

        public Campaign GetById(int id)
        {
           return _repository.GetById(id).ToCampaign();
        }

        public void Insert(Campaign campaign)
        {
            _repository.Insert(campaign.ToCampaignDto());
        }

        public void Update(Campaign campaign)
        {
            _repository.Update(campaign.ToCampaignDto());
        }
    }
}
