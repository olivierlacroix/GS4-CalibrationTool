namespace GS4_Calibration_Utility
{
    partial class TestForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestForm));
            this.label1 = new System.Windows.Forms.Label();
            this.txtComPort = new System.Windows.Forms.TextBox();
            this.cboServoNumber = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.scrollServo = new System.Windows.Forms.VScrollBar();
            this.btnOnOff = new System.Windows.Forms.Button();
            this.grpIndividualTest = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblportwarning = new System.Windows.Forms.Label();
            this.grpIndividualTest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Com Port";
            // 
            // txtComPort
            // 
            this.txtComPort.Location = new System.Drawing.Point(37, 29);
            this.txtComPort.Name = "txtComPort";
            this.txtComPort.Size = new System.Drawing.Size(47, 20);
            this.txtComPort.TabIndex = 1;
            this.txtComPort.TextChanged += new System.EventHandler(this.txtComPort_TextChanged);
            // 
            // cboServoNumber
            // 
            this.cboServoNumber.FormattingEnabled = true;
            this.cboServoNumber.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15"});
            this.cboServoNumber.Location = new System.Drawing.Point(6, 35);
            this.cboServoNumber.Name = "cboServoNumber";
            this.cboServoNumber.Size = new System.Drawing.Size(121, 21);
            this.cboServoNumber.TabIndex = 2;
            this.cboServoNumber.SelectedIndexChanged += new System.EventHandler(this.cboServoNumber_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Select servo :";
            // 
            // scrollServo
            // 
            this.scrollServo.Enabled = false;
            this.scrollServo.Location = new System.Drawing.Point(28, 116);
            this.scrollServo.Minimum = 1;
            this.scrollServo.Name = "scrollServo";
            this.scrollServo.Size = new System.Drawing.Size(50, 141);
            this.scrollServo.TabIndex = 4;
            this.scrollServo.Value = 50;
            this.scrollServo.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scrollServo_Scroll);
            // 
            // btnOnOff
            // 
            this.btnOnOff.BackColor = System.Drawing.Color.Red;
            this.btnOnOff.Location = new System.Drawing.Point(37, 73);
            this.btnOnOff.Name = "btnOnOff";
            this.btnOnOff.Size = new System.Drawing.Size(75, 23);
            this.btnOnOff.TabIndex = 5;
            this.btnOnOff.Text = "OFF";
            this.btnOnOff.UseVisualStyleBackColor = false;
            this.btnOnOff.Click += new System.EventHandler(this.btnOnOff_Click);
            // 
            // grpIndividualTest
            // 
            this.grpIndividualTest.Controls.Add(this.label3);
            this.grpIndividualTest.Controls.Add(this.label2);
            this.grpIndividualTest.Controls.Add(this.cboServoNumber);
            this.grpIndividualTest.Controls.Add(this.scrollServo);
            this.grpIndividualTest.Enabled = false;
            this.grpIndividualTest.Location = new System.Drawing.Point(37, 130);
            this.grpIndividualTest.Name = "grpIndividualTest";
            this.grpIndividualTest.Size = new System.Drawing.Size(168, 308);
            this.grpIndividualTest.TabIndex = 6;
            this.grpIndividualTest.TabStop = false;
            this.grpIndividualTest.Text = "Individual servo testing";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Move servo slider";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(284, 130);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(316, 292);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(190, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(406, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "**Do not do these tests while seated in your GS4!";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(376, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "Servo number layout";
            // 
            // lblportwarning
            // 
            this.lblportwarning.AutoSize = true;
            this.lblportwarning.ForeColor = System.Drawing.Color.Red;
            this.lblportwarning.Location = new System.Drawing.Point(37, 54);
            this.lblportwarning.Name = "lblportwarning";
            this.lblportwarning.Size = new System.Drawing.Size(120, 13);
            this.lblportwarning.TabIndex = 10;
            this.lblportwarning.Text = "Not a valid port number!";
            this.lblportwarning.Visible = false;
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 450);
            this.Controls.Add(this.lblportwarning);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.grpIndividualTest);
            this.Controls.Add(this.btnOnOff);
            this.Controls.Add(this.txtComPort);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "TestForm";
            this.Text = "GS4 test center";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TestForm_FormClosed);
            this.Load += new System.EventHandler(this.TestForm_Load);
            this.grpIndividualTest.ResumeLayout(false);
            this.grpIndividualTest.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtComPort;
        private System.Windows.Forms.ComboBox cboServoNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.VScrollBar scrollServo;
        private System.Windows.Forms.Button btnOnOff;
        private System.Windows.Forms.GroupBox grpIndividualTest;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblportwarning;
    }
}