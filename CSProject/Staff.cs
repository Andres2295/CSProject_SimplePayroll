using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProject
{
    internal class Staff
    {
        private float hourlyRate { get; set; }
        private int hWorked {  get; set; }
        public float TotalPay { get; protected set; }
        public float BasicPay { get; private set; }
        public string NameOfStaff { get; private set; }
        public int HoursWorked
        {
            get
            {
                return hWorked;
            }
            set
            {
                if (value > 0)
                {
                    hWorked = value;
                }
                else
                {
                    hWorked = 0;
                }
            }
        }

        public Staff(string name, float rate)
        {
            NameOfStaff = name;
            hourlyRate = rate;
        }

        public void PrintMessage()
        {
            Console.WriteLine("Calculating Pay...");
        }

        public virtual void CalculatePay()
        {
            PrintMessage();

            BasicPay = hWorked * hourlyRate;
            TotalPay = BasicPay;
        }

        public override string ToString() {
            return "\nName of Staff = " + NameOfStaff + "\nHourly Rate = " + hourlyRate + "\nHours Worked = " + HoursWorked +
                "\nBasic Pay = " + BasicPay + "\n\nTotalPay = " + TotalPay;
        }

    }
}
