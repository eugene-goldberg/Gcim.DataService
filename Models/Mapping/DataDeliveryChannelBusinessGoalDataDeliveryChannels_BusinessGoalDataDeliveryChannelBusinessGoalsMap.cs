using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SelfHostedWebApiDataService.Models.Mapping
{
    public class DataDeliveryChannelBusinessGoalDataDeliveryChannels_BusinessGoalDataDeliveryChannelBusinessGoalsMap : EntityTypeConfiguration<DataDeliveryChannelBusinessGoalDataDeliveryChannels_BusinessGoalDataDeliveryChannelBusinessGoals>
    {
        public DataDeliveryChannelBusinessGoalDataDeliveryChannels_BusinessGoalDataDeliveryChannelBusinessGoalsMap()
        {
            // Primary Key
            this.HasKey(t => t.OID);

            // Properties
            // Table & Column Mappings
            this.ToTable("DataDeliveryChannelBusinessGoalDataDeliveryChannels_BusinessGoalDataDeliveryChannelBusinessGoals");
            this.Property(t => t.DataDeliveryChannelBusinessGoals).HasColumnName("DataDeliveryChannelBusinessGoals");
            this.Property(t => t.BusinessGoalDataDeliveryChannels).HasColumnName("BusinessGoalDataDeliveryChannels");
            this.Property(t => t.OID).HasColumnName("OID");
            this.Property(t => t.OptimisticLockField).HasColumnName("OptimisticLockField");

            // Relationships
            this.HasOptional(t => t.BusinessGoal)
                .WithMany(t => t.DataDeliveryChannelBusinessGoalDataDeliveryChannels_BusinessGoalDataDeliveryChannelBusinessGoals)
                .HasForeignKey(d => d.DataDeliveryChannelBusinessGoals);
            this.HasOptional(t => t.DataDeliveryChannel)
                .WithMany(t => t.DataDeliveryChannelBusinessGoalDataDeliveryChannels_BusinessGoalDataDeliveryChannelBusinessGoals)
                .HasForeignKey(d => d.BusinessGoalDataDeliveryChannels);

        }
    }
}
