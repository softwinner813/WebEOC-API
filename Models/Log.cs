using System;
using System.Collections.Generic;

namespace WebEOC.Models
{
    public partial class Log
    {
        public long Id { get; set; }
        public string? DeviceName { get; set; }
        public string? Description { get; set; }
        public DateTime? CreatedAt { get; set; }
        public byte[]? UpdatedAt { get; set; }
    }
}
