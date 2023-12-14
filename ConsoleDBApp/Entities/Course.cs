using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleDBApp.Entities;

public class Course : BaseItem
{
    public string Name { get; set; }
    [ForeignKey("CoursesGroups")]
    public int CourseGroupID { get; set; }
    public virtual CourseGroup CourseGroup { get; set; }
    [ForeignKey("CoursesLevel")]
    public int CourseLevelID { get; set; }


    public virtual CourseLevel CourseLevel { get; set; }

    public int CourseDuration { get; set; }

    public override string ToString()
    {
        return String.Format("Id: {0}\t| Название: {1}\t| Направление: {2}\t| Уровень: {3}\t| Длительность: {4} мес.", ID, Name, CourseGroup.Name, CourseLevel.Name, CourseDuration);
    }
}