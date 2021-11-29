using System;

namespace Magic_Year_Calculator_App
{
    public  class MagicYearCalculator
    {
        
        public string Name { get; set; }
        public string Surname { get; set; }

        public int CalculateMonthlySalary(int annualSalary)
        {
            var monthlySalary = annualSalary / 12;
            return monthlySalary; 
        }

        public int CalculateMagicYear(int startYear)
        {
            var magicYear = startYear + 65;
            return magicYear;
        }
    
    }
}
