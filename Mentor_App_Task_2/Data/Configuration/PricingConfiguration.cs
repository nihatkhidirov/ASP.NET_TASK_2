using Mentor_App_Task_2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Mentor_App_Task_2.Data.Configuration
{
    public class PricingConfiguration : IEntityTypeConfiguration<Pricing>

    {
        public void Configure(EntityTypeBuilder<Pricing> builder)
        {

        }
    }
}
