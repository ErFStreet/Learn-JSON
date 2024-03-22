namespace App.Infrastructure;

public static class JsonHelper
{
    public static string ConvertToJson(this object obj)
    {
        var result =
            JsonSerializer.Serialize(value: obj);

        return result;
    }
}
