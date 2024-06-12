using ApplicationCore.Avelam.Enum;

namespace ApplicationCore.Avelam.Models;
public class Order : BaseEntity
{
    public int Quantity { get; set; }
    public decimal Price { get; set; } = 0;
    public DateTime DataCreated { get; set; }
    public DateTime EndDate { get; set; }
    public StatusOrder StatusOrder { get; set; }
    public long SweetId { get; set; }
    public Sweet Sweet { get; set; }
}
