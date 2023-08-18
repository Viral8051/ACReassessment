namespace mathInter
{
    partial class Form1
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
            this.headLabel = new System.Windows.Forms.Label();
            this.quetextBox = new System.Windows.Forms.TextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.textLabel1 = new System.Windows.Forms.Label();
            this.outputLabel = new System.Windows.Forms.Label();
            this.btnCharVisiblity = new System.Windows.Forms.Button();
            this.btnLbl = new System.Windows.Forms.Label();
            this.lblX = new System.Windows.Forms.Label();
            this.lblY = new System.Windows.Forms.Label();
            this.txtValueX = new System.Windows.Forms.TextBox();
            this.txtValueY = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // headLabel
            // 
            this.headLabel.AutoSize = true;
            this.headLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headLabel.ForeColor = System.Drawing.Color.Cornsilk;
            this.headLabel.Location = new System.Drawing.Point(263, 9);
            this.headLabel.Name = "headLabel";
            this.headLabel.Size = new System.Drawing.Size(308, 31);
            this.headLabel.TabIndex = 0;
            this.headLabel.Text = "MATH INTERPRETER";
            this.headLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // quetextBox
            // 
            this.quetextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quetextBox.Location = new System.Drawing.Point(50, 193);
            this.quetextBox.Multiline = true;
            this.quetextBox.Name = "quetextBox";
            this.quetextBox.Size = new System.Drawing.Size(703, 63);
            this.quetextBox.TabIndex = 1;
            // 
            // submitButton
            // 
            this.submitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitButton.Location = new System.Drawing.Point(311, 274);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(161, 29);
            this.submitButton.TabIndex = 2;
            this.submitButton.Text = "SUBMIT";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // textLabel1
            // 
            this.textLabel1.AutoSize = true;
            this.textLabel1.BackColor = System.Drawing.SystemColors.ControlText;
            this.textLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textLabel1.ForeColor = System.Drawing.Color.White;
            this.textLabel1.Location = new System.Drawing.Point(46, 105);
            this.textLabel1.Name = "textLabel1";
            this.textLabel1.Size = new System.Drawing.Size(472, 20);
            this.textLabel1.TabIndex = 3;
            this.textLabel1.Text = "Welcome to Math Interpreter. Write your Text below to get Answer";
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.outputLabel.Location = new System.Drawing.Point(46, 329);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(81, 20);
            this.outputLabel.TabIndex = 4;
            this.outputLabel.Text = "Answer is:";
            // 
            // btnCharVisiblity
            // 
            this.btnCharVisiblity.BackColor = System.Drawing.Color.Chocolate;
            this.btnCharVisiblity.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCharVisiblity.Location = new System.Drawing.Point(362, 146);
            this.btnCharVisiblity.Name = "btnCharVisiblity";
            this.btnCharVisiblity.Size = new System.Drawing.Size(80, 24);
            this.btnCharVisiblity.TabIndex = 5;
            this.btnCharVisiblity.Text = "Disable";
            this.btnCharVisiblity.UseVisualStyleBackColor = false;
            this.btnCharVisiblity.Click += new System.EventHandler(this.btnCharVisiblity_Click);
            // 
            // btnLbl
            // 
            this.btnLbl.AutoSize = true;
            this.btnLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLbl.ForeColor = System.Drawing.Color.White;
            this.btnLbl.Location = new System.Drawing.Point(47, 149);
            this.btnLbl.Name = "btnLbl";
            this.btnLbl.Size = new System.Drawing.Size(309, 17);
            this.btnLbl.TabIndex = 6;
            this.btnLbl.Text = "Enable/Disable Character Express (Click Here) :";
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.ForeColor = System.Drawing.Color.White;
            this.lblX.Location = new System.Drawing.Point(464, 149);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(23, 13);
            this.lblX.TabIndex = 7;
            this.lblX.Text = "X  :";
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.ForeColor = System.Drawing.Color.White;
            this.lblY.Location = new System.Drawing.Point(586, 151);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(23, 13);
            this.lblY.TabIndex = 8;
            this.lblY.Text = "Y  :";
            // 
            // txtValueX
            // 
            this.txtValueX.Location = new System.Drawing.Point(493, 146);
            this.txtValueX.Name = "txtValueX";
            this.txtValueX.Size = new System.Drawing.Size(66, 20);
            this.txtValueX.TabIndex = 9;
            // 
            // txtValueY
            // 
            this.txtValueY.Location = new System.Drawing.Point(615, 146);
            this.txtValueY.Name = "txtValueY";
            this.txtValueY.Size = new System.Drawing.Size(66, 20);
            this.txtValueY.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtValueY);
            this.Controls.Add(this.txtValueX);
            this.Controls.Add(this.lblY);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.btnLbl);
            this.Controls.Add(this.btnCharVisiblity);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.textLabel1);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.quetextBox);
            this.Controls.Add(this.headLabel);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button submitButton;
        public System.Windows.Forms.Label textLabel1;
        public System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Label headLabel;
        public System.Windows.Forms.TextBox quetextBox;
        private System.Windows.Forms.Button btnCharVisiblity;
        private System.Windows.Forms.Label btnLbl;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.TextBox txtValueX;
        private System.Windows.Forms.TextBox txtValueY;
    }
}

