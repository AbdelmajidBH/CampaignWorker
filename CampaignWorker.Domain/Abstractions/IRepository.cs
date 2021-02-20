
using CampaignWorker.Domain.Dto;
using System.Collections.Generic;

namespace CampaignWorker.Domain.Abstractions
{
    public interface IRepository
    {
        IEnumerable<CampaignDto> GetAll();
        CampaignDto GetById(int id);
        void Insert(CampaignDto campaign);
        void Update(CampaignDto campaign);
        void Delete(int id);
    }
}
