namespace transik
{
    internal static  class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
      public static string idkl="2";

        public static string nazwaklubu = "";
        public static string budzet = "";

        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            Form7 fr7 = new Form7();
            fr7.ShowDialog();

            Form1 fr=new Form1();
            fr.ShowDialog();
        }
    }
}