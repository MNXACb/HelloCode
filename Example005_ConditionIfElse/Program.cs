﻿Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "маша")
{
        Console.WriteLine("Ура-а! Это же Маша! ))");
}

else
{
    Console.Write ("Привет, ");
    Console.Write (username);
}