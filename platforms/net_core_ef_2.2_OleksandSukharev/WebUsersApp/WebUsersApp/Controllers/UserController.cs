using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebUsersApp.Controllers
{
    using Models.Context;
    using Models.Domain;

    public class UserController : Controller
    {
        private UserContext _userContext;

        private static List<User> _users = new List<User>
        {
            new User() {FirstName ="Lola", LastName="Samara", Age=27, Email="lola.samara27@example.com", EducationId = 0, GenderId = 0, Education = new Education{Id = 0, Name = "High"}, Gender = new Gender{Id=0,Name = "Female"}},
            new User() {FirstName ="Lola", LastName="Samara", Age=27, Email="lola.samara27@example.com", EducationId = 0, GenderId = 0, Education = new Education{Id = 0, Name = "High"}, Gender = new Gender{Id=0,Name = "Female"}},
            new User() {FirstName ="Lola", LastName="Samara", Age=27, Email="lola.samara27@example.com", EducationId = 0, GenderId = 0, Education = new Education{Id = 0, Name = "High"}, Gender = new Gender{Id=0,Name = "Female"}},
            new User() {FirstName ="Lola", LastName="Samara", Age=27, Email="lola.samara27@example.com", EducationId = 0, GenderId = 0, Education = new Education{Id = 0, Name = "High"}, Gender = new Gender{Id=0,Name = "Female"}},
            new User() {FirstName ="Lola", LastName="Samara", Age=27, Email="lola.samara27@example.com", EducationId = 0, GenderId = 0, Education = new Education{Id = 0, Name = "High"}, Gender = new Gender{Id=0,Name = "Female"}},
            new User() {FirstName ="Lola", LastName="Samara", Age=27, Email="lola.samara27@example.com", EducationId = 0, GenderId = 0, Education = new Education{Id = 0, Name = "High"}, Gender = new Gender{Id=0,Name = "Female"}},
            new User() {FirstName ="Lola", LastName="Samara", Age=27, Email="lola.samara27@example.com", EducationId = 0, GenderId = 0, Education = new Education{Id = 0, Name = "High"}, Gender = new Gender{Id=0,Name = "Female"}},
            new User() {FirstName ="Lola", LastName="Samara", Age=27, Email="lola.samara27@example.com", EducationId = 0, GenderId = 0, Education = new Education{Id = 0, Name = "High"}, Gender = new Gender{Id=0,Name = "Female"}},
            new User() {FirstName ="Lola", LastName="Samara", Age=27, Email="lola.samara27@example.com", EducationId = 0, GenderId = 0, Education = new Education{Id = 0, Name = "High"}, Gender = new Gender{Id=0,Name = "Female"}},
            new User() {FirstName ="Lola", LastName="Samara", Age=27, Email="lola.samara27@example.com", EducationId = 0, GenderId = 0, Education = new Education{Id = 0, Name = "High"}, Gender = new Gender{Id=0,Name = "Female"}},
            new User() {FirstName ="Lola", LastName="Samara", Age=27, Email="lola.samara27@example.com", EducationId = 0, GenderId = 0, Education = new Education{Id = 0, Name = "High"}, Gender = new Gender{Id=0,Name = "Female"}},
            new User() {FirstName ="Lola", LastName="Samara", Age=27, Email="lola.samara27@example.com", EducationId = 0, GenderId = 0, Education = new Education{Id = 0, Name = "High"}, Gender = new Gender{Id=0,Name = "Female"}},
            new User() {FirstName ="Lola", LastName="Samara", Age=27, Email="lola.samara27@example.com", EducationId = 0, GenderId = 0, Education = new Education{Id = 0, Name = "High"}, Gender = new Gender{Id=0,Name = "Female"}},
        };

        public UserController(UserContext userContext)
        {
            _userContext = userContext;
        }

        [HttpGet]
        [Route("empty")]
        public IActionResult GetEmpty() => Ok();

        [HttpGet]
        [Route("users")]
        public IActionResult GetStaticUser() => View("UsersStatic");

        [HttpGet]
        [Route("mock-users")]
        public IActionResult GetMockUserAsync() => View("Users", _users);

        [HttpGet]
        [Route("db-users")]
        public async Task<IActionResult> GetDbUserAsync() => View("Users", await _userContext.Users.ToListAsync());
    }
}
