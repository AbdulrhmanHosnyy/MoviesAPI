using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MoviesAPI.Data.Config
{
    public partial class GenreConfiguration
    {
        public class MovieConfiguration : IEntityTypeConfiguration<Movie>
        {
            public void Configure(EntityTypeBuilder<Movie> builder)
            {
                builder.HasKey(m => m.Id);
                builder.Property(m => m.Id).ValueGeneratedOnAdd();
                builder.Property(m => m.Title).HasColumnType("VARCHAR").HasMaxLength(250);
                builder.Property(m => m.Storyline).HasColumnType("VARCHAR").HasMaxLength(250);
                builder.ToTable("Movies");
            }
        }
    }
}
