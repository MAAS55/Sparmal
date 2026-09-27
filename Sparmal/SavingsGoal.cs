using System;

namespace Sparmal
{
    class SavingsGoal
    {
        public string Name { get; set; } = "";
        public decimal Target { get; set; }
        public decimal Monthly { get; set; }

        public decimal MonthsLeft()
        {
            return Math.Ceiling(Target / Monthly);
        }


        //public DateTime ReachedDate()
        //{
        //    return Datetime.Today.Addmonths((int) MonthLeft());
        //}
        public DateTime ReachedDate()
        {
            return DateTime.Today.AddMonths((int)MonthsLeft());
        }
    }
}   
