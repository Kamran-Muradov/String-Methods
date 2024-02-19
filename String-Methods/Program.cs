#region Classwork

//int[] arr = { 1, 23, 4, 5 };

//arr[1] = 100;

//List<int> datas = new() { 1, 2, 3, 4 };

//datas.Add(100); 

//string name = "Test";

//string newName = name + "salam";


//string name = "test";

//name = "salam";

//using System.Text;

//StringBuilder str = new StringBuilder("Salam");

//str.Append("sagol");

//int age = 100;

//Console.WriteLine(age.ToString().GetType());

//string surname = "test";

//Console.WriteLine(surname.Length);

//string str1 = "salam";
//string str2 = " necesiz ?";

//string result = string.Concat(str1, str2);

//Console.WriteLine(result);

//string result = "";

//string result2 = string.Empty;

//var result3 = result2 + "salam";

//string text = "Azerbaycan";

//if (string.IsNullOrEmpty(text))
//{
//    Console.WriteLine("empty");
//}
//else
//{
//    Console.WriteLine("filled");
//}

//if (string.IsNullOrWhiteSpace(text))
//{
//    Console.WriteLine("empty");
//}
//else
//{
//    Console.WriteLine("filled");
//}

//Console.WriteLine(text.ToUpper());

//Console.WriteLine(text.ToLower());

//string str1 = "    Apple";
//string str2 = "apple";

//Console.WriteLine(str1.Trim().ToLower() == str2.Trim().ToLower());

//Console.WriteLine(str1.Trim().ToLower().Equals(str2.Trim().ToLower()));

//Console.WriteLine(CheckStr(str1).Equals(CheckStr(str2)));


//string CheckStr(string str)
//{
//    return str.Trim().ToLower();
//}

//string str="This is \"Salam\" class.";

//Console.WriteLine(str);

//string message=$"Welcome to {str}";

//string authors = "Mahesh - Chand,Henry-He,Chris-Love,Raj Beniwal,Praveen Kumar";

////Console.WriteLine(authors);

//string[] authorsList = authors.Split("-");

//foreach (var item in authorsList)
//{
//    Console.WriteLine(item);
//}

//string text = "Salam Azerbaycan";

//Console.WriteLine(text.Replace("Salam","sagol"));

//string result = text.Substring(0, 5) + "...";

//Console.WriteLine(result);

//Console.WriteLine(text.Contains("Az"));

//bool Search(string text, string letter)
//{
//    var result = CheckStr(text).Contains(CheckStr(letter));
//    return result;
//}


//string CheckStr(string str)
//{
//    string result = str.Trim().ToLower();
//    return result;
//}

//Console.WriteLine("Add text");
//string text = Console.ReadLine();

//Console.WriteLine("Add search text");
//string searchext = Console.ReadLine();



//void StartSearch()
//{
//    if (Search(text, searchext))
//    {
//        Console.WriteLine("Found");
//    }
//    else
//    {
//        Console.WriteLine("NotFound");
//    }
//}

//StartSearch();
#endregion

#region Homework

//Parametr olaraq string qebul eden metod yazmalisiz. Hemin metod qebul etdiyi stringi tersine formada ekranda gostersin.
//(Cavid gelirse , ekranda divaC gorsensin).

string ReverseStr(string str)
{
    string reverse = string.Empty;

    for (int i = str.Length - 1; i >= 0; i--)
    {
        reverse += str[i];
    }
    return reverse;
}

string result = ReverseStr("Cavid");
Console.WriteLine(result);

#endregion