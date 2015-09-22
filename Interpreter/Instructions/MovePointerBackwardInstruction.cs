﻿namespace OokLanguageInterpreter.Interpreter.Instructions
{
    public class MovePointerBackwardInstruction : BaseInstruction
    {
        public override void Interpret(InterpreterState state)
        {
            state.MovePrevious();
        }
    }
}