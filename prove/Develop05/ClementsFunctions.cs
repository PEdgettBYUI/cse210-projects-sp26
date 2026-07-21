using System.ComponentModel;

public class ClementsFunctions
{
    public static int GetUserInputInteger(string prompt)
    {
        int returnValue = 0;
        bool wac_flag = true;
        while (wac_flag)
        {
            try
            {
                Console.Write(prompt + " ");
                string wacUserInputStr = Console.ReadLine();
                returnValue = int.Parse(wacUserInputStr);
            } catch (Exception e)
            {
                Console.WriteLine("Value is not acceptable, please enter a valid integer");
            }
            wac_flag = false;
        }
        return returnValue;
    }

    public static float GetUserInputFloat(string prompt)
    {
        float returnValue = 0;
        bool wac_flag = true;
        while (wac_flag)
        {
            try
            {
                Console.Write(prompt + " ");
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

    public static string GetUserInputString(string prompt)
    {
        string returnValue = "";
        bool wac_flag = true;
        while (wac_flag)
        {
            try
            {
                Console.Write(prompt + " ");
                returnValue = Console.ReadLine();
                if (string.IsNullOrEmpty(returnValue) == true)
                {
                    throw new Exception();
                }
            } catch (Exception e)
            { Console.WriteLine("Value is not acceptable, please enter a valid string"); }
            wac_flag = false;
        }
        return returnValue;
    }

    public static float GetUserInputRealNumber(string prompt)
    {
        float returnValue = 0;
        bool wac_flag = true;
        while (wac_flag)
        {
            try
            {
                Console.WriteLine(prompt);
                string wacUserInputStr = Console.ReadLine();
                returnValue = float.Parse(wacUserInputStr);
                if (float.IsRealNumber(returnValue))
                {
                    throw new Exception();
                }
            } catch (Exception e)
            { Console.WriteLine("Value is not acceptable, please enter a valid real number"); }
            wac_flag = false;
        }

        return returnValue;
    }

}