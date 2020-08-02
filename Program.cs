using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = "Hello World";
            Console.WriteLine(message);
            MessageBox.Show(message);
            Patient jack = new Patient("123", 56, 1);
            jack.CallPatient();
        }
    }
    class Patient
    {
        public string ID { get; set; }
        public int Age { get; set; }
        public int Priority { get; set; }

        public Patient(string iD, int age, int priority)
        {
            ID = iD;
            Age = age;
            Priority = priority;
        }
        public void CallPatient()
        {
            MessageBox.Show(ID + " " + Age + " " + Priority);
        }
    }


}
