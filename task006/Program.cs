﻿//Console.SetCursorPosition(3, 1);
//Console.WriteLine("*");

int xa = 40;
int ya = 1;
int xb = 1;
int yb = 30;
int xc = 80;
int yc = 30;

Console.SetCursorPosition(xa, ya);
Console.Write("*");

Console.SetCursorPosition(xb, yb);
Console.Write("*");

Console.SetCursorPosition(xc, yc);
Console.Write("*");

int x = xa, y = xb;

int count = 0;

while (count < 19000)
{
    int what = new Random().Next(0, 3);
    if (what == 0)
    {
        x = (x + xa) / 2;
        y = (y + ya) / 2;
    }
    if (what == 1)
    {
        x = (x + xb) / 2;
        y = (y + yb) / 2;
    }
    if (what == 2)
    {
        x = (x + xc) / 2;
        y = (y + yc) / 2;
    }
    Console.SetCursorPosition(x, y);
    Console.WriteLine("*");
    count = count + 1;
}
