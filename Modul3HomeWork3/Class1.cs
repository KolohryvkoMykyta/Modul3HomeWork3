using System.Reflection.Metadata.Ecma335;

namespace Modul3HomeWork3
{
    public class Class1
    {
        public Action<bool> ShowHandler { get; set; } = Program.Show;

        public int Pow(int x, int y) => x * y;
    }
}
