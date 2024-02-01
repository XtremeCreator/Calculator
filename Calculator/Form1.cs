namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        void buttons()
        {
            if (txtFirstNum.Text != "" || txtSecondNum.Text != "")
            { btnClear.Enabled = true; }
            else { btnClear.Enabled = false; }


            if (txtFirstNum.Text != "" && txtSecondNum.Text != "")
            {
                btnAdd.Enabled = true;
                btnSubtract.Enabled = true;
                btnMultiply.Enabled = true;
                btnDivide.Enabled = true;



            }
            else
            {
                btnAdd.Enabled = false;
                btnSubtract.Enabled = false;
                btnMultiply.Enabled = false;
                btnDivide.Enabled = false;
            }
        }
        void Add()
        {

            double FirstNum = double.Parse(txtFirstNum.Text);
            double SecondNum = double.Parse(txtSecondNum.Text);
            double Answer = FirstNum + SecondNum;
            lblAnswer.Text = Answer.ToString();
        }

        void Sub(String x, String y)
        {
            double FirstNum = double.Parse(x);
            double SecondNum = double.Parse(y);
            double Answer = FirstNum - SecondNum;
            lblAnswer.Text = Answer.ToString();
        }

        String Multiply()
        {
            double FirstNum = double.Parse(txtFirstNum.Text);
            double SecondNum = double.Parse(txtSecondNum.Text);
            double Answer = FirstNum * SecondNum;
            return Answer.ToString();
        }

        String Divide(String x, String y)
        {
            double FirstNum = double.Parse(x);
            double SecondNum = double.Parse(y);
            double Answer = FirstNum / SecondNum;
            return lblAnswer.Text = Answer.ToString();
        }

        void Clear()
        {
            txtFirstNum.Text = null;
            txtSecondNum.Text = null;
            lblAnswer.Text = "---";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Add();
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            Sub(txtFirstNum.Text, txtSecondNum.Text);
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            lblAnswer.Text = Multiply();
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            double SecondNum = Double.Parse(txtSecondNum.Text);

            if (SecondNum <= 0)
            {
                lblAnswer.Text = "Can't Divide by Zero";
            }
            else
            {
                Divide(txtFirstNum.Text, txtSecondNum.Text);
            }
        }



        private void txtFirstNum_TextChanged(object sender, EventArgs e)
        {
            buttons();
        }

        private void txtSecondNum_TextChanged(object sender, EventArgs e)
        {
            buttons();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
