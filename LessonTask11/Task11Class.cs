using LessonTask;
using MethodsClassLibrary;

namespace LessonTask11;

public class Task11Class : TaskBaseClass
{
    protected override string Name { get; set; } = "Задача крестики-нолики";

    protected override string Description { get; set; } =
        "Создайте игру в крестики-нолики, которая соответствует требованиям, изложенным ниже:\n" +
        "Игровой процесс протекает в консоли (не требуется графический интерфейс пользователя).\n" +
        "Два игрока-человека делают ходы по очереди, используя одну и ту же клавиатуру.\n" +
        "Игроки могут указать, в какую клетку они хотят сыграть, используя клавиатуру. Один из возможных подходов " +
        "заключается в том, чтобы пронумеровать клетки в доске 3x3 цифрами от 1 до 9, как цифровая клавиатура NumPad. " +
        "Если игрок вводит число 7, то выбирается верхний левый угол доски.\n" +
        "Игра должна гарантировать соблюдение правил при каждом ходе:\n" +
        "Нельзя играть в квадрат, который уже занят.\n" +
        "Игрок не может сделать ход не в свою очередь.\n" +
        "Если игрок пытается делать запрещённый ход, доска должна остаться неизменной.\n" +
        "Игра должна уметь определять, когда один из игроков выигрывает, или когда ничья.\n" +
        "При обнаружении конца игры результат отображается пользователю.\n" +
        "Приложение может завершиться после одного раунда игры.";

    public override void Run()
    { 
        PrintTaskInfo();
        var field = new int[9];
        var winFlag = false;
        var isPlayer1 = true;
        var player1Cells = "";
        var player2Cells = "";
        
        while (!winFlag && (field.Contains(0)))
        {
            if (isPlayer1)
            {
                PlayerMove(ref field, ref isPlayer1, ref player1Cells);
                winFlag = IsWinningCombination(player1Cells);
            }
            else
            {
                PlayerMove(ref field, ref isPlayer1, ref player2Cells);
                winFlag = IsWinningCombination(player2Cells);
            }
        }

        Console.WriteLine(winFlag ? "Игра закончилась выигрышом игрока" : "Игра закончилась ничьей");
        PrintField(field);
    }

    private static void PlayerMove(ref int[] field, ref bool isPlayer1, ref string playerCells)
    {
        string outputMessage;
        int cellValue;

        if (isPlayer1)
        {
            outputMessage = "Ход первого игрока";
            cellValue = 1;
        }
        else
        {
            outputMessage = "Ход второго игрока";
            cellValue = 2;
        }
        
        var cellIndex = MethodsClass.GetNumber(outputMessage, 1, 9) - 1;
        
        while (field[cellIndex] != 0)
        {
            Console.WriteLine("Квадрат занят");
            cellIndex = MethodsClass.GetNumber(outputMessage, 1, 9) - 1;
        }
        
        field[cellIndex] = cellValue;
        playerCells += (cellIndex + 1).ToString();
        isPlayer1 = !isPlayer1;
                
        //PrintField(field); // раскомментировать, чтобы поле отображалось после каждого хода первого игрока
    }

    //Выигрышные комбинации
    private static bool IsWinningCombination(string playersCell)
    {
        return (playersCell.Contains("1") && playersCell.Contains("2") && playersCell.Contains("3")) ||
               (playersCell.Contains("4") && playersCell.Contains("5") && playersCell.Contains("6")) || 
               (playersCell.Contains("7") && playersCell.Contains("8") && playersCell.Contains("9")) || 
               (playersCell.Contains("1") && playersCell.Contains("4") && playersCell.Contains("7")) || 
               (playersCell.Contains("2") && playersCell.Contains("5") && playersCell.Contains("8")) ||
               (playersCell.Contains("3") && playersCell.Contains("6") && playersCell.Contains("9")) ||
               (playersCell.Contains("1") && playersCell.Contains("5") && playersCell.Contains("9")) ||
               (playersCell.Contains("3") && playersCell.Contains("5") && playersCell.Contains("7"));
    }
    
    private static void PrintField(int[] field)
    {
        PrintCellValue(field[6]);
        Console.Write("|");
        PrintCellValue(field[7]);
        Console.Write("|");
        PrintCellValue(field[8]);
        Console.WriteLine();
        Console.WriteLine("---+---+---");
        PrintCellValue(field[3]);
        Console.Write("|");
        PrintCellValue(field[4]);
        Console.Write("|");
        PrintCellValue(field[5]);
        Console.WriteLine();
        Console.WriteLine("---+---+---");
        PrintCellValue(field[0]);
        Console.Write("|");
        PrintCellValue(field[1]);
        Console.Write("|");
        PrintCellValue(field[2]);
        Console.WriteLine();
    }

    private static void PrintCellValue(int value)
    {
        switch (value)
        {
            case 0:
                Console.Write("   ");
                break;
            case 1:
                Console.Write(" X ");
                break;
            case 2:
                Console.Write(" 0 ");
                break;
        }
    }
}
