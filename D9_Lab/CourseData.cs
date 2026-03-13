namespace D9_Lab.DataLayer
{
    public static class CourseData
    {
        public class Course
        {
            public int    Id          { get; set; }
            public string Name        { get; set; }
            public string Description { get; set; }
            public string Track       { get; set; }
        }

        private static int _nextId = 4;

        public static List<Course> Courses = new List<Course>
        {
            new Course { Id = 1, Name = "C# Basics",      Description = "Intro to C#",        Track = "Backend"  },
            new Course { Id = 2, Name = "HTML & CSS",      Description = "Web fundamentals",   Track = "Frontend" },
            new Course { Id = 3, Name = "ASP.NET Core",    Description = "Web API with .NET",  Track = "FullStack"},
        };

        public static void Add(Course c)
        {
            c.Id = _nextId++;
            Courses.Add(c);
        }

        public static void Update(Course updated)
        {
            var c = Courses.Find(x => x.Id == updated.Id);
            if (c == null) return;
            c.Name        = updated.Name;
            c.Description = updated.Description;
            c.Track       = updated.Track;
        }

        public static void Delete(int id) => Courses.RemoveAll(x => x.Id == id);

        public static List<Course> GetByTrack(string track) =>
            Courses.FindAll(c => c.Track.Equals(track, StringComparison.OrdinalIgnoreCase));
    }
}
