namespace Abstractions
{
    //Abstract Class
    abstract class SummationMultiplication
    {// method
        public int SumTwoVariables(int num1, int num2)
        {
            return num1 + num2;

        }

        public abstract int MultiplyTwoVariables(int num1, int num2);
        class derived : SummationMultiplication
        {
            public override int MultiplyTwoVariables(int num1, int num2)
            {
                return num1 * num2;
            }
        }

        static void Main(string[] args)
        {
            derived d = new derived();
            Console.WriteLine("Addition : {0} Multiplication :{1}",
                d.SumTwoVariables(5, 15),
                d.MultiplyTwoVariables(5, 15));
        }
        
    }
}