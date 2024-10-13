using Dapper;
using RealEstateDapperAPI.DTOS.CatagoryDtos;
using RealEstateDapperAPI.DTOS.TestimonialDtos;
using RealEstateDapperAPI.Models.DapperContext;
using RealEstateDapperAPI.Repositories.Interfaces;

namespace RealEstateDapperAPI.Repositories.Implementations
{
    public class StatisticsRepository : IStatisticsRepository
    {
        private readonly Context _context;
        public StatisticsRepository(Context context)
        {
            _context = context;
        }

        public int ActiveCategoryCount()
        {
            string query = "Select Count(*) From Category where CategoryStatus=1";
            using (var connection = _context.CreateConnection())
            {
                var values = connection.QueryFirstOrDefault<int>(query);

                return values;
            }

        }

        public int ActiveEmployeeCount()
        {
            string query = "Select Count(*) From Employee where Status=1";
            using (var connection = _context.CreateConnection())
            {
                var values = connection.QueryFirstOrDefault<int>(query);

                return values;
            }
        }

        public int ApartmentCount()
        {
            string query = "Select Count(*) From Product where Title like '%Dairə%'";
            using (var connection = _context.CreateConnection())
            {
                var values = connection.QueryFirstOrDefault<int>(query);

                return values;
            }
        }

        public decimal AverageProductPriceByRent()
        {
            string query = "Select Avg(Price) From Product where Type=N'Kiralıq'";
            using (var connection = _context.CreateConnection())
            {
                var values = connection.QueryFirstOrDefault<decimal>(query);

                return values;
            }
        }

        public decimal AverageProductPriceBySale()
        {
            string query = "Select Avg(Price) From Product where Type=N'Satılıq'";
            using (var connection = _context.CreateConnection())
            {
                var values = connection.QueryFirstOrDefault<decimal>(query);

                return values;
            }
        }

        public int AverageRoomCount()
        {
            string query = "Select Avg(RoomCount) From ProductDetails";
            using (var connection = _context.CreateConnection())
            {
                var values = connection.QueryFirstOrDefault<int>(query);

                return values;
            }
        }

        public int CategoryCount()
        {
            string query = "Select Count(*) From Category";
            using (var connection = _context.CreateConnection())
            {
                var values = connection.QueryFirstOrDefault<int>(query);

                return values;
            }
        }

        public string CategoryNameByMaxProductCount()
        {
            string query = "Select top(1) CategoryName,Count(*) From Product " +
                "inner join Category On Product.ProductCategory=Category.CategoryId " +
                "Group By CategoryName order by Count(*) Desc";
            using (var connection = _context.CreateConnection())
            {
                var values = connection.QueryFirstOrDefault<string>(query);

                return values;
            }
        }

        public string CityNameByMaxProductCount()
        {
            string query = "Select City, Count(*) as 'NumberOfAd' From Product" +
                " Group By City order by NumberOfAd Desc";
            using (var connection = _context.CreateConnection())
            {
                var values = connection.QueryFirstOrDefault<string>(query);

                return values;
            }
        }

        public int DifferentCityCount()
        {
            string query = "Select Count(Distinct(City)) From Product ";
            using (var connection = _context.CreateConnection())
            {
                var values = connection.QueryFirstOrDefault<int>(query);

                return values;
            }
        }

        public string EmployeeNameByMaxProductCount()
        {
            string query = "Select EmployeeName,Count(*) 'ProductCount' from Product Inner join Employee On Product.EmployeeId=Employee.EmployeeId Group By EmployeeName Order By ProductCount Desc ";
            using (var connection = _context.CreateConnection())
            {
                var values = connection.QueryFirstOrDefault<string>(query);

                return values;
            }
        }

        public decimal LastProductPrice()
        {
            string query = "Select Top(1) Price From Product Order By ProductId Desc  ";
            using (var connection = _context.CreateConnection())
            {
                var values = connection.QueryFirstOrDefault<decimal>(query);

                return values;
            }
        }

        public string NewestBuildingYear()
        {
            string query = "Select Top(1) BuildYear From ProductDetails Order by BuildYear Desc";
            using (var connection = _context.CreateConnection())
            {
                var values = connection.QueryFirstOrDefault<string>(query);

                return values;
            }
        }

        public string OldestBuildingYear()
        {
            string query = "Select Top(1) BuildYear From ProductDetails Order by BuildYear Asc";
            using (var connection = _context.CreateConnection())
            {
                var values = connection.QueryFirstOrDefault<string>(query);

                return values;
            }

        }

        public int PassiveCategoryCount()
        {
            string query = "Select Count(*) From Category where CategoryStatus=0";
            using (var connection = _context.CreateConnection())
            {
                var values = connection.QueryFirstOrDefault<int>(query);

                return values;
            }

        }

        public int ProductCount()
        {
            string query = "Select Count(*) From Product";
            using (var connection = _context.CreateConnection())
            {
                var values = connection.QueryFirstOrDefault<int>(query);

                return values;
            }
        }
    }
}
