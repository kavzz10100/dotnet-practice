

Console.WriteLine("--------------------------------------------------------");
String fname = "kaviya";
String lname= "Mathi";
int age = 23;
float val = 23.45353f;


Console.WriteLine($"My name is {fname} and last name is {lname}");
Console.WriteLine("My age is " +  age);
Console.WriteLine(val);

Console.WriteLine("---------------------Arithmetic Operators-----------------------------------");
var a = 10;
var b = 14;
var c = a + b;

Console.WriteLine("Add of two num is  " + c);
Console.WriteLine("sub of two num is  " + (a-b));
Console.WriteLine("Multiplication of two num is  " + (a *b));
Console.WriteLine("Division of two num is  " + (b/a));
Console.WriteLine("Modulo of two num is  " + (b%a));

Console.WriteLine("---------------------Relational Operators-----------------------------------");
Console.WriteLine("GT: " + (a > b));
Console.WriteLine("GT or equal:" + (a >= b));
Console.WriteLine("LT :" + (a < b));
Console.WriteLine("LT or equal: " + (a <= b));
Console.WriteLine("Equal: " + (a == b));
Console.WriteLine("Not Equal: " + (a != b)); 




Console.WriteLine("---------------------Logical Operators-----------------------------------");
bool a1 = true, b1 = false;

if (a1 && b1)
    Console.WriteLine("a and b are true");

if (a1 || b1)
    Console.WriteLine("Either a or b is true");

if (!a1)
    Console.WriteLine("a is not true");
if (!b1)
    Console.WriteLine("b is not true"); 


Console.WriteLine("---------------------Assignment Operators-----------------------------------");
var k = 10;
k += 5;
Console.WriteLine("Add Assignment: " + k);

k -= 3;
Console.WriteLine("Subtract Assignment: " + k);

k *= 2;
Console.WriteLine("Multiply Assignment: " + k);

k /= 4;
Console.WriteLine("Division Assignment: " + k);

k %= 5;
Console.WriteLine("Modulo Assignment: " + k);

Console.WriteLine("Final value of k: " + k);


Console.WriteLine("---------------------Increment / decrement Operators-----------------------------------");
Console.WriteLine("++k returns: " + ++k);
Console.WriteLine("k++ returns: " + k++);

Console.WriteLine("Final value of k: " + k);
Console.WriteLine();


Console.WriteLine("--k returns: " + --k);
Console.WriteLine("k-- returns: " + k--);

Console.WriteLine("Final value of k: " + k);  


Console.WriteLine("---------------------Ternary Operators-----------------------------------");
var x = 10;
var y = 14;

string result = (x > y) ? "x" : "y";
Console.WriteLine(result + " is greater");
   