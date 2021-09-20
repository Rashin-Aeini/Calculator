namespace Calculator.App
{
    public class Calc
    {
        public int Addition(int first, int second)
        {
            return first + second;
        }

        public float Addition(float[] entry)
        {
            float result = 0;

            foreach (float item in entry)
            {
                result += item;
            }

            return result;
        }
        
        public int Subtraction(int first, int second)
        {
            return first - second;
        }
        
        public float Subtraction(float[] entry)
        {
            float result = 0;

            foreach (float item in entry)
            {
                result -= item;
            }

            return result;
        }
        
        public int Multiplication(int first, int second)
        {
            return first * second;
        }
        
        public int Division(int first, int second)
        {
            return first / second;
        }
        
    }
}