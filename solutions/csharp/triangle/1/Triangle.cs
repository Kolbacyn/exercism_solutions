public static class Triangle
{
    public static bool IsScalene(double side1, double side2, double side3) =>
        !CheckZero(side1, side2, side3) &&
        CheckSums(side1, side2, side3) &&
        side1 != side2 && side2 != side3 && side1 != side3;
    
    public static bool IsIsosceles(double side1, double side2, double side3) =>
        !CheckZero(side1, side2, side3) &&
        CheckSums(side1, side2, side3) &&
        (side1 == side2 || side2 == side3 || side1 == side3);

    public static bool IsEquilateral(double side1, double side2, double side3) =>
        !CheckZero(side1, side2, side3) &&
        CheckSums(side1, side2, side3) &&
        side1 == side2 && side2 == side3;

    public static bool CheckZero(double side1, double side2, double side3) =>
        side1 == 0 || side2 == 0 || side3 == 0;

    public static bool CheckSums(double side1, double side2, double side3) =>
        side1 + side2 > side3 && side1 + side3 > side2 && side2 + side3 > side1;
}