namespace vaja3
{
    partial class vsPc
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
            this.components = new System.ComponentModel.Container();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.AImoves = new System.Windows.Forms.Timer(this.components);
            this.button10 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(164, 277);
            this.button9.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(69, 80);
            this.button9.TabIndex = 19;
            this.button9.Tag = "play";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.playerClick);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(88, 277);
            this.button8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(69, 80);
            this.button8.TabIndex = 18;
            this.button8.Tag = "play";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.playerClick);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(13, 277);
            this.button7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(69, 80);
            this.button7.TabIndex = 17;
            this.button7.Tag = "play";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.playerClick);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(164, 189);
            this.button6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(69, 80);
            this.button6.TabIndex = 16;
            this.button6.Tag = "play";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.playerClick);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(88, 189);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(69, 80);
            this.button5.TabIndex = 15;
            this.button5.Tag = "play";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.playerClick);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(13, 189);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(69, 80);
            this.button4.TabIndex = 14;
            this.button4.Tag = "play";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.playerClick);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(164, 101);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(69, 80);
            this.button3.TabIndex = 13;
            this.button3.Tag = "play";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.playerClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(88, 101);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(69, 80);
            this.button2.TabIndex = 12;
            this.button2.Tag = "play";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.playerClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 101);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 80);
            this.button1.TabIndex = 11;
            this.button1.Tag = "play";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.playerClick);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(11, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 75);
            this.label1.TabIndex = 10;
            this.label1.Text = "Your turn!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AImoves
            // 
            this.AImoves.Interval = 1000;
            this.AImoves.Tick += new System.EventHandler(this.AImove);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(73, 380);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(94, 29);
            this.button10.TabIndex = 20;
            this.button10.Text = "Restart";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.restartGame);
            // 
            // vsPc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 421);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "vsPc";
            this.Text = "vsPc";
            this.ResumeLayout(false);

        }

        #endregion

        private Button button9;
        private Button button8;
        private Button button7;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Label label1;
        private System.Windows.Forms.Timer AImoves;
        private Button button10;
    }
}