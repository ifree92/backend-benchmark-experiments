using Microsoft.EntityFrameworkCore;

namespace WebUsersApp.Models.Context
{
    using Domain;

    public class UserContext : DbContext
    {
        public UserContext(DbContextOptions<UserContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<Education> Educations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //(1,"Primary"),(2,"Master"),(3,"Bachelor"),(4,"Lower secondary"),(5,"Upper secondary"),(6,"Doctoral");
            modelBuilder.Entity<Education>().HasData(
                new Education { Id = 1, Name = "Primary" },
                new Education { Id = 2, Name = "Master" },
                new Education { Id = 3, Name = "Bachelor" },
                new Education { Id = 4, Name = "Lower secondary" },
                new Education { Id = 5, Name = "Upper secondary" },
                new Education { Id = 6, Name = "Doctoral" }
                );

            //(1,"Female"),(2,"Male");
            modelBuilder.Entity<Gender>().HasData(
                new Gender { Id = 1, Name = "Female" },
                new Gender { Id = 2, Name = "Male" }
                );

            modelBuilder.Entity<User>().HasData(
                new User(1, "Rubie", "Richards", 27, "r.richards@randatmail.com", 1, 1),
                new User(2, "April", "Mitchell", 23, "a.mitchell@randatmail.com", 1, 1),
                new User(3, "Thomas", "Crawford", 25, "t.crawford@randatmail.com", 1, 1),
                new User(4, "Lucy", "Wright", 26, "l.wright@randatmail.com", 1, 1),
                new User(5, "Derek", "Harper", 21, "d.harper@randatmail.com", 1, 1),
                new User(6, "Clark", "Gibson", 19, "c.gibson@randatmail.com", 1, 1),
                new User(7, "Kimberly", "Baker", 26, "k.baker@randatmail.com", 1, 1),
                new User(8, "Caroline", "Kelley", 30, "c.kelley@randatmail.com", 1, 1),
                new User(9, "Maya", "Harris", 22, "m.harris@randatmail.com", 1, 1),
                new User(10, "Kevin", "Clark", 27, "k.clark@randatmail.com", 1, 1),
                new User(11, "Roland", "Cameron", 30, "r.cameron@randatmail.com", 1, 1),
                new User(12, "Rebecca", "Williams", 27, "r.williams@randatmail.com", 1, 1),
                new User(13, "Adison", "Johnson", 19, "a.johnson@randatmail.com", 1, 1),
                new User(14, "Derek", "Moore", 20, "d.moore@randatmail.com", 1, 1),
                new User(15, "Preston", "Barnes", 23, "p.barnes@randatmail.com", 1, 1),
                new User(16, "James", "Richardson", 27, "j.richardson@randatmail.com", 1, 1),
                new User(17, "Walter", "Henderson", 24, "w.henderson@randatmail.com", 1, 1),
                new User(18, "Emily", "Morris", 21, "e.morris@randatmail.com", 1, 1),
                new User(19, "Emma", "Warren", 27, "e.warren@randatmail.com", 1, 1),
                new User(20, "Cadie", "Ellis", 24, "c.ellis@randatmail.com", 1, 1),
                new User(21, "Maximilian", "Hall", 28, "m.hall@randatmail.com", 1, 1),
                new User(22, "Alissa", "Hall", 22, "a.hall@randatmail.com", 1, 1),
                new User(23, "Vincent", "Hunt", 23, "v.hunt@randatmail.com", 1, 1),
                new User(24, "Deanna", "Thomas", 29, "d.thomas@randatmail.com", 1, 1),
                new User(25, "Vanessa", "Martin", 29, "v.martin@randatmail.com", 1, 1),
                new User(26, "Lilianna", "Kelley", 29, "l.kelley@randatmail.com", 1, 1),
                new User(27, "Roland", "Alexander", 26, "r.alexander@randatmail.com", 1, 1),
                new User(28, "Aiden", "Johnson", 22, "a.johnson@randatmail.com", 1, 1),
                new User(29, "Florrie", "Spencer", 27, "f.spencer@randatmail.com", 1, 1),
                new User(30, "David", "Crawford", 30, "d.crawford@randatmail.com", 1, 1),
                new User(31, "Max", "Elliott", 28, "m.elliott@randatmail.com", 1, 1),
                new User(32, "Chloe", "Lloyd", 21, "c.lloyd@randatmail.com", 1, 1),
                new User(33, "Adam", "Dixon", 26, "a.dixon@randatmail.com", 1, 1),
                new User(34, "Byron", "Russell", 20, "b.russell@randatmail.com", 1, 1),
                new User(35, "Kelsey", "Cunningham", 27, "k.cunningham@randatmail.com", 1, 1),
                new User(36, "Garry", "Johnson", 25, "g.johnson@randatmail.com", 1, 1),
                new User(37, "Alina", "Davis", 22, "a.davis@randatmail.com", 1, 1),
                new User(38, "Frederick", "Phillips", 23, "f.phillips@randatmail.com", 1, 1),
                new User(39, "Abigail", "Barnes", 21, "a.barnes@randatmail.com", 1, 1),
                new User(40, "John", "Farrell", 29, "j.farrell@randatmail.com", 1, 1),
                new User(41, "Aldus", "Grant", 30, "a.grant@randatmail.com", 1, 1),
                new User(42, "Roland", "Armstrong", 24, "r.armstrong@randatmail.com", 1, 1),
                new User(43, "Dexter", "Adams", 20, "d.adams@randatmail.com", 1, 1),
                new User(44, "Kate", "Watson", 25, "k.watson@randatmail.com", 1, 1),
                new User(45, "Julia", "Hall", 18, "j.hall@randatmail.com", 1, 1),
                new User(46, "Steven", "Jones", 27, "s.jones@randatmail.com", 1, 1),
                new User(47, "Aston", "Morris", 21, "a.morris@randatmail.com", 1, 1),
                new User(48, "Penelope", "Alexander", 29, "p.alexander@randatmail.com", 1, 1),
                new User(49, "Dominik", "Jones", 19, "d.jones@randatmail.com", 1, 1),
                new User(50, "Martin", "Williams", 28, "m.williams@randatmail.com", 1, 1),
                new User(51, "Freddie", "Carroll", 27, "f.carroll@randatmail.com", 1, 1),
                new User(52, "Chelsea", "Moore", 25, "c.moore@randatmail.com", 1, 1),
                new User(53, "Oscar", "Warren", 23, "o.warren@randatmail.com", 1, 1),
                new User(54, "Alford", "Dixon", 25, "a.dixon@randatmail.com", 1, 1),
                new User(55, "Henry", "Roberts", 25, "h.roberts@randatmail.com", 1, 1),
                new User(56, "Lily", "Russell", 27, "l.russell@randatmail.com", 1, 1),
                new User(57, "Nicole", "Murray", 25, "n.murray@randatmail.com", 1, 1),
                new User(58, "Justin", "Riley", 19, "j.riley@randatmail.com", 1, 1),
                new User(59, "Henry", "Evans", 20, "h.evans@randatmail.com", 1, 1),
                new User(60, "Preston", "Cole", 21, "p.cole@randatmail.com", 1, 1),
                new User(61, "Ellia", "Hall", 30, "e.hall@randatmail.com", 1, 1),
                new User(62, "Oscar", "Taylor", 23, "o.taylor@randatmail.com", 1, 1),
                new User(63, "Tess", "Cunningham", 24, "t.cunningham@randatmail.com", 1, 1),
                new User(64, "Reid", "Williams", 22, "r.williams@randatmail.com", 1, 1),
                new User(65, "Alexander", "Murphy", 28, "a.murphy@randatmail.com", 1, 1),
                new User(66, "Emma", "Cole", 26, "e.cole@randatmail.com", 1, 1),
                new User(67, "Joyce", "Barrett", 20, "j.barrett@randatmail.com", 1, 1),
                new User(68, "Freddie", "Stewart", 21, "f.stewart@randatmail.com", 1, 1),
                new User(69, "Ryan", "Johnson", 27, "r.johnson@randatmail.com", 1, 1),
                new User(70, "Owen", "Murphy", 30, "o.murphy@randatmail.com", 1, 1),
                new User(71, "Dale", "Richardson", 28, "d.richardson@randatmail.com", 1, 1),
                new User(72, "Richard", "Harrison", 18, "r.harrison@randatmail.com", 1, 1),
                new User(73, "Isabella", "Scott", 22, "i.scott@randatmail.com", 1, 1),
                new User(74, "Adam", "Ross", 23, "a.ross@randatmail.com", 1, 1),
                new User(75, "Sienna", "Casey", 23, "s.casey@randatmail.com", 1, 1),
                new User(76, "Maddie", "Turner", 28, "m.turner@randatmail.com", 1, 1),
                new User(77, "Julian", "Spencer", 23, "j.spencer@randatmail.com", 1, 1),
                new User(78, "Isabella", "Perry", 30, "i.perry@randatmail.com", 1, 1),
                new User(79, "Elian", "Ferguson", 19, "e.ferguson@randatmail.com", 1, 1),
                new User(80, "Jordan", "Bailey", 25, "j.bailey@randatmail.com", 1, 1),
                new User(81, "Maximilian", "Kelly", 26, "m.kelly@randatmail.com", 1, 1),
                new User(82, "Brad", "Grant", 24, "b.grant@randatmail.com", 1, 1),
                new User(83, "Martin", "Scott", 23, "m.scott@randatmail.com", 1, 1),
                new User(84, "Michelle", "Thompson", 22, "m.thompson@randatmail.com", 1, 1),
                new User(85, "Vanessa", "Nelson", 22, "v.nelson@randatmail.com", 1, 1),
                new User(86, "Alan", "Casey", 18, "a.casey@randatmail.com", 1, 1),
                new User(87, "Dale", "Henderson", 29, "d.henderson@randatmail.com", 1, 1),
                new User(88, "Amanda", "Reed", 21, "a.reed@randatmail.com", 1, 1),
                new User(89, "Vivian", "Grant", 24, "v.grant@randatmail.com", 1, 1),
                new User(90, "Chester", "Nelson", 18, "c.nelson@randatmail.com", 1, 1),
                new User(91, "Oscar", "Martin", 27, "o.martin@randatmail.com", 1, 1),
                new User(92, "Wilson", "Howard", 22, "w.howard@randatmail.com", 1, 1),
                new User(93, "Grace", "Perkins", 27, "g.perkins@randatmail.com", 1, 1),
                new User(94, "Tess", "Wilson", 21, "t.wilson@randatmail.com", 1, 1),
                new User(95, "Miller", "Morrison", 22, "m.morrison@randatmail.com", 1, 1),
                new User(96, "Adelaide", "Ryan", 30, "a.ryan@randatmail.com", 1, 1),
                new User(97, "Edward", "Myers", 18, "e.myers@randatmail.com", 1, 1),
                new User(98, "Lenny", "Richards", 22, "l.richards@randatmail.com", 1, 1),
                new User(99, "Adrianna", "Cameron", 21, "a.cameron@randatmail.com", 1, 1),
                new User(100, "Alan", "Cole", 24, "a.cole@randatmail.com", 1, 1)
                );
        }
    }
}
