//Преобразуем первую входящую строку в целочисленное значение. 
//Это значение является количеством последующих входных строк с номерами автомобилей.
var rows = int.Parse(Console.ReadLine());

//Создаем динамический массив строк для ответов.
List<string> answers = new List<string>();
for(int i = 0; i < rows; i++)
{
    //Входящую строку сохраняем в переменную str.
    var str = Console.ReadLine();

    //Создаем строку-ответ для добавления автомобильных номеров или знака '-'.
    var answerRow = "";

    //Создаем массив символов для точной работы с символами.
    char[] newNumber;

    //Создаем цикл для работы со входящей строкой.
    for(int j = 0; j < 50; j++)
    {
        //Проверяем является строка пустой и нет. Если нет выполняем условие if.
        if(!String.IsNullOrEmpty(str))
        {
            //Заполняем массив символов копируя символы из строки.
            newNumber = str.ToCharArray();

            //Проверяем тип и порядок символов первых четырех элементов массива.
            if(newNumber.Length >= 4 && Char.IsLetter(newNumber[0]) &&
                Char.IsDigit(newNumber[1]) &&
                Char.IsLetter(newNumber[2]) &&
                Char.IsLetter(newNumber[3]))
            {
                //Если все соотвествует правилам задания,добавляем в строку-ответ символы из массива,
                // отрезав от него все элементы кроме первых четырех и добавляем пробел.
                answerRow += (new string(newNumber).Remove(4));
                answerRow += (" ");

                //Затем преобразуем входную строку, присваивая ей все символы кроме первых четырех элементов.
                str = new string(newNumber).Remove(0,4);
            }

            //Проверяем тип и порядок символов первых пяти элементов массива.
            else if(newNumber.Length >= 5 && Char.IsLetter(newNumber[0]) &&
                    Char.IsDigit(newNumber[1]) &&
                    Char.IsDigit(newNumber[2]) &&
                    Char.IsLetter(newNumber[3]) &&
                    Char.IsLetter(newNumber[4]))
            {
                //Если все соотвествует правилам задания,добавляем в строку-ответ символы из массива,
                // отрезав от него все элементы кроме первых пяти и добавляем пробел.
                answerRow += (new string(newNumber).Remove(5));
                answerRow += (" ");

                //Затем преобразуем входную строку, присваивая ей все символы кроме первых пяти элементов.
                str = new string(newNumber).Remove(0,5);
            }
            //Если оба предыдущих варианта невозможны, добавляем в строку ответ знак '-' и выходим из цикла.
            else
            {
                answerRow = ("-");
                break;
            }  
        } 
    }
    //Добавляем строку-ответ в массив строк.
    answers.Add(answerRow);
}
//Выводим в терминал все элементы массива строк.
foreach(string element in answers)
{
    Console.WriteLine(element);
}