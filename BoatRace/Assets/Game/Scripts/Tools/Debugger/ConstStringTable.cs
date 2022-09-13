namespace BoatRace.Tools.Debugger
{
    public static class ConstStringTable
    {
        private static string[] secDict = new string[100];
        private static string[] tenDict = new string[10];

        static ConstStringTable()
        {
            for (int index = 0; index < 100; ++index)
                ConstStringTable.secDict[index] = string.Intern(index.ToString("00"));
            for (int index = 0; index < 10; ++index)
                ConstStringTable.tenDict[index] = string.Intern(index.ToString());
        }

        public static string GetTimeIntern(int time) => time < 0 || time > 99 ? time.ToString() : ConstStringTable.secDict[time];

        public static string GetNumIntern(int num)
        {
            if (num < 0 || num > 99)
                return num.ToString();
            return num >= 10 ? ConstStringTable.secDict[num] : ConstStringTable.tenDict[num];
        }
    }
}