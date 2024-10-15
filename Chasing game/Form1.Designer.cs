namespace Chasing_game
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
            play = new PictureBox();
            timer = new System.Windows.Forms.Timer(components);
            chase = new PictureBox();
            scoreTimer = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            scored = new TextBox();
            ChaserMove = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)play).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chase).BeginInit();
            SuspendLayout();
            // 
            // play
            // 
            play.Image = Properties.Resources.w_i_d_e_pope;
            play.Location = new Point(321, 204);
            play.Name = "play";
            play.Size = new Size(57, 43);
            play.SizeMode = PictureBoxSizeMode.StretchImage;
            play.TabIndex = 0;
            play.TabStop = false;
            // 
            // timer
            // 
            timer.Enabled = true;
            timer.Interval = 17;
            timer.Tick += timer_Tick;
            // 
            // chase
            // 
            chase.Image = Properties.Resources.something;
            chase.Location = new Point(136, 104);
            chase.Name = "chase";
            chase.Size = new Size(113, 97);
            chase.SizeMode = PictureBoxSizeMode.StretchImage;
            chase.TabIndex = 1;
            chase.TabStop = false;
            // 
            // scoreTimer
            // 
            scoreTimer.Enabled = true;
            scoreTimer.Interval = 10000;
            scoreTimer.Tick += scoreTimer_Tick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(567, 21);
            label1.Name = "label1";
            label1.Size = new Size(111, 25);
            label1.TabIndex = 2;
            label1.Text = "player score:";
            // 
            // scored
            // 
            scored.Location = new Point(683, 19);
            scored.Name = "scored";
            scored.ReadOnly = true;
            scored.Size = new Size(117, 31);
            scored.TabIndex = 3;
            scored.Text = "0";
            // 
            // ChaserMove
            // 
            ChaserMove.Interval = 300;
            ChaserMove.Tick += ChaserMove_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(scored);
            Controls.Add(label1);
            Controls.Add(chase);
            Controls.Add(play);
            KeyPreview = true;
            Name = "Form1";
            Text = "Form1";
            KeyDown += Form1_KeyDown;
            KeyUp += Form1_KeyUp;
            ((System.ComponentModel.ISupportInitialize)play).EndInit();
            ((System.ComponentModel.ISupportInitialize)chase).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox play;
        private System.Windows.Forms.Timer timer;
        private PictureBox chase;
        private System.Windows.Forms.Timer scoreTimer;
        private Label label1;
        private TextBox scored;
        private System.Windows.Forms.Timer ChaserMove;
    }
}
