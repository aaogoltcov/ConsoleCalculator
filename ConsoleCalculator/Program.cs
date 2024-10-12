string aInputValue = "";
string bInputValue = "";
string operandInputValue = "";

decimal aValue;
decimal bValue;
char operandValue;

Console.WriteLine("Калькулятор, вычисляющий выражения вида a + b, a - b, a / b, a * b");

string[] questions =
[
    "Введите значение a: ",
    "Введите значение b: ",
    "Введите значение операнд (+, -, / или *): ",
];

for (int index = 0; index < questions.Length; index++)
{
    Console.Write(questions[index]);
    
    if (index == 0)
    {
        aInputValue = Console.ReadLine();
    }

    if (index == 1)
    {
        bInputValue = Console.ReadLine();
    }

    if (index == 2)
    {
        operandInputValue = Console.ReadLine();
    }
}

var isAValue = decimal.TryParse(aInputValue, out aValue);
var isBValue = decimal.TryParse(bInputValue, out bValue);
var isOperandValue = char.TryParse(operandInputValue, out operandValue);

if (isAValue && isBValue && isOperandValue)
{
    switch (operandValue)
    {
        case '+':
            Console.WriteLine($"Результат: {aValue + bValue}");
            break;
        case '-':
            Console.WriteLine($"Результат: {aValue - bValue}");
            break;
        case '/':
            if (bValue == 0)
            {
                Console.WriteLine("Нельзя делить на 0");
                break;
            }

            Console.WriteLine($"Результат: {aValue / bValue}");
            break;
        case '*':
            Console.WriteLine($"Результат: {aValue * bValue}");
            break;
        default:
            Console.WriteLine("Неизвестный операнд");
            break;
    }
}
else
{
    Console.WriteLine("Введены неверные данные, попробуйте снова");
}