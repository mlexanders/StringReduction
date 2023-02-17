namespace StringReduction
{
    [Serializable]
    public class NotUpperCase : Exception
    {
        public NotUpperCase()
        {
        }

        public NotUpperCase(string? message) : base(message)
        {
        }
    }
}