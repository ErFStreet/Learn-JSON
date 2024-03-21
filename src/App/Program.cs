namespace App;

public static class Program
{
    static void Main(string[] args)
    {
        // String To Json => You can replace INT,LONG,Bool,.....

        var message = "Hello World";

        var messageResultToJson = message.ConvertToJson();

        Console.WriteLine(value: messageResultToJson);

        // Object To Json

        var obj = new
        {
            FName = "Erfan",
            LName = "Edalati",
            Age = 15,
            IsActived = true,
        };

        var objResultToJson = obj.ConvertToJson();

        Console.WriteLine(value: objResultToJson);
    }
}