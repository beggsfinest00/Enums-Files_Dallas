//creates three int vaules
int myBirthMonth = (int)Months.Dec;
int myBirthDay = 23;
int myBirthYear = 1997;

//makes a string vaurples with a iterpation
string myBirthDate = $"My birthday is on {myBirthMonth}/{myBirthDay}/{myBirthYear}";

//creates a file object
File.WriteAllText("myFile.txt", "This is my text file vermin!\n");
Console.WriteLine(File.ReadAllText("myFile.txt"));

//creates a file object
File.AppendAllText("myFile.txt", "WooHoo more text added to file!\n");
Console.WriteLine(File.ReadAllText("myFile.txt"));

//making a if statement with a else to copy or replace file
if (!File.Exists("newFile.txt"))
{
    File.Copy("myFile.txt", "newFile.txt");
}
else
{
    File.Replace("newFile.txt", "myFile.txt", "backupFile.txt");
}

//
File.AppendAllText("newFile.txt", myBirthDate);
Console.WriteLine(File.ReadAllText("newFile.txt"));

//creates a enum methoed of the months
enum Months
{
    Jan = 1,
    Feb,
    Mar,
    Apr,
    May,
    Jun,
    Jul,
    Aug,
    Sep,
    Oct,
    Nov,
    Dec
}