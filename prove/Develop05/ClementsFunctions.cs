using System.ComponentModel;

public class ClementsFunctions
{
    public static int GetUserInputInteger(string Prompt)
    {
        int returnValue = 0;
        bool wac_flag = true;
        while (wac_flag)
        {
            try
            {
                Console.WriteLine(Prompt);
                string wacUserInputStr = Console.ReadLine();
                returnValue = int.Parse(wacUserInputStr);
            } catch {Exception e;}
            {
                Console.WriteLine("Value is not acceptable, please enter a valid float");
            }
            wac_flag = false;
        }
        return returnValue;
    }

    public static float GetUserInputFloat(string Prompt)
    {
        float returnValue = 0;
        bool wac_flag = true;
        while (wac_flag)
        {
            try
            {
                Console.WriteLine(Prompt);
                string wacUserInputStr = Console.ReadLine();
                returnValue = float.Parse(wacUserInputStr);
            } catch {Exception e;}
            {
                Console.WriteLine("Value is not acceptable, please enter a valid float");
            }
            wac_flag = false;
        }
        return returnValue;
    }

    public static string GetUserInputString()
    {
        string returnValue = "";
        bool wac_flag = true;
        while (wac_flag)
        {
            try
            {
                Console.ReadLine();
                returnValue = Console.ReadLine();
                if (string.IsNullOrEmpty(returnValue)==true)
                {
                    throw new Exception();
                }
            } catch {Exception e;}
            {
                Console.WriteLine("Value is not acceptable, please enter a valid string");
            }
            wac_flag = false;
        }
        return returnValue;
    }

    public static float GetUserInputRealNumber(string Prompt)
    {
        float returnValue = 0;
        bool wac_flag = true;
        while (wac_flag)
        {
            try
            {
                Console.WriteLine(Prompt);
                string wacUserInputStr = Console.ReadLine();
                returnValue = float.Parse(wacUserInputStr);
                if (float.IsRealNumber(returnValue))
                {
                    throw new Exception();
                }
            } catch {Exception e;}
            {
                Console.WriteLine("Value is not acceptable, please enter a decimal value");
            }
            wac_flag = false;
        }

        return returnValue;
    }

}