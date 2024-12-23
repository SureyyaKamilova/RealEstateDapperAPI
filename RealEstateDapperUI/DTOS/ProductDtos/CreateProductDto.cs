﻿namespace RealEstateDapperUI.DTOS.ProductDtos
{
    public class CreateProductDto
    {
        public string title { get; set; }
        public decimal price { get; set; }
        public string city { get; set; }
        public string district { get; set; }
        public string categoryid { get; set; }
        public string coverImage { get; set; }
        public string type { get; set; }
        public string address { get; set; }
        public bool dealOfTheDay { get; set; }
        public DateTime announcementDate { get; set; }

    }
}
