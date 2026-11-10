int timeBegin = 8;
int timeEnd = 20;

int lanchStart = 13;
int lanchEnd = 15;

int timeCustomer;

Console.Write("Input time your visit: ");
timeCustomer = Convert.ToInt32(Console.ReadLine());

//if(timeCustomer >= timeBegin && timeCustomer <= timeEnd)
//if(timeCustomer >= timeBegin && timeCustomer < lanchStart
//    || timeCustomer >= lanchEnd &&  timeCustomer < timeEnd)
if (timeCustomer >= timeBegin && timeCustomer <= timeEnd
    && !(timeCustomer >= lanchStart && timeCustomer < lanchEnd))
    Console.WriteLine("You will be served");
else
    Console.WriteLine("You will not be served");


int rookHor = 4, rookVert = 2;      // rook coordinate
int figureHor = 3, figureVert = 5;  // figure coordinate


if(rookHor == figureHor || rookVert == figureVert)
    Console.WriteLine("Rook fight figure");

if(Math.Abs(rookHor - figureHor) == Math.Abs(rookVert - figureVert))
    Console.WriteLine("Bishop fight figure");



int day;
Console.Write("Введите номер дня недели: ");
day = Convert.ToInt32(Console.ReadLine());

if(day == 1)
    Console.WriteLine("Понедельник");
else if(day == 2)
    Console.WriteLine("Вторник");
else if(day == 3)
    Console.WriteLine("Среда");
else if (day == 4)
    Console.WriteLine("Четверг");
else if (day == 5)
    Console.WriteLine("Пятница");
else if (day == 6)
    Console.WriteLine("Суббота");
else if (day == 7)
    Console.WriteLine("Воскресенье");
else
    Console.WriteLine("Ошибочный номер дня недели");


switch(day)
{
    case 1: 
        Console.WriteLine("Понедельник");
        break;
    case 2:
        Console.WriteLine("Вторник");
        break;
    case 3: Console.WriteLine("Среда"); break;
    case 4: 
        Console.WriteLine("Четверг");
        break;
    case 5: 
        Console.WriteLine("Пятница");
        break;
    case 6: 
        Console.WriteLine("Суббота");
        break;
    case 7: 
        Console.WriteLine("Воскресенье");
        break;
    default: 
        Console.WriteLine("Ошибочный номер дня недели");
        break;
}


