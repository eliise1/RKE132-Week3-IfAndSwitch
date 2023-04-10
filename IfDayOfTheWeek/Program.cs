
int weekDay = Convert.ToInt32(DateTime.Now.DayOfWeek);

if(weekDay == 0 )
{
    Console.WriteLine("Iy's Sunday!");
}
else if(weekDay == 1 )
{
    Console.WriteLine("Iy's Monday!");
}
else if(weekDay == 2 )
{
    Console.WriteLine("Iy's Tuesday!");
}
else if(weekDay == 3 )
{
    Console.WriteLine("Iy's Wednesday!");
}
else if(weekDay == 4 )
{
    Console.WriteLine("Iy's Thursday!");
}
else if(weekDay == 5 )
{
    Console.WriteLine("Iy's Friday!");
}
else if(weekDay == 6 )
{
    Console.WriteLine("Iy's Saturday!");
}

Console.WriteLine("Have a nice day!");
