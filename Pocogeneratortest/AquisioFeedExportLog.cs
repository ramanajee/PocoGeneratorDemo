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

    // AquisioFeedExportLogs
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.28.0.0")]
    public class AquisioFeedExportLog
    {
        public int Id { get; set; } // Id (Primary key)
        public string Url { get; set; } // URL (length: 500)
        public System.DateTime StartTime { get; set; } // StartTime
        public System.DateTime EndTime { get; set; } // EndTime
        public string TotalTime { get; set; } // TotalTime (length: 50)
        public string Status { get; set; } // Status (length: 50)
        public System.DateTime? Date { get; set; } // Date
        public string Message { get; set; } // Message
        public string FilePath { get; set; } // FilePath (length: 500)
        public string FeedType { get; set; } // FeedType (length: 50)

        public AquisioFeedExportLog()
        {
            FeedType = "Aquisio Feed";
        }
    }

}
// </auto-generated>
