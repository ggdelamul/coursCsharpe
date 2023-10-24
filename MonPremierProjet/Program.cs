// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("J'apprend le c#");


//variable en c#
string nom = "jhon";
int age = 25;
bool isAlive = true;
age=12;
Console.WriteLine(nom);
Console.WriteLine(age);
Console.WriteLine(isAlive);
//constante en csharpe
// const string prenom ="doe";
//recuperer une valeur 
var saisie = Console.ReadLine();

//pour définir un caractère unique
//simple quote pour char 
// char a = 'a';
// char apostrophe ='\'';

char  copyright ='\u00A9';
Console.WriteLine(copyright);
string chemin = @"C:\docs\fichiers.txt";
string bonjour = $"Bonjour {nom}";

Console.WriteLine(bonjour);