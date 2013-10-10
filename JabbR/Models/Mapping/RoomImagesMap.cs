using System.Data.Entity.ModelConfiguration;

namespace JabbR.Models.Mapping
{
    public class RoomImagesMap : EntityTypeConfiguration<RoomImages>
    {
        public RoomImagesMap()
        {
            // Primary Key
            this.HasKey(m => m.Key);

            // Properties
            // Table & Column Mappings
            this.ToTable("RoomImages");
            this.Property(m => m.Key).HasColumnName("Key");
            this.Property(m => m.ImageName).HasColumnName("ImageName");
            this.Property(m => m.ImageSource).HasColumnName("ImageSource");
            this.Property(m => m.BigImageSource).HasColumnName("BigImageSource");
            this.Property(m => m.Comment).HasColumnName("Comment");

            this.HasRequired(a => a.User)
                .WithMany(u => u.RoomImages)
                .HasForeignKey(a => a.UserKey);

            this.HasRequired(a => a.Room)
                .WithMany(u => u.RoomImages)
                .HasForeignKey(a => a.RoomKey);
        }
    }
}