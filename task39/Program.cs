
// Нужно найти самое часто встречающееся слово в тексте.
// Текст должен содержать не более 1000 символов. Вывод должен быть в UPPER CASE (верхний регистр).
// Написать функцию void mostRecent(char *text,char *word).


Console.WriteLine("Введите строку: ");
string text = Console.ReadLine();
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

var mostFrequent = wordFrequency.OrderByDescending(pair => pair.Value).FirstOrDefault();

if (mostFrequent.Value == 1)
{
    Console.WriteLine("Не одно слово не встречается чаще других");
}
else
{
    Console.WriteLine("Самое часто встречающееся слово: " + mostFrequent.Key.ToUpperInvariant());
    Console.WriteLine("Число повторений в тексте: " + mostFrequent.Value);
}
}
