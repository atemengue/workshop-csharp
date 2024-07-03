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
for (int index = 0; index < studentNames.Length; index++)
{
    Console.WriteLine(studentNames[index]);
}