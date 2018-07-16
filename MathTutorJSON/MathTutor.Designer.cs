namespace MathTutorJSON
{
    partial class MathTutor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.QuestionLbl = new System.Windows.Forms.Label();
            this.QuestionPnl = new System.Windows.Forms.Panel();
            this.EqualsLbl = new System.Windows.Forms.Label();
            this.AnswerTxtBox = new System.Windows.Forms.TextBox();
            this.OkBtn = new System.Windows.Forms.Button();
            this.GenerateBtn = new System.Windows.Forms.Button();
            this.OperationGrpBox = new System.Windows.Forms.GroupBox();
            this.DifficultyGrpBox = new System.Windows.Forms.GroupBox();
            this.AddRdoBtn = new System.Windows.Forms.RadioButton();
            this.SubtractRdoBtn = new System.Windows.Forms.RadioButton();
            this.MultiplyRdoBtn = new System.Windows.Forms.RadioButton();
            this.Level3RdoBtn = new System.Windows.Forms.RadioButton();
            this.Level2RdoBtn = new System.Windows.Forms.RadioButton();
            this.Level1RdoBtn = new System.Windows.Forms.RadioButton();
            this.QuestionPnl.SuspendLayout();
            this.OperationGrpBox.SuspendLayout();
            this.DifficultyGrpBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // QuestionLbl
            // 
            this.QuestionLbl.AutoSize = true;
            this.QuestionLbl.Location = new System.Drawing.Point(63, 5);
            this.QuestionLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.QuestionLbl.Name = "QuestionLbl";
            this.QuestionLbl.Size = new System.Drawing.Size(70, 20);
            this.QuestionLbl.TabIndex = 0;
            this.QuestionLbl.Text = "question";
            // 
            // QuestionPnl
            // 
            this.QuestionPnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.QuestionPnl.Controls.Add(this.QuestionLbl);
            this.QuestionPnl.Location = new System.Drawing.Point(12, 12);
            this.QuestionPnl.Name = "QuestionPnl";
            this.QuestionPnl.Size = new System.Drawing.Size(199, 34);
            this.QuestionPnl.TabIndex = 1;
            // 
            // EqualsLbl
            // 
            this.EqualsLbl.AutoSize = true;
            this.EqualsLbl.Location = new System.Drawing.Point(230, 18);
            this.EqualsLbl.Name = "EqualsLbl";
            this.EqualsLbl.Size = new System.Drawing.Size(18, 20);
            this.EqualsLbl.TabIndex = 2;
            this.EqualsLbl.Text = "=";
            // 
            // AnswerTxtBox
            // 
            this.AnswerTxtBox.Enabled = false;
            this.AnswerTxtBox.Location = new System.Drawing.Point(264, 16);
            this.AnswerTxtBox.Name = "AnswerTxtBox";
            this.AnswerTxtBox.Size = new System.Drawing.Size(199, 26);
            this.AnswerTxtBox.TabIndex = 3;
            // 
            // OkBtn
            // 
            this.OkBtn.Enabled = false;
            this.OkBtn.Location = new System.Drawing.Point(494, 16);
            this.OkBtn.Name = "OkBtn";
            this.OkBtn.Size = new System.Drawing.Size(126, 26);
            this.OkBtn.TabIndex = 4;
            this.OkBtn.Text = "OK";
            this.OkBtn.UseVisualStyleBackColor = true;
            this.OkBtn.Click += new System.EventHandler(this.OkBtn_Click);
            // 
            // GenerateBtn
            // 
            this.GenerateBtn.Location = new System.Drawing.Point(494, 64);
            this.GenerateBtn.Name = "GenerateBtn";
            this.GenerateBtn.Size = new System.Drawing.Size(124, 169);
            this.GenerateBtn.TabIndex = 5;
            this.GenerateBtn.Text = "Generate\r\nExample";
            this.GenerateBtn.UseVisualStyleBackColor = true;
            this.GenerateBtn.Click += new System.EventHandler(this.GenerateBtn_Click);
            // 
            // OperationGrpBox
            // 
            this.OperationGrpBox.Controls.Add(this.MultiplyRdoBtn);
            this.OperationGrpBox.Controls.Add(this.SubtractRdoBtn);
            this.OperationGrpBox.Controls.Add(this.AddRdoBtn);
            this.OperationGrpBox.Location = new System.Drawing.Point(13, 64);
            this.OperationGrpBox.Name = "OperationGrpBox";
            this.OperationGrpBox.Size = new System.Drawing.Size(450, 77);
            this.OperationGrpBox.TabIndex = 6;
            this.OperationGrpBox.TabStop = false;
            this.OperationGrpBox.Text = "Operation";
            // 
            // DifficultyGrpBox
            // 
            this.DifficultyGrpBox.Controls.Add(this.Level3RdoBtn);
            this.DifficultyGrpBox.Controls.Add(this.Level2RdoBtn);
            this.DifficultyGrpBox.Controls.Add(this.Level1RdoBtn);
            this.DifficultyGrpBox.Location = new System.Drawing.Point(13, 156);
            this.DifficultyGrpBox.Name = "DifficultyGrpBox";
            this.DifficultyGrpBox.Size = new System.Drawing.Size(450, 77);
            this.DifficultyGrpBox.TabIndex = 7;
            this.DifficultyGrpBox.TabStop = false;
            this.DifficultyGrpBox.Text = "Difficulty";
            // 
            // AddRdoBtn
            // 
            this.AddRdoBtn.AutoSize = true;
            this.AddRdoBtn.Location = new System.Drawing.Point(24, 33);
            this.AddRdoBtn.Name = "AddRdoBtn";
            this.AddRdoBtn.Size = new System.Drawing.Size(85, 24);
            this.AddRdoBtn.TabIndex = 0;
            this.AddRdoBtn.TabStop = true;
            this.AddRdoBtn.Text = "Addition";
            this.AddRdoBtn.UseVisualStyleBackColor = true;
            this.AddRdoBtn.CheckedChanged += new System.EventHandler(this.AddRdoBtn_CheckedChanged);
            // 
            // SubtractRdoBtn
            // 
            this.SubtractRdoBtn.AutoSize = true;
            this.SubtractRdoBtn.Location = new System.Drawing.Point(157, 33);
            this.SubtractRdoBtn.Name = "SubtractRdoBtn";
            this.SubtractRdoBtn.Size = new System.Drawing.Size(109, 24);
            this.SubtractRdoBtn.TabIndex = 1;
            this.SubtractRdoBtn.TabStop = true;
            this.SubtractRdoBtn.Text = "Subtraction";
            this.SubtractRdoBtn.UseVisualStyleBackColor = true;
            this.SubtractRdoBtn.CheckedChanged += new System.EventHandler(this.SubtractRdoBtn_CheckedChanged);
            // 
            // MultiplyRdoBtn
            // 
            this.MultiplyRdoBtn.AutoSize = true;
            this.MultiplyRdoBtn.Location = new System.Drawing.Point(314, 33);
            this.MultiplyRdoBtn.Name = "MultiplyRdoBtn";
            this.MultiplyRdoBtn.Size = new System.Drawing.Size(118, 24);
            this.MultiplyRdoBtn.TabIndex = 2;
            this.MultiplyRdoBtn.TabStop = true;
            this.MultiplyRdoBtn.Text = "Multiplication";
            this.MultiplyRdoBtn.UseVisualStyleBackColor = true;
            this.MultiplyRdoBtn.CheckedChanged += new System.EventHandler(this.MultiplyRdoBtn_CheckedChanged);
            // 
            // Level3RdoBtn
            // 
            this.Level3RdoBtn.AutoSize = true;
            this.Level3RdoBtn.Location = new System.Drawing.Point(314, 34);
            this.Level3RdoBtn.Name = "Level3RdoBtn";
            this.Level3RdoBtn.Size = new System.Drawing.Size(77, 24);
            this.Level3RdoBtn.TabIndex = 5;
            this.Level3RdoBtn.TabStop = true;
            this.Level3RdoBtn.Text = "Level 3";
            this.Level3RdoBtn.UseVisualStyleBackColor = true;
            this.Level3RdoBtn.CheckedChanged += new System.EventHandler(this.Level3RdoBtn_CheckedChanged);
            // 
            // Level2RdoBtn
            // 
            this.Level2RdoBtn.AutoSize = true;
            this.Level2RdoBtn.Location = new System.Drawing.Point(157, 34);
            this.Level2RdoBtn.Name = "Level2RdoBtn";
            this.Level2RdoBtn.Size = new System.Drawing.Size(77, 24);
            this.Level2RdoBtn.TabIndex = 4;
            this.Level2RdoBtn.TabStop = true;
            this.Level2RdoBtn.Text = "Level 2";
            this.Level2RdoBtn.UseVisualStyleBackColor = true;
            this.Level2RdoBtn.CheckedChanged += new System.EventHandler(this.Level2RdoBtn_CheckedChanged);
            // 
            // Level1RdoBtn
            // 
            this.Level1RdoBtn.AutoSize = true;
            this.Level1RdoBtn.Location = new System.Drawing.Point(24, 34);
            this.Level1RdoBtn.Name = "Level1RdoBtn";
            this.Level1RdoBtn.Size = new System.Drawing.Size(77, 24);
            this.Level1RdoBtn.TabIndex = 3;
            this.Level1RdoBtn.TabStop = true;
            this.Level1RdoBtn.Text = "Level 1";
            this.Level1RdoBtn.UseVisualStyleBackColor = true;
            this.Level1RdoBtn.CheckedChanged += new System.EventHandler(this.Level1RdoBtn_CheckedChanged);
            // 
            // MathTutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 242);
            this.Controls.Add(this.DifficultyGrpBox);
            this.Controls.Add(this.OperationGrpBox);
            this.Controls.Add(this.GenerateBtn);
            this.Controls.Add(this.OkBtn);
            this.Controls.Add(this.AnswerTxtBox);
            this.Controls.Add(this.EqualsLbl);
            this.Controls.Add(this.QuestionPnl);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MathTutor";
            this.Text = "Math Tutor";
            this.QuestionPnl.ResumeLayout(false);
            this.QuestionPnl.PerformLayout();
            this.OperationGrpBox.ResumeLayout(false);
            this.OperationGrpBox.PerformLayout();
            this.DifficultyGrpBox.ResumeLayout(false);
            this.DifficultyGrpBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label QuestionLbl;
        private System.Windows.Forms.Panel QuestionPnl;
        private System.Windows.Forms.Label EqualsLbl;
        private System.Windows.Forms.TextBox AnswerTxtBox;
        private System.Windows.Forms.Button OkBtn;
        private System.Windows.Forms.Button GenerateBtn;
        private System.Windows.Forms.GroupBox OperationGrpBox;
        private System.Windows.Forms.RadioButton MultiplyRdoBtn;
        private System.Windows.Forms.RadioButton SubtractRdoBtn;
        private System.Windows.Forms.RadioButton AddRdoBtn;
        private System.Windows.Forms.GroupBox DifficultyGrpBox;
        private System.Windows.Forms.RadioButton Level3RdoBtn;
        private System.Windows.Forms.RadioButton Level2RdoBtn;
        private System.Windows.Forms.RadioButton Level1RdoBtn;
    }
}

