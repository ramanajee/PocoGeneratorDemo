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


namespace Pocogeneratortest.Entities
{

    // DealerGeoTowns
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.28.0.0")]
    public class DealerGeoTown
    {
        public int Id { get; set; } // Id (Primary key)
        public int DealerId { get; set; } // DealerId
        public string GeoTown { get; set; } // GeoTown (length: 500)
        public System.DateTime DateCreated { get; set; } // DateCreated
        public double Latitude { get; set; } // Latitude
        public double Longitude { get; set; } // Longitude
        public string State { get; set; } // State (length: 100)
    }

}
// </auto-generated>
