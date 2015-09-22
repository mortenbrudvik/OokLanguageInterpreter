using System;
using System.Text;

namespace OokLanguageInterpreter.Interpreter.Instructions
{
    public class PrintCharInstruction : BaseInstruction
    {
        public override void Interpret(InterpreterState state)
        {
            var data = (byte)state.CurrentData;
            var c = Encoding.ASCII.GetChars(new[] { data })[0];
            Console.Write(c);
        }
    }
}