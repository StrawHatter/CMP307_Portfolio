namespace DogeConsultancyTest
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.add_question_label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.remove_submit = new System.Windows.Forms.Button();
            this.remove_list = new System.Windows.Forms.ComboBox();
            this.exit_admin = new System.Windows.Forms.Button();
            this.welcome_admin = new System.Windows.Forms.Label();
            this.image_description = new System.Windows.Forms.Label();
            this.add_submit = new System.Windows.Forms.Button();
            this.image_description_input = new System.Windows.Forms.TextBox();
            this.remove_description = new System.Windows.Forms.Label();
            this.e_pos_score_label = new System.Windows.Forms.Label();
            this.p_pos_score_label = new System.Windows.Forms.Label();
            this.e_neg_score_label = new System.Windows.Forms.Label();
            this.p_neg_score_label = new System.Windows.Forms.Label();
            this.earnings_label = new System.Windows.Forms.Label();
            this.popularity_label = new System.Windows.Forms.Label();
            this.e_pos_score = new System.Windows.Forms.TextBox();
            this.e_neg_score = new System.Windows.Forms.TextBox();
            this.p_pos_score = new System.Windows.Forms.TextBox();
            this.p_neg_score = new System.Windows.Forms.TextBox();
            this.image_url_input = new System.Windows.Forms.TextBox();
            this.lbl_url = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // add_question_label
            // 
            this.add_question_label.AutoSize = true;
            this.add_question_label.BackColor = System.Drawing.Color.Transparent;
            this.add_question_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.add_question_label.ForeColor = System.Drawing.Color.Black;
            this.add_question_label.Location = new System.Drawing.Point(97, 59);
            this.add_question_label.Name = "add_question_label";
            this.add_question_label.Size = new System.Drawing.Size(154, 29);
            this.add_question_label.TabIndex = 1;
            this.add_question_label.Text = "Add question";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(79, 502);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 29);
            this.label2.TabIndex = 17;
            this.label2.Text = "Remove question";
            // 
            // remove_submit
            // 
            this.remove_submit.Location = new System.Drawing.Point(139, 620);
            this.remove_submit.Name = "remove_submit";
            this.remove_submit.Size = new System.Drawing.Size(75, 23);
            this.remove_submit.TabIndex = 20;
            this.remove_submit.Text = "Remove";
            this.remove_submit.UseVisualStyleBackColor = true;
            this.remove_submit.Click += new System.EventHandler(this.remove_submit_Click);
            // 
            // remove_list
            // 
            this.remove_list.FormattingEnabled = true;
            this.remove_list.Location = new System.Drawing.Point(39, 574);
            this.remove_list.Name = "remove_list";
            this.remove_list.Size = new System.Drawing.Size(280, 21);
            this.remove_list.TabIndex = 19;
            // 
            // exit_admin
            // 
            this.exit_admin.BackColor = System.Drawing.Color.Transparent;
            this.exit_admin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_admin.ForeColor = System.Drawing.Color.Black;
            this.exit_admin.Location = new System.Drawing.Point(325, 12);
            this.exit_admin.Name = "exit_admin";
            this.exit_admin.Size = new System.Drawing.Size(22, 23);
            this.exit_admin.TabIndex = 21;
            this.exit_admin.Text = "x";
            this.exit_admin.UseVisualStyleBackColor = false;
            this.exit_admin.Click += new System.EventHandler(this.exit_admin_Click);
            // 
            // welcome_admin
            // 
            this.welcome_admin.AutoSize = true;
            this.welcome_admin.BackColor = System.Drawing.Color.Transparent;
            this.welcome_admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.welcome_admin.ForeColor = System.Drawing.Color.Black;
            this.welcome_admin.Location = new System.Drawing.Point(9, 12);
            this.welcome_admin.Name = "welcome_admin";
            this.welcome_admin.Size = new System.Drawing.Size(182, 26);
            this.welcome_admin.TabIndex = 0;
            this.welcome_admin.Text = "Welcome admin, ";
            // 
            // image_description
            // 
            this.image_description.AutoSize = true;
            this.image_description.BackColor = System.Drawing.Color.Transparent;
            this.image_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.image_description.ForeColor = System.Drawing.Color.Black;
            this.image_description.Location = new System.Drawing.Point(9, 102);
            this.image_description.Name = "image_description";
            this.image_description.Size = new System.Drawing.Size(121, 17);
            this.image_description.TabIndex = 2;
            this.image_description.Text = "Image Description";
            // 
            // add_submit
            // 
            this.add_submit.Location = new System.Drawing.Point(139, 464);
            this.add_submit.Name = "add_submit";
            this.add_submit.Size = new System.Drawing.Size(75, 23);
            this.add_submit.TabIndex = 16;
            this.add_submit.Text = "Add";
            this.add_submit.UseVisualStyleBackColor = true;
            this.add_submit.Click += new System.EventHandler(this.add_submit_Click);
            // 
            // image_description_input
            // 
            this.image_description_input.Location = new System.Drawing.Point(12, 122);
            this.image_description_input.Multiline = true;
            this.image_description_input.Name = "image_description_input";
            this.image_description_input.Size = new System.Drawing.Size(332, 82);
            this.image_description_input.TabIndex = 3;
            // 
            // remove_description
            // 
            this.remove_description.AutoSize = true;
            this.remove_description.BackColor = System.Drawing.Color.Transparent;
            this.remove_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.remove_description.ForeColor = System.Drawing.Color.Black;
            this.remove_description.Location = new System.Drawing.Point(75, 543);
            this.remove_description.Name = "remove_description";
            this.remove_description.Size = new System.Drawing.Size(219, 17);
            this.remove_description.TabIndex = 18;
            this.remove_description.Text = "Please select which ID to remove:";
            // 
            // e_pos_score_label
            // 
            this.e_pos_score_label.AutoSize = true;
            this.e_pos_score_label.BackColor = System.Drawing.Color.Transparent;
            this.e_pos_score_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.e_pos_score_label.ForeColor = System.Drawing.Color.Black;
            this.e_pos_score_label.Location = new System.Drawing.Point(18, 307);
            this.e_pos_score_label.Name = "e_pos_score_label";
            this.e_pos_score_label.Size = new System.Drawing.Size(75, 13);
            this.e_pos_score_label.TabIndex = 7;
            this.e_pos_score_label.Text = "Positive Score";
            // 
            // p_pos_score_label
            // 
            this.p_pos_score_label.AutoSize = true;
            this.p_pos_score_label.BackColor = System.Drawing.Color.Transparent;
            this.p_pos_score_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p_pos_score_label.ForeColor = System.Drawing.Color.Black;
            this.p_pos_score_label.Location = new System.Drawing.Point(18, 399);
            this.p_pos_score_label.Name = "p_pos_score_label";
            this.p_pos_score_label.Size = new System.Drawing.Size(75, 13);
            this.p_pos_score_label.TabIndex = 12;
            this.p_pos_score_label.Text = "Positive Score";
            // 
            // e_neg_score_label
            // 
            this.e_neg_score_label.AutoSize = true;
            this.e_neg_score_label.BackColor = System.Drawing.Color.Transparent;
            this.e_neg_score_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.e_neg_score_label.ForeColor = System.Drawing.Color.Black;
            this.e_neg_score_label.Location = new System.Drawing.Point(213, 307);
            this.e_neg_score_label.Name = "e_neg_score_label";
            this.e_neg_score_label.Size = new System.Drawing.Size(81, 13);
            this.e_neg_score_label.TabIndex = 9;
            this.e_neg_score_label.Text = "Negative Score";
            // 
            // p_neg_score_label
            // 
            this.p_neg_score_label.AutoSize = true;
            this.p_neg_score_label.BackColor = System.Drawing.Color.Transparent;
            this.p_neg_score_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p_neg_score_label.ForeColor = System.Drawing.Color.Black;
            this.p_neg_score_label.Location = new System.Drawing.Point(213, 399);
            this.p_neg_score_label.Name = "p_neg_score_label";
            this.p_neg_score_label.Size = new System.Drawing.Size(81, 13);
            this.p_neg_score_label.TabIndex = 14;
            this.p_neg_score_label.Text = "Negative Score";
            // 
            // earnings_label
            // 
            this.earnings_label.AutoSize = true;
            this.earnings_label.BackColor = System.Drawing.Color.Transparent;
            this.earnings_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.earnings_label.ForeColor = System.Drawing.Color.Black;
            this.earnings_label.Location = new System.Drawing.Point(18, 280);
            this.earnings_label.Name = "earnings_label";
            this.earnings_label.Size = new System.Drawing.Size(64, 17);
            this.earnings_label.TabIndex = 6;
            this.earnings_label.Text = "Earnings";
            // 
            // popularity_label
            // 
            this.popularity_label.AutoSize = true;
            this.popularity_label.BackColor = System.Drawing.Color.Transparent;
            this.popularity_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.popularity_label.ForeColor = System.Drawing.Color.Black;
            this.popularity_label.Location = new System.Drawing.Point(18, 369);
            this.popularity_label.Name = "popularity_label";
            this.popularity_label.Size = new System.Drawing.Size(71, 17);
            this.popularity_label.TabIndex = 11;
            this.popularity_label.Text = "Popularity";
            // 
            // e_pos_score
            // 
            this.e_pos_score.Location = new System.Drawing.Point(21, 323);
            this.e_pos_score.Name = "e_pos_score";
            this.e_pos_score.Size = new System.Drawing.Size(86, 20);
            this.e_pos_score.TabIndex = 8;
            this.e_pos_score.Text = "Example: 15";
            // 
            // e_neg_score
            // 
            this.e_neg_score.Location = new System.Drawing.Point(217, 323);
            this.e_neg_score.Name = "e_neg_score";
            this.e_neg_score.Size = new System.Drawing.Size(90, 20);
            this.e_neg_score.TabIndex = 10;
            this.e_neg_score.Text = "Example: -15";
            // 
            // p_pos_score
            // 
            this.p_pos_score.Location = new System.Drawing.Point(21, 415);
            this.p_pos_score.Name = "p_pos_score";
            this.p_pos_score.Size = new System.Drawing.Size(86, 20);
            this.p_pos_score.TabIndex = 13;
            this.p_pos_score.Text = "Example: 15";
            // 
            // p_neg_score
            // 
            this.p_neg_score.Location = new System.Drawing.Point(217, 415);
            this.p_neg_score.Name = "p_neg_score";
            this.p_neg_score.Size = new System.Drawing.Size(90, 20);
            this.p_neg_score.TabIndex = 15;
            this.p_neg_score.Text = "Example: -15";
            // 
            // image_url_input
            // 
            this.image_url_input.Location = new System.Drawing.Point(12, 257);
            this.image_url_input.Name = "image_url_input";
            this.image_url_input.Size = new System.Drawing.Size(332, 20);
            this.image_url_input.TabIndex = 22;
            // 
            // lbl_url
            // 
            this.lbl_url.AutoSize = true;
            this.lbl_url.BackColor = System.Drawing.Color.Transparent;
            this.lbl_url.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_url.ForeColor = System.Drawing.Color.Black;
            this.lbl_url.Location = new System.Drawing.Point(9, 237);
            this.lbl_url.Name = "lbl_url";
            this.lbl_url.Size = new System.Drawing.Size(78, 17);
            this.lbl_url.TabIndex = 23;
            this.lbl_url.Text = "Image URL";
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(359, 654);
            this.Controls.Add(this.lbl_url);
            this.Controls.Add(this.image_url_input);
            this.Controls.Add(this.p_neg_score);
            this.Controls.Add(this.p_pos_score);
            this.Controls.Add(this.e_neg_score);
            this.Controls.Add(this.e_pos_score);
            this.Controls.Add(this.popularity_label);
            this.Controls.Add(this.earnings_label);
            this.Controls.Add(this.p_neg_score_label);
            this.Controls.Add(this.e_neg_score_label);
            this.Controls.Add(this.p_pos_score_label);
            this.Controls.Add(this.e_pos_score_label);
            this.Controls.Add(this.remove_description);
            this.Controls.Add(this.image_description_input);
            this.Controls.Add(this.add_submit);
            this.Controls.Add(this.image_description);
            this.Controls.Add(this.welcome_admin);
            this.Controls.Add(this.exit_admin);
            this.Controls.Add(this.remove_list);
            this.Controls.Add(this.remove_submit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.add_question_label);
            this.MaximumSize = new System.Drawing.Size(375, 692);
            this.MinimumSize = new System.Drawing.Size(375, 692);
            this.Name = "Admin";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label add_question_label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button remove_submit;
        private System.Windows.Forms.ComboBox remove_list;
        private System.Windows.Forms.Button exit_admin;
        private System.Windows.Forms.Label welcome_admin;
        private System.Windows.Forms.Label image_description;
        private System.Windows.Forms.Button add_submit;
        private System.Windows.Forms.TextBox image_description_input;
        private System.Windows.Forms.Label remove_description;
        private System.Windows.Forms.Label e_pos_score_label;
        private System.Windows.Forms.Label p_pos_score_label;
        private System.Windows.Forms.Label e_neg_score_label;
        private System.Windows.Forms.Label p_neg_score_label;
        private System.Windows.Forms.Label earnings_label;
        private System.Windows.Forms.Label popularity_label;
        private System.Windows.Forms.TextBox e_pos_score;
        private System.Windows.Forms.TextBox e_neg_score;
        private System.Windows.Forms.TextBox p_pos_score;
        private System.Windows.Forms.TextBox p_neg_score;
        private System.Windows.Forms.TextBox image_url_input;
        private System.Windows.Forms.Label lbl_url;
    }
}