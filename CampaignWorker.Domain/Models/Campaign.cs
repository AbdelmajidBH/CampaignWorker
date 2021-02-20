namespace CampaignWorker.Domain.Models
{
    public class Campaign
    {
        public int Id { set; get; }

        public string Name { set; get; }

        public string Description { set; get; }

        public bool IsActive { set; get; }
    }
}
