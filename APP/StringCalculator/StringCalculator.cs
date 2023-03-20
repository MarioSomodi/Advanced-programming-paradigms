using System;
using System.Collections.Generic;

namespace StringCalculator
{
    public class StringCalculator : IStringCalculator
    {
        public int Add(string numbers)
        {
            if (string.IsNullOrEmpty(numbers))
                return 0;
            char delimiter = ',';
            List<string> strings = numbers
                .Split(new string[] { "\n" }, StringSplitOptions.None).ToList();
            if (strings[0].Contains("\\")){
                delimiter = strings[0][strings[0].Length - 1];
                strings.RemoveAt(0);
            } 
            List<int> numbersInt = strings.Select(line => line.Length > 1 ?
                    line.Split(delimiter)
                    .Select(num => Convert.ToInt32(num)) : new int[] { Convert.ToInt32(line) })
                .SelectMany(num => num)
                .ToList()
                .FindAll(num => num <= 1000);
            List<string> negativeNumbers = numbersInt.FindAll(num => num < 0).Select(numInt => Convert.ToString(numInt)).ToList();
            if (negativeNumbers.Count > 0)
            {
                string negativeNumbersString = negativeNumbers.Aggregate((i, j) => i.ToString() + delimiter + j.ToString()).ToString();
                throw new Exception("negatives not allowed: " + negativeNumbersString);
            }
            return numbersInt.Count > 1 ? numbersInt.Sum() : numbersInt[0];
        }
    }
}
