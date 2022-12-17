// Console.WriteLine("Input first number");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input second number");
// int b = Convert.ToInt32(Console.ReadLine());

// int quad = b * b;

// if(quad == a)
// {
//     Console.WriteLine($"{a} is quad of {b}");
// }
// else
// {
//   Console.WriteLine($"{a} is not quad of {b}");  
// }

// int DeleteNumber (int num)// 456
// {
//     int sot = num / 100 ;
//     int ed  = num % 10;
//     return sot*10 + ed;

// }

// int randomNumber = new Random().Next(100,1000);
// Console.WriteLine(randomNumber);
// int result = DeleteNumber(randomNumber);
// Console.WriteLine(result);

// int kratnost ( int num1, int num2);
// {
//     if (num1 % num2 = 0)
//     Console.WriteLine
// } 

// Console.Clear();

// // 1 задание
// int max = 0;
// int min = 0;

// Console.Write("Введите первое число:");
// int firstNumber =
// Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите второе число");
// int secondNumber =
// Convert.ToInt32(Console.ReadLine());

// if (firstNumber > secondNumber) max = firstNumber;
// if (secondNumber<firstNumber) min=secondNumber;

// Console.WriteLine("max="+max+"min="+min);


// Задание 2

// int max = 0;

// Console.Write("Введите первое число:");
// int firstNumber = Convert.ToInt32(Console.ReadLine());


// Console.Write("Введите второе число:");
// int secondNumber = Convert.ToInt32(Console.ReadLine());


// Console.Write("Введите третье число:");
// int thirdNumber = Convert.ToInt32(Console.ReadLine());


// if (firstNumber > max) max = firstNumber;
// if (secondNumber > max) max = secondNumber;
// if (thirdNumber > max) max = thirdNumber;

// Console.WriteLine( "max ="+max);


// Задание 3

// Console.Write("Write number:");
// int number = Convert.ToInt32( Console.ReadLine() );

// int remDiv = number%2;

// if (remDiv == 0)
//  {
//     Console.WriteLine("Yes");
//  }
// else
// {
//     Console.WriteLine("No");
// }



// Задание 4


Console.Write("Введите число:");
int num = Convert.ToInt32(Console.ReadLine());


int evennum = 2;
if (num > 1)
{
    while (evennum <= num)
    { 
        
        Console.Write(evennum+"");
        evennum = evennum + 2;
    }
}