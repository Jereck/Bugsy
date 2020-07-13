using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Config
{
    public class BugConfiguration : IEntityTypeConfiguration<Bug>
    {
        public void Configure(EntityTypeBuilder<Bug> builder)
        {
            builder.Property(p => p.Id).IsRequired();
            builder.Property(p => p.BugTitle).IsRequired().HasMaxLength(100);
            builder.Property(p => p.BugDescription).IsRequired();
            builder.Property(p => p.ToolName).IsRequired();
        }
    }
}