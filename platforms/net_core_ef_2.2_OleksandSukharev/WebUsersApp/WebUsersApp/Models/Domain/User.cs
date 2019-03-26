namespace WebUsersApp.Models.Domain
{
    public class User
    {
        public User() { }

        public User(int id, string firstName, string lastName, int age, string email, int? genderId = null, int? educationId = null)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Age = age;
            GenderId = genderId;
            EducationId = educationId;
        }

        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public int Age { get; set; }

        public int? GenderId { get; set; }

        public Gender Gender { get; set; }

        public int? EducationId { get; set; }

        public Education Education { get; set; }
    }
}
