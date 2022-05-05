/* 
Открыть терминал на полный экран.
По X максимальное 25
По Y максимальное 15
*/
 
Console.Write("Введите X: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Y: ");
int y = Convert.ToInt32(Console.ReadLine());


Console.Clear();
int lineX = 1, maxX = 100;
int lineY = 15, maxY = 30;
// Console.SetCursorPosition(x, y);
// Console.Write("*");
void CoordinateX(int pointX, int pointY)

{
    while (pointX < maxX)
    {
        if (pointX != maxX / 2)
        {

            Console.SetCursorPosition(pointX, pointY);
            Console.Write("_");
        }
        else
        {
            Console.SetCursorPosition(pointX, pointY);
            Console.Write("|");
        }
        pointX++;
    }
}

void CoordinateY(int pointX, int pointY)

{
    pointY = 1;
    pointX = maxX / 2;
    while (pointY < maxY)
    {
        /*if (pointY != maxY/2)
        {

            Console.SetCursorPosition(pointX, pointY);
            Console.Write("_");
        }
        else*/
        {
            Console.SetCursorPosition(pointX, pointY);
            Console.Write("|");
        }
        pointY++;
    }
}

void Point(int x, int y) 
{
    x = (x*2)+(maxX/2);
    y = (maxY/2)-y;
    Console.SetCursorPosition(x,y);
    Console.Write(".");
}

CoordinateX(lineX, lineY);
CoordinateY(lineX, lineY);
Point(x,y);
Console.SetCursorPosition(maxX,maxY);
Console.WriteLine();

