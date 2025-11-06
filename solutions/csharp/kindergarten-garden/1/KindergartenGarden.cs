public enum Plant
{
    Violets,
    Radishes,
    Clover,
    Grass
}

public enum Student
{
    Alice,
    Bob,
    Charlie,
    David,
    Eve,
    Fred,
    Ginny,
    Harriet,
    Ileana,
    Joseph,
    Kincaid,
    Larry
}

public class KindergartenGarden
{
    private readonly string[] gardenRows;
    private static readonly Student[] students = (Student[])Enum.GetValues(typeof(Student));
    
    public KindergartenGarden(string diagram)
    {
        gardenRows = diagram.Split('\n');
    }

    public IEnumerable<Plant> Plants(string student)
    {
        int studentIndex = Array.IndexOf(students, (Student)Enum.Parse(typeof(Student), student));
        int start = studentIndex * 2;
        var plants = new List<Plant>();

        foreach (var row in gardenRows)
        {
            plants.Add(MapPlant(row[start]));
            plants.Add(MapPlant(row[start+1]));
        }
        return plants;
    }

    public Plant MapPlant(char c)
    {
        return c switch
        {
            'V' => Plant.Violets,
            'R' => Plant.Radishes,
            'C' => Plant.Clover,
            'G' => Plant.Grass,
            _ => throw new ArgumentException($"Invalid plant code: {c}")
        };
    }
}