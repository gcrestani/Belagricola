using System;
using System.Collections.Generic;
using System.Text;

namespace Belagricola_01_soma_par.Entities
{
    class Even
    {
        public List<int> Numbers { get; set; }

        public Even(List<int> num)
        {
            Numbers = FilterEvenNumbers(num);
        }
        private List<int> FilterEvenNumbers(List<int> numbers)
        {
            List<int> evens = new List<int>();
            foreach (int n in numbers)
            {
                if (n % 2 == 0)
                {
                    evens.Add(n);
                }
            }
            return evens;
        }

        public double MinSumEvenNumbers()
        {
            int min = int.MaxValue;
            for (int i = 0; i < this.Numbers.Count; i++)
            {
                for (int j = 0; j < this.Numbers.Count; j++)
                {                    
                    if (j<=i)
                    {
                        j = i+1; //avoid that a number is summed with itself
                        if (j >= this.Numbers.Count)
                        {
                            break; //avoid that the last number is summed with itself
                        }
                    }
                    int sum = this.Numbers[i] + this.Numbers[j];
                    min = sum < min ? sum : min;
                }
            }
            return min;
        }
    }
}
