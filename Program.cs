using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            statement.main();
            Console.ReadLine();
        }
    }
    class statement
    {
        public static void main()
        {
            string username;
            Console.WriteLine("Enter username: ");
            username = Console.ReadLine();

            if (username == "Abdullah")
            {
                In_OFFICE IO = new In_OFFICE();
                IO.day();
                IO.Start();
                IO.End();
                WORK_FROM_HOME wfh = new WORK_FROM_HOME();
                wfh.day();
                wfh.Start();
                wfh.End();
            }
            else
            {
                Console.WriteLine("Enter correct Name");
            }
        }
    }
    class spantech
    {
        public void Start()
        {
            Console.WriteLine("clock In sharply at 10AM\n");
        }
        public void End()
        {
            Console.WriteLine("Before clock Out Make-Sure 8hr is Complited or Nots\n");
        }


    }
    class In_OFFICE : spantech
    {
        public void day()
        {
            Console.WriteLine("OFFC_Day Started\n");
        }
    }

    class WORK_FROM_HOME : spantech
    {
        public void day()
        {
            Console.WriteLine(" WFH_Day Started\n");
        }
    }
}



