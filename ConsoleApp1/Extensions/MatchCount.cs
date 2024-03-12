namespace Task1.Extensions
{
    internal static partial class Extension
    {
        internal static int MatchCount(this string input, string matchString)
        {
            int count = default;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == matchString[0])
                {
                    if (input.Substring(i, matchString.Length).Equals(matchString)) count++;
                }
            }
            return count;
        }
    }
}
