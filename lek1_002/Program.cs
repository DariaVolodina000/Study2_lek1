Console.WriteLine("Введите номер дня");
string[] week = new string [] {"Понедельник", "Вторник" , "Среда", "Четверг", "Это ПЯТНИЦА!", "Суббота", "Воскресенье"};
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(week [num-1]);




