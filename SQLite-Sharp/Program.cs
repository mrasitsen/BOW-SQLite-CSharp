// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string? userName = Console.ReadLine();

if (string.IsNullOrEmpty(userName)){
    Console.WriteLine("I Dont know who you are!");
}else{
    Console.WriteLine("Ohhh Hello " + userName);
}

Thread.Sleep(10000);
