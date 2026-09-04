namespace homework1
{
    public partial class homework1 : Form
    {
        private const double BIG_PAY_DOLLAR = 10.50; //big const for big pay dollar that gets used later
        public homework1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void firstBox_TextChanged(object sender, EventArgs e)
        {



        }

        private void lastBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void hourBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void firstLabel_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            firstBox.Clear();
            lastBox.Clear();
            hourBox.Clear();
            superLabel.Text = "";
        }

        private void summary_Click(object sender, EventArgs e) // currently this just does parsing
        {
            string hourBoxInput = (string)hourBox.Text;

            try
            {

                string firstName = firstBox.Text;
                string lastName = lastBox.Text;

                char firstNameThrower = firstName[0]; //trying to get an exception thrown if these fields are empty
                char lastNameThrower = lastName[0];

                int hourNumber = int.Parse(hourBoxInput);
                //some work hour math plus smushing the string together

                int dollarNumber = (int)(BIG_PAY_DOLLAR * hourNumber); //this converts the double back to an int which might mess up math slightly
                superLabel.ForeColor = Color.Black;
                superLabel.Text = $"{firstName} {lastName} worked {hourNumber} hours and earned {dollarNumber} dollars at $10.50 per hour ";


            }
            catch (Exception) //generic exception should be okay here
            {
                superLabel.ForeColor = Color.Red;
                string cooked = "Please enter a real integer, and also a real name";
                superLabel.Text = cooked;
            }
        }

        private void superLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
