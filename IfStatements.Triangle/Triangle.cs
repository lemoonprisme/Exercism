﻿namespace IfStatements.Triangle;

public static class Triangle
{
    public static bool IsTriangle(double a, double b, double c)
    {
        return (a + b) >= c && (b + c) >= a && (a + c) >= b && (a != 0 || b != 0 || c != 0);
    }

    public static bool IsScalene(double side1, double side2, double side3)
    {
        if(Triangle.IsTriangle(side1, side2, side3)) 
            return side1 != side2 && side2 != side3 && side1 != side3;
        return false;
    }

    public static bool IsIsosceles(double side1, double side2, double side3) 
    {
        if(Triangle.IsTriangle(side1, side2, side3)) 
            return side1 == side2 || side2 == side3 || side1 == side3;
        return false;
    }

    public static bool IsEquilateral(double side1, double side2, double side3) 
    {
        if(Triangle.IsTriangle(side1, side2, side3)) 
            return side1 == side2 && side2 == side3;
        return false;
    }
}