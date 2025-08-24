using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProject
{
    internal class Manager : Staff
    {
        private const float managerHourlyRate = 50;
        public int Allowance {  get; private set; }

        public Manager(string name) : base(name, managerHourlyRate)
        {
        }

        public override void CalculatePay()
        {
            base.CalculatePay();

            Allowance = 100;

            if(HoursWorked > 160)
            {
                TotalPay = BasicPay + Allowance;
            }
        }
        public override string ToString()
        {
            return "\nName of Staff = " + NameOfStaff + "\nHourly Rate = " + managerHourlyRate + "\nHours Worked = " + HoursWorked +
                "\nBasic Pay = " + BasicPay + "\n\nTotalPay = " + TotalPay;
        }
    }
}
