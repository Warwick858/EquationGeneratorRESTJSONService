// ******************************************************************************************************************
//  Math Tutor - GUI application that randomly generates an arithmetic equation.
//  Program calls EquationGenerator REST service to randomly generate the equation.
//  Copyright(C) 2018  James LoForti
//  Contact Info: jamesloforti@gmail.com
//
//  This program is free software: you can redistribute it and/or modify
//  it under the terms of the GNU General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
//
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
//  GNU General Public License for more details.
//
//  You should have received a copy of the GNU General Public License
//  along with this program.If not, see<https://www.gnu.org/licenses/>.
//									     ____.           .____             _____  _______   
//									    |    |           |    |    ____   /  |  | \   _  \  
//									    |    |   ______  |    |   /  _ \ /   |  |_/  /_\  \ 
//									/\__|    |  /_____/  |    |__(  <_> )    ^   /\  \_/   \
//									\________|           |_______ \____/\____   |  \_____  /
//									                             \/          |__|        \/ 
//
// ******************************************************************************************************************
//
using System;
using System.IO;
using System.Net.Http;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Windows.Forms;

namespace MathTutorJSON
{
    /// <summary>
    /// MathTutor Form - the main form for the application.
    /// </summary>
    public partial class MathTutor : Form
    {
        private string operation = "add";
        private int level = 1;
        private Equation currEquation;
        private HttpClient service = new HttpClient(); // used to invoke web service

        /// <summary>
        /// Default Constructor - to initialize the GUI components.
        /// </summary>
        public MathTutor()
        {
            InitializeComponent();
        } // end constructor

        /// <summary>
        /// GenerateBtn_Click Method - to generate a new equation.
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        private async void GenerateBtn_Click(object sender, EventArgs e)
        {
            //Send request to service
            string jsonStr = await service.GetStringAsync(new Uri("http://localhost:9660/EquationGenerator.svc/" +
                "equation/" + operation + "/" + level));

            //Deserialize JSON into Equation object
            DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(Equation));
            currEquation = (Equation)jsonSerializer.ReadObject(new MemoryStream(Encoding.Unicode.GetBytes(jsonStr)));

            //Display equation
            QuestionLbl.Text = currEquation.LeftHandSide;
            OkBtn.Enabled = true;
            AnswerTxtBox.Enabled = true;
        } // end method GenerateBtn_Click

        /// <summary>
        /// OkBtn_Click Method - to check the user's answer.
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        private void OkBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(AnswerTxtBox.Text))
            {
                //Determine if user's answer is correct
                if (currEquation.Result == Convert.ToInt32(AnswerTxtBox.Text))
                {
                    //CORRECT
                    QuestionLbl.Text = string.Empty;
                    AnswerTxtBox.Clear();
                    OkBtn.Enabled = false;
                    MessageBox.Show("Correct!  Good job!", "Result");
                } // end if
                else
                {
                    //INCORRECT
                    MessageBox.Show("Incorrect.  Try again.", "Result");
                } // end else
            } // end if
        } // end method OkBtn_Click

        /// <summary>
        /// AddRdoBtn_CheckedChanged Method - to set the operation if the checkbox is checked.
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        private void AddRdoBtn_CheckedChanged(object sender, EventArgs e)
        {
            operation = (AddRdoBtn.Checked) ? "add" : "add";
        } // end method AddRdoBtn_CheckedChanged

        /// <summary>
        /// SubtractRdoBtn_CheckedChanged Method - to set the operation if the checkbox is checked.
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        private void SubtractRdoBtn_CheckedChanged(object sender, EventArgs e)
        {
            operation = (SubtractRdoBtn.Checked) ? "subtract" : "add";
        } // end method SubtractRdoBtn_CheckedChanged

        /// <summary>
        /// MultiplyRdoBtn_CheckedChanged Method - to set the operation if the checkbox is checked.
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        private void MultiplyRdoBtn_CheckedChanged(object sender, EventArgs e)
        {
            operation = (MultiplyRdoBtn.Checked) ? "multiply" : "add";
        } // end method MultiplyRdoBtn_CheckedChanged

        /// <summary>
        /// Level1RdoBtn_CheckedChanged Method - to set the level if the checkbox is checked.
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        private void Level1RdoBtn_CheckedChanged(object sender, EventArgs e)
        {
            level = (Level1RdoBtn.Checked) ? 1 : 1;
        } // end method Level1RdoBtn_CheckedChanged

        /// <summary>
        /// Level2RdoBtn_CheckedChanged Method - to set the level if the checkbox is checked.
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        private void Level2RdoBtn_CheckedChanged(object sender, EventArgs e)
        {
            level = (Level2RdoBtn.Checked) ? 2 : 1;
        } // end method Level2RdoBtn_CheckedChanged

        /// <summary>
        /// Level3RdoBtn_CheckedChanged Method - to set the level if the checkbox is checked.
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        private void Level3RdoBtn_CheckedChanged(object sender, EventArgs e)
        {
            level = (Level3RdoBtn.Checked) ? 3 : 1;
        } // end method Level3RdoBtn_CheckedChanged
    } // end class MathTutor
} // end namespace MathTutorJSON
