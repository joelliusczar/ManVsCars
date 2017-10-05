using System;
using System.Collections.Generic;
using System.Text;


namespace ArmsJect.HumanArmsImplemtations
{
    public static class CodeGenUtil
    {
        public static string GetOutputType(string output)
        {
            return String.Format("Console.WriteLine({0})", output);
        }

    }
}
