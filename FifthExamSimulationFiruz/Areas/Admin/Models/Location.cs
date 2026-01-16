using FifthExamSimulationFiruz.Areas.Admin.Models.Common;

namespace FifthExamSimulationFiruz.Areas.Admin.Models
{
    public class Location : BaseEntity
    {
        public string Place { get; set; } = null!;
        public ICollection<Event> Events { get; set; } = [];
    }
}
