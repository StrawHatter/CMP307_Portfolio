namespace DogeConsultancyTest
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.player_namem = new System.Windows.Forms.Label();
            this.score_l = new System.Windows.Forms.Label();
            this.image_card = new System.Windows.Forms.PictureBox();
            this.yes_button = new System.Windows.Forms.Button();
            this.no_button = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Earnings_label = new System.Windows.Forms.Label();
            this.Popularity_label = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Label();
            this.wealth_score = new System.Windows.Forms.Label();
            this.popularity_score = new System.Windows.Forms.Label();
            this.image_description = new System.Windows.Forms.TextBox();
            this.mins_left = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.image_card)).BeginInit();
            this.SuspendLayout();
            // 
            // player_namem
            // 
            this.player_namem.AutoSize = true;
            this.player_namem.BackColor = System.Drawing.Color.Transparent;
            this.player_namem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player_namem.ForeColor = System.Drawing.Color.White;
            this.player_namem.Location = new System.Drawing.Point(13, 547);
            this.player_namem.Name = "player_namem";
            this.player_namem.Size = new System.Drawing.Size(100, 20);
            this.player_namem.TabIndex = 0;
            this.player_namem.Text = "player_name";
            // 
            // score_l
            // 
            this.score_l.AutoSize = true;
            this.score_l.BackColor = System.Drawing.Color.Transparent;
            this.score_l.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score_l.ForeColor = System.Drawing.Color.White;
            this.score_l.Location = new System.Drawing.Point(269, 547);
            this.score_l.Name = "score_l";
            this.score_l.Size = new System.Drawing.Size(20, 24);
            this.score_l.TabIndex = 1;
            this.score_l.Text = "0";
            // 
            // image_card
            // 
            this.image_card.Image = ((System.Drawing.Image)(resources.GetObject("image_card.Image")));
            this.image_card.Location = new System.Drawing.Point(52, 221);
            this.image_card.Name = "image_card";
            this.image_card.Size = new System.Drawing.Size(260, 260);
            this.image_card.TabIndex = 3;
            this.image_card.TabStop = false;
            // 
            // yes_button
            // 
            this.yes_button.BackColor = System.Drawing.Color.Transparent;
            this.yes_button.FlatAppearance.BorderSize = 0;
            this.yes_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yes_button.ForeColor = System.Drawing.Color.Transparent;
            this.yes_button.Location = new System.Drawing.Point(17, 221);
            this.yes_button.Name = "yes_button";
            this.yes_button.Size = new System.Drawing.Size(38, 260);
            this.yes_button.TabIndex = 4;
            this.yes_button.UseVisualStyleBackColor = false;
            this.yes_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // no_button
            // 
            this.no_button.BackColor = System.Drawing.Color.Transparent;
            this.no_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.no_button.FlatAppearance.BorderSize = 0;
            this.no_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.no_button.ForeColor = System.Drawing.Color.Transparent;
            this.no_button.Location = new System.Drawing.Point(309, 221);
            this.no_button.Name = "no_button";
            this.no_button.Size = new System.Drawing.Size(38, 260);
            this.no_button.TabIndex = 5;
            this.no_button.UseVisualStyleBackColor = false;
            this.no_button.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(325, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(22, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "x";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Earnings_label
            // 
            this.Earnings_label.AutoSize = true;
            this.Earnings_label.BackColor = System.Drawing.Color.Transparent;
            this.Earnings_label.ForeColor = System.Drawing.Color.White;
            this.Earnings_label.Location = new System.Drawing.Point(270, 44);
            this.Earnings_label.Name = "Earnings_label";
            this.Earnings_label.Size = new System.Drawing.Size(48, 13);
            this.Earnings_label.TabIndex = 10;
            this.Earnings_label.Text = "Earnings";
            // 
            // Popularity_label
            // 
            this.Popularity_label.AutoSize = true;
            this.Popularity_label.BackColor = System.Drawing.Color.Transparent;
            this.Popularity_label.ForeColor = System.Drawing.Color.White;
            this.Popularity_label.Location = new System.Drawing.Point(51, 44);
            this.Popularity_label.Name = "Popularity_label";
            this.Popularity_label.Size = new System.Drawing.Size(53, 13);
            this.Popularity_label.TabIndex = 11;
            this.Popularity_label.Text = "Popularity";
            // 
            // timer
            // 
            this.timer.AutoSize = true;
            this.timer.BackColor = System.Drawing.Color.Transparent;
            this.timer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.timer.ForeColor = System.Drawing.Color.White;
            this.timer.Location = new System.Drawing.Point(168, 37);
            this.timer.Name = "timer";
            this.timer.Size = new System.Drawing.Size(0, 20);
            this.timer.TabIndex = 12;
            // 
            // wealth_score
            // 
            this.wealth_score.AutoSize = true;
            this.wealth_score.BackColor = System.Drawing.Color.Transparent;
            this.wealth_score.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.wealth_score.ForeColor = System.Drawing.Color.White;
            this.wealth_score.Location = new System.Drawing.Point(278, 15);
            this.wealth_score.Name = "wealth_score";
            this.wealth_score.Size = new System.Drawing.Size(24, 17);
            this.wealth_score.TabIndex = 13;
            this.wealth_score.Text = "50";
            // 
            // popularity_score
            // 
            this.popularity_score.AutoSize = true;
            this.popularity_score.BackColor = System.Drawing.Color.Transparent;
            this.popularity_score.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.popularity_score.ForeColor = System.Drawing.Color.White;
            this.popularity_score.Location = new System.Drawing.Point(65, 15);
            this.popularity_score.Name = "popularity_score";
            this.popularity_score.Size = new System.Drawing.Size(24, 17);
            this.popularity_score.TabIndex = 14;
            this.popularity_score.Text = "50";
            // 
            // image_description
            // 
            this.image_description.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.image_description.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.image_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.image_description.ForeColor = System.Drawing.Color.White;
            this.image_description.Location = new System.Drawing.Point(54, 114);
            this.image_description.Multiline = true;
            this.image_description.Name = "image_description";
            this.image_description.Size = new System.Drawing.Size(258, 80);
            this.image_description.TabIndex = 16;
            this.image_description.Text = "Example image description.";
            // 
            // mins_left
            // 
            this.mins_left.AutoSize = true;
            this.mins_left.BackColor = System.Drawing.Color.Transparent;
            this.mins_left.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.mins_left.ForeColor = System.Drawing.Color.White;
            this.mins_left.Location = new System.Drawing.Point(149, 9);
            this.mins_left.Name = "mins_left";
            this.mins_left.Size = new System.Drawing.Size(80, 17);
            this.mins_left.TabIndex = 17;
            this.mins_left.Text = "Minutes left";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(359, 629);
            this.Controls.Add(this.mins_left);
            this.Controls.Add(this.image_description);
            this.Controls.Add(this.popularity_score);
            this.Controls.Add(this.wealth_score);
            this.Controls.Add(this.timer);
            this.Controls.Add(this.Popularity_label);
            this.Controls.Add(this.Earnings_label);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.score_l);
            this.Controls.Add(this.player_namem);
            this.Controls.Add(this.no_button);
            this.Controls.Add(this.yes_button);
            this.Controls.Add(this.image_card);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.image_card)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label score_l;
        private System.Windows.Forms.PictureBox image_card;
        private System.Windows.Forms.Label player_namem;
        private System.Windows.Forms.Button yes_button;
        private System.Windows.Forms.Button no_button;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label Earnings_label;
        private System.Windows.Forms.Label Popularity_label;
        private System.Windows.Forms.Label timer;
        private System.Windows.Forms.Label wealth_score;
        private System.Windows.Forms.Label popularity_score;
        private System.Windows.Forms.TextBox image_description;
        private System.Windows.Forms.Label mins_left;
    }
}