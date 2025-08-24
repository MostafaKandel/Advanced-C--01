using System.Collections;

namespace Advanced_C__01
{
    internal class Program
    {

        // without generic
        public static void ReverseList(ArrayList arrList)
        {
            for (int i = 0; i < (arrList.Count) / 2; i++)
            {
                object temp = arrList[i]; ;
                arrList[i] = arrList[arrList.Count - 1 - i];
                arrList[arrList.Count - 1 - i] = temp;

            }
        }

        public static void ReverseObject<T>(List<T> list)
        {
            for (int i = 0; i < list.Count / 2; i++)
            {
                T temp = list[i];
                list[i] = list[list.Count - 1 - i];
                list[list.Count - 1 - i] = temp;
            }
        }
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


            List<int> numbersList= new List<int>(){ 1, 2, 3, 4, 5, 6, 7 };
            Console.WriteLine("Before reverse");
            foreach (int item in numbersList)
                Console.WriteLine(item);

            Console.WriteLine("after reverse");
          ReverseObject<int>(numbersList);

            foreach (int item in numbersList)
                Console.WriteLine(item);







            #endregion
        }
    }
}
            