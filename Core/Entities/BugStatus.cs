using System.Runtime.Serialization;

namespace Core.Entities
{
    public enum BugStatus
    {
        [EnumMember(Value="New")]
        New,
        [EnumMember(Value="Active")]
        Active,
        [EnumMember(Value="Blocked")]
        Blocked,
        [EnumMember(Value="Close")]
        Close
    }
}