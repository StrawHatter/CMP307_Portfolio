namespace DogeConsultancyTest
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.player_namem = new System.Windows.Forms.Label();
            this.score_l = new System.Windows.Forms.Label();
            this.image_card = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.popularity_indicator = new System.Windows.Forms.PictureBox();
            this.wealth_indicator = new System.Windows.Forms.PictureBox();
            this.Wealth_label = new System.Windows.Forms.Label();
            this.Popularity_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.image_card)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popularity_indicator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wealth_indicator)).BeginInit();
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
            this.image_card.Location = new System.Drawing.Point(53, 101);
            this.image_card.Name = "image_card";
            this.image_card.Size = new System.Drawing.Size(260, 380);
            this.image_card.TabIndex = 3;
            this.image_card.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(17, 221);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(38, 260);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.Transparent;
            this.button2.Location = new System.Drawing.Point(309, 221);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(38, 260);
            this.button2.TabIndex = 5;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(337, 1);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(22, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "x";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // popularity_indicator
            // 
            this.popularity_indicator.BackColor = System.Drawing.Color.Transparent;
            this.popularity_indicator.Image = global::DogeConsultancyTest.Properties.Resources.empty_bar;
            this.popularity_indicator.Location = new System.Drawing.Point(53, 1);
            this.popularity_indicator.Name = "popularity_indicator";
            this.popularity_indicator.Size = new System.Drawing.Size(50, 50);
            this.popularity_indicator.TabIndex = 7;
            this.popularity_indicator.TabStop = false;
            this.popularity_indicator.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // wealth_indicator
            // 
            this.wealth_indicator.BackColor = System.Drawing.Color.Transparent;
            this.wealth_indicator.Image = global::DogeConsultancyTest.Properties.Resources.empty_bar;
            this.wealth_indicator.Location = new System.Drawing.Point(263, 1);
            this.wealth_indicator.Name = "wealth_indicator";
            this.wealth_indicator.Size = new System.Drawing.Size(50, 50);
            this.wealth_indicator.TabIndex = 8;
            this.wealth_indicator.TabStop = false;
            this.wealth_indicator.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // Wealth_label
            // 
            this.Wealth_label.AutoSize = true;
            this.Wealth_label.BackColor = System.Drawing.Color.Transparent;
            this.Wealth_label.ForeColor = System.Drawing.Color.White;
            this.Wealth_label.Location = new System.Drawing.Point(267, 52);
            this.Wealth_label.Name = "Wealth_label";
            this.Wealth_label.Size = new System.Drawing.Size(41, 13);
            this.Wealth_label.TabIndex = 10;
            this.Wealth_label.Text = "Wealth";
            // 
            // Popularity_label
            // 
            this.Popularity_label.AutoSize = true;
            this.Popularity_label.BackColor = System.Drawing.Color.Transparent;
            this.Popularity_label.ForeColor = System.Drawing.Color.White;
            this.Popularity_label.Location = new System.Drawing.Point(51, 52);
            this.Popularity_label.Name = "Popularity_label";
            this.Popularity_label.Size = new System.Drawing.Size(53, 13);
            this.Popularity_label.TabIndex = 11;
            this.Popularity_label.Text = "Popularity";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(359, 629);
            this.Controls.Add(this.Popularity_label);
            this.Controls.Add(this.Wealth_label);
            this.Controls.Add(this.wealth_indicator);
            this.Controls.Add(this.popularity_indicator);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.score_l);
            this.Controls.Add(this.player_namem);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.image_card);
            this.Name = "Form2";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.image_card)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popularity_indicator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wealth_indicator)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label score_l;
        private System.Windows.Forms.PictureBox image_card;
        private System.Windows.Forms.Label player_namem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox popularity_indicator;
        private System.Windows.Forms.PictureBox wealth_indicator;
        private System.Windows.Forms.Label Wealth_label;
        private System.Windows.Forms.Label Popularity_label;
    }
}