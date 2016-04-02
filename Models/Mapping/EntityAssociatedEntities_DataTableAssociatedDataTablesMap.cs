using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SelfHostedWebApiDataService.Models.Mapping
{
    public class EntityAssociatedEntities_DataTableAssociatedDataTablesMap : EntityTypeConfiguration<EntityAssociatedEntities_DataTableAssociatedDataTables>
    {
        public EntityAssociatedEntities_DataTableAssociatedDataTablesMap()
        {
            // Primary Key
            this.HasKey(t => t.OID);

            // Properties
            // Table & Column Mappings
            this.ToTable("EntityAssociatedEntities_DataTableAssociatedDataTables");
            this.Property(t => t.AssociatedDataTables).HasColumnName("AssociatedDataTables");
            this.Property(t => t.AssociatedEntities).HasColumnName("AssociatedEntities");
            this.Property(t => t.OID).HasColumnName("OID");
            this.Property(t => t.OptimisticLockField).HasColumnName("OptimisticLockField");

            // Relationships
            this.HasOptional(t => t.DataTable)
                .WithMany(t => t.EntityAssociatedEntities_DataTableAssociatedDataTables)
                .HasForeignKey(d => d.AssociatedDataTables);
            this.HasOptional(t => t.Entity)
                .WithMany(t => t.EntityAssociatedEntities_DataTableAssociatedDataTables)
                .HasForeignKey(d => d.AssociatedEntities);

        }
    }
}
