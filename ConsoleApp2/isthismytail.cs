namespace ConsoleApp2
{
    internal class isthismytail
    {
        public static bool CorrectTail(string body, string tail)
        {
            return body.Substring(body.Length - tail.Length) == tail;
        }
    }
}
    