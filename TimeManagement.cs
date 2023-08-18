using System;
using System.Xml.Linq;
using static System.Console;
class TimeManagement
{
    static void Main()
    {

        //-----------(VARIABLES FOR IF STATEMENT)---------------------//
        const int HOUR_THRESHOLD1 = 0;
        const int HOUR_THRESHOLD2 = 1; //MAKE NAMES MORE MEANINGFUL
        const int HOUR_THRESHOLD3 = 3;
        const int HOUR_THRESHOLD4 = 5;
        const int HOUR_THRESHOLD5 = 8;

        //---------------(VARIABELS FOR EVENTS AND COMPUTATION)----------------//
       
        int Response1 = 0, Rating = 0;
        double AVGHW;
        double AvgHWTime = 0, ActivityHours = 0, HoursRatio = 0;
        string Name = "", Response = "";
 
        double TotalHours;
        //------------------(USER INPUT)-------------------//

        Write("Please enter your name:");
        Name = ReadLine();
        Clear();

        ShowWelcomeMessage (Name);

        Write("Press any key to continue:");
            ReadLine();
        Clear();
        //------------CUSTOM METHOD #1---------------//
        static void ShowWelcomeMessage(string Name)
        {
            WriteLine("|-------------------------------------------------------------------------------------------------|");
            WriteLine("  Welcome {0}!                                                                                    ", Name);
            WriteLine("| If you see this message odds are you need assistance balancing your time management.            |");
            WriteLine("| Dont worry, hopefully after answering a few questions you will walk away alot less stressed :)  |");
            WriteLine("| The following program will assist you by allowing you to keep track of homework time.           |");
            WriteLine("| These events will then be placed in order based on the day of the week.                         |");
            WriteLine("| ------------------------------------------------------------------------------------------------|");

            
        }
        //---------------------ARRAY ABOUT STRESS/How r u Feeling------------------//
        int[] feeling = { 1, 2, 3, 4, 5 };
        string[] FeelingOutput = { "You are unbeleivably stressed.", "You are very stressed.", "You are mildy stressed.", "You are somewhat stressed.", "You seem unphased by stress, to be honest you probably dont need to use this app." };

        bool isValidFeeling = false;
        int StressLevel;
        string FeelingResult = "";
        Write("How confident are you about your time management skills as it relates to stress?(ie...1, 2, 3, 4, 5) 1 being the most stressed and 5 being not stressed at all:");
        StressLevel = Convert.ToInt32(ReadLine());
        //----------------------Processing for array-----------------------//
        for (int x = feeling.Length - 1; x >= 0; --x)
        {

            if (StressLevel == feeling[x])
            {
                isValidFeeling = true;

                if (StressLevel == 5)
                    FeelingResult = "You seem unphased by stress, to be honest you probably dont need to use this app.";
                if (StressLevel == 4)
                    FeelingResult = "You are somewhat stressed.";
                if (StressLevel == 3)
                    FeelingResult = "You are mildy stressed.";
                if (StressLevel == 2)
                    FeelingResult = "You are very stressed.";
                if (StressLevel == 1)
                    FeelingResult = "You are unbeleivably stressed.";


            }

        }

        //------------------------------OUTPUT FOR ARRAY---------------------//
        if (isValidFeeling)
        {
            WriteLine("{0} {1} Hopefully this time managment app will benefit you in some way shape or form:", Name, FeelingResult);

        }
        WriteLine("------------------------------------------------------------------------------------------------------");
        Write("Press any key to continue onwards with the application...");
        ReadLine();
        



        //--------------------Personal Questions(If Else)-------------------//
        Clear();
        Write("On average, how many hours do you think you spend doing homework each day?(ie....1, 2, 3.5):");
        AvgHWTime = Convert.ToDouble(ReadLine());
        


        if (AvgHWTime >= HOUR_THRESHOLD2 & AvgHWTime < HOUR_THRESHOLD3)
            Response1 = 2;
        else
            if (AvgHWTime >= HOUR_THRESHOLD3 & AvgHWTime < HOUR_THRESHOLD4)
            Response1 = 3;
        else
            if (AvgHWTime >= HOUR_THRESHOLD4 & AvgHWTime < HOUR_THRESHOLD5)
            Response1 = 4;
        else
            if (AvgHWTime >= HOUR_THRESHOLD5)
            Response1 = 5;

        if (AvgHWTime == HOUR_THRESHOLD1)
        WriteLine("{0} You really need to get your priorities straight. Follow along and hopefully this program helps you do that.", Name);
        else
            WriteLine("Your score is a {0} out of 5, this score should tell you how much time you allocate for homework everyday with 1 being the least and 5 being maybe a little too much.", Response1);
        WriteLine("-----------------------------------------------------------------------------------------------");

        //------------CUSTOM METHOD #2--------// Move out of your main? Never implement local method.
        ShowAvgTime (AvgHWTime);
        static void ShowAvgTime(double AvgHWTime)
        {
            Write("Press any key to continue:");
            ReadLine();
        }
        Clear();



        //-------------------------USER INPUT FOR EVENTS for Calendar---------------------//
        Write("Any Homework for Monday? If so Please enter the class its for or (NONE) if that is the case:");
        string MondayHomework = ReadLine();
        Write("How much time do you think it will take in hours?(ie...1, 2, 3.5):");
        double MondayTime = Convert.ToDouble(ReadLine());
        Clear();
        Write("How about Tuesday or (NONE) if that is the case:");
        string TuesdayHomework = ReadLine();
        Write("How much time do you think it will take in hours?(ie...1, 2, 3.5):");
        double TuesdayTime = Convert.ToDouble(ReadLine());
        Clear();
        Write("How about Wednesday or (NONE) if that is the case?:");
        string WednesdayHomework = ReadLine();
        Write("How much time do you think it will take in hours?(ie...1, 2, 3.5):");
        double WednesdayTime = Convert.ToDouble(ReadLine());
        Clear();
        Write("How about Thursday or (NONE) if that is the case?:");
        string ThursdayHomework = ReadLine();
        Write("How much time do you think it will take in hours?(ie...1, 2, 3.5):");
        double ThursdayTime = Convert.ToDouble(ReadLine());
        Clear();
        Write("Any HW for Friday or (NONE) if that is the case?:");
        string FridayHomework = ReadLine();
        Write("How much time do you think it will take in hours?(ie...1, 2, 3.5):");
        double FridayTime = Convert.ToDouble(ReadLine());
        Clear();
        Write("How about Saturday or (NONE) if that is the case?:");
        string SaturdayHomework = ReadLine();
        Write("How much time do you think it will take in hours?(ie...1, 2, 3.5):");
        double SaturdayTime = Convert.ToDouble(ReadLine());
        Clear();
        Write("How about Sunday or (NONE) if that is the case?:");
        string SundayHomework = ReadLine();
        Write("How much time do you think it will take in hours?(ie...1, 2, 3.5):");
        double SundayTime = Convert.ToDouble(ReadLine());
        TotalHours = (MondayTime + TuesdayTime + WednesdayTime + ThursdayTime + FridayTime + SaturdayTime + SundayTime);
        AVGHW = TotalHours / 7;
        Clear();

        //-------------------WHILE LOOP FOR FRIVOLOUS TIME(Outside Activites) ---------------------//
        Write("How many hours did you spend doing outside activities this past week (ie...Excercising, Video Games, Partying):");
        ActivityHours = Convert.ToDouble(ReadLine());
        HoursRatio = ActivityHours / (24 * 7);
        Write("Would you like to see the average amount of time per week you spend doing (Activities other than school work?) Enter Y or N:");
        Response = ReadLine();

        while (Response == "Y" || Response == "y")
        {
            ActivityHours = HoursRatio * 100;
            WriteLine("You spent aproximately {0} percent of your weekly total hours doing outside activities:", ActivityHours.ToString("N2"));
            
            Write("Would you like to see it again or carry on to your finished calculator? Enter (Y) for yes or (N) for no:");
            Response = ReadLine();

        }
        //-------------------------------OUTPUT-------------------------------//

        Clear();
        Write("Press any key to continue:");
        ReadLine();
        Clear();
        WriteLine("{0}'s Event/Time Management Calendar", Name);
        WriteLine("-----------------------------------------------------------------------------");
        WriteLine("MONDAY:                                                                      ");
        WriteLine("[{0}]                                                                        ", MondayHomework);
        WriteLine("You should spend aprox. {0} hours on the work for this class                 ", MondayTime);
        WriteLine("-----------------------------------------------------------------------------");
        WriteLine("TUESDAY:                                                                     ");
        WriteLine("[{0}]                                                                        ", TuesdayHomework);
        WriteLine("You should spend aprox. {0} hours on the work for this class                 ", TuesdayTime);
        WriteLine("-----------------------------------------------------------------------------");
        WriteLine("WEDNESDAY:                                                                   ");
        WriteLine("[{0}]                                                                        ", WednesdayHomework);
        WriteLine("You should spend aprox. {0} hours on the work for this class                 ", WednesdayTime);
        WriteLine("-----------------------------------------------------------------------------");
        WriteLine("THURSDAY:                                                                    ");
        WriteLine("[{0}]                                                                        ", ThursdayHomework);
        WriteLine("You should spend aprox. {0} hours on the work for this class                 ", ThursdayTime);
        WriteLine("-----------------------------------------------------------------------------");
        WriteLine("FRIDAY:                                                                      ");
        WriteLine("[{0}]                                                                        ", FridayHomework);
        WriteLine("You should spend aprox. {0} hours on the work for this class                 ", FridayTime);
        WriteLine("-----------------------------------------------------------------------------");
        WriteLine("SATURDAY:                                                                    ");
        WriteLine("[{0}]                                                                        ", SaturdayHomework);
        WriteLine("You should spend aprox. {0} hours on the work for this class                 ", SaturdayTime);
        WriteLine("-----------------------------------------------------------------------------");
        WriteLine("SUNDAY:                                                                      ");
        WriteLine("[{0}]                                                                        ", SundayHomework);
        WriteLine("You should spend aprox. {0} hours on the work for this class                 ", SundayTime);
        WriteLine("-----------------------------------------------------------------------------");
        //--------------------------PREVIOUS QUESTIONS TO SERVE AS REMINDERS----------------------//
        WriteLine("REMINDERS:");
        WriteLine("------------------");
        WriteLine("- You spent aproximately {0} percent of your weekly total hours doing outside activities last week", ActivityHours.ToString("N2"));
        TotalHours = (MondayTime + TuesdayTime + WednesdayTime + ThursdayTime + FridayTime + SaturdayTime + SundayTime);
        AVGHW = (MondayTime + TuesdayTime + WednesdayTime + ThursdayTime + FridayTime + SaturdayTime + SundayTime)/7;
        WriteLine("- The Avg amount of work hours you should be putting in per day is:{0}", AVGHW.ToString("N2")); //WHY ISNT THIS CALCULATING CORRECTLY ???
        WriteLine("- {0} {1} Hopefully this time managment app will benefit you in some way shape or form.", Name, FeelingResult);

        //-----------------------Implementation Class------------------------//

        TotalHours = (MondayTime + TuesdayTime + WednesdayTime + ThursdayTime + FridayTime + SaturdayTime + SundayTime);
       
        WeeklySchedule mySchedule = new WeeklySchedule();

        mySchedule.outputDisplay( TotalHours);

        //-------------------------RATING Switch Block--------------------------------//
        WriteLine("");
        WriteLine("RATING:");
        WriteLine("------------------");
        Write("Before you go, do you mind leaving a rating for this program?(ie...1, 2, 3, 4, 5):");
        Rating = Convert.ToInt32(ReadLine());

        switch(Rating)
        {
            case 1:
                WriteLine("Im sorry that you didnt enjoy this program, I hope you find something that works better for you :(");
                break;
            case 2:
                WriteLine("Sorry to see you didnt enjoy the application as much as I hoped, goodluck with your time management regardless :)");
                break;
            case 3:
                WriteLine("Glad to see you somewhat enjoyed the application, thank you for participating!");
                break;
            case 4:
                WriteLine("Im glad you enjoyed the program, hope this helped you with your time management skills!");
                break;
            case 5:
                WriteLine("Thank you so much! Im glad to see this program helped you as much as I had hoped it would. Perhaps this could become a weekly routine for you?");
                break;

        }


        }
    
}
class WeeklySchedule
{
    
    private double totalHours;
    public double TotalHours
        
    {
        get
        {
            return totalHours;
        }
    }
    //-----------------Class Output-----------------//
    public void outputDisplay(double totalHours)
    {
        WriteLine("Total Hours worth of work during the week is:{0}", totalHours);
    }

   

    











}








