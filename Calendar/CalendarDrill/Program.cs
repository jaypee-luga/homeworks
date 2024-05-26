using System;

// See https://aka.ms/new-console-template for more information

Console.Write("Enter Calendar Year: ");
int inputYear = 0;
int.TryParse( Console.ReadLine(), out inputYear);

//Console.WriteLine($"You have entered year: {inputYear}");

string[] MONTHS = new string[] { "JANUARY", "FEBRUARY", "MARCH", "APRIL", "MAY", "JUNE", "JULY", "AUGUST", "SEPTEMBER", "OCTOBER", "NOVEMBER", "DECEMBER"};
string[] DAYS = new string[] {"Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat"};


for(int i = 1; i <= MONTHS.Length; i++){
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine(MONTHS[i-1]);
    
    #region -- Day Headers --
    for(int j = 0; j < DAYS.Length; j++)
    {
        if(j == 0 || j == 6){
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write($"{DAYS[j]}\t");
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write($"{DAYS[j]}\t");
        }
    }
    Console.WriteLine();
    #endregion   

    //Get First Date of the Month Entry
    DateTime dt = new DateTime(inputYear, i, 1);
    
    //Get which day the month starts
    var startDay = (int)dt.DayOfWeek;

    //Get number of days in the month
    var daysInMonths = DateTime.DaysInMonth(dt.Year, dt.Month);

    //Console.WriteLine($"starting day of the month is {dt.DayOfWeek} == {startDay}");

    #region -- Print Dates --
    var daysInWeekCount = 1;
    //print preceding empty dates if any
    for(int k = 0; k < startDay; k++)
    {
        Console.Write("\t");
        daysInWeekCount++;
    }

    Console.ForegroundColor = ConsoleColor.Gray;
    for(int dayCount = 1; dayCount <= daysInMonths; dayCount++)    
    {
        //Set Date Color to Yellow when it's the weekends
        if(daysInWeekCount == 1 || daysInWeekCount == 7)
            Console.ForegroundColor = ConsoleColor.Yellow;
        else
            Console.ForegroundColor = ConsoleColor.Gray;

        Console.Write($"{dayCount}\t");
        daysInWeekCount++;
        
        //Check if we should start on the next line
        if(daysInWeekCount > 7)
        {
            Console.WriteLine();
            daysInWeekCount = 1;
        }
    }
    
    #endregion
    Console.WriteLine("\n");
}
