using System;

public delegate int GearChange(int n);

public class Car
{
    private string  name;
    private string  colors;
    private string  AutoGear;
    private string  carKinds;
    private int     gear;
    private int     carqty;

    public static int Count = 0;
    public static int PringCount()
    {
        Console.WriteLine("현재 차 개수: " + Count + " 대");
        return Count;
    }

	public Car()
	{
        name = "";
        colors = "";
        gear = 0;
        carKinds = "";
        carqty = 1;
        Count++;
	}
}
