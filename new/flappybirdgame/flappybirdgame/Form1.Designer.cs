namespace flappybirdgame
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
            this.components = new System.ComponentModel.Container();
            this.zemin = new System.Windows.Forms.PictureBox();
            this.balt = new System.Windows.Forms.PictureBox();
            this.kus = new System.Windows.Forms.PictureBox();
            this.bust = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gametimer = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.zemin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.balt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bust)).BeginInit();
            this.SuspendLayout();
            // 
            // zemin
            // 
            this.zemin.Image = global::flappybirdgame.Properties.Resources.ground;
            this.zemin.Location = new System.Drawing.Point(-12, 526);
            this.zemin.Name = "zemin";
            this.zemin.Size = new System.Drawing.Size(691, 95);
            this.zemin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.zemin.TabIndex = 3;
            this.zemin.TabStop = false;
            // 
            // balt
            // 
            this.balt.BackColor = System.Drawing.Color.Transparent;
            this.balt.Image = global::flappybirdgame.Properties.Resources.pipe;
            this.balt.Location = new System.Drawing.Point(365, 404);
            this.balt.Name = "balt";
            this.balt.Size = new System.Drawing.Size(100, 150);
            this.balt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.balt.TabIndex = 2;
            this.balt.TabStop = false;
            // 
            // kus
            // 
            this.kus.Image = global::flappybirdgame.Properties.Resources.bird;
            this.kus.Location = new System.Drawing.Point(77, 251);
            this.kus.Name = "kus";
            this.kus.Size = new System.Drawing.Size(67, 57);
            this.kus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.kus.TabIndex = 1;
            this.kus.TabStop = false;
            // 
            // bust
            // 
            this.bust.BackColor = System.Drawing.Color.Transparent;
            this.bust.Image = global::flappybirdgame.Properties.Resources.pipedown;
            this.bust.Location = new System.Drawing.Point(456, -27);
            this.bust.Name = "bust";
            this.bust.Size = new System.Drawing.Size(109, 224);
            this.bust.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bust.TabIndex = 0;
            this.bust.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 624);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 28);
            this.label1.TabIndex = 4;
            this.label1.Text = "Score: 0";
            // 
            // gametimer
            // 
            this.gametimer.Enabled = true;
            this.gametimer.Interval = 20;
            this.gametimer.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(515, 624);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 27);
            this.label2.TabIndex = 5;
            this.label2.Text = "Yusuf GÜNER";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(673, 650);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.kus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.zemin);
            this.Controls.Add(this.balt);
            this.Controls.Add(this.bust);
            this.Name = "Form1";
            this.Text = "Play Game";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gamekeyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.zemin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.balt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bust)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox bust;
        private System.Windows.Forms.PictureBox kus;
        private System.Windows.Forms.PictureBox balt;
        private System.Windows.Forms.PictureBox zemin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer gametimer;
        private System.Windows.Forms.Label label2;
    }
}

