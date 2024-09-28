namespace ChangeCalcHW5
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}
private void btnCalculate_Click(object sender, EventArgs e)
{
    // Get the amount of change from the user
    int changeAmount = int.Parse(txtChangeAmount.Text);

    // Calculate quarters
    int quarters = changeAmount / 25;
    changeAmount %= 25;

    // Calculate dimes
    int dimes = changeAmount / 10;
    changeAmount %= 10;

    // Calculate nickels
    int nickels = changeAmount / 5;
    changeAmount %= 5;

    // Calculate pennies
    int pennies = changeAmount;

    // Display the results in the text boxes
    txtQuarters.Text = quarters.ToString();
    txtDimes.Text = dimes.ToString();
    txtNickels.Text = nickels.ToString();
    txtPennies.Text = pennies.ToString();
}

private void btnExit_Click(object sender, EventArgs e)
{
    // Close the application
    this.Close();
}