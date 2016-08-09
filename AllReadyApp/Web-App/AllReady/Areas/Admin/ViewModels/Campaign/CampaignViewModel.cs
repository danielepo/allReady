using AllReady.Areas.Admin.Models;
using AllReady.Models;
using System;
using System.ComponentModel.DataAnnotations;

namespace AllReady.Areas.Admin.ViewModels.Campaign
{
    public class CampaignViewModel
    {
        public CampaignViewModel(CampaignDetailModel campaign)
        {
            Name = campaign.Name;
            Featured = campaign.Featured;
            Locked = campaign.Locked;
            Id = campaign.Id;
            StartDate = campaign.StartDate;
            EndDate = campaign.EndDate;
            OrganizationName = campaign.OrganizationName;
            OrganizationId = campaign.OrganizationId;
            CampaignImpact = campaign.CampaignImpact;
            FullDescription = campaign.FullDescription;
            ImageUrl = campaign.ImageUrl;
            ExternalUrlText = campaign.ExternalUrlText;
            ExternalUrl = campaign.ExternalUrl;
            Location = campaign.Location;
            PrimaryContactEmail = campaign.PrimaryContactEmail;
            PrimaryContactFirstName = campaign.PrimaryContactFirstName;
            PrimaryContactLastName = campaign.PrimaryContactLastName;
            PrimaryContactPhoneNumber = campaign.PrimaryContactPhoneNumber;
            TimeZoneId = campaign.TimeZoneId;
        }
        public string Name { get; private set; }
        public bool Featured { get; private set; }
        public bool Locked { get; private set; }
        public int Id { get; private set; }

        [Display(Name = "Start Date")]
        public DateTimeOffset StartDate { get; private set; }

        [Display(Name = "End Date")]
        public DateTimeOffset EndDate { get; private set; }

        [Display(Name = "Time Zone")]
        public string TimeZoneId { get; private set; }

        [Display(Name = "First Name")]
        public string PrimaryContactFirstName { get; private set; }

        [Display(Name = "Last Name")]
        public string PrimaryContactLastName { get; private set; }

        [Display(Name = "Phone Number")]
        [Phone]
        public string PrimaryContactPhoneNumber { get; private set; }

        [Display(Name = "Email")]
        [EmailAddress]
        public string PrimaryContactEmail { get; private set; }

        public LocationDisplayModel Location { get; private set; }

        [Display(Name = "External URL")]
        public string ExternalUrl { get; set; }

        [Display(Name = "External URL Text")]
        public string ExternalUrlText { get; set; }

        [Display(Name = "Image URL")]
        public string ImageUrl { get; set; }

        public string FullDescription { get; set; }
        public CampaignImpact CampaignImpact { get; set; }

        [Display(Name = "Organization")]
        public int OrganizationId { get; set; }

        [Display(Name = "Organization")]
        public string OrganizationName { get; set; }
    }
}