// Arithmetic

int x = 500;

int y = 100;

int zAdd = x + y;
Console.WriteLine("Addition 500 and 100 is " + zAdd);

int zSub = x - y;
Console.WriteLine("Subtraction 500 and 100 is " + zSub);

int zMultip = x * y;
Console.WriteLine("Multiplication 500 and 100 is " + zMultip);

int zDiv = x / y;
Console.WriteLine("Division 500 and 100 is " + zDiv);

int zMod = x % y;
Console.WriteLine("Modulus 500 and 100 is " + zMod);

Console.WriteLine("Result x++ is " + x++);

Console.WriteLine("Result x-- is " + x--);

// Assignment
// using symbol equal '=';

Console.WriteLine("\nx = 500, result " + x);

x += 50;
Console.WriteLine("x += 50, result " + x);

x = 500;
x -= 50;
Console.WriteLine("x -= 50, result " + x);

x = 500;
x /= 50;
Console.WriteLine("x /= 50, result " + x);

x = 500;
x *= 50;
Console.WriteLine("x *= 50, result " + x);

x = 500;
x %= 50;
Console.WriteLine("x %= 50, result " + x);

x = 5;
x &= 7;
Console.WriteLine("x = 5; x &= 7 is equal 101 AND 111 = 101, result " + x);

x = 5;
x |= 7;
Console.WriteLine("x = 5; x |= 7 is equal 101 OR 111 = 111, result " + x);

x = 5;
x ^= 3;
Console.WriteLine("x ^= 3 is equal to 101 NAND 11 = 110, result " + x);

x = 5;
x >>= 1;
Console.WriteLine("x >>= 1 is equal to remove 1 digit in the end of biner 101 = 10, result " + x);

x = 5;
x <<= 3;
Console.WriteLine("x <<= 3 is equal to add 3 digit of 0 zero in the end of biner 101 = 101000, or 5 * (2^3) result " + x);

// Comparison
// return boolean (true or false) comparing to variable

x = 5;
y = 7;

Console.WriteLine("\nx = 5, y = 7;");
Console.WriteLine("x == y, result " + (x == y));

Console.WriteLine("x >= y, result " + (x >= y));

Console.WriteLine("x <= y, result " + (x <= y));

Console.WriteLine("x != y, result " + (x != y));

Console.WriteLine("x > y, result " + (x > y));

Console.WriteLine("x < y, result " + (x < y));



// Logical
// && logical AND
// || logical OR
// ! logical NOT