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

    // MakeOverrides
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.28.0.0")]
    public class MakeOverrideConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<MakeOverride>
    {
        public MakeOverrideConfiguration()
            : this("dbo")
        {
        }

        public MakeOverrideConfiguration(string schema)
        {
            ToTable("MakeOverrides", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"Id").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Make).HasColumnName(@"Make").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.NewMakeName).HasColumnName(@"NewMakeName").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(100);
            Property(x => x.DateCreated).HasColumnName(@"DateCreated").HasColumnType("date").IsRequired();
            Property(x => x.DateModified).HasColumnName(@"DateModified").HasColumnType("date").IsOptional();
        }
    }

}
// </auto-generated>