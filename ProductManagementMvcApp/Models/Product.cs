﻿namespace ProductManagementMvcApp.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public string? Description { get; set; }
        public bool InStock { get; set; }
        //public Category? Category { get; set; }
        //public  int Quantity { get; set; }
        //public DateTime CreatedAt { get; set; }
    }
}
