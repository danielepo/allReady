using System;

namespace AllReady.Areas.Admin.ViewModels.Request
{
    public class RequestSearchCriteria
    {
        public Guid? RequestId { get; set; }
        public bool IncludeAssigned { get; set; } = false;
        public bool IncludeCanceled { get; set; } = false;
        public int? EventId { get; set; }

        public string Keywords { get; set; }
    }
}
