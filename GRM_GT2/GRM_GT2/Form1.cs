namespace GRM_GT2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            NumberOfTeethResultOutput.Text = "";
            RadiusResultOutput.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double NumberOfTeeth = Convert.ToDouble(InputNumberOfTeeth.Text);
            double Radius = Convert.ToDouble(InputRadius.Text);
            if (NumberOfTeeth > 0)
            {
                double NumberOfTeethOutput = 2 * NumberOfTeeth / 6.28 - 1.5; // output
                NumberOfTeethResultOutput.Text = Math.Round(NumberOfTeethOutput, 3) + ""; // text output
            }
            if (Radius > 0)
            {
                double RadiusOutput = Radius / 2 * 6.28 + 5; // output
                RadiusResultOutput.Text = Math.Round(RadiusOutput, 0) + ""; // text output
            }
            
        }
    }
}