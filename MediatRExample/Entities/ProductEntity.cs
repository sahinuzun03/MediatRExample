using System;

namespace MediatRExample.Entities
{
    public class ProductEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public decimal Amount { get; set; }

    }
}
