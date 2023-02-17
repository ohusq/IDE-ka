

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
            for (; ; ) // while true loop
            {
                await Task.Delay(10); // Number in ms

                // Transform background color smooth from 25 to 40 back to 25 so its going from black to white and back

                // Make it brighter
                int c1 = 75 + (int)(Math.Sin(DateTime.Now.Millisecond / 1000.0 * 2 * Math.PI) * 15); // Thanks copilot :)
                int c2 = 75 + (int)(Math.Sin(DateTime.Now.Millisecond / 1000.0 * 2 * Math.PI + 2 * Math.PI / 3) * 15); // Thanks copilot :)
                int c3 = 75 + (int)(Math.Sin(DateTime.Now.Millisecond / 1000.0 * 2 * Math.PI + 4 * Math.PI / 3) * 15); // Thanks copilot :)

                BackColor = Color.FromArgb(c1, c2, c3); // Change background color


                //await Task.Delay(100); // Number in ms
                // Change RGB
                //int c1 = new Random()
                    //.Next(0, 255);
                //int c2 = new Random()
                    //.Next(0, 255);
                //int c3 = new Random()
                    //.Next(0, 255);

                //BackColor = Color.FromArgb(c1, c2, c3); // Change background color
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

        private void OpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                Title = "Open txt File.",
                DefaultExt = "txt"
            };
            openFileDialog1.ShowDialog();
            if (openFileDialog1.FileName == "")
            {
                return;
            }
            string text = File.ReadAllText(openFileDialog1.FileName);
            inputBox.Text = text;
        }
    }
}