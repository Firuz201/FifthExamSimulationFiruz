namespace FifthExamSimulationFiruz.ViewModels.EventViewModels;

public class EventCreateVM
{
    public string Title { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;

    public decimal Price { get; set; }

    public DateOnly Date { get; set; }

    public int LocationId { get; set; }

    public IFormFile Image { get; set; } = null!;
}
