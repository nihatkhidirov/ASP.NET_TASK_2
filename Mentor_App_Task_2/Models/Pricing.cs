namespace Mentor_App_Task_2.Models
{
    public class Pricing:BaseEntity
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public decimal Price { get; set; }
        public bool IsFeatured { get; set; }
        public bool IsAdvanced { get; set; }

    }
}
