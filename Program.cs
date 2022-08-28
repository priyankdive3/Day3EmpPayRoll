namespace EmpPayroll
{
    internal class Program
    {
        
            static void Main(string[] args)
            {
                Console.WriteLine("Welcome To Employee Wage!");
                Console.WriteLine("Choose option\n 1.Check absent or present\n2.Check daily employee wages\n3.Part time wage\n4.Part time wage using switch case\n5.Monthly Wages");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        EmpPresentAbsent.EmployeeAttenanceCheck();
                        break;
                    case 2:
                        DailyWage.CalculateDailywage();
                        break;
                    case 3:
                        PartTimeIf.CalculatePercentage();
                        break;
                    case 4:
                        PartTimeSwitch.CalculateWage();
                        break;
                case 5:
                    MonthlyWage.CalculateMonthlyWage();
                    break;
                default:
                        Console.WriteLine("Entered wrong choice");
                        break;
                }
            }

     }
       
}