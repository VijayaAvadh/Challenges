using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Class1
    {
    }
    //public static int bouncingBall(double h, double bounce, double window)
    //{
    //    int result = 0;
    //    if (bounce < 0 && bounce > 1) return -1;
    //    if( h > 0 && (window < h))
    //    {
    //        var twoThridofh = (2 * h / 3) * bounce;
    //        var x = (window - bounce) * 2;
    //        result = Convert.ToInt32( x * 2);
    //    }
    //    else
    //    {
    //        result = -1;
    //    }
    //    return result;
    //}

    //public static string BestPractice_HighAndLow(string numbers)
    //{
    //    var parsed = numbers.Split().Select(int.Parse);
    //    return parsed.Max() + " " + parsed.Min();
    //}

    //public static string HighAndLow(string numbers)
    //{
    //    var numberList = numbers.Split(' ').Select(x => int.Parse(x));
    //    return $"{numberList.Max()} {numberList.Min()}";
    //    return "throw towel";
    //}

    //public static bool ValidatePin(string pin)
    //{
    //    var result = Regex.Match(pin, @"\d+").Value;
    //    return ((pin.Length == 4 || pin.Length == 6) && Equals(pin, result)) ? true : false;
    //}

    //public static string[] TowerBuilder(int nFloors)
    //{
    //    List<string> returnThis = new List<string>();
    //    switch (nFloors)
    //    {
    //        case 0:
    //            break;
    //        default:
    //            returnThis = Helper(nFloors);
    //            break;
    //    }
    //    return returnThis.ToArray();
    //}
    //private static List<string> Helper(int count)
    //{
    //    List<string> returnThis = new List<string>();
    //    for (int i = 1; i <= count * 2; i += 1)
    //    {
    //        returnThis.Add(AddStars(i));
    //        i += 2;
    //    }
    //    return returnThis;
    //}
    //private static string AddStars(int count)
    //{
    //    string result = string.Empty;
    //    for (int i = 1; i <= count; i += 1)
    //    {
    //        result += "*";
    //    }
    //    return result;
    //}
    //public static bool IsPrime(int number)
    //{
    //    if (number <= 1) return false;
    //    if (number == 2) return true;
    //    if (number % 2 == 0) return false;

    //    var boundary = (int)Math.Floor(Math.Sqrt(number));

    //    for (int i = 3; i <= boundary; i += 2)
    //        if (number % i == 0)
    //            return false;

    //    return true;
    //}

    //public static IEnumerable<int> GetIntegersFromList(List<object>] names)
    //{
    //    var returnText = " likes this";
    //string formattedText = string.Empty;

    //    if (names.Length == 0)
    //    {
    //        return  $"no one{returnText}";
    //    }

    //    if(names.Length <= 2)
    //        formattedText = names.Select(f => f.ToString()).Aggregate((x, y) => x + " and " + y);
    //    if (names.Length == 3)
    //        formattedText = $"{names.Take(2).Select(f => f.ToString()).Aggregate((x, y) => x + "," + y)} and {names[2]}";
    //    if (names.Length > 3)
    //        formattedText = $"{names.Take(2).Select(f => f.ToString()).Aggregate((x, y) => x + "," + y)} and other {names.Length-2} ";

    //    return $"{formattedText}{returnText}";
    //}

    //        ListFilterer.GetIntegersFromList(new List<object>(){1, 2, "a", "b"}) => {1, 2}
    //ListFilterer.GetIntegersFromList(new List<object>(){1, 2, "a", "b", 0, 15}) => {1, 2, 0, 15}
    //ListFilterer.GetIntegersFromList(new List<object>(){1, 2, "a", "b", "aasf", "1", "123", 231}) => {1, 2, 231}
}
