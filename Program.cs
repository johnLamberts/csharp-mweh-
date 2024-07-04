/* 
 Integers
*/

// int max = int.MaxValue ;
// int min = int.MinValue;
// int minModify = int.MinValue + 5;



/* 
 Double
*/

// double max = double.MaxValue ;
// double min = double.MinValue;
// // double minModify = double.MinValue + 5;

// double test = 1.0 / 4.0;

// Console.WriteLine($"The range of double is {min} to {max}");
// Console.WriteLine(test);


/* 
 Decimal
*/

// decimal max = decimal.MaxValue ;
// decimal min = decimal.MinValue;
// decimal minModify = decimal.MinValue + 5;

// // double test = 1.0 / 4.0;

// Console.WriteLine($"The range of decimal is {min} to {max}");
// Console.WriteLine(minModify);

// double a = 1.0;
// double b = 3.0;
// Console.WriteLine(a / b);

// decimal c = 1.0M;
// decimal d = 3.0M;
// Console.WriteLine(c / d);

// double radius = 2.50;

// double area = Math.PI * radius * radius;


// for (int row = 1; row < 11; row++)
//       for(char column = 'a'; column < 'k'; column++) {
//             Console.WriteLine($"The cell is ({row}, {column})");
//       } 
            

// int sum = 0;

// for (int number = 1; number < 21; number++) {
//       if(number % 3 == 0)
//       {
//             sum += number;
//       }
// }

// Console.WriteLine($"The total sum is {sum}");


// var names = new List<string> {"John", "Merry", "Donut"};

// foreach (string name in names) {
//       Console.WriteLine($"Hello, {name}!");
// }

// Console.WriteLine($"=========================");

// names.Add("Bill");
// names.Add("Maria");
// names.Remove("John");


// int index = names.IndexOf("Maria");

// if(index != -1) 
//       Console.WriteLine($"The name {names[index]} is at index {index}");
// else 
//       Console.WriteLine($"The name {names[index]} isn't at index {index}");



/*
      FIBONACCI NUMBER using List<T>
*/
// List<int> fibonacciNumbers = [];

// int a = 0, b = 1;

// fibonacciNumbers.Add(a);
// fibonacciNumbers.Add(b);

// for(int i = 2; i <= 20; i++) 
// {
//       int next = a + b;
//       fibonacciNumbers.Add(next);
//       a = b;
//       b = next;
// }

//      foreach (int num in fibonacciNumbers)
//         {
//             Console.WriteLine(num);
//         }