namespace Ch24FibonacciForm {
    internal static class Program {
        // global variables
        private static long number1 = 0;
        private static long number2 = 1;
        private static long temp = 0;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new FibonacciForm());
        }

        public static long CalculateRecursively(long n) {
            if(n == 0 || n == 1) {
                return n;
            }
            else {
                return CalculateRecursively(n - 1) + CalculateRecursively(n - 2);
            }
        }

        public static void CalculateIteravely() {
            temp = number1 + number2;
            number1 = number2;
            number2 = temp;
        }

        public static long GetResult() => number2;
    }
}