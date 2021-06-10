namespace Data.EntityTypeConfiguration
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using Models;

    public class GameExtraConfiguration : IEntityTypeConfiguration<GameExtra>
    {
        public void Configure(EntityTypeBuilder<GameExtra> builder)
        {
            builder.HasKey(tcm => new { tcm.GameId, tcm.ExtraId });

            builder.HasOne(tcm => tcm.Game)
                .WithMany(t => t.GameExtras)
                .HasForeignKey(tcm => tcm.GameId);

            builder.HasOne(tcm => tcm.Extra)
                .WithMany(tc => tc.GameExtras)
                .HasForeignKey(tcm => tcm.ExtraId);
        }
    }
}
