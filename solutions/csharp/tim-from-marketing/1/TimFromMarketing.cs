static class Badge
{
    public static string Print(int? id, string name, string? department)
    {
        string response;

        if (id == null && department == null)
        {
            response = $"{name} - OWNER"; 
        }
        else if (id == null)
        {
            response = $"{name} - {department?.ToUpper() ?? "OWNER"}";
        }
        else
        {
            response = $"[{id}] - {name} - {department?.ToUpper() ?? "OWNER"}";
        }

        return response;
    }
}
