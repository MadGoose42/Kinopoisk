using System.Runtime.Serialization;

namespace Kinopoisk.Core
{
    public enum ProductionStatus
    {
        [EnumMember(Value = "FILMING")]
        FILMING,
        [EnumMember(Value = "PRE_PRODUCTION")]
        PRE_PRODUCTION,
        [EnumMember(Value = "COMPLETED")]
        COMPLETED,
        [EnumMember(Value = "ANNOUNCED")]
        ANNOUNCED,
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,
        [EnumMember(Value = "POST_PRODUCTION")]
        POST_PRODUCTION
    }
}