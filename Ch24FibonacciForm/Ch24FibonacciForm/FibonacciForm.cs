namespace Ch24FibonacciForm {
    public partial class FibonacciForm : Form {
        public FibonacciForm() {
            InitializeComponent();
        }

        private async void RecursiveBtn_Click(object sender, EventArgs e) {
            // capture start time
            DateTime startTime = DateTime.Now;
            // notify user the program is working
            RecursiveResult.Text = "Calculating...";
            TimeResult.Text = "Calculating...";
            // calculate fibonacci number based on user input, async
            long recursiveTask = await Task.Run(() => Program.CalculateRecursively(long.Parse(RecursiveTextBox.Text)));
            // display result
            RecursiveResult.Text = recursiveTask.ToString();
            // capture end time
            DateTime endTime = DateTime.Now;
            // calculate length of time in seconds
            double seconds = (endTime - startTime).TotalSeconds;
            // display total time
            TimeResult.Text = seconds.ToString();
        }

        private void IterativeBtn_Click(object sender, EventArgs e) {
            // calculate next fibonacci number using static variables
            Program.CalculateIteravely();
            // display result
            IterativeResult.Text = Program.GetResult().ToString();
        }
    }
}