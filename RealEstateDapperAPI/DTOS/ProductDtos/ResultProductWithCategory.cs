﻿namespace RealEstateDapperAPI.DTOS.ProductDtos
{
    public class ResultProductWithCategory
    {
        public int ProductId { get; set; }
        public string Titlke { get; set; }
        public decimal Price { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string CategoryName { get; set; }
    }
}