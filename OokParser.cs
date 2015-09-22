using System.Collections.Generic;
using System.IO;

namespace OokLanguageInterpreter
{
    public static class OokParser
    {
        public static List<string> Parse(string filePath)
        {
            var text = File.ReadAllText(filePath);

            var ooks = text.TrimFull();
            var ookList = new List<string>();

            var command = "";
            var index = 0;
            foreach (var ch in ooks.ToCharArray())
            {
                command += ch;
                if (index == 7)
                {
                    ookList.Add(command);
                    command = "";
                    index = 0;
                    continue;
                }
                index++;
            }

            return ookList;
        }
    }
}