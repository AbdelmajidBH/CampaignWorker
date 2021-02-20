using CampaignWorker.Domain.Models;
using System.Collections.Generic;

namespace CampaignWorker.Domain.Abstractions
{
    public interface ICampaignHandler
    {
        IEnumerable<Campaign> GetAll();
        Campaign GetById(int id);
        void Insert(Campaign campaign);
        void Update(Campaign campaign);
        void Delete(int id);
    }
}
