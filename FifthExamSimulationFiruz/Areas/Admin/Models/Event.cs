using FifthExamSimulationFiruz.Areas.Admin.Models.Common;

namespace FifthExamSimulationFiruz.Areas.Admin.Models
{
    public class Event : BaseEntity
    {
        public string Title { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public string ImagePath { get; set; } = string.Empty;

        public decimal Price { get; set; }

        public DateOnly Date { get; set; }

        public int LocationId { get; set; }

        public Location Location { get; set; } = null!;
    }
}
