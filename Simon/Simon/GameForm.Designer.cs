namespace MemoryGame
{
    partial class GameForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.gameButton5 = new MemoryGame.gameButton();
            this.gameButton6 = new MemoryGame.gameButton();
            this.gameButton7 = new MemoryGame.gameButton();
            this.gameButton8 = new MemoryGame.gameButton();
            this.gameButton9 = new MemoryGame.gameButton();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(86, 96);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(167, 96);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "gameButton2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // gameButton5
            // 
            this.gameButton5.Clicked = false;
            this.gameButton5.Location = new System.Drawing.Point(120, 150);
            this.gameButton5.Name = "gameButton5";
            this.gameButton5.Rotation = 0;
            this.gameButton5.Size = new System.Drawing.Size(75, 23);
            this.gameButton5.TabIndex = 5;
            this.gameButton5.Text = "gameButton5";
            this.gameButton5.UseVisualStyleBackColor = true;
            this.gameButton5.Click += new System.EventHandler(this.gameButton_Click);
            // 
            // gameButton6
            // 
            this.gameButton6.Clicked = false;
            this.gameButton6.Location = new System.Drawing.Point(33, 32);
            this.gameButton6.Name = "gameButton6";
            this.gameButton6.Rotation = 0;
            this.gameButton6.Size = new System.Drawing.Size(75, 23);
            this.gameButton6.TabIndex = 6;
            this.gameButton6.Text = "gameButton1";
            this.gameButton6.UseVisualStyleBackColor = true;
            // 
            // gameButton7
            // 
            this.gameButton7.Clicked = false;
            this.gameButton7.Location = new System.Drawing.Point(167, 31);
            this.gameButton7.Name = "gameButton7";
            this.gameButton7.Rotation = 0;
            this.gameButton7.Size = new System.Drawing.Size(75, 23);
            this.gameButton7.TabIndex = 7;
            this.gameButton7.Text = "gameButton2";
            this.gameButton7.UseVisualStyleBackColor = true;
            // 
            // gameButton8
            // 
            this.gameButton8.Clicked = false;
            this.gameButton8.Location = new System.Drawing.Point(52, 149);
            this.gameButton8.Name = "gameButton8";
            this.gameButton8.Rotation = 0;
            this.gameButton8.Size = new System.Drawing.Size(75, 23);
            this.gameButton8.TabIndex = 8;
            this.gameButton8.Text = "gameButton3";
            this.gameButton8.UseVisualStyleBackColor = true;
            // 
            // gameButton9
            // 
            this.gameButton9.Clicked = false;
            this.gameButton9.Location = new System.Drawing.Point(202, 149);
            this.gameButton9.Name = "gameButton9";
            this.gameButton9.Rotation = 0;
            this.gameButton9.Size = new System.Drawing.Size(75, 23);
            this.gameButton9.TabIndex = 9;
            this.gameButton9.Text = "gameButton4";
            this.gameButton9.UseVisualStyleBackColor = true;
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.gameButton9);
            this.Controls.Add(this.gameButton8);
            this.Controls.Add(this.gameButton7);
            this.Controls.Add(this.gameButton6);
            this.Controls.Add(this.gameButton5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "GameForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private gameButton gameButton5;
        private gameButton gameButton6;
        private gameButton gameButton7;
        private gameButton gameButton8;
        private gameButton gameButton9;
    }
}

