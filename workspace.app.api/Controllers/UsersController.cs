using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using workspace.app.api.Data;

namespace workspace.app.api.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class UsersController : ControllerBase
    {
        private readonly WorkspaceContext _dbContext;

        public UsersController(WorkspaceContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public List<User> Get()
        {
            return _dbContext.Users.ToList();
        }
    }
}