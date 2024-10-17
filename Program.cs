namespace TupleToDictionary
{
    public class Program
    {
        static void Main(string[] args)
        {

            //Tuple Elements......
            Tuple <int,string> tuple1 = new Tuple<int,string>(1,"Diya");
            Console.WriteLine(tuple1);
            Tuple<string, int, string> tuple2 = new Tuple<string, int, string>("Software", 2, "Sana");
            Console.WriteLine(tuple2);

            //Creating empty dictionary Empty dictionary.....
            Dictionary <int,string>dict = new Dictionary<int,string>();
            dict.Add(tuple1.Item1, tuple1.Item2);
            foreach(KeyValuePair<int,string> kvp in dict)
            {
                Console.WriteLine($"{kvp.Key}:{kvp.Value}");
            }
            //Second dictionary.......
            Dictionary<string, int> dict1 = new Dictionary<string, int>();
            dict1.Add(tuple2.Item1, tuple2.Item2);
            foreach (KeyValuePair<string, int> kvp in dict1)
            {
                Console.WriteLine($"{kvp.Key}:{kvp.Value}");
            }










        }
    }
}
