using CotecAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CotecAPI.DataAccess.ModelsConfig
{
    public class CountryConfig
    {
        public static void SetEntityBuilder(EntityTypeBuilder<Country> entityBuilder)
        {   
            // Table Name
            entityBuilder.ToTable("Countries");

            // Primary Key
            entityBuilder.HasKey(ctry => ctry.Code); 

            // Country Code
            entityBuilder.Property(ctry => ctry.Code)
                         .HasColumnType("varchar")
                         .HasMaxLength(3)
                         .IsRequired();

            // Country Name
            entityBuilder.Property(ctry => ctry.Name)
                         .HasColumnType("varchar")
                         .HasMaxLength(50)
                         .IsRequired();

            // Flag Url
            entityBuilder.Property(ctry => ctry.FlagUrl)
                         .HasColumnType("varchar")
                         .HasMaxLength(45);

            // Foreign Key
            entityBuilder.HasOne<Continent>(ctry => ctry.Continent)
                         .WithMany(cnt => cnt.Countries)
                         .HasForeignKey(ctry => ctry.ContinentCode);

        }
    }
}