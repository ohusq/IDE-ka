namespace csNotes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            ChangeRGB();
            InitializeComponent();
        }

        async void ChangeRGB()
        {
            for(; ;) // while true loop
            {
                await Task.Delay(100); // Number in ms
                // Change RGB
                int c1 = new Random()
                    .Next(0, 255);
                int c2 = new Random()
                    .Next(0, 255);
                int c3 = new Random()
                    .Next(0, 255);

                BackColor = Color.FromArgb(c1, c2, c3); // Change background color
            };
        }
        private void ClearButton_Click(object sender, EventArgs e)
        {
            // Clear the text box
            inputBox.Clear();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            // Save text from textbox
            string text = inputBox.Text;
            string fileName = FileName.Text + ".txt";
            // Save text to file
            File.WriteAllText(fileName, text);
        }
    }
}