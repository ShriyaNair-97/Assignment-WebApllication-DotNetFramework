using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using CalculatorLibrary;

namespace ConCalculator
{
    [Serializable]
    class Program
    {
        static void Main(string[] args)
        {
            Calculate cal = new Calculate();
            FileStream fs = new FileStream("Calculator.txt" ,
                FileMode.OpenOrCreate,FileAccess.ReadWrite);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs,cal);
            Console.WriteLine("Serialization done");
            fs.Close();

        }
}
}
