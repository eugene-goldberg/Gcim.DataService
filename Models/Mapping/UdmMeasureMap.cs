using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SelfHostedWebApiDataService.Models.Mapping
{
    public class UdmMeasureMap : EntityTypeConfiguration<UdmMeasure>
    {
        public UdmMeasureMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            // Table & Column Mappings
            this.ToTable("UdmMeasures");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Measure).HasColumnName("Measure");
            this.Property(t => t.EtlOrSsas).HasColumnName("EtlOrSsas");
            this.Property(t => t.SsasCalculation).HasColumnName("SsasCalculation");
            this.Property(t => t.DataMartDatabaseName).HasColumnName("DataMartDatabaseName");
            this.Property(t => t.FactTableName).HasColumnName("FactTableName");
            this.Property(t => t.DetailTableName).HasColumnName("DetailTableName");
        }
    }
}
