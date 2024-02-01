using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MoviesAPI.Data.Config
{
    public partial class GenreConfiguration : IEntityTypeConfiguration<Genre>
    {
        public void Configure(EntityTypeBuilder<Genre> builder)
        {
            builder.HasKey(g => g.Id);
            builder.Property(g => g.Id).ValueGeneratedOnAdd();
            builder.Property(g => g.Name).HasColumnType("VARCHAR").HasMaxLength(100).IsRequired();
            builder.ToTable("Genres");
        }
    }
}
