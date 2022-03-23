using Newtonsoft.Json;

namespace School_Program;

public struct SchoolSubject
{
    public string Name { get; }
    public string TeacherName { get; }

    public TimeOnly StartTime { get; }
    public TimeOnly EndTime { get; }

    public SchoolSubject(string name, string teacherName, int minutesClass, params int[] startTime)
    {
        Name = name;
        TeacherName = teacherName;
        StartTime = new TimeOnly(startTime[0], startTime[1]);
        EndTime = StartTime.AddMinutes(minutesClass);
    }

    public SchoolSubject(string name, string teacherName, params int[] startTime)
    {
        Name = name;
        TeacherName = teacherName;
        StartTime = new TimeOnly(startTime[0], startTime[1]);
        EndTime = StartTime.AddMinutes(40);
    }
}

public class School
{
    private readonly List<SchoolSubject> _schoolSubjects = new();
    private Dictionary<string, string> _teachers = new();


    public School()
    {
        _schoolSubjects.Add(new SchoolSubject(
            "Math",
            "Mr. Smith", 40, 8, 5
        ));

        AddTeachers();
        ShowProgram();
    }

    public void ShowTeachers()
    {
        Console.WriteLine(new string('-', 50));

        foreach (var teacher in _teachers)
        {
            Console.WriteLine("");
            Console.WriteLine($"{teacher.Key} - {teacher.Value}");
            Console.WriteLine("");
        }

        Console.WriteLine(new string('-', 50));
    }

    public void ShowProgram()
    {
        string[] monday =
        {
            "История",
            "Английски език",
            "Български език",
            "Информационни технологии",
            "Английски език",
            "Математика",
            "Мобилни приложения"
        };

        string[] tuesday =
        {
            "Български език",
            "Български език",
            "Философия",
            "Математика",
            "ФВС",
            "Немски език",
            "География"
        };

        string[] wednesday =
        {
            "Английски език",
            "Химия",
            "Математика",
            "ФВС",
            "Мобилни приложения",
            "Мобилни приложения",
            "Час на класа"
        };

        string[] thursday =
        {
            "Биология",
            "Английски език",
            "Немски език",
            "Графични продукти",
            "Физика",
            "История",
            "Химия"
        };

        string[] friday =
        {
            "Увод в ООП",
            "Увод в ООП",
            "Увод в ООП",
            "Английски език",
            "Английски език"
        };


        Table.PrintLine();
        Table.PrintRow("Час", "Понеделник", "Вторник", "Сряда", "Четвъртък", "Петък");
        Table.PrintLine();

        #region 1

            Table.PrintRow("1", monday[0], tuesday[0], wednesday[0], thursday[0], friday[0]);
            Table.PrintRow("", _teachers[monday[0]], _teachers[tuesday[0]], _teachers[wednesday[0]], _teachers[thursday[0]], _teachers[friday[0]]);
            Table.PrintRow("", "", "", "", "", "");

        #endregion

        #region 2

            Table.PrintRow("2", monday[1], tuesday[1], wednesday[1], thursday[1], friday[0]);
            Table.PrintRow("", _teachers[monday[1]], _teachers[tuesday[1]], _teachers[wednesday[1]], _teachers[thursday[1]], _teachers[friday[0]]);
            Table.PrintRow("", "", "", "", "", "");

        #endregion

        #region 3

            Table.PrintRow("3", monday[2], tuesday[2], wednesday[2], thursday[2], friday[2]);
            Table.PrintRow("", _teachers[monday[2]], _teachers[tuesday[2]], _teachers[wednesday[2]], _teachers[thursday[2]], _teachers[friday[2]]);
            Table.PrintRow("", "", "", "", "", "");

        #endregion

        #region 4

            Table.PrintRow("4", monday[3], tuesday[3], wednesday[3], thursday[3], friday[3]);
            Table.PrintRow("", _teachers[monday[3]], _teachers[tuesday[3]], _teachers[wednesday[3]], _teachers[thursday[3]], _teachers[friday[3]]);
            Table.PrintRow("", "", "", "", "", "");

        #endregion

        #region 5

            Table.PrintRow("5", monday[4], tuesday[4], wednesday[4], thursday[4], friday[4]);
            Table.PrintRow("", _teachers[monday[4]], _teachers[tuesday[4]], _teachers[wednesday[4]], _teachers[thursday[4]], _teachers[friday[4]]);
            Table.PrintRow("", "", "", "", "", "");

        #endregion

        #region 6

            Table.PrintRow("6", monday[5], tuesday[5], wednesday[5], thursday[5], "");
            Table.PrintRow("", _teachers[monday[5]], _teachers[tuesday[5]], _teachers[wednesday[5]], _teachers[thursday[5]], "");
            Table.PrintRow("", "", "", "", "", "");

        #endregion

        #region 7

            Table.PrintRow("7", monday[6], tuesday[6], wednesday[6], thursday[6], "");
            Table.PrintRow("", _teachers[monday[6]], _teachers[tuesday[6]], _teachers[wednesday[6]], _teachers[thursday[6]], "");
            Table.PrintRow("", "", "", "", "", "");

        #endregion

        Table.PrintLine();
    }

    private void AddTeachers()
    {
        using (var r = new StreamReader(@"D:\Dev\C#\School Program\School Program\teachers.json"))
        {
            var json = r.ReadToEnd();
            _teachers = JsonConvert.DeserializeObject<Dictionary<string, string>>(json);
        }
        
        _teachers.Add("", "invalid");
    }
}