// Worshop 4: Array

string[] studentNames = new string[] { "Regis", "Brayan", "Farida", "Priscile" };

string[] matricules = new string[4];

matricules[0] = "12U0434";
matricules[1] = "25U0931";
matricules[2] = "19B1234";
matricules[3] = "22T0621";

int[] idStudents = new int[4];

// remplissage des index.
for (int index = 0; index < idStudents.Length; index++)
{
    idStudents[index] = index;
}

// affichage des noms
Console.WriteLine("Affichage des noms des etudiants");
for (int index = 0; index < studentNames.Length; index++)
{
    Console.WriteLine(studentNames[index]);
}

// affichage id, students, matricules et names
Console.WriteLine("Les id, les matricules et les noms");
for (int index = 0; index < studentNames.Length; index++)
{
    Console.WriteLine(idStudents[index] + " " + matricules[index] + ": " + studentNames[index]);
}

// autre declaration
int[] numbers = { 1, 2, 3, 4, 5 };

// utilisation du foreach

Console.WriteLine("Affichage des nombres");
foreach(int num in numbers)
{
    Console.WriteLine(num);
}

// les classes de base des arrays

// CopyTo
string[] studentNamesCopy = new string[studentNames.Length]; ;
studentNames.CopyTo(studentNamesCopy,0);

foreach(string name in studentNamesCopy)
{
    Console.WriteLine(name);
}

// Sort

int[] unOrderNumbers = { 3, 5, 3, 1, 0, 2, 5 };
Console.WriteLine("Unordered Numbers");
Array.Sort(unOrderNumbers);
Console.WriteLine("Ordered Numbbers");
foreach (int num in unOrderNumbers)
{
    Console.WriteLine(num);
}

// reserver
Array.Reverse(unOrderNumbers);