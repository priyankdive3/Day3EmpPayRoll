using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayRoll
{
    internal class EmpWageBuilder
    {
        private string v1;
        private int v2;
        private int v3;
        private int v4;

        public EmpWageBuilder(string v1, int v2, int v3, int v4)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
            this.v4 = v4;
        }

        internal void computeEmpWage()
        {
            throw new NotImplementedException();
        }
    }
}
