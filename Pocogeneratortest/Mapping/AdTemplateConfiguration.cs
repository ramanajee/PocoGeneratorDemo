// <auto-generated>
// ReSharper disable ConvertPropertyToExpressionBody
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable InconsistentNaming
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable RedundantNameQualifier
// ReSharper disable RedundantOverridenMember
// ReSharper disable UseNameofExpression
// TargetFrameworkVersion = 4.5
#pragma warning disable 1591    //  Ignore "Missing XML Comment" warning


namespace Pocogeneratortest.Mapping
{
    using Pocogeneratortest.Entities;

    // AdTemplates
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.28.0.0")]
    public class AdTemplateConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<AdTemplate>
    {
        public AdTemplateConfiguration()
            : this("dbo")
        {
        }

        public AdTemplateConfiguration(string schema)
        {
            ToTable("AdTemplates", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"Id").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.DealerId).HasColumnName(@"DealerId").HasColumnType("bigint").IsRequired();
            Property(x => x.AdNumber).HasColumnName(@"AdNumber").HasColumnType("int").IsOptional();
            Property(x => x.Template).HasColumnName(@"Template").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.DateCreated).HasColumnName(@"DateCreated").HasColumnType("date").IsOptional();
            Property(x => x.AdCampaignId).HasColumnName(@"AdCampaignId").HasColumnType("bigint").IsOptional();
        }
    }

}
// </auto-generated>
