using System;
using System.Collections.Generic;

namespace StringCalculator
{
    public class StringCalculator : IStringCalculator
    {
        private List<string> getDelimiters(string unproccessedString)
        {
            List<string> delimiters = new ();
            foreach(var delimiter in unproccessedString.Split('['))
            {
                if(delimiter.Contains("]")) delimiters.Add(delimiter.Split(']')[0]);
            }
            return delimiters;
        }

        public int Add(string numbers)
        {
            if (string.IsNullOrEmpty(numbers))
                return 0;
            List<string> delimiters = new() { "," };
            List<string> strings = numbers
                .Split(new string[] { "\n" }, StringSplitOptions.None).ToList();
            if (strings[0].Contains("\\")){
                delimiters = strings[0].Contains("]") ? getDelimiters(strings[0]) : new List<string> { strings[0][strings[0].Length - 1].ToString() };
                strings.RemoveAt(0);
            } 
            List<int> numbersInt = strings.Select(line => line.Length > 1 ?
                    line.Split(delimiters.ToArray(), StringSplitOptions.None)
                    .Select(num => Convert.ToInt32(num)) : new int[] { Convert.ToInt32(line) })
                .SelectMany(num => num)
                .ToList()
                .FindAll(num => num <= 1000);
            List<string> negativeNumbers = numbersInt.FindAll(num => num < 0).Select(numInt => Convert.ToString(numInt)).ToList();
            if (negativeNumbers.Count > 0)
            {
                string negativeNumbersString = negativeNumbers.Aggregate((i, j) => i.ToString() + delimiters[0] + j.ToString()).ToString();
                throw new Exception("negatives not allowed: " + negativeNumbersString);
            }
            return numbersInt.Count > 1 ? numbersInt.Sum() : numbersInt[0];
        }
    }
}
