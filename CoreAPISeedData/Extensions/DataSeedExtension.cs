using CoreAPISeedData.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace CoreAPISeedData.Extensions
{
    public static class DataSeedExtension
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            // Bu yaptığımız yöntemde Primary Key İdentity'si tetiklenmez .. Dolayısıyla ID'yi burada elle vermeliyiz..

            #region CategoryData
            Category c = new()
            {
                ID = 1,
                CategoryName = "TestKategori",
                Description = "Test Verisidir"
            };

            modelBuilder.Entity<Category>().HasData(c);
            #endregion
        }
    }
}
