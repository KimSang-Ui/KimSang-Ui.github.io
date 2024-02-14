namespace WinFormsApp_코드리뷰_스탑워치_
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            button4 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(43, 28);
            label1.Name = "label1";
            label1.Size = new Size(157, 28);
            label1.TabIndex = 0;
            label1.Text = "C# - StopWatch";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Impact", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(208, 142);
            label2.Name = "label2";
            label2.Size = new Size(147, 42);
            label2.TabIndex = 0;
            label2.Text = "0 : 0 : 0 : 0";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveBorder;
            button1.Font = new Font("Impact", 12F);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(43, 265);
            button1.Name = "button1";
            button1.Size = new Size(94, 39);
            button1.TabIndex = 1;
            button1.Text = "Start";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveBorder;
            button2.Font = new Font("Impact", 12F);
            button2.ForeColor = SystemColors.ActiveCaptionText;
            button2.Location = new Point(239, 265);
            button2.Name = "button2";
            button2.Size = new Size(94, 39);
            button2.TabIndex = 1;
            button2.Text = "Stop";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ActiveBorder;
            button3.Font = new Font("Impact", 12F);
            button3.ForeColor = SystemColors.ActiveCaptionText;
            button3.Location = new Point(435, 265);
            button3.Name = "button3";
            button3.Size = new Size(94, 39);
            button3.TabIndex = 1;
            button3.Text = "Reset";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ActiveBorder;
            button4.Font = new Font("Impact", 12F);
            button4.ForeColor = SystemColors.ActiveCaptionText;
            button4.Location = new Point(435, 28);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 2;
            button4.Text = "Alarm";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button button1;
        private Button button2;
        private Button button3;
        private System.Windows.Forms.Timer timer1;
        private Button button4;
    }
}
