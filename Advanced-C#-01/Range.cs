using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_C__01
{
    internal class Range<T> where T: IComparable<T> // i can here also <INumber> to make all methods in the class accept only numeric types

    {
        
        #region properties 
        public T Min { get; set; }
        public T Max { get; set; }
        #endregion
        #region constracor
        //●	Implement a constructor that takes the minimum and maximum values to define the range.
        public Range(T min, T max)
        {
            if (min.CompareTo(max) > 0)
                throw new ArgumentException(" the max value should be greater than min value");

            Min = min;
            Max = max;
        }
        #endregion

        #region method
        //Implement a method IsInRange(T value) that returns true if the given  value is within the range, otherwise false.
        public bool IsInRange(T value)
        {
            return value.CompareTo(Min) >= 0 && value.CompareTo(Max) <= 0;
        }


        //Implement a method Length() that returns the length of the range(the difference between the maximum and minimum values).
        /*
                 public T Length()
        {
            return Max - Min;

        }  // this in sont valid because T may be string anther type
         */

        // i can use constrains to be only use INumber<T> in the classs and in this case i will use normal operator

        public double Length()// double: because it is work with all type of numeric
        {
            try
            {
                double minValue = Convert.ToDouble(Min);
                double maxValue = Convert.ToDouble(Max);
                return maxValue - minValue;
            }
            catch (Exception) { 
                
                throw new InvalidOperationException(" the Leength function can only work with numeric types");
            }
        } 
        #endregion


    }
}
