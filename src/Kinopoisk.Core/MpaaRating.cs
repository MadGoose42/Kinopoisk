using System.Runtime.Serialization;

namespace Kinopoisk.Core
{
    public enum MpaaRating
    {
        [EnumMember(Value = "G")]
        G,
        [EnumMember(Value = "PG")]
        PG,
        [EnumMember(Value = "PG13")]
        PG13,
        [EnumMember(Value = "R")]
        R,
        [EnumMember(Value = "NC17")]
        NC17
    }
}