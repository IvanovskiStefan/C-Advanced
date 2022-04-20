namespace SEDC.Oop.C_Advanced.Class08.App
{
    public partial class Form1 : Form
    {
        int counter = 0;
        public Form1()
        {
            InitializeComponent();
            clickcounterButton.Text = "0";
            Button button = new Button();
            clickcounterButton.Click += ClickCounterButtonClick;

        }


        private void ClickCounterButtonClick (object sender, EventArgs e)
        {
            clickcounterButton.Text = (++counter)
        }
    }
}