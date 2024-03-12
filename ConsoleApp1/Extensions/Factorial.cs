namespace Task1.Extensions
{
    internal static partial class Extension
    {
        internal static int Factorial(this int num)
        {
            int result = num;
            for (int i = 1; i < num; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}
