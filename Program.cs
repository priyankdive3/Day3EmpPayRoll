namespace EmpPayroll
{
    internal class Program
    {
        
            static void Main(string[] args)
            {
                Console.WriteLine("Welcome To Employee Wage!");
                Console.WriteLine("Choose option\n 1.Check absent or present\n2.Check daily employee wage\n3.Part time wage\n4.Part time wage using switch case\n5.Monthly Wages\n6.Total Working Hours Of Employee\n7.Refactor Code\n8.Wages for Multiple Companies.\n9.Employee Wage builder for each companies");
                  
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
                case 6:
                    TotalWorkingHrWhileCase.CalculateWage();
                    break;
                
                case 8:
                    MultipleCompanies.calculate("D-Mart", 20, 20, 100);
                    MultipleCompanies.calculate("Reliance", 20, 20, 100);
                    break;
                case 9:
                    EmpWageBuilder dmart = new EmpWageBuilder("Dmart", 20, 2, 10);//creating dmart object
                    EmpWageBuilder reliance = new EmpWageBuilder("Reliance", 10, 4, 20);//creating reliance object
                    dmart.computeEmpWage();
                    Console.WriteLine(dmart.ToString());
                    reliance.computeEmpWage();
                    Console.WriteLine(reliance.ToString());
                    break;
                default:
                        Console.WriteLine("Entered wrong choice");
                        break;
                }
            }

     }
       
}
