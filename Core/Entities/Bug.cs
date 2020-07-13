using System;

namespace Core.Entities
{
    public class Bug : BaseEntity
    {
        public string BugTitle { get; set; }
        public string BugDescription { get; set; }
        public string ToolName { get; set; }
        public string Version { get; set; }
        public DateTime BugCreatedDate { get; set; }
        public BugStatus Status { get; set; } = BugStatus.New;
    }
}