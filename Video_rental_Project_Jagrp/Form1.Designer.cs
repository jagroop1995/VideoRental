namespace Video_rental_Project_Jagrp
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
            this.data_customer = new System.Windows.Forms.Button();
            this.data_video = new System.Windows.Forms.Button();
            this.data_rental = new System.Windows.Forms.Button();
            this.data_pop_movie = new System.Windows.Forms.Button();
            this.data_pop_customer = new System.Windows.Forms.Button();
            this.DatabaseTable = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.video_del = new System.Windows.Forms.Button();
            this.video_update = new System.Windows.Forms.Button();
            this.video_add = new System.Windows.Forms.Button();
            this.genre = new System.Windows.Forms.TextBox();
            this.plot = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.copies = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cost = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.realease_year = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rate_video = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.del_cust = new System.Windows.Forms.Button();
            this.update_del = new System.Windows.Forms.Button();
            this.add_cust = new System.Windows.Forms.Button();
            this.cus_address = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cus_ph = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cus_email = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cus_name = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.retrn_Date = new System.Windows.Forms.DateTimePicker();
            this.ise_Date = new System.Windows.Forms.DateTimePicker();
            this.del_movie = new System.Windows.Forms.Button();
            this.return_mov = new System.Windows.Forms.Button();
            this.issue_mov = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.mov_id = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.cus_id = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DatabaseTable)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // data_customer
            // 
            this.data_customer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.data_customer.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.data_customer.Location = new System.Drawing.Point(102, 12);
            this.data_customer.Name = "data_customer";
            this.data_customer.Size = new System.Drawing.Size(130, 49);
            this.data_customer.TabIndex = 0;
            this.data_customer.Text = "Customer";
            this.data_customer.UseVisualStyleBackColor = false;
            this.data_customer.Click += new System.EventHandler(this.data_customer_Click);
            // 
            // data_video
            // 
            this.data_video.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.data_video.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.data_video.Location = new System.Drawing.Point(253, 12);
            this.data_video.Name = "data_video";
            this.data_video.Size = new System.Drawing.Size(130, 49);
            this.data_video.TabIndex = 1;
            this.data_video.Text = "Video\'s";
            this.data_video.UseVisualStyleBackColor = false;
            this.data_video.Click += new System.EventHandler(this.data_video_Click);
            // 
            // data_rental
            // 
            this.data_rental.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.data_rental.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.data_rental.Location = new System.Drawing.Point(405, 14);
            this.data_rental.Name = "data_rental";
            this.data_rental.Size = new System.Drawing.Size(130, 49);
            this.data_rental.TabIndex = 2;
            this.data_rental.Text = "Rental";
            this.data_rental.UseVisualStyleBackColor = false;
            this.data_rental.Click += new System.EventHandler(this.data_rental_Click);
            // 
            // data_pop_movie
            // 
            this.data_pop_movie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.data_pop_movie.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.data_pop_movie.Location = new System.Drawing.Point(554, 14);
            this.data_pop_movie.Name = "data_pop_movie";
            this.data_pop_movie.Size = new System.Drawing.Size(130, 49);
            this.data_pop_movie.TabIndex = 3;
            this.data_pop_movie.Text = "POP Movie";
            this.data_pop_movie.UseVisualStyleBackColor = false;
            this.data_pop_movie.Click += new System.EventHandler(this.data_pop_movie_Click);
            // 
            // data_pop_customer
            // 
            this.data_pop_customer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.data_pop_customer.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.data_pop_customer.Location = new System.Drawing.Point(702, 14);
            this.data_pop_customer.Name = "data_pop_customer";
            this.data_pop_customer.Size = new System.Drawing.Size(148, 49);
            this.data_pop_customer.TabIndex = 4;
            this.data_pop_customer.Text = "POP Customer";
            this.data_pop_customer.UseVisualStyleBackColor = false;
            this.data_pop_customer.Click += new System.EventHandler(this.data_pop_customer_Click);
            // 
            // DatabaseTable
            // 
            this.DatabaseTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DatabaseTable.Location = new System.Drawing.Point(2, 67);
            this.DatabaseTable.Name = "DatabaseTable";
            this.DatabaseTable.Size = new System.Drawing.Size(848, 220);
            this.DatabaseTable.TabIndex = 5;
            this.DatabaseTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DatabaseTable_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.video_del);
            this.groupBox1.Controls.Add(this.video_update);
            this.groupBox1.Controls.Add(this.video_add);
            this.groupBox1.Controls.Add(this.genre);
            this.groupBox1.Controls.Add(this.plot);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.copies);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cost);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.realease_year);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.rate_video);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.title);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 293);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(296, 453);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Video\'s";
            // 
            // video_del
            // 
            this.video_del.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.video_del.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.video_del.Location = new System.Drawing.Point(208, 366);
            this.video_del.Name = "video_del";
            this.video_del.Size = new System.Drawing.Size(100, 34);
            this.video_del.TabIndex = 15;
            this.video_del.Text = "Delete";
            this.video_del.UseVisualStyleBackColor = false;
            this.video_del.Click += new System.EventHandler(this.video_del_Click);
            // 
            // video_update
            // 
            this.video_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.video_update.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.video_update.Location = new System.Drawing.Point(106, 366);
            this.video_update.Name = "video_update";
            this.video_update.Size = new System.Drawing.Size(100, 34);
            this.video_update.TabIndex = 14;
            this.video_update.Text = "Update";
            this.video_update.UseVisualStyleBackColor = false;
            this.video_update.Click += new System.EventHandler(this.video_update_Click);
            // 
            // video_add
            // 
            this.video_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.video_add.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.video_add.Location = new System.Drawing.Point(0, 368);
            this.video_add.Name = "video_add";
            this.video_add.Size = new System.Drawing.Size(100, 34);
            this.video_add.TabIndex = 8;
            this.video_add.Text = "Add";
            this.video_add.UseVisualStyleBackColor = false;
            this.video_add.Click += new System.EventHandler(this.video_add_Click);
            // 
            // genre
            // 
            this.genre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genre.Location = new System.Drawing.Point(140, 331);
            this.genre.Name = "genre";
            this.genre.Size = new System.Drawing.Size(127, 29);
            this.genre.TabIndex = 13;
            // 
            // plot
            // 
            this.plot.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plot.Location = new System.Drawing.Point(140, 292);
            this.plot.Name = "plot";
            this.plot.Size = new System.Drawing.Size(127, 29);
            this.plot.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 331);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 22);
            this.label7.TabIndex = 11;
            this.label7.Text = "Genre";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 292);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 22);
            this.label6.TabIndex = 10;
            this.label6.Text = "Plot";
            // 
            // copies
            // 
            this.copies.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copies.Location = new System.Drawing.Point(140, 246);
            this.copies.Name = "copies";
            this.copies.Size = new System.Drawing.Size(127, 29);
            this.copies.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 22);
            this.label5.TabIndex = 8;
            this.label5.Text = "Copies";
            // 
            // cost
            // 
            this.cost.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cost.Location = new System.Drawing.Point(140, 201);
            this.cost.Name = "cost";
            this.cost.ReadOnly = true;
            this.cost.Size = new System.Drawing.Size(127, 29);
            this.cost.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "Cost";
            // 
            // realease_year
            // 
            this.realease_year.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.realease_year.Location = new System.Drawing.Point(140, 147);
            this.realease_year.Name = "realease_year";
            this.realease_year.Size = new System.Drawing.Size(127, 29);
            this.realease_year.TabIndex = 5;
            this.realease_year.TextChanged += new System.EventHandler(this.realease_year_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Year Realease";
            // 
            // rate_video
            // 
            this.rate_video.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rate_video.Location = new System.Drawing.Point(140, 91);
            this.rate_video.Name = "rate_video";
            this.rate_video.Size = new System.Drawing.Size(127, 29);
            this.rate_video.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Rate";
            // 
            // title
            // 
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(140, 39);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(127, 29);
            this.title.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.del_cust);
            this.groupBox2.Controls.Add(this.update_del);
            this.groupBox2.Controls.Add(this.add_cust);
            this.groupBox2.Controls.Add(this.cus_address);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.cus_ph);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.cus_email);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.cus_name);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Location = new System.Drawing.Point(314, 293);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(281, 453);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Customer\'s";
            // 
            // del_cust
            // 
            this.del_cust.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.del_cust.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.del_cust.Location = new System.Drawing.Point(70, 353);
            this.del_cust.Name = "del_cust";
            this.del_cust.Size = new System.Drawing.Size(100, 34);
            this.del_cust.TabIndex = 15;
            this.del_cust.Text = "Delete";
            this.del_cust.UseVisualStyleBackColor = false;
            this.del_cust.Click += new System.EventHandler(this.del_cust_Click);
            // 
            // update_del
            // 
            this.update_del.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.update_del.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_del.Location = new System.Drawing.Point(140, 292);
            this.update_del.Name = "update_del";
            this.update_del.Size = new System.Drawing.Size(100, 34);
            this.update_del.TabIndex = 14;
            this.update_del.Text = "Update";
            this.update_del.UseVisualStyleBackColor = false;
            this.update_del.Click += new System.EventHandler(this.update_del_Click);
            // 
            // add_cust
            // 
            this.add_cust.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.add_cust.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_cust.Location = new System.Drawing.Point(6, 292);
            this.add_cust.Name = "add_cust";
            this.add_cust.Size = new System.Drawing.Size(100, 34);
            this.add_cust.TabIndex = 8;
            this.add_cust.Text = "Add";
            this.add_cust.UseVisualStyleBackColor = false;
            this.add_cust.Click += new System.EventHandler(this.add_cust_Click);
            // 
            // cus_address
            // 
            this.cus_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cus_address.Location = new System.Drawing.Point(140, 201);
            this.cus_address.Name = "cus_address";
            this.cus_address.Size = new System.Drawing.Size(127, 29);
            this.cus_address.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(18, 201);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 22);
            this.label11.TabIndex = 6;
            this.label11.Text = "Address";
            // 
            // cus_ph
            // 
            this.cus_ph.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cus_ph.Location = new System.Drawing.Point(140, 147);
            this.cus_ph.Name = "cus_ph";
            this.cus_ph.Size = new System.Drawing.Size(127, 29);
            this.cus_ph.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(16, 147);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 22);
            this.label12.TabIndex = 4;
            this.label12.Text = "Phone";
            // 
            // cus_email
            // 
            this.cus_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cus_email.Location = new System.Drawing.Point(140, 91);
            this.cus_email.Name = "cus_email";
            this.cus_email.Size = new System.Drawing.Size(127, 29);
            this.cus_email.TabIndex = 3;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(16, 91);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(57, 22);
            this.label13.TabIndex = 2;
            this.label13.Text = "Email";
            // 
            // cus_name
            // 
            this.cus_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cus_name.Location = new System.Drawing.Point(140, 39);
            this.cus_name.Name = "cus_name";
            this.cus_name.Size = new System.Drawing.Size(127, 29);
            this.cus_name.TabIndex = 1;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(16, 39);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(59, 22);
            this.label14.TabIndex = 0;
            this.label14.Text = "Name ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.retrn_Date);
            this.groupBox3.Controls.Add(this.ise_Date);
            this.groupBox3.Controls.Add(this.del_movie);
            this.groupBox3.Controls.Add(this.return_mov);
            this.groupBox3.Controls.Add(this.issue_mov);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.mov_id);
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Controls.Add(this.cus_id);
            this.groupBox3.Controls.Add(this.label21);
            this.groupBox3.Location = new System.Drawing.Point(601, 293);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(249, 453);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Rental\'s";
            // 
            // retrn_Date
            // 
            this.retrn_Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.retrn_Date.Location = new System.Drawing.Point(23, 251);
            this.retrn_Date.Name = "retrn_Date";
            this.retrn_Date.Size = new System.Drawing.Size(181, 20);
            this.retrn_Date.TabIndex = 17;
            // 
            // ise_Date
            // 
            this.ise_Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ise_Date.Location = new System.Drawing.Point(23, 175);
            this.ise_Date.Name = "ise_Date";
            this.ise_Date.Size = new System.Drawing.Size(181, 20);
            this.ise_Date.TabIndex = 16;
            // 
            // del_movie
            // 
            this.del_movie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.del_movie.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.del_movie.Location = new System.Drawing.Point(69, 368);
            this.del_movie.Name = "del_movie";
            this.del_movie.Size = new System.Drawing.Size(100, 34);
            this.del_movie.TabIndex = 15;
            this.del_movie.Text = "Delete";
            this.del_movie.UseVisualStyleBackColor = false;
            this.del_movie.Click += new System.EventHandler(this.del_movie_Click);
            // 
            // return_mov
            // 
            this.return_mov.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.return_mov.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.return_mov.Location = new System.Drawing.Point(140, 309);
            this.return_mov.Name = "return_mov";
            this.return_mov.Size = new System.Drawing.Size(94, 34);
            this.return_mov.TabIndex = 14;
            this.return_mov.Text = "Return";
            this.return_mov.UseVisualStyleBackColor = false;
            this.return_mov.Click += new System.EventHandler(this.return_mov_Click);
            // 
            // issue_mov
            // 
            this.issue_mov.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.issue_mov.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.issue_mov.Location = new System.Drawing.Point(9, 309);
            this.issue_mov.Name = "issue_mov";
            this.issue_mov.Size = new System.Drawing.Size(100, 34);
            this.issue_mov.TabIndex = 8;
            this.issue_mov.Text = "Issue";
            this.issue_mov.UseVisualStyleBackColor = false;
            this.issue_mov.Click += new System.EventHandler(this.issue_mov_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(51, 208);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(107, 22);
            this.label18.TabIndex = 6;
            this.label18.Text = "Return Date";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(65, 136);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(93, 22);
            this.label19.TabIndex = 4;
            this.label19.Text = "Issue Date";
            // 
            // mov_id
            // 
            this.mov_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mov_id.Location = new System.Drawing.Point(140, 91);
            this.mov_id.Name = "mov_id";
            this.mov_id.Size = new System.Drawing.Size(78, 29);
            this.mov_id.TabIndex = 3;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(5, 91);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(86, 22);
            this.label20.TabIndex = 2;
            this.label20.Text = "Movie ID";
            // 
            // cus_id
            // 
            this.cus_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cus_id.Location = new System.Drawing.Point(140, 39);
            this.cus_id.Name = "cus_id";
            this.cus_id.Size = new System.Drawing.Size(78, 29);
            this.cus_id.TabIndex = 1;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(5, 39);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(109, 22);
            this.label21.TabIndex = 0;
            this.label21.Text = "Customer ID";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(862, 733);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DatabaseTable);
            this.Controls.Add(this.data_pop_customer);
            this.Controls.Add(this.data_pop_movie);
            this.Controls.Add(this.data_rental);
            this.Controls.Add(this.data_video);
            this.Controls.Add(this.data_customer);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DatabaseTable)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button data_customer;
        private System.Windows.Forms.Button data_video;
        private System.Windows.Forms.Button data_rental;
        private System.Windows.Forms.Button data_pop_movie;
        private System.Windows.Forms.Button data_pop_customer;
        private System.Windows.Forms.DataGridView DatabaseTable;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button video_del;
        private System.Windows.Forms.Button video_update;
        private System.Windows.Forms.Button video_add;
        private System.Windows.Forms.TextBox genre;
        private System.Windows.Forms.TextBox plot;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox copies;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox cost;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox realease_year;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox rate_video;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button del_cust;
        private System.Windows.Forms.Button update_del;
        private System.Windows.Forms.Button add_cust;
        private System.Windows.Forms.TextBox cus_address;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox cus_ph;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox cus_email;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox cus_name;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker retrn_Date;
        private System.Windows.Forms.DateTimePicker ise_Date;
        private System.Windows.Forms.Button del_movie;
        private System.Windows.Forms.Button return_mov;
        private System.Windows.Forms.Button issue_mov;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox mov_id;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox cus_id;
        private System.Windows.Forms.Label label21;
    }
}

