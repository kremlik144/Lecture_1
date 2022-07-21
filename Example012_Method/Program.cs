// 1 вид методов - ничего не возращают и ничего не принимают 

void Method1()
{
    Console.WriteLine("Автор .....");
}
//Method1(); - вызов







// 2 вид методов - ничего не возращают, но принимают какие то аргументы 

void Method2(string msg)
{
    Console.WriteLine(msg);
}
//Method2("Текст метода 2");


void Method21(string msg, int count)
{
    int i = 0;
    while(i < count)
    {
        Console.WriteLine(msg);
        i++;
    }   
}
//Method21(msg: "Текст метода 2", count: 2);  // так 
//Method21("Текст метода 2", 2);             // или так, можно не по порядку






// 3 вид методов - что то возращают, но ничего не принимают

int Method3()
{
    return DateTime.Now.Year;
}
//int year = Method3();
//Console.WriteLine(year);





// 4 вид методов - что то принимают и что то возращают

string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty;

    while(i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}

//string res = Method4(4, "abc+");
//Console.WriteLine(res);

string Method41(int count, string text)         // цикл for
{
    string result = String.Empty;

    for(int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}

string res = Method41(4, "z+");
Console.WriteLine(res);





// Цикл вложенный в цикл

for(int i = 2; i <= 10; i++)
{
    for(int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i*j}");
    }
    Console.WriteLine();
}