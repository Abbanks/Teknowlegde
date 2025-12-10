using Teknowlegde.Data.Entity;

namespace Teknowlegde.Data
{
    public static class DataSeeder
    {
        public static void Seed(ApplicationDbContext context)
        {
            if (!context.Students.Any())
            {
                var students = new List<Student>
                {
                    new() { Name = "Abigail" },
                    new Student { Name = "Peace Elizabeth" },
                    new Student { Name = "Muhammed" },
                    new() { Name = "Adora" },
                    new() { Name = "Temidayo" },
                    new() { Name = "Elizabeth" },
                    new() { Name = "Praise" },
                };

                context.Students.AddRange(students);
                context.SaveChanges();
            }
        }
    }
}
