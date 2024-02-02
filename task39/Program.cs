
// Нужно найти самое часто встречающееся слово в тексте.
// Текст должен содержать не более 1000 символов. Вывод должен быть в UPPER CASE (верхний регистр).
// Написать функцию void mostRecent(char *text,char *word).

Console.WriteLine("Введите строку: ");
string text = Console.ReadLine();
int count = 0;
int temp = 0;
MostRecent(text);

void MostRecent(string text)
{
Dictionary<string, int> wordFrequency = new Dictionary<string, int>();
string[] words = text.Split(new char[] { ' ', '.', ',', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

foreach (string word in words)
{
    string lowerWord = word.ToLowerInvariant();
    if (wordFrequency.ContainsKey(lowerWord))
    {
        wordFrequency[lowerWord]++;
    }
    else
    {
        wordFrequency[lowerWord] = 1;
    }
}

foreach (var item in wordFrequency)
{
    var mostFrequent = wordFrequency.OrderByDescending(pair => pair.Value).FirstOrDefault();


    if (mostFrequent.Value == 1 && count == 0)
    {
        Console.WriteLine("Не одно слово не встречается чаще других");
        return;
    }
    else
    {
    if(count > 0 && temp == mostFrequent.Value)
    {
        Console.WriteLine("Самое часто встречающееся слово: " + mostFrequent.Key.ToUpperInvariant());
        Console.WriteLine("Число повторений в тексте: " + mostFrequent.Value);
    }
    if(count == 0)
    {
        Console.WriteLine("Самое часто встречающееся слово: " + mostFrequent.Key.ToUpperInvariant());
        Console.WriteLine("Число повторений в тексте: " + mostFrequent.Value);
        temp = mostFrequent.Value;
        count++;
    }
        
    }
    wordFrequency.Remove(mostFrequent.Key);
}
}
