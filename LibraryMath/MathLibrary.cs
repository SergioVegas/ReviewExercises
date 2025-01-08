namespace LibraryMath
{
    public class EX1
    {
        const int DivisionMinutesHours = 60;
        public static int ConvertMinutes(int seconds)
        {
            int minuts;
            
            minuts = seconds / DivisionMinutesHours;

            return minuts;
        }
        public static int RestantSeconds(int seconds)
        {
            seconds = seconds % DivisionMinutesHours;

            return seconds;
        }
        public static int ConvertHour(int seconds)
        {
            int hour;
            int minuts = ConvertMinutes(seconds);

            hour = minuts / DivisionMinutesHours;

            return hour;
        }
        public static int RestantMinutes(int seconds)
        {
            int minuts = ConvertMinutes(seconds);
            minuts = minuts % DivisionMinutesHours;

            return minuts;
        }
    }
}
