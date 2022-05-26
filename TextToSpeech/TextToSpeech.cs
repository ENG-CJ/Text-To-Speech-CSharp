using System;
using System.Speech.Synthesis;
using System.Threading;
using System.Windows.Forms;
namespace TextToSpeech
{
    public partial class TextToSpeech : Form
    {
        public TextToSpeech()
        {
            InitializeComponent();
        }

        // closing the form
        private void CloseForm(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Speak(object sender, EventArgs e)
        {

            // checking the textBox
            if (richTextBox1.Text == "")
                MessageBox.Show("Text Is Required");
            else
            {

                // using threeds as waiting and changing button text
                Thread.Sleep(1000);
                btn.Text = "Speaking....";

                // calling the function
                ConvertTextToSpeech(richTextBox1.Text);

                //change button text to default text
                btn.Text = "SPEAK";


            }


        }


        // converting text to speech
        static void ConvertTextToSpeech(string text)
        {
            //creating object sysnthese
            SpeechSynthesizer speech = new SpeechSynthesizer();
            speech.Speak(text);
        }
    }
}
