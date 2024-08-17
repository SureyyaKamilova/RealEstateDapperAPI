using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace RealEstateDapperAPI.DTOS.CatagoryDtos
{
    public class ResultCategoryDto
    {
        public int CategoryId {  get; set; }
        public string CategoryName { get; set; }
        public bool CategoryStatus {  get; set; }
    }
}
