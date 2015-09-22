namespace OokLanguageInterpreter.Interpreter.Instructions
{
    public class DecrementCellInstruction : BaseInstruction
    {
        public override void Interpret(InterpreterState state)
        {
            state.DecrementCurrentData();
        }
    }
}