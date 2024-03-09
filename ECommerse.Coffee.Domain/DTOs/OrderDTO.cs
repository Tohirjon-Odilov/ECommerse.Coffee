using ECommerse.Coffee.Domain.Enums;

namespace ECommerse.Coffee.Domain.DTOs
{
    public class OrderDTO
    {
        public int EmployeeId { get; set; }
        public int CustomerId { get; set; }
        public int AddressId { get; set; }
        public int Quantity { get; set; }
        public OrderStatus orderStatus { get; set; }
        public List<int> Products { get; set; }

    }
}
