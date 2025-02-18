// Arithmetic Operators
int a = 10;
int b = 5;

int sum = a + b;        // Addition
int difference = a - b; // Subtraction
int product = a * b;    // Multiplication
int quotient = a / b;   // Division
int remainder = a % b;  // Modulus

Console.WriteLine($"Sum: {sum}, Difference: {difference}, Product: {product}, Quotient: {quotient}, Remainder: {remainder}");

//Rational Operators
bool isEqual = a == b;       // Equal to
bool isNotEqual = a != b;    // Not equal to
bool isGreater = a > b;      // Greater than
bool isLess = a < b;         // Less than
bool isGreaterOrEqual = a >= b; // Greater than or equal to
bool isLessOrEqual = a <= b;    // Less than or equal to

Console.WriteLine($"Equal: {isEqual}, Not Equal: {isNotEqual}, Greater: {isGreater}, Less: {isLess}, Greater or Equal: {isGreaterOrEqual}, Less or Equal: {isLessOrEqual}");

//Logical Operators
bool x = true;
bool y = false;

bool and = x && y; // Logical AND
bool or = x || y;  // Logical OR
bool not = !x;     // Logical NOT

Console.WriteLine($"AND: {and}, OR: {or}, NOT: {not}");

//Bitwise Operators
int c = 6;  // 110 in binary
int d = 3;  // 011 in binary

int bitwiseAnd = c & d; // Bitwise AND
int bitwiseOr = c | d;  // Bitwise OR
int bitwiseXor = c ^ d; // Bitwise XOR
int bitwiseNot = ~c;    // Bitwise NOT
int leftShift = c << 1; // Left shift
int rightShift = c >> 1; // Right shift

Console.WriteLine($"Bitwise AND: {bitwiseAnd}, Bitwise OR: {bitwiseOr}, Bitwise XOR: {bitwiseXor}, Bitwise NOT: {bitwiseNot}, Left Shift: {leftShift}, Right Shift: {rightShift}");

//Assignment and Compound Assignment Operators
int e = 10;
e += 5;  // e = e + 5
e -= 3;  // e = e - 3
e *= 2;  // e = e * 2
e /= 4;  // e = e / 4
e %= 3;  // e = e % 3

Console.WriteLine($"e: {e}");

//Condtional and Null Coalescing Operator
int f = 10;
int g = 20;

string result = f > g ? "f is greater" : "g is greater"; // Conditional operator
Console.WriteLine(result);

string? nullableString = null;
string nonNullableString = nullableString ?? "Default value"; // Null-coalescing operator
Console.WriteLine(nonNullableString);

nullableString ??= "Assigned value"; // Null-coalescing assignment operator
Console.WriteLine(nullableString);
