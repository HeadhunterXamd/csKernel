using System;
using System.Collections.Generic;
using System.Text;

namespace CosKernel
{
    public class ConsoleParser
    {
        public string[] KeyStrings = {"|", "&", ">", "<"};


        public string ParseConsoleLine(string input)
        {
            // check if the console should run the command in the background.
            if (input.Contains(KeyStrings[1]))
            {
                // remove the outer command (if it is the & sign), so we can continue parsing the line!
                string processLine = input.Substring(0, input.IndexOf(KeyStrings[1], StringComparison.Ordinal) - 1);

                return "PID: " + ProcessManager.Instance.CreateProcess(ParseProcessLine(processLine));
            }

            return "";
        }

        private string ParseProcessLine(string substring)
        {
            throw new NotImplementedException();
        }
    }
}
