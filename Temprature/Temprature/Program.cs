using System;

namespace exercise_state_wise_temperature_average
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[][] temp = new int[][]
                {
                    new int[]{30,50,65},
                    new int[]{25,36,45,43,38,12,66},
                    new int[]{33,44,55,22}
                };
            int pos = 0;

            Console.WriteLine(GetStateWiseAverage(pos, temp));
            /*declare array for collecting temperature of cities of 3 states
             *
             *first state provides temperature of 3 cities
             *second state provides temperature of 7 cities
             *third state provides temperature of 4 cities
            */

            /*
             * Call GetStateWiseAverage() with state position and temperature data
             */

            /*
             * Display Average
             */
        }

        /* 
         * Method calculates average of temperature for the state whose position is provided
         */

        public static int GetStateWiseAverage(int pos, int[][] temp)
        {
            int size = temp[pos].Length;
            int avg, sum = 0;
            for (int i = 0; i < size; i++)
            {
                sum = sum + temp[pos][i];
            }
            avg = sum / size;
            return avg;
            // put here logic to calculate average
        }
    }
}