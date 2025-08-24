using System.Collections;

namespace Advanced_C__01
{
    internal class Program
    {

        // without generic
        //public static void ReverseList(ArrayList arrList)
        //{
        //    for (int i = 0; i < (arrList.Count) / 2; i++)
        //    {
        //        object temp = arrList[i]; ;
        //        arrList[i] = arrList[arrList.Count - 1 - i];
        //        arrList[arrList.Count - 1 - i] = temp;

        //    }
        //}

        //public static void ReverseObject<T>(List<T> list)
        //{
        //    for (int i = 0; i < list.Count / 2; i++)
        //    {
        //        T temp = list[i];
        //        list[i] = list[list.Count - 1 - i];
        //        list[list.Count - 1 - i] = temp;
        //    }
        //}

        //public static List<int> EvenList(List<int> list) { 

        //    List<int> evenNumbers = new List<int>();
        //    for (int i = 0; i < list.Count; i++)
        //    {


        //        if (list[i] > 0 && list[i] % 2 == 0)
        //        {
        //            evenNumbers.Add(list[i]);
        //        }
        //    }

        //     return evenNumbers;

        //}

        #region Q5
        //public static int FirstNonRepeatedChar(string input)
        //{
        //    Dictionary<char, int> repeated = new Dictionary<char, int>();
        //    string stringInsensitive = input.ToLower();
        //    // store char and count of repeating
        //    foreach (char c in stringInsensitive)
        //    {
        //        if (repeated.ContainsKey(c))
        //            repeated[c]++;
        //        else repeated[c] = 1;
        //    }

        //    // find the first non-repeated char

        //    for (int i = 0; i < stringInsensitive.Length; i++)
        //    {
        //        if (repeated[stringInsensitive[i]] == 1)
        //            return i;
        //    }
        //    return -1;
        //}

        #endregion
        static void Main(string[] args)
        {
            #region Q1
            // Var: is used for implicit typing. it tells the compiler to figure out the right type from the expression
            var intRange = new Range<int>(10, 20);
            Console.WriteLine(intRange.IsInRange(10));
            Console.WriteLine(intRange.IsInRange(25));
            Console.WriteLine("Length: " + intRange.Length());
            #endregion


            #region Q2


            //ArrayList arr = new ArrayList() { 1, 2, 3, 4, 5, 6,7 };
            //Console.WriteLine("Before reverse");
            //foreach (int item in arr)
            //    Console.WriteLine(item);

            //Console.WriteLine("after reverse");
            //ReverseList(arr);

            //foreach (int item in arr)
            //    Console.WriteLine(item);


            //  List<int> numbersList= new List<int>(){ 1, 2, 3, 4, 5, 6, 7 };
            //  Console.WriteLine("Before reverse");
            //  foreach (int item in numbersList)
            //      Console.WriteLine(item);

            //  Console.WriteLine("after reverse");
            //ReverseObject<int>(numbersList);

            //  foreach (int item in numbersList)
            //      Console.WriteLine(item);
            #endregion

            #region Q3

            //List<int> numbersList = new List<int>() { 1, 2, 3, 4, 5, 6, 7 };
            //Console.WriteLine("Before extract even");
            //foreach (int item in numbersList)
            //    Console.WriteLine(item);

            //Console.WriteLine("after extract");

            //foreach (int item in EvenList(numbersList))
            //    Console.WriteLine(item);

            #endregion

            #region Q4

            FixedSizeList<int> list = new FixedSizeList<int>(2);
            list.Add(10);
            list.Add(25);
 

           

            Console.WriteLine(list.Get(1));
            Console.WriteLine(list.Get(0));
            #endregion


            #region Q5

            //string s1 = "Hhello";
            //string s2 = "ahmed";

            //int first = FirstNonRepeatedChar(s1);
            //int second = FirstNonRepeatedChar(s2);

            //Console.WriteLine($"the string is : {s1} and the index of first non-repeated-char is {first} and the first non-repeated char is {s1[first]}");
            //Console.WriteLine($"the string is : {s2} and the index of first non-repeated-char is {second} and the first non-repeated char is {s2[second]}");

            #endregion


        }
    }
}
            