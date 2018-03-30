using System;

namespace session2
{
    class Program
    {
        const int YEAR_2018 = 2018;

        int instanceVariable { get; set; } = 0;
        public int myProperty { get; set; } = 100;

        //Method examples
        public int lambdaExample() => 0;

        public int otherLambdaMethod() => 100 * 25;

        //constructors
        public Program(int parameters)
        { }

        //destructors
        ~Program()
        { }

        // Events
        public event EventHandler myEvent;

        //indexador
        public int this[int value]
        {
            get
            {
                return value * 5;
            }
        }

        public class myNestedClass { }

        public class myClass: object
        {

        }
        public abstract class Vehicle : myClass
        {

        }

        public class TerrestrialVehicle : Vehicle
        {
        }

        public sealed class bicycle : TerrestrialVehicle
        {

        }

        //public class monocycle : bicycle
        //{
//        1>------ Build started: Project: session2, Configuration: Debug Any CPU ------
//1>Program.cs(57,22,57,31): error CS0509: 'Program.monocycle': cannot derive from sealed type 'Program.bicycle'
//1>Done building project "session2.csproj" -- FAILED.
//========== Build: 0 succeeded, 1 failed, 0 up-to-date, 0 skipped ==========
        //}

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            object o = new object();
            Console.WriteLine(o.ToString());
            Console.WriteLine(o.GetType());
            Console.ReadKey();

            Vehicle terrestrial = new TerrestrialVehicle();
        }

        

    }
}
