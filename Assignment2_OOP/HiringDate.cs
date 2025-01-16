using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_OOP
{
   
    public class HiringDate
    {
        #region fields
        private int day;
        private int month;
        private int year;
        #endregion
        #region properties
        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
        #endregion


        #region constructor
        public HiringDate(int day, int month, int year)
        {
            if (day < 1 || day > 31 || month < 1 || month > 12)
            {
                Console.WriteLine("Invalid date provided. Setting to default date: 1/1/2020.");
                Day = 1;
                Month = 1;
                Year = 2020;
            }
            else
            {
                Day = day;
                Month = month;
                Year = year;
            }
        }
        #endregion

        #region function tostring
        public override string ToString()
        {
            return $"{Day:00}/{Month:00}/{Year}";
        }
        #endregion


    }
}
