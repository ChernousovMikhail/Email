using System;
using Microsoft.EntityFrameworkCore;
namespace Email.Core.Models
{
    public class EmailModel : BaseDbo
    {
        public Guid EmailId { get; set; }
        public string? From { get; set; }
        public string? Subject { get; set; }
        public string? Status { get; set; }
        public string? Text { get; set; }
    }
}
