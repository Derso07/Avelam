using ApplicationCore.Avelam.Enum;

namespace ApplicationCore.Avelam.Models;
public class Sweet : BaseEntity
{
    public string Title { get; set; }
    public string Description { get; set; }
    public TypeSweet TypeSweet { get; set; }

    public ICollection<Order> Orders { get; set; } = new List<Order>();
}
