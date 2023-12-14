using ConsoleDBApp;
using ConsoleDBApp.Entities;
using Microsoft.EntityFrameworkCore;


namespace DB
{
    class Program
    {
        DBRepository<Course> _repository = new DBRepository<Course>();
        DataContext context = new DataContext();

        static void Main(string[] args)
        {
            var prog = new Program();

            prog.PrintCourses();
            prog.AddCourse();
            prog.PrintCourses(); 
        }

        public void PrintCourses()
        {
            var courses = context.Courses.Include(x => x.CourseGroup).Include(y => y.CourseLevel).OrderBy(x => x.ID).ToList();

            foreach (var item in courses)
            {
                Console.WriteLine(item.ToString());
            }
        }

        public void AddCourse()
        {
            var newItem = new Course();

            Console.WriteLine("\nДобавить новый курс");
            Console.Write("\nНазвание: "); newItem.Name = Console.ReadLine();

            var groups = context.CoursesGroups.ToList();

            Console.WriteLine("Направления: ");
            foreach (var group in groups)
            {
                Console.WriteLine(group.ToString());
            }

            Console.Write("Выберите направление: "); 
            newItem.CourseGroupID = Int32.Parse(Console.ReadLine());

            var levels = context.CoursesLevel.ToList();

            Console.WriteLine("Уровни:");
            foreach (var level in levels)
            {
                Console.WriteLine(level.ToString());
            }
            Console.Write("Выберите уровень: ");
            newItem.CourseLevelID = Int32.Parse(Console.ReadLine());

            Console.Write("\nДлительность в мес.: "); newItem.CourseDuration = Int32.Parse(Console.ReadLine());

            //Console.WriteLine(String.Format("{0} {1} {2} {3}", newItem.Name, newItem.CourseGroupID, newItem.CourseLevelID, newItem.CourseDuration));
            _repository.AddItem(newItem);
        }
    }
}