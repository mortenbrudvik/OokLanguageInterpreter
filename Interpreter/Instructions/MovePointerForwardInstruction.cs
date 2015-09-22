namespace OokLanguageInterpreter.Interpreter.Instructions
{
    public class MovePointerForwardInstruction : BaseInstruction
    {
        public override void Interpret(InterpreterState state)
        {
            state.MoveNext();
        }
    }
}