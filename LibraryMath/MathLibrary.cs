namespace LibraryMath
{
    public class EX1
    {
        public static int ConvertMinutes(int seconds)
        {
            int minuts;
            const int DivisionMinutesHours = 60;
            minuts = seconds / DivisionMinutesHours;

            return minuts;
        }
        public static int RestantSeconds(int seconds)
        {
            const int DivisionMinutsHours = 60;
            seconds = seconds % DivisionMinutsHours;

            return seconds;
        }
        public static int ConvertHour(int seconds, int minuts)
        {
            const int DivisionMinutsHours = 60;
            int hour;

            hour = minuts / DivisionMinutsHours;

            return hour;
        }
        public static int RestantMinutes(int minuts)
        {
            const int DivisionMinutsHours = 60;
            minuts = minuts % DivisionMinutsHours;

            return minuts;
        }
    }
}
