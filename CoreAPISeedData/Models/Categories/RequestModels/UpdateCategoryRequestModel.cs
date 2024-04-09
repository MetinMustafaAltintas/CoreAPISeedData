namespace CoreAPISeedData.Models.Categories.RequestModels
{
    public class UpdateCategoryRequestModel
    {
        public int ID { get; set; }

        public string CategoryName { get; set; }

        public string Description { get; set; }
    }
}
