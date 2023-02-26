using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorApp2.Shared
{
    public class MemberOverview
    {
        public Guid MemberId { get; set; }
        public string? MemberName { get; set; }
        public string? MemberGender { get; set; }
    }
}
