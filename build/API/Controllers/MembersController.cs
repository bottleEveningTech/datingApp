using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    public class MembersController(AppDbContext context) : BaseApiController
    {
        //Synchronous Task
        // [HttpGet]
        // public ActionResult<IReadOnlyList<AppUser>> GetMembers()
        // {
        //     var members = context.Users.ToList();
        //     return members;
        // }

        // [HttpGet("{id}")] //localhost:50001/api/members/bob-id
        // public ActionResult<AppUser> GetMember(string id)
        // {
        //     var member = context.Users.Find(id);
        //     if (member == null)
        //     {
        //         return NotFound();
        //     }
        //     return member;
        // }

        [HttpGet]
        public async Task<ActionResult<IReadOnlyList<AppUser>>> GetMembersAsync()
        {
            var members = await context.Users.ToListAsync();
            return members;
        }

        [HttpGet("{id}")] //localhost:50001/api/members/bob-id
        public async Task<ActionResult<AppUser>> GetMemberAsync(string id)
        {
            var member = await context.Users.FindAsync(id);
            if (member == null)
            {
                return NotFound();
            }
            return member;
        }

    }
}
