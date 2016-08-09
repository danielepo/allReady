using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using AllReady.Areas.Admin.ViewModels.Itinerary;
using AllReady.Areas.Admin.ViewModels.Shared;
using AllReady.Areas.Admin.ViewModels.Task;
using AllReady.Models;

namespace AllReady.Areas.Admin.ViewModels.Event
{
    public class EventDetailViewModel : EventSummaryViewModel
    {
        [UIHint("Location")]
        public LocationEditViewModel Location { get; set; }
        public IList<TaskSummaryViewModel> Tasks { get; set; } = new List<TaskSummaryViewModel>();
        public IList<string> Volunteers { get; set; } = new List<string>();

        [Display(Name = "Required Skills")]
        public IEnumerable<EventSkill> RequiredSkills { get; set; } = new List<EventSkill>();

        public IEnumerable<ItineraryListViewModel> Itineraries { get; set; } = new List<ItineraryListViewModel>();

        public bool DisplayItineraries => EventType == EventType.Itinerary;

        public ItineraryEditViewModel NewItinerary { get; set; } = new ItineraryEditViewModel();

        public string ItinerariesDetailsUrl { get; set; }
    }
}
