using System;
using OokLanguageInterpreter.Interpreter;
using OokLanguageInterpreter.Interpreter.Instructions;

namespace OokLanguageInterpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            var expressionManager = new InstructionSequence();

            var ooks = OokParser.Parse(@"d:\private\ook.txt");

            foreach (var ook in ooks)
            {
                if (ook == "Ook.Ook?")
                    expressionManager.Add(new MovePointerForwardInstruction());
                else if (ook == "Ook?Ook.")
                    expressionManager.Add(new MovePointerBackwardInstruction());
                else if (ook == "Ook.Ook.")
                    expressionManager.Add(new IncrementCellInstruction());
                else if (ook == "Ook!Ook!")
                    expressionManager.Add(new DecrementCellInstruction());
                else if (ook == "Ook.Ook!")
                    expressionManager.Add(new ReadCharInstruction());
                else if (ook == "Ook!Ook.")
                    expressionManager.Add(new PrintCharInstruction());
                else if (ook == "Ook!Ook?")
                    expressionManager.Add(new MoveForwardToWhenZeroInstruction(expressionManager));
                else if (ook == "Ook?Ook!")
                    expressionManager.Add(new MoveBackwardToIfNotZeroInstruction(expressionManager));
            }

            expressionManager.Run();

            Console.ReadLine();
        }
    }
}
