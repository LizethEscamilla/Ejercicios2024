public class AbsoluteValue
{
    public int GetAbsolute(int num1, int num2)
    {
        int difference =Math.Abs(num1 - num2);
        
        if (num1 > num2)
        {
            return 2*difference;
        }
        
        return difference;
    }
}
