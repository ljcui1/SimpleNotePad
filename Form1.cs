namespace SimpleNotePad
{
    public partial class Form1 : Form
    {
        string userInput = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void save_txt(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            saveFileDialog.Title = "Save your text file";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Write the textbox content to the chosen file path
                File.WriteAllText(saveFileDialog.FileName, textBox1.Text);
                MessageBox.Show("File saved successfully!");
            }

        }

        private void open_txt(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text Files (*.txt|*.txt|All Files (*.*)|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = File.ReadAllText(ofd.FileName);
            }
        }

        /*private void update_textbox()
        {
            textBox1.Text = userInput;
        }

        private void key_typed(object sender, KeyPressEventArgs e)
        {
            string newKey = (e.KeyChar).ToString();
            userInput += newKey;
            update_textbox();
        }

        private void special_keys(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\b')
            {
                userInput = userInput.Remove(userInput.Length - 1, 1);
                update_textbox();
            }
            if (e.KeyChar == '\r')
            {

            }
        }*/
    }
}
