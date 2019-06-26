using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson_8A
{
    public partial class lab08Form : Form
    {
        public string UserName { get; set; }
        public float UserAge { get; set; }

        /// <summary>
        /// This is the default Constructor
        /// </summary>
        public lab08Form()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This is the Event for the submit button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AgeLabel_Click(object sender, EventArgs e)
        {

        }

        private void InfoGroupbox_Enter(object sender, EventArgs e)
        {

        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            UserName = NameTextbox.Text;

            //option A
            //UserAge = Convert.ToSingle(AgeTextbox.Text);

            //option B
            UserAge = float.Parse(AgeTextbox.Text);

            //option C
            //float tempFloat;
            //bool result = float.TryParse(AgeTextbox.Text, out tempFloat);
            //UserAge = tempFloat;

            OutputLabel.Text = NameTextbox.Text + " " + AgeTextbox.Text;

        }

        /// <summary>
        /// This is the Event handler for Clear form
        /// </summary>
        private void ClearForm()
        {
            NameTextbox.Clear();
            AgeTextbox.Clear();
            SubmitButton.Enabled = false;
        }

        /// <summary>
        /// This is the Event handler for the Lab08Form Load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lab08Form_Load(object sender, EventArgs e)
        {
            ClearForm();
        }

        /// <summary>
        /// This is the Event handler for the AgeTextBox TextChanged Event 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AgeTextbox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                float.Parse(AgeTextbox.Text);
                SubmitButton.Enabled = true;
            }
            catch 
            {
                SubmitButton.Enabled = false;
            }
            
        }

        private void OutputLabel_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// This is the Event Handler for  the NameTextBox Textchanged Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NameTextbox_TextChanged(object sender, EventArgs e)
        {
            SubmitButton.Enabled = (NameTextbox.Text.Length >= 2) ? true : false;
        }
    }
}
