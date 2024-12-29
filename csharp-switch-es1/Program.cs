// dichiaro la variabile num di tipo byte 
byte num;
// chiedo all'utente di inserire un numero tra 1 e 7
Console.WriteLine("Inserisci un numero tra 1 e 7");
// leggo il numero inserito dall'utente e lo converto in byte
byte.TryParse(Console.ReadLine(), out num);

// in base al numero inserito stampo il giorno della settimana corrispondente
switch (num)
{
    case 0:
        Console.WriteLine("Sunday");
        break;
    case 1:
        Console.WriteLine("Monday");
        break;
    case 2:
        Console.WriteLine("Tuesday");
        break;
    case 3:
        Console.WriteLine("Wednesday");
        break;
    case 4:
        Console.WriteLine("Thursday");
        break;
    case 5:
        Console.WriteLine("Friday");
        break;
    case 6:
        Console.WriteLine("Saturday");
        break;
}