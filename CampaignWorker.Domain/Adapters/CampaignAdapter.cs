using CampaignWorker.Domain.Dto;
using CampaignWorker.Domain.Models;
using System.Collections.Generic;

namespace CampaignWorker.Domain.Adapters
{
    public static class CampaignAdapter
    {
        public static Campaign ToCampaign(this CampaignDto campaignDto)
        {
            if (campaignDto == null)
            {
                return null;
            }

            return new Campaign
            {
                Id = campaignDto.Id,
                Name = campaignDto.Name,
                Description = campaignDto.Description,
                IsActive = campaignDto.IsActive

            };
        }

        public static IEnumerable<Campaign> ToCampaigns(this List<CampaignDto> campaignDtos)
        {
            if (campaignDtos == null || campaignDtos.Count <= 0)
            {
                return null;
            }

            return campaignDtos.ConvertAll(ToCampaign);
        }

        public static CampaignDto ToCampaignDto(this Campaign campaign)
        {
            if (campaign == null)
            {
                return null;
            }

            return new CampaignDto
            {
                Id = campaign.Id,
                Name = campaign.Name,
                Description = campaign.Description,
                IsActive = campaign.IsActive

            };
        }
    }
}
