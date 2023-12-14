namespace ConsoleDBApp.Entities;

public class CourseGroup : BaseItem
{
    public string Name  { get; set; }

    public IList<Course> Courses { get; set; }

    public override string ToString()
    {
        return String.Format("Id: {0}\t| Название направления: {1}\t", ID, Name);
    }

}