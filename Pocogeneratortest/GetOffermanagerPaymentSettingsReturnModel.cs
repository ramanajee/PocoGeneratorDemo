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

    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.28.0.0")]
    public class GetOffermanagerPaymentSettingsReturnModel
    {
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.28.0.0")]
        public class ResultSetModel1
        {
            public System.Int32 AccountId { get; set; }
            public System.String PaymentType { get; set; }
            public System.Boolean? IsRoundUpEnabled { get; set; }
            public System.Boolean? IsPerDayOffersEnabled { get; set; }
        }
        public System.Collections.Generic.List<ResultSetModel1> ResultSet1;

    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.28.0.0")]
        public class ResultSetModel2
        {
            public System.Int32? DealerId { get; set; }
            public System.Int32? Term { get; set; }
            public System.String PaymentType { get; set; }
            public System.Int32? MinStockCount { get; set; }
        }
        public System.Collections.Generic.List<ResultSetModel2> ResultSet2;

    }

}
// </auto-generated>
