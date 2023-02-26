using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorApp2.Server.Data
{
    public partial class BlazorEntities : DbContext
    {
        public BlazorEntities(DbContextOptions<BlazorEntities> options) : base(options)
        {
            
        }

        public DbSet<Member> Members { get; set; }
    }

    [Table("Members")]
    public partial class Member
    {
        [Column("Id"), Required, MaxLength(36), Key]
        public Guid MemberId { get; set; }

        [Column("Name"), Required, MaxLength(50)]
        public string? MemberName { get; set; }

        [Column("Gender"), Required, MaxLength(10)]
        public string? MemberGender { get; set; }

    }
}
