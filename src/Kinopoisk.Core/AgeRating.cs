using System.Runtime.Serialization;

namespace Kinopoisk.Core
{
    public enum AgeRating
    {
        [EnumMember(Value = "age0")]
        Age0,
        [EnumMember(Value = "age6")]
        Age6,
        [EnumMember(Value = "age12")]
        Age12,
        [EnumMember(Value = "age16")]
        Age16,
        [EnumMember(Value = "age18")]
        Age18
    }
}
