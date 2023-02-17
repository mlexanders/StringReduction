namespace StringReduction
{
    public class Reduction
    {
        public static string GetReductionString(string sequences)
        {
            var result = string.Empty;
            var i = 0;

            while (i < sequences.Length)
            {
                if (!char.IsUpper(sequences[i])) throw new NotUpperCase($"{sequences[i]} is not upper case");

                var count = 1;
                result += sequences[i];

                while (i < sequences.Length - 1)
                {
                    if (!sequences[i].Equals(sequences[i + 1])) break;
                    i++;
                    count++;
                }
                if (count > 1) result += count.ToString();
                i++;
            }
            return result;
        }
    }
}