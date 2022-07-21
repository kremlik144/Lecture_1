
// Работа с текстом 

// Дан текст. В тексте нужно все пробелы заменить черточками,
// буквы (к) заменить (К), буквы (с) на (С)

string text = "- Я думаю, - сказал князь, улыбаясь, - что, "
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля. "
            + "Вы так красноречивы. Вы дадите мне чаю?";

// string s = "qerty"
//             01234
// s[3] = r

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    int length = text.Length;

    for(int i = 0; i < length; i++)
    {
        if(text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";

    }
    return result;
}
string newText1 = Replace(text, ' ', '_');
Console.WriteLine(newText1);
Console.WriteLine();

string newText2 = Replace(newText1, 'к', 'К');
Console.WriteLine(newText2);
Console.WriteLine();

string newText3 = Replace(newText2, 'с', 'С');
Console.WriteLine(newText3);
Console.WriteLine();