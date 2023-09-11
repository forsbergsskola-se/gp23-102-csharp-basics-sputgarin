
/*
Implicit and Explicit Casting:
Use casting (explicit or implicit) when converting between compatible data types, 
such as from smaller integral types to larger ones (e.g., int to long) or from derived classes to base classes.
Explicit casting is required when there's a possibility of data loss or when converting from larger to smaller data types 
(e.g., double to int).
 */
double doubleValue = 5.56f;
int intValue = (int)doubleValue; // Explicit cast. Loose data the output will  be 5.
long longValue = intValue; // Implicit cast. No loss of data.
float floatValue = intValue; // Implicit cast. No loss of data.


/*
Parse Methods:
Use parse methods like int.Parse(), double.Parse(), or DateTime.Parse() 
when converting strings to primitive data types.
 These methods throw exceptions if the conversion fails, so use them when you expect valid input.
 */
string strValue = "42";
int intValue2 = int.Parse(strValue);
 
/*
TryParse Methods:
Use int.TryParse(), double.TryParse(), etc., 
when converting strings to primitive data types if there's a possibility of invalid input.
These methods return a Boolean indicating success and store the result in an out parameter.*/
string strValue3 = "42";
int intValue3;
if (int.TryParse(strValue3, out intValue3))
{
 Console.WriteLine("YAY");// Conversion succeeded
}
else
{
 Console.WriteLine("NAY"); // Conversion failed
}

// Use classes like Convert for standard conversions between built-in types.
int intValue4 = Convert.ToInt32(doubleValue);