/*Задача 21
Напишите программу, которая принимает на вход координаты 
двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

void GetDistanceBetweenThreePoints(int fstX, int secX, int fstY, int secY, int fstZ, int secZ)
{
    double result = 0;
    double TempX = Math.Pow(secX - fstX, 2); 
    double TempY = Math.Pow(secY - fstY, 2);
    double TempZ = Math.Pow(secZ - fstZ, 2);
    result = Math.Sqrt(TempX + TempY + TempZ);
    Console.WriteLine();
    Console.WriteLine($"Расстояние между двумя точками в 3D {result}");
    Console.WriteLine();    
}
GetDistanceBetweenThreePoints(3, 2, 6, 1, 8, -7);
GetDistanceBetweenThreePoints(7, 1, -5, -1, 0, 9);
