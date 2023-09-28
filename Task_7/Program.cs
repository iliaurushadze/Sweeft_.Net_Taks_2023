namespace Task_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var context = new SchoolContext())
            {
                var teachersTeachingGiorgi = context.Teachers
                    .Where(teacher => teacher.Pupils.Any(pupil => pupil.FirstName == "Giorgi"))
                    .ToList();

                foreach (var teacher in teachersTeachingGiorgi)
                {
                    Console.WriteLine($"{teacher.FirstName} {teacher.LastName} teaches pupil named Giorgi.");
                }
            }
        }
    }
}