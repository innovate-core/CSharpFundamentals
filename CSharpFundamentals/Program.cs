namespace CSharpFundamentals;

internal class Program
{
    static void Main(string[] args)
    {
        //Primitive Types and Expressions
        VariablesAndConstants.VariablesAndConstantsProgram();
        TypeConversion.TypeConversionProgram();
        Operators.OperatorsProgram();

        //Non-Primitive Types
        Classes.ClassProgram();
        Arrays.ArraysProgram();
        Strings.StringsProgram();
        Enums.EnumsProgram();
        ReferenceTypesAndValueTypes.ReferenceTypesAndValueTypesProgram();

        //Control Flow
        IfElseAndSwitchCase.IfElseAndSwitchCaseProgram();
        ForLoops.ForLoopsProgram();
        ForeachLoops.ForeachLoopsProgram();
        WhileLoops.WhileLoopsProgram();
    }
}
