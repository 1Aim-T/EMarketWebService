﻿using Core.Entities.Abstract;

namespace EMarketWebService.Entities.Dtos
{
    public class ProductDetailsDto : IDto
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string CategoryName { get; set; }
        public decimal Price { get; set; }
        public int UnitsInStock { get; set; }
    }
}
