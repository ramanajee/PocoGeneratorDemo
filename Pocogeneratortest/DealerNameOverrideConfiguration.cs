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


namespace Pocogeneratortest
{

    // DealerNameOverrides
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.28.0.0")]
    public class DealerNameOverrideConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<DealerNameOverride>
    {
        public DealerNameOverrideConfiguration()
            : this("dbo")
        {
        }

        public DealerNameOverrideConfiguration(string schema)
        {
            ToTable("DealerNameOverrides", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"Id").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.DealerId).HasColumnName(@"DealerId").HasColumnType("int").IsRequired();
            Property(x => x.DealerNameInFeed).HasColumnName(@"DealerNameInFeed").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(500);
        }
    }

}
// </auto-generated>
