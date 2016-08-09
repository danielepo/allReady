using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using AllReady.Areas.Admin.ViewModels.Itinerary;
using AllReady.Areas.Admin.ViewModels.Shared;
using AllReady.Areas.Admin.ViewModels.Task;
using AllReady.Models;

namespace AllReady.Areas.Admin.ViewModels.Event
{
    public class EventDetailModel : EventSummaryModel
    {
        [UIHint("Location")]
        public LocationEditModel Location { get; set; }
        public IList<TaskSummaryModel> Tasks { get; set; } = new List<TaskSummaryModel>();
        public IList<string> Volunteers { get; set; } = new List<string>();

        [Display(Name = "Required Skills")]
        public IEnumerable<EventSkill> RequiredSkills { get; set; } = new List<EventSkill>();

        public IEnumerable<ItineraryListModel> Itineraries { get; set; } = new List<ItineraryListModel>();

        public bool DisplayItineraries => EventType == EventType.Itinerary;

        public ItineraryEditModel NewItinerary { get; set; } = new ItineraryEditModel();

        public string ItinerariesDetailsUrl { get; set; }
    }
}
