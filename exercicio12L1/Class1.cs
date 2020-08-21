using System;

namespace exercicio12L1
{
    public class RetornaSomaPares
    {

        public  int SomaPares(params int[] numbers)
        {
            int sumPairs = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)

                {
                    sumPairs += numbers[i];
                }
            }

            return sumPairs;



        }
        
    }
}
