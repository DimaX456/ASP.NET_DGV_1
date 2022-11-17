using ASP_NET_DGV_1.Models;
using Microsoft.AspNetCore.Mvc;
using ASP_NET_DGV_1.Abiturient;
using Microsoft.AspNetCore.Http;

namespace ASP_NET_DGV_1.Controllers
{
 
        [Route("A_C/[controller]")]
        [ApiController]
        public class UsersController : ControllerBase
        {
            private static readonly IList<Users> Users = new List<Users>();
            [HttpGet]
            public IEnumerable<Users> Get()
            {
                return Users;
            }

            [HttpGet(template: "stats")]
            public UsersStaticsResponseModel GetStatistic()
            {
                var result = new UsersStaticsResponseModel
                {
                    Count = Users.Count,
                    AvgRate = Users.Average(x => x.AvgRate),
                };
                return result;
            }
            [HttpGet(template: "{id}")]
            public Users GetUser(Guid id)
            {
                return Users.FirstOrDefault(x => x.Id == id);
            }
            [HttpPost]
            public Users Add(Users model)
            {
                var users = new Users
                {
                    Id = Guid.NewGuid(),
                    FullName = model.FullName,
                    Gender = model.Gender,
                };
                Users.Add(users);
                return users;
            }
            [HttpPost(template: "{id:guid}")]
            public Users Update([FromRoute] Guid id, [FromBody] Users model)
            {
                var targetUser = Users.FirstOrDefault(x => x.Id == id);
                if (targetUser != null)
                {
                    targetUser.FullName = model.FullName;
                    targetUser.Gender = model.Gender;
                }
                return targetUser;
            }

            [HttpDelete(template: "{id:guid}")]
            public bool Remove(Guid id)
            {
                var targetUser = Users.FirstOrDefault(x => x.Id == id);
                if (targetUser != null)
                {
                    return Users.Remove(targetUser);
                }
                return false;
            }
        }
    }


