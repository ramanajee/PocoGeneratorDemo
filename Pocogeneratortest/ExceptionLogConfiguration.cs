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

    // ExceptionLog
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.28.0.0")]
    public class ExceptionLogConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<ExceptionLog>
    {
        public ExceptionLogConfiguration()
            : this("dbo")
        {
        }

        public ExceptionLogConfiguration(string schema)
        {
            ToTable("ExceptionLog", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"Id").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Message).HasColumnName(@"Message").HasColumnType("varchar(max)").IsOptional().IsUnicode(false);
            Property(x => x.ExceptionType).HasColumnName(@"ExceptionType").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(1000);
            Property(x => x.ExceptionSource).HasColumnName(@"ExceptionSource").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.Url).HasColumnName(@"URL").HasColumnType("varchar(max)").IsOptional().IsUnicode(false);
            Property(x => x.Date).HasColumnName(@"Date").HasColumnType("datetime").IsOptional();
            Property(x => x.Comments).HasColumnName(@"Comments").HasColumnType("varchar(max)").IsOptional().IsUnicode(false);
        }
    }

}
// </auto-generated>
