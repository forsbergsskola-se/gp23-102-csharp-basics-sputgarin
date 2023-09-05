Console.WriteLine("What's your age?");
bool isChild = false;
bool isTeenager = false;
bool isGrownup = false;

int age = Convert.ToInt32(Console.ReadLine());
if (age < 13)
{
    isChild = true;
}
if (age > 12 && age < 19)
{
    isTeenager = true;
}

if (age > 18)
{
    isGrownup = true;
}

Console.WriteLine("You are a child: {0}", isChild);
Console.WriteLine("You are a teenager: {0}", isTeenager);
Console.WriteLine("You are a grown-up: {0}", isGrownup);