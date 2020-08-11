using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CalculatorLibrary

{
    
    public class Calculate
    {
        public int FirstNumber { get; set; }
        public int SecondNumber { get; set; }

        public int Add()
        {
            return FirstNumber + SecondNumber;
        }
        public int Substract()
        {
            if (FirstNumber > SecondNumber)
            {
                return FirstNumber - SecondNumber;
            }
            else
            {
                return SecondNumber - FirstNumber;
            }

        }
        public int Multiply()
        {
            return FirstNumber * SecondNumber;
        }
        public double Divide()
        {
            return FirstNumber / SecondNumber;
        }
    }
}
