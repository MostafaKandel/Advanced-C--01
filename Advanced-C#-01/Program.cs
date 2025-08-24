namespace Advanced_C__01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            // Var: is used for implicit typing. it tells the compiler to figure out the right type from the expression
            var intRange = new Range<int>(10, 20);
            Console.WriteLine(intRange.IsInRange(10)); 
            Console.WriteLine(intRange.IsInRange(25));
            Console.WriteLine("Length: " + intRange.Length());
            #endregion
        }
    }
}
