// See https://aka.ms/new-console-template for more information




Person svein = new Person("Svein", 23);


Console.WriteLine(svein.getNavn());











/*
using System.ComponentModel.DataAnnotations;
const int min = 0;
const int max = 2;


int menu = -1;
do{
    Console.WriteLine("----------------");
    Console.WriteLine("0 - Exit");
    Console.WriteLine("1 - Greeting");
    Console.WriteLine("2 - Joke");
    string input = Console.ReadLine();
    try{
        menu = Int32.Parse(input);
    }catch(FormatException e){
        Console.WriteLine("Only accept a number entry! (" + min + "-" + max + ")");
        continue;
    }
    switch(menu){
        case 0:
            break;
        case 1:
            Console.WriteLine("Hey");
            break;
        case 2:
            Console.WriteLine("joke");
            break;
        default:
            Console.WriteLine("Invalid selection, only " + min + "-" + max);
            break;
    }
}while(menu != 0);


Console.WriteLine("Bye");*/