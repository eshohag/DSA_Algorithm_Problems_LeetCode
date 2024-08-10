using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoSum_Problem
{
    public class TwoSum_Solution
    { /// <summary>
      /// Brute force: Time Complexity: O(n^2), Space complexity: O(1)
      /// </summary>
      /// <param name="array"></param>
      /// <param name="target"></param>
      /// <returns>integer array of indices</returns>
        public static int[] NormalSolution(int[] array, int target)
        {
            //Declarations
            int length = array.Length;

            //Validations
            if (array == null || length < 2)
            {
                return Array.Empty<int>();
            }

            //Logic
            for (int i = 0; i < length; i++)
            {
                for (int j = i + 1; j < length; j++)
                {
                    if (array[i] + array[j] == target)
                    {
                        return new int[] { i, j };
                    }
                }
            }
            return Array.Empty<int>();
        }

        /// <summary>
        /// Using a Dictionary: Time Complexity: O(n), Space complexity: O(n)
        /// </summary>
        /// <param name="array"></param>
        /// <param name="target"></param>
        /// <returns>integer array of indices</returns>
        public static int[] OptimizedSolution(int[] array, int target)
        {
            //Declarations
            int length = array.Length;

            //Key, Value
            Dictionary<int, int> result = new Dictionary<int, int>();

            //Validations
            if (array == null || length < 2)
            {
                return Array.Empty<int>();
            }

            //Logic
            //x+y=target
            //firstNumber+secondNumber=target
            //secondNumber=target-firstNumber;
            for (int i = 0; i < length; i++)
            {
                int firstNumber = array[i];
                int secondNumber = target - firstNumber;
                if (result.ContainsKey(secondNumber))
                {
                    return new[] { result[secondNumber], i };
                }
                result[firstNumber] = i;
            }

            return Array.Empty<int>(); ;
        }
    }
}
