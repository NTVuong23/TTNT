namespace Lab02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                float number1 = float.Parse(textBox1.Text);
                float number2 = float.Parse(textBox2.Text);
                float result = number1 + number2;
                textBox3.Text = result.ToString();
            }
            catch (FormatException)
            {
                DialogResult dialogResult = MessageBox.Show("Bạn biết nhập số không?", "Lỗi định dạng!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                }
                else if (dialogResult == DialogResult.No)
                {
                    MessageBox.Show("Vậy hãy học lại lớp 1 :)", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                float number1 = float.Parse(textBox1.Text);
                float number2 = float.Parse(textBox2.Text);
                float result = number1 - number2;
                textBox3.Text = result.ToString();
            }
            catch (FormatException)
            {
                DialogResult dialogResult = MessageBox.Show("Bạn biết nhập số không?", "Lỗi định dạng!", MessageBoxButtons.YesNo, MessageBoxIcon.Error);

                if (dialogResult == DialogResult.Yes)
                {
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                }
                else if (dialogResult == DialogResult.No)
                {
                    MessageBox.Show("Vậy hãy học lại lớp 1 :)", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                float number1 = float.Parse(textBox1.Text);
                float number2 = float.Parse(textBox2.Text);
                float result = number1 * number2;
                textBox3.Text = result.ToString();
            }
            catch (FormatException)
            {
                DialogResult dialogResult = MessageBox.Show("Bạn biết nhập số không?", "Lỗi định dạng!", MessageBoxButtons.YesNo, MessageBoxIcon.Error);

                if (dialogResult == DialogResult.Yes)
                {
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                }
                else if (dialogResult == DialogResult.No)
                {
                    MessageBox.Show("Vậy hãy học lại lớp 1 :)", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                float number1 = float.Parse(textBox1.Text);
                float number2 = float.Parse(textBox2.Text);
                if (number2 == 0)
                {
                    throw new DivideByZeroException();
                }
                else
                {
                    float result = number1 / number2;
                    textBox3.Text = result.ToString();
                }
            }
            catch (FormatException)
            {
                DialogResult dialogResult = MessageBox.Show("Bạn biết nhập số không?", "Lỗi định dạng!", MessageBoxButtons.YesNo, MessageBoxIcon.Error);

                if (dialogResult == DialogResult.Yes)
                {
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                }
                else if (dialogResult == DialogResult.No)
                { 
                    MessageBox.Show("Vậy hãy học lại lớp 1 :)", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
            }
        }
    }
}