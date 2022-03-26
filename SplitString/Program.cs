string sentence = "The quick brown fox jumps over the lazy dog.";
string names = "John,Alex,Sam,Brad,Tom";
string emails = "John@Mail.com;Alex@Mail.com;Sam@Mail.com;Brad@Mail.com;Tom@Mail.com";

string[] words = sentence.Split(' ');

foreach (var item in words)
    Console.WriteLine(item);

string[] nameList = names.Split(',');

foreach (var item in nameList)
    Console.WriteLine(item);

string[] emailList = emails.Split(';');

foreach (var item in emailList)
    Console.WriteLine(item);