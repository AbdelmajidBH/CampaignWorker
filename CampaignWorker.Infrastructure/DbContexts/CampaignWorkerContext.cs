using CampaignWorker.Domain.Dto;
using Microsoft.EntityFrameworkCore;

namespace CampaignWorker.Infrastructure.DbContexts
{
    public class CampaignWorkerContext : DbContext
    {
        public CampaignWorkerContext(DbContextOptions<CampaignWorkerContext> options) : base(options)
        {
        }

        public DbSet<CampaignDto> Campaigns { get; set; }
    }
}