namespace OokLanguageInterpreter.Interpreter.Instructions
{
    public class IncrementCellInstruction : BaseInstruction
    {
        public override void Interpret(InterpreterState state)
        {
            state.IncrementCurrentData();
        }
    }
}