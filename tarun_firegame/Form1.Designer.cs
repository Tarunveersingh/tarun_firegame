using System;

namespace tarun_firegame
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
            this.label1 = new System.Windows.Forms.Label();
            this.tarun_start = new System.Windows.Forms.Button();
            this.tarun_load = new System.Windows.Forms.Button();
            this.tarun_spin = new System.Windows.Forms.Button();
            this.tarun_soot = new System.Windows.Forms.Button();
            this.tarun_shoot_away = new System.Windows.Forms.Button();
            this.tarun_reload = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(352, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 79);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fire Here";
            // 
            // tarun_start
            // 
            this.tarun_start.BackColor = System.Drawing.Color.Gainsboro;
            this.tarun_start.Location = new System.Drawing.Point(15, 38);
            this.tarun_start.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.tarun_start.Name = "tarun_start";
            this.tarun_start.Size = new System.Drawing.Size(105, 50);
            this.tarun_start.TabIndex = 1;
            this.tarun_start.Text = "Start";
            this.tarun_start.UseVisualStyleBackColor = false;
            this.tarun_start.Click += new System.EventHandler(this.tarun_start_Click);
            // 
            // tarun_load
            // 
            this.tarun_load.BackColor = System.Drawing.Color.Gainsboro;
            this.tarun_load.Location = new System.Drawing.Point(132, 38);
            this.tarun_load.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.tarun_load.Name = "tarun_load";
            this.tarun_load.Size = new System.Drawing.Size(105, 50);
            this.tarun_load.TabIndex = 2;
            this.tarun_load.Text = "Load";
            this.tarun_load.UseVisualStyleBackColor = false;
            this.tarun_load.Click += new System.EventHandler(this.tarun_load_Click);
            // 
            // tarun_spin
            // 
            this.tarun_spin.BackColor = System.Drawing.Color.Gainsboro;
            this.tarun_spin.Location = new System.Drawing.Point(249, 38);
            this.tarun_spin.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.tarun_spin.Name = "tarun_spin";
            this.tarun_spin.Size = new System.Drawing.Size(105, 50);
            this.tarun_spin.TabIndex = 3;
            this.tarun_spin.Text = "Spin";
            this.tarun_spin.UseVisualStyleBackColor = false;
            this.tarun_spin.Click += new System.EventHandler(this.tarun_spin_Click);
            // 
            // tarun_soot
            // 
            this.tarun_soot.BackColor = System.Drawing.Color.Gainsboro;
            this.tarun_soot.Location = new System.Drawing.Point(621, 38);
            this.tarun_soot.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.tarun_soot.Name = "tarun_soot";
            this.tarun_soot.Size = new System.Drawing.Size(105, 50);
            this.tarun_soot.TabIndex = 4;
            this.tarun_soot.Text = "Shoot";
            this.tarun_soot.UseVisualStyleBackColor = false;
            this.tarun_soot.Click += new System.EventHandler(this.tarun_soot_Click);
            // 
            // tarun_shoot_away
            // 
            this.tarun_shoot_away.BackColor = System.Drawing.Color.Gainsboro;
            this.tarun_shoot_away.Location = new System.Drawing.Point(738, 38);
            this.tarun_shoot_away.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.tarun_shoot_away.Name = "tarun_shoot_away";
            this.tarun_shoot_away.Size = new System.Drawing.Size(105, 50);
            this.tarun_shoot_away.TabIndex = 5;
            this.tarun_shoot_away.Text = "Shoot Away";
            this.tarun_shoot_away.UseVisualStyleBackColor = false;
            this.tarun_shoot_away.Click += new System.EventHandler(this.tarun_shoot_away_Click);
            // 
            // tarun_reload
            // 
            this.tarun_reload.BackColor = System.Drawing.Color.Gainsboro;
            this.tarun_reload.Location = new System.Drawing.Point(855, 38);
            this.tarun_reload.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.tarun_reload.Name = "tarun_reload";
            this.tarun_reload.Size = new System.Drawing.Size(105, 50);
            this.tarun_reload.TabIndex = 6;
            this.tarun_reload.Text = "Reload";
            this.tarun_reload.UseVisualStyleBackColor = false;
            this.tarun_reload.Click += new System.EventHandler(this.tarun_reload_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(15, 110);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(940, 385);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(967, 507);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tarun_reload);
            this.Controls.Add(this.tarun_shoot_away);
            this.Controls.Add(this.tarun_soot);
            this.Controls.Add(this.tarun_spin);
            this.Controls.Add(this.tarun_load);
            this.Controls.Add(this.tarun_start);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

    
        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button tarun_start;
        private System.Windows.Forms.Button tarun_load;
        private System.Windows.Forms.Button tarun_spin;
        private System.Windows.Forms.Button tarun_soot;
        private System.Windows.Forms.Button tarun_shoot_away;
        private System.Windows.Forms.Button tarun_reload;
        private System.Windows.Forms.PictureBox pictureBox1;
        
    }
}

