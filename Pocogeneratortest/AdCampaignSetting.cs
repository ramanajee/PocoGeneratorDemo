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

    // AdCampaignSettings
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.28.0.0")]
    public class AdCampaignSetting
    {
        public int Id { get; set; } // Id (Primary key)
        public int AdCampaignId { get; set; } // AdCampaignId
        public int? DealerId { get; set; } // DealerId
        public string Platform { get; set; } // Platform (length: 50)
        public string Type { get; set; } // Type (length: 50)
        public System.DateTime CreateDate { get; set; } // CreateDate
        public System.DateTime? ModifiedDate { get; set; } // ModifiedDate
    }

}
// </auto-generated>
