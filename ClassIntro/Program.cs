namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Engin";
            int age = 36;

            Course course1 = new Course();
            course1.CourseName = "C#";
            course1.Instructor = "Engin Demirog";
            course1.Rating = 68;

            Course course2 = new Course();
            course2.CourseName = "Java";
            course2.Instructor = "Kerem Varış";
            course2.Rating = 64;

            Course course3 = new Course();
            course3.CourseName = "Python";
            course3.Instructor = "Berkay Bilgin";
            course3.Rating = 80;

            Course[] courses = new Course[] { course1, course2, course3 };
            foreach (var course in courses)
            {
                Console.WriteLine(course.CourseName +": "+ course.Instructor +"\nİzlenme Oranı: "+ course.Rating);
            }
        }
    }
}

class Course
{
    public string CourseName { get; set; }
    public string Instructor { get; set; }//Eğitmen
    public int Rating { get; set; }//izlenme oranı
}