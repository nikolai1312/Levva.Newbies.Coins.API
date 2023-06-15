using Levva.Newbies.Coins.API.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Levva.Newbies.Coins.API.Data.Configuration
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Transaction>
    {
        public void Configure(EntityTypeBuilder<Transaction> builder)
        {

        }
    }
}
