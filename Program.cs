//Напишите программу, которая на входе принимает два числа, а на выходе выдает, какое большее, а какое меньшее

Console.Write ("Введите чило 1   ");
string strNumber1 = Console.ReadLine(); 
int number1 = Convert.ToInt32(strNumber1);
Console.Write("Введите чило 2   ");
string strNumber2 = Console.ReadLine(); 
int number2 = Convert.ToInt32(strNumber2);
if(number1>number2)
{
Console.WriteLine("max =" + number1);
Console.WriteLine("min =" + number2);
}
else if (number2>number1)
{
Console.WriteLine("max =" + number2);
Console.WriteLine("min =" + number1);
}
else
{
Console.WriteLine("max = min =" + number1);
}
//Напишите программу, которая на входе принимает три числа, а на выходе выдает максимальное
//Вариант1
Console.WriteLine("Введите число 1   ");
string strNumber3 = Console.ReadLine(); 
int number3 = Convert.ToInt32(strNumber3);
Console.WriteLine("Введите число 2   ");
string strNumber4 = Console.ReadLine(); 
int number4 = Convert.ToInt32(strNumber4);
Console.WriteLine("Введите число 3   ");
string strNumber5 = Console.ReadLine(); 
int number5 = Convert.ToInt32(strNumber5);
if(number3>number4 & number3>number5)
{
Console.WriteLine("max =" + number3);
}
else if(number4>number3 & number4>number5)
{
Console.WriteLine("max =" + number4);
}
else if(number5>number4 & number5>number3)
{
Console.WriteLine("max =" + number5);
}

else if(number3==number4 & number3>number5)
{
Console.WriteLine("max =" + number3);
}

else if(number3==number5 & number3>number4)
{
Console.WriteLine("max =" + number3);
}
else if(number5>number4 & number4==number3)
{
Console.WriteLine("max =" + number5);
}
else if(number4>number5 & number5==number3)
{
Console.WriteLine("max =" + number4);
}
else
{
Console.WriteLine("max =" + number3);
}

//Напишите программу, которая на входе принимает три числа, а на выходе выдает максимальное
//Вариант2

Console.WriteLine("Введите число 1   ");
string strNum1 = Console.ReadLine(); 
int num1 = Convert.ToInt32(strNum1);

Console.WriteLine("Введите число 2   ");
string strNum2 = Console.ReadLine(); 
int num2 = Convert.ToInt32(strNum2);

Console.WriteLine("Введите число 3   ");
string strNum3 = Console.ReadLine(); 
int num3 = Convert.ToInt32(strNum3);

int max = num1;
if (num2>num1) max = num2;
if (num3>num2) max = num3;
Console.WriteLine("max =" + max);


//Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
//4 -> да
//-3 -> нет
//7 -> нет

Console.WriteLine("Введите любое число : ");
string strNumber6 = Console.ReadLine();
int number6 = Convert.ToInt32(strNumber6);
if (number6 % 2 == 0)
{
Console.WriteLine("Указанное число является четным");
}
else
{
Console.WriteLine("Указанное число является нечетным");
}

//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
//5 -> 2, 4
//8 -> 2, 4, 6, 8

Console.WriteLine("Введите любое число : ");
string strNumber7 = Console.ReadLine();
int number7 = Convert.ToInt32(strNumber7);
int count = 0;
while (count < number7)
{
    Console.WriteLine(count);
    count = count+2; 
}
