using Modul3HomeWork3;

public class Program
 {
    public static void Show(bool result)
    {
        Console.WriteLine(result);
    }

    private static void Main(string[] args)
    {
        var class1 = new Class1();
        var class2 = new Class2();
        var result = class2.Calc(class1.Pow, 12, 29);

        class1.ShowHandler(result(10000));
    }
}
