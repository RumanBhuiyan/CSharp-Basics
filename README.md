## C# Basics

> ## [hackerrank certificate](https://www.hackerrank.com/certificates/bc6935f64953)
> <img src="https://github.com/RumanBhuiyan/CSharp-Basics/blob/main/Certificates/certificate.png" /> <br>

> ## Hello World
```csharp
      // to use different classes of System namespace
      using System;

      // namespace is a Container of classes
      namespace ConsoleApp1
      {
          class Program
          {
              static void Main(string[] args)
              {
                  // printing output without a newline after output
                  Console.Write("Hello ");
                  Console.Write("World\n");

                  // printing newline after printing output
                  Console.WriteLine("Happy Coding");
                  Console.WriteLine("C# Journey");
              }
          }
      }
```
> ## Variables and Data Types
```csharp
      using System;

      namespace ConsoleApp1
      {
          class Program
          {
              static void Main(string[] args)
              {
                  // variables
                  string name = "Bangladesh";
                  int age = 42;
                  double number = 2.5;
                  char letter = 'c';
                  bool flag = true;
                  const double PI = 3.1416;

                  Console.WriteLine("Name : " + name);
                  Console.WriteLine("Age : " + age);
                  Console.WriteLine("Number : " + number);
                  Console.WriteLine("Letter : " + letter);
                  Console.WriteLine("flag : " + flag);
                  Console.WriteLine("Constant PI : "+PI);
              }
          }
      }
```
> ## Type Casting and Type Conversion
```csharp
      using System;

      namespace ConsoleApp1
      {
          class Program
          {
              static void Main(string[] args)
              {
                  double number = 5.6;
                  // explicit type casting
                  Console.WriteLine("Integer value : " + (int)number);


                  int myInt = 10;
                  double myDouble = 5.25;
                  bool myBool = true;

                  // type conversion
                  Console.WriteLine(Convert.ToString(myInt));    // convert int to string
                  Console.WriteLine(Convert.ToDouble(myInt));    // convert int to double
                  Console.WriteLine(Convert.ToInt32(myDouble));  // convert double to int
                  Console.WriteLine(Convert.ToString(myBool));   // convert bool to string

              }
          }
      }
```
> ## User Input
```csharp
      using System;

      namespace ConsoleApp1
      {
          class Program
          {
              static void Main(string[] args)
              {
                  // Taking User Input
                  Console.Write("Enter the first number: ");
                  int first = Convert.ToInt32(Console.ReadLine());

                  Program prog = new Program();
                  Console.WriteLine("The factorial is : "+prog.getFactorial(first));



              }
              public int getFactorial(int number)
              {
                  return number == 1 ? 1 : number * getFactorial(number - 1);
              }
          }
      }
```
> ## Math Library Functions
```csharp
      using System;

      namespace ConsoleApp1
      {
          class Program
          {
              static void Main(string[] args)
              {
                  // Math library functions 
                  Console.WriteLine("Max between two numbers: " + Math.Max(2, 3));
                  Console.WriteLine("Min between two numbers: " + Math.Min(2, 3));
                  Console.WriteLine("Root of a number: " + Math.Sqrt(25));
                  Console.WriteLine("Max between two numbers: " + Math.Max(2, 3));
                  Console.WriteLine("Abs of a number: " + Math.Abs(-4));

              }

          }
      }
```
> ## String methods and Interpolation
```csharp
      using System;

      namespace ConsoleApp1
      {
          class Program
          {
              static void Main(string[] args)
              {
                  // String library functions 
                  string name = "Bangladesh";

                  Console.WriteLine("Length of a string: "+name.Length);
                  Console.WriteLine("UpperCase string: "+name.ToUpper());
                  Console.WriteLine("Lowercase string: "+name.ToLower());

                  // String Interpolation
                  string sentence = $"My Country is {name}";
                  Console.WriteLine(sentence);

              }

          }
      }
```
> ## Conditional Statements
```csharp
      using System;

      namespace ConsoleApp1
      {
          class Program
          {
              static void Main(string[] args)
              {
                  Console.Write("Enter the number: ");
                  int number = Convert.ToInt32(Console.ReadLine());

                  // Conditional Statements
                  // Ternary Opetator 
                  bool isPositive = number > 0 ? true : false;
                  Console.WriteLine("Number is " + (isPositive ? "positive" : "negative"));

                  // if-else ladder 
                  if (number > 0)
                  {
                      Console.WriteLine("Number is Positive");
                  }else if (number < 0)
                  {
                      Console.WriteLine("Number is Negative");
                  }else
                  {
                      Console.WriteLine("Number is zero");
                  }

                  //Switch Statement 
                  int checking = number > 0 ? 1 : number < 0 ? 2 : 3;

                  switch (checking)
                  {
                      case 1:
                          Console.WriteLine("Number is Postive");
                          break;
                      case 2:
                          Console.WriteLine("Number is Negative");
                          break;
                      default:
                          Console.WriteLine("Number is zero");
                          break;
                  }

              }

          }
      }
```
> ## Looping 
```csharp
      using System;
      using System.Linq; // using to sort array,finding min max of array

      namespace ConsoleApp1
      {
          class Program
          {
              static void Main(string[] args)
              {
                  // Looping 
                  // while loop
                  int i = 0;
                  while (i<5)
                  {
                      Console.WriteLine("i = "+(i+1));
                      i++;
                  }

                  // do while loop
                  int j = 5;
                  do
                  {
                      Console.WriteLine("j = " + (j));
                      j--;
                  } while (j>0);

                  // for loop 
                  for (int k = 6; k<10; k++)
                  {
                      Console.WriteLine("k = "+(k));
                  }

                  // for each loop 
                  int[] numbers = { 3,4,1,2,5};
                  // Sorting array elements
                  Array.Sort(numbers);

                  foreach (int num in numbers)
                  {
                      Console.WriteLine(num);
                  }

              }

          }
      }
```
> ## Functions and Method Overloading 
```csharp
      using System;

      namespace ConsoleApp1
      {
          class Program
          {
              static void Main(string[] args)
              {
                  // using static methods or functions
                  Console.WriteLine("Summation between 1,100: " + getSumBetween(1, 100));
                  Console.WriteLine("Summation between 0 to 50: "+getSumBetween(50));

              }
              static int getSumBetween(int start, int end)
              {
                  int summation = 0;

                  while (start <= end)
                  {
                      summation += start;
                      start++;
                  }
                  return summation;
              }

              // method overloading 
              static int getSumBetween(int number)
              {
                  int summation = 0;

                  while (number >0)
                  {
                      summation += number;
                      number--;
                  }
                  return summation;
              }

          }
      }
```
> ## Class and Objects
```csharp
      using System;

      namespace ConsoleApp1
      {
          class Program
          {
              double length;
              double width; 
              static void Main(string[] args)
              {

                  Program prog = new Program();
                  prog.setLength(4);
                  prog.setWidth(5);

                  Console.WriteLine("Length is : "+prog.getLength());
                  Console.WriteLine("Width is : "+prog.getWidth());
                  Console.WriteLine("Area is "+prog.getArea());
              }
              public Program()
              {
                  this.length = 0;
                  this.width = 0;
              }
              public void setLength(double len)
              {
                  this.length = len;
              }
              public double getLength()
              {
                  return this.length;
              }
              public void setWidth(double wid)
              {
                  this.width = wid;
              }
              public double getWidth()
              {
                  return this.width;
              }
              public double getArea()
              {
                  return this.length * this.width;
              }
          }
      }
```
> ## Inheritance 
```csharp
      using System;

      namespace ConsoleApp1
      {
          // Program class is inheriting Circle class where
          // parent class is Circle and Derived class is Program
          class Program : Circle
          {
              static void Main(string[] args)
              {
                  // Inheritance 
                  Program prog = new Program();
                  prog.setRadius(2.5);

                  Console.WriteLine("Radius is : "+prog.getRadius());
                  Console.WriteLine("Circle area is : "+prog.getArea());

              }

          }

          // if you use sealed keyword before any class then other class cant
          // inherit it

          class Circle
          {
              private double radius;
              public Circle()
              {
                  this.radius = 0;
              }
              public void setRadius(double radius)
              {
                  this.radius = radius;
              }
              public double getRadius()
              {
                  return this.radius;
              }
              public double getArea()
              {
                  return Math.PI * (Math.Pow(this.radius, 2));
              }
          }

      }
```
> ## Abstraction
```csharp
      using System;

      namespace ConsoleApp1
      {
          // Program class is implementing or overriding methods of
          // abstract class Circle
          class Program : Circle
          {
              private double radius;
              static void Main(string[] args)
              {
                  // Inheritance 
                  Program prog = new Program();
                  prog.setRadius(2.5);

                  Console.WriteLine("Radius is : "+prog.getRadius());
                  Console.WriteLine("Circle area is : "+prog.getArea());

              }
              // Implementing or overrding abstract class methods 
              public override void setRadius(double radius)
              {
                  this.radius = radius;
              }
              public override double getRadius()
              {
                  return this.radius;
              }
              public override double getArea()
              {
                  return Math.PI * (Math.Pow(this.radius,2));
              }

          }

           abstract class Circle
          {
              public abstract void setRadius(double radius);
              public abstract double getRadius();
              public abstract double getArea();
          }

      }
```
> ## Interface
```csharp
      using System;

      namespace ConsoleApp1
      {
          // Implementing Circle Interface 
          class Program : Circle
          {
              private double radius;
              static void Main(string[] args)
              {

                  Program prog = new Program();
                  prog.setRadius(2.5);

                  Console.WriteLine("Radius is : "+prog.getRadius());
                  Console.WriteLine("Circle area is : {0:F3}",prog.getArea());

              }
              // Implementing interface methods
              public void setRadius(double radius)
              {
                  this.radius = radius;
              }
              public double getRadius()
              {
                  return this.radius;
              }
              public  double getArea()
              {
                  return Math.PI * (Math.Pow(this.radius,2));
              }

          }

          interface Circle
          {
               void setRadius(double radius);
               double getRadius();
               double getArea();
          }

      }
```
> ## Exception Handling 
```csharp
      using System;

      namespace ConsoleApp1
      {
          // Exception Handling 
          class Program 
          {
              static void Main(string[] args)
              {
                  Console.Write("Enter first number: ");
                  double first = Convert.ToDouble(Console.ReadLine());

                  Console.Write("Enter second number: ");
                  double second = Convert.ToDouble(Console.ReadLine());

                  Console.WriteLine("Quotient is " +getQuotient(first,second));
              }

              static double getQuotient(double first,double second)
              {
                  double result = 0;
                  bool isAnyProblem = false;

                  try
                  {
                      if (second == 0)
                      {
                          isAnyProblem = true;
                          result = 0;
                      }else
                      {
                          result = first / second;
                      }
                  }
                  catch (Exception e)
                  {
                      Console.WriteLine(e);
                  }
                  finally
                  {
                      if (isAnyProblem)
                      {
                          Console.WriteLine("Cant't divide by 0");
                      }
                  }
                  return result;
              }

          }

      }
```
> ## Indexers
```csharp
      using System;

      namespace ConsoleApp1
      {
          //Indexers is creating virtual array 
          class Program 
          {
              static void Main(string[] args)
              {
                  Program prog = new Program();

                  // using setter here
                  prog[0] = "C";
                  prog[1] = "C++";
                  prog[2] = "Java";
                  prog[3] = "C#";

                  // using getter here 
                  Console.WriteLine(prog[2]);

              }

              public string[] names = new string[5];

              public string this[int index]
              {
                  get
                  {
                      return names[index];
                  }
                  set
                  {
                      names[index] = value;
                  }
              }


          }

      }
```
> ## ArrayList
```csharp
      using System;
      using System.Collections; // for using ArrayList

      namespace ConsoleApp1
      {
          //ArrayList of Collection 
          class Program 
          {
              static void Main(string[] args)
              {
                  ArrayList numbers = new ArrayList();

                  numbers.Add(3);
                  numbers.Add(2);
                  numbers.Add(1);
                  numbers.Add(4);
                  numbers.Add(5);

                  // sorting 
                  numbers.Sort();

                  Console.WriteLine("Capacity: "+numbers.Capacity);
                  Console.WriteLine("Count: "+numbers.Count);
                  Console.WriteLine("Third elememnt: "+numbers[2]);
              }
          }

      }
```
> ## HashTable 
```csharp
      using System;
      using System.Collections; // for using ArrayList

      namespace ConsoleApp1
      {
          //HashTable of Collection 
          class Program 
          {
              static void Main(string[] args)
              {
                  Hashtable myDictionary = new Hashtable();

                  myDictionary.Add("first", "C");
                  myDictionary.Add("second", "C++");
                  myDictionary.Add("third", "Java");
                  myDictionary.Add("fourth", "C#");

                  // Accessing values
                  Console.WriteLine("first value : "+myDictionary["first"]);

                  // Iterating over items
                  foreach (string key in myDictionary.Keys)
                  {
                      Console.WriteLine("Key : " +key+" value : "+myDictionary[key]);
                  }
              }
          }

      }
```
> ## Stack
```csharp
      using System;
      using System.Collections;

      namespace ConsoleApp1
      {
          //Stack of Collection 
          class Program 
          {
              static void Main(string[] args)
              {
                  Stack numbers = new Stack();

                  // pushing into stack
                  numbers.Push(2);
                  numbers.Push(3);
                  numbers.Push(1);
                  numbers.Push(5);
                  numbers.Push(4);

                  Console.Write("Before Poping: ");
                  showItems(numbers);

                  // numbers.Peek() returns last inserted item but dont remove it
                  // numbers.Pop() returns and remove last inserted item
                  int last_item = (int)numbers.Pop();

                  Console.WriteLine("Last item : "+last_item);
                  Console.Write("After poping: ");
                  showItems(numbers);
              }
              static void showItems(Stack keep)
              {
                  foreach (int item in keep)
                  {
                      // reading items from top of stack to bottom of stack
                      Console.Write(item + " ");
                  }
                  Console.WriteLine();
              }
          }

      }
```
> ## Queue
```csharp
      using System;
      using System.Collections;

      namespace ConsoleApp1
      {
          //Queue of Collection 
          class Program 
          {
              static void Main(string[] args)
              {
                  Queue numbers = new Queue();

                  // Adding items at last sequentially into Queue
                  numbers.Enqueue(2);
                  numbers.Enqueue(3);
                  numbers.Enqueue(1);
                  numbers.Enqueue(5);
                  numbers.Enqueue(4);

                  Console.Write("Before Poping: ");
                  showItems(numbers);

                  // numbers.Dequeue() returns and remove first inserted item
                  int first_item = (int)numbers.Dequeue();

                  Console.WriteLine("first item : "+first_item);
                  Console.Write("After Dequeing: ");
                  showItems(numbers);
              }
              static void showItems(Queue keep)
              {
                  foreach (int item in keep)
                  {

                      Console.Write(item + " ");
                  }
                  Console.WriteLine();
              }
          }

      }
```
