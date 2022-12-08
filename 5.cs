int age;

do
{   
    Console.WriteLine("Yasinizi daxil edin");
    age = Convert.ToInt32(Console.ReadLine());
    if (age<1||age>100)
    {
        Console.WriteLine("Yasinizi duzgun daxil edin");
    }
    
} while (age<1||age>100);
if (age<18)
{
    Console.WriteLine(18-age +" " + "ile ala bilersiniz");
}
else
{
    Console.WriteLine("Suruculuk vesiqesini ala bilersiniz");
}