using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;
using WebApiDemoProject.Models;

namespace WebApiDemoProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        [HttpGet]

        public IActionResult GetAll()
        {
            AdminUserContext adminUserContext = new AdminUserContext();
            List<AdminUser> adminUsers= adminUserContext.AdminUsers.ToList();
            return Ok(adminUsers);

        }
        [HttpGet("{id}")]
        public IActionResult GetID(int id)
        {
            AdminUserContext userContext = new AdminUserContext();
            AdminUser user = userContext.AdminUsers.FirstOrDefault(x=>x.Id == id);
            if (user == null)
            {
                return NotFound("User not found");
            }

            return Ok(user);

        }

        [HttpPost]
        public IActionResult Post(AdminUser user)
        {
            AdminUserContext adminUserContext= new AdminUserContext();
           adminUserContext.AdminUsers.Add(user);
            adminUserContext.SaveChanges();

            return Ok("Added successfully");

        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            AdminUserContext db = new AdminUserContext();
            AdminUser user= db.AdminUsers.Find( id);
            
            if (user == null)
            {
                return NotFound("User not found");

            }
            db.AdminUsers.Remove(user);
            db.SaveChanges();
            return Ok("Process is successfull");
        }

        [HttpPut]
        public IActionResult Put(AdminUser user)
        {
            AdminUserContext db = new AdminUserContext();
            AdminUser entity = db.AdminUsers.FirstOrDefault(x=> x.Id == user.Id);
            entity.FirstName = user.FirstName;
            entity.Surname = user.Surname;
            entity.Email = user.Email;
            entity.Phone = user.Phone;
            entity.CreatedDate = user.CreatedDate;
            entity.IsDeleted = user.IsDeleted;
            db.SaveChanges();
            return Ok("Updated is successfull");

        }
    }
}
