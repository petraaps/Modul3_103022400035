namespace Modul3_103022400035
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string[] satuan = { "Celcius", "Fahrenheit", "Kelvin", "Reamur" };
            comboBox1.Items.AddRange(satuan);
            comboBox2.Items.AddRange(satuan);
            textBox2.ReadOnly = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private string ConvertTemperature(string input, string satuan1, string satuan2)
        {
            double value = double.Parse(input);
            double result = 0;
            switch (satuan1)
            {
                case "Celcius":
                    if (satuan2 == "Fahrenheit")
                        result = value * 9 / 5 + 32;
                    else if (satuan2 == "Kelvin")
                        result = value + 273.15;
                    else if (satuan2 == "Reamur")
                        result = value * 4 / 5;
                    else
                        result = value;
                    break;
                case "Fahrenheit":
                    if (satuan2 == "Celcius")
                        result = (value - 32) * 5 / 9;
                    else if (satuan2 == "Kelvin")
                        result = (value - 32) * 5 / 9 + 273.15;
                    else if (satuan2 == "Reamur")
                        result = (value - 32) * 4 / 9;
                    else
                        result = value;
                    break;
                case "Kelvin":
                    if (satuan2 == "Celcius")
                        result = value - 273.15;
                    else if (satuan2 == "Fahrenheit")
                        result = (value - 273.15) * 9 / 5 + 32;
                    else if (satuan2 == "Reamur")
                        result = (value - 273.15) * 4 / 5;
                    else
                        result = value;
                    break;
                case "Reamur":
                    if (satuan2 == "Celcius")
                        result = value * 5 / 4;
                    else if (satuan2 == "Fahrenheit")
                        result = value * 9 / 4 + 32;
                    else if (satuan2 == "Kelvin")
                        result = value * 5 / 4 + 273.15;
                    else
                        result = value;
                    break;
            }
            return result.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null || comboBox2.SelectedItem == null)
            {
                MessageBox.Show("Silahkan pilih satuan");
                return;
            }
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Masukkan angka");
                return;
            }
            switch (comboBox1.SelectedItem.ToString())
            {
                case "Celcius":
                    textBox2.Text = ConvertTemperature(textBox1.Text, "Celcius", comboBox2.SelectedItem.ToString());
                    break;
                case "Fahrenheit":
                    textBox2.Text = ConvertTemperature(textBox1.Text, "Fahrenheit", comboBox2.SelectedItem.ToString());
                    break;
                case "Kelvin":
                    textBox2.Text = ConvertTemperature(textBox1.Text, "Kelvin", comboBox2.SelectedItem.ToString());
                    break;
                case "Reamur":
                    textBox2.Text = ConvertTemperature(textBox1.Text, "Reamur", comboBox2.SelectedItem.ToString());
                    break;
                default:
                    MessageBox.Show("Satuan tidak valid");
                    break;
            }
        }
    }
}
