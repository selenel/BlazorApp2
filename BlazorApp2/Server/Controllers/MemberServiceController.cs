using BlazorApp2.Server.Data;
using BlazorApp2.Shared;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp2.Server.Controllers
{
    [ApiController]
    [Route("MemberService")]
    public class MemberServiceController : ControllerBase
    {
        private IDbContextFactory<BlazorEntities> dbFactory { get; set; }

        public MemberServiceController(IDbContextFactory<BlazorEntities> dbFactory)
        {
            this.dbFactory = dbFactory;
        }

        [HttpGet("GetMembers")]
        public async Task<List<MemberOverview>> GetAuthors()
        {
            var result = new List<MemberOverview>();

            using (var pubs = dbFactory.CreateDbContext())
            {
                var query = from a in pubs.Members
                            select new MemberOverview()
                            {
                                MemberId = a.MemberId,
                                MemberName = a.MemberName,
                                MemberGender = a.MemberGender,
                            };
                result = await query.ToListAsync();
            }

            return result;
        }

    }

}
