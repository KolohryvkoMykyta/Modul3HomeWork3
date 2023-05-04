namespace Modul3HomeWork3
{
    public class Class2
    {
        private int _powResult;

        public Func<int, bool> Calc(Func<int, int, int> pow, int value1, int value2)
        {
            _powResult = pow(value1, value2);

            return Result;
        }

        public bool Result(int value)
        {
            return _powResult % value == 0;
        }
    }
}
