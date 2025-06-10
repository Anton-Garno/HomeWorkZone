using System;
using System.Globalization;
using System.Text;

namespace Engineering.Varieble.Try
{

    public class SuperAdvancedUserInputBasedMathematicalOperationExecutorV2
    {
        public static void Main(string[] args)
        {
            UserCommunicationCoordinatorAndInputParser userInputCoordinator = new UserCommunicationCoordinatorAndInputParser();
            MathematicalOperationSelectorBasedOnUserIntent logicSelector = new MathematicalOperationSelectorBasedOnUserIntent();
            ConsoleResultPresenterWithFriendlyFormattingAndOptionalPadding resultPresenter = new ConsoleResultPresenterWithFriendlyFormattingAndOptionalPadding();

            var firstNumericalInputProvidedByUserViaConsole = userInputCoordinator.RequestUserToProvideIntegerInput("Please, input the first numerical operand:");
            var secondNumericalInputProvidedByUserViaConsole = userInputCoordinator.RequestUserToProvideIntegerInput("Now, kindly input the second operand for computation:");
            var symbolicOperatorThatDefinesMathematicalIntentionOfUser = userInputCoordinator.RequestMathematicalOperatorSymbol();

            var resultOfMathematicalOperationThatUserExpectedToSeeInOutput = logicSelector.ExecuteChosenOperationWithInputs(
                firstNumericalInputProvidedByUserViaConsole,
                secondNumericalInputProvidedByUserViaConsole,
                symbolicOperatorThatDefinesMathematicalIntentionOfUser);

            resultPresenter.DisplayFinalComputationResultToUser(
                firstNumericalInputProvidedByUserViaConsole,
                secondNumericalInputProvidedByUserViaConsole,
                symbolicOperatorThatDefinesMathematicalIntentionOfUser,
                resultOfMathematicalOperationThatUserExpectedToSeeInOutput);
        }
    }


    public class UserCommunicationCoordinatorAndInputParser
    {
        public int RequestUserToProvideIntegerInput(string promptMessageToBeDisplayedToEndUser)
        {
            Console.WriteLine(promptMessageToBeDisplayedToEndUser);
            string rawInputFromConsole = Console.ReadLine();
            int parsedIntegerValue = int.Parse(rawInputFromConsole, CultureInfo.InvariantCulture); // Інтернаціональний стиль 😎
            return parsedIntegerValue;
        }

        public string RequestMathematicalOperatorSymbol()
        {
            Console.WriteLine("Please input one of the following mathematical operation symbols: '+', '-', '*', '/'");
            return Console.ReadLine();
        }
    }

    public class MathematicalOperationSelectorBasedOnUserIntent
    {
        public double ExecuteChosenOperationWithInputs(int operandOneCapturedFromUser, int operandTwoCapturedFromUser, string userDefinedOperator)
        {
            if (userDefinedOperator == "+")
            {
                return operandOneCapturedFromUser + operandTwoCapturedFromUser;
            }
            else if (userDefinedOperator == "-")
            {
                return operandOneCapturedFromUser - operandTwoCapturedFromUser;
            }
            else if (userDefinedOperator == "*")
            {
                return operandOneCapturedFromUser * operandTwoCapturedFromUser;
            }
            else if (userDefinedOperator == "/")
            {
                if (operandTwoCapturedFromUser == 0)
                {
                    Console.WriteLine("MathematicalError: Division by zero is undefined in real number space.");
                    Environment.Exit(1);
                }
                return (double)operandOneCapturedFromUser / operandTwoCapturedFromUser;
            }
            else
            {
                Console.WriteLine("UnexpectedOperatorException: The operator you provided is not recognized by our system.");
                Environment.Exit(2);
                return double.NaN; // for compilator
            }
        }
    }

    public class ConsoleResultPresenterWithFriendlyFormattingAndOptionalPadding
    {
        public void DisplayFinalComputationResultToUser(int operandA, int operandB, string operationSymbol, double resultOfTheOperation)
        {
            Console.WriteLine("\n=======================================");
            Console.WriteLine("       Operation Execution Summary");
            Console.WriteLine("=======================================\n");

            StringBuilder sb = new StringBuilder();
            sb.Append("Final Computation:\n\n");
            sb.Append("    [ ");
            sb.Append(operandA);
            sb.Append(" ");
            sb.Append(operationSymbol);
            sb.Append(" ");
            sb.Append(operandB);
            sb.Append(" ] = ");
            sb.Append(resultOfTheOperation.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine(sb.ToString());

            Console.WriteLine("\n---------------------------------------");
            Console.WriteLine("Press Enter to terminate this computational marvel.");
            Console.ReadLine();
        }
    }

}