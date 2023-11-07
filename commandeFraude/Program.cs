/*Déclarez un tableau et initialisez-le pour qu’il contienne les éléments suivants :
B123
C234
A345
C15
B177
G3003
C235
B179
Créez une instruction foreach pour parcourir chaque élément de votre tableau.
Signalez les ID de commande qui commencent par la lettre « B »
utilisez la méthode String.StartsWith()

*/
string [] numCommandes  = {"B123","C234","A345","C15","B177","G3003","C235", "B179"};

foreach(string oneCommande in numCommandes )
{
    if(oneCommande.StartsWith("B"))
    {
        Console.WriteLine(oneCommande);
    }
}