namespace DBapplication
{
    partial class Cinema
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
            this.insertGroupBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.genreTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.durationTextBox = new System.Windows.Forms.TextBox();
            this.insertButton = new System.Windows.Forms.Button();
            this.countGroupBox = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.movieIDCountTextBox = new System.Windows.Forms.TextBox();
            this.countButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.countTextBox = new System.Windows.Forms.TextBox();
            this.updateGroupBox = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.movieIDUpdateTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.durationUpdateTextBox = new System.Windows.Forms.TextBox();
            this.updateButton = new System.Windows.Forms.Button();
            this.deleteGroupBox = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.showIDDeleteTextBox = new System.Windows.Forms.TextBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.selectGroupBox = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.genreSelectTextBox = new System.Windows.Forms.TextBox();
            this.selectButton = new System.Windows.Forms.Button();
            this.resultDataGrid = new System.Windows.Forms.DataGridView();
            this.closeButton = new System.Windows.Forms.Button();
            this.insertGroupBox.SuspendLayout();
            this.countGroupBox.SuspendLayout();
            this.updateGroupBox.SuspendLayout();
            this.deleteGroupBox.SuspendLayout();
            this.selectGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // insertGroupBox
            // 
            this.insertGroupBox.Controls.Add(this.label1);
            this.insertGroupBox.Controls.Add(this.titleTextBox);
            this.insertGroupBox.Controls.Add(this.label2);
            this.insertGroupBox.Controls.Add(this.genreTextBox);
            this.insertGroupBox.Controls.Add(this.label3);
            this.insertGroupBox.Controls.Add(this.durationTextBox);
            this.insertGroupBox.Controls.Add(this.insertButton);
            this.insertGroupBox.Location = new System.Drawing.Point(12, 12);
            this.insertGroupBox.Name = "insertGroupBox";
            this.insertGroupBox.Size = new System.Drawing.Size(380, 172);
            this.insertGroupBox.TabIndex = 0;
            this.insertGroupBox.TabStop = false;
            this.insertGroupBox.Text = "Insert New Movie";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 33);
            this.label1.Name = "label1";
            this.label1.TabIndex = 1;
            this.label1.Text = "Title";
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(150, 30);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(210, 22);
            this.titleTextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 65);
            this.label2.Name = "label2";
            this.label2.TabIndex = 3;
            this.label2.Text = "Genre";
            // 
            // genreTextBox
            // 
            this.genreTextBox.Location = new System.Drawing.Point(150, 62);
            this.genreTextBox.Name = "genreTextBox";
            this.genreTextBox.Size = new System.Drawing.Size(210, 22);
            this.genreTextBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 97);
            this.label3.Name = "label3";
            this.label3.TabIndex = 5;
            this.label3.Text = "Duration (min)";
            // 
            // durationTextBox
            // 
            this.durationTextBox.Location = new System.Drawing.Point(150, 94);
            this.durationTextBox.Name = "durationTextBox";
            this.durationTextBox.Size = new System.Drawing.Size(210, 22);
            this.durationTextBox.TabIndex = 6;
            // 
            // insertButton
            // 
            this.insertButton.Location = new System.Drawing.Point(150, 126);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(210, 30);
            this.insertButton.TabIndex = 7;
            this.insertButton.Text = "Insert Movie";
            this.insertButton.UseVisualStyleBackColor = true;
            this.insertButton.Click += new System.EventHandler(this.insertButton_Click);
            // 
            // countGroupBox
            // 
            this.countGroupBox.Controls.Add(this.label4);
            this.countGroupBox.Controls.Add(this.movieIDCountTextBox);
            this.countGroupBox.Controls.Add(this.countButton);
            this.countGroupBox.Controls.Add(this.label5);
            this.countGroupBox.Controls.Add(this.countTextBox);
            this.countGroupBox.Location = new System.Drawing.Point(12, 194);
            this.countGroupBox.Name = "countGroupBox";
            this.countGroupBox.Size = new System.Drawing.Size(380, 140);
            this.countGroupBox.TabIndex = 8;
            this.countGroupBox.TabStop = false;
            this.countGroupBox.Text = "Count Movie Showtimes";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 33);
            this.label4.Name = "label4";
            this.label4.TabIndex = 9;
            this.label4.Text = "Movie ID";
            // 
            // movieIDCountTextBox
            // 
            this.movieIDCountTextBox.Location = new System.Drawing.Point(150, 30);
            this.movieIDCountTextBox.Name = "movieIDCountTextBox";
            this.movieIDCountTextBox.Size = new System.Drawing.Size(210, 22);
            this.movieIDCountTextBox.TabIndex = 10;
            // 
            // countButton
            // 
            this.countButton.Location = new System.Drawing.Point(150, 62);
            this.countButton.Name = "countButton";
            this.countButton.Size = new System.Drawing.Size(210, 30);
            this.countButton.TabIndex = 11;
            this.countButton.Text = "Count Showtimes";
            this.countButton.UseVisualStyleBackColor = true;
            this.countButton.Click += new System.EventHandler(this.countButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 105);
            this.label5.Name = "label5";
            this.label5.TabIndex = 12;
            this.label5.Text = "Showtimes";
            // 
            // countTextBox
            // 
            this.countTextBox.Location = new System.Drawing.Point(150, 102);
            this.countTextBox.Name = "countTextBox";
            this.countTextBox.ReadOnly = true;
            this.countTextBox.Size = new System.Drawing.Size(210, 22);
            this.countTextBox.TabIndex = 13;
            // 
            // updateGroupBox
            // 
            this.updateGroupBox.Controls.Add(this.label6);
            this.updateGroupBox.Controls.Add(this.movieIDUpdateTextBox);
            this.updateGroupBox.Controls.Add(this.label7);
            this.updateGroupBox.Controls.Add(this.durationUpdateTextBox);
            this.updateGroupBox.Controls.Add(this.updateButton);
            this.updateGroupBox.Location = new System.Drawing.Point(404, 12);
            this.updateGroupBox.Name = "updateGroupBox";
            this.updateGroupBox.Size = new System.Drawing.Size(380, 140);
            this.updateGroupBox.TabIndex = 14;
            this.updateGroupBox.TabStop = false;
            this.updateGroupBox.Text = "Update Movie Duration";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 33);
            this.label6.Name = "label6";
            this.label6.TabIndex = 15;
            this.label6.Text = "Movie ID";
            // 
            // movieIDUpdateTextBox
            // 
            this.movieIDUpdateTextBox.Location = new System.Drawing.Point(150, 30);
            this.movieIDUpdateTextBox.Name = "movieIDUpdateTextBox";
            this.movieIDUpdateTextBox.Size = new System.Drawing.Size(210, 22);
            this.movieIDUpdateTextBox.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 65);
            this.label7.Name = "label7";
            this.label7.TabIndex = 17;
            this.label7.Text = "New Duration";
            // 
            // durationUpdateTextBox
            // 
            this.durationUpdateTextBox.Location = new System.Drawing.Point(150, 62);
            this.durationUpdateTextBox.Name = "durationUpdateTextBox";
            this.durationUpdateTextBox.Size = new System.Drawing.Size(210, 22);
            this.durationUpdateTextBox.TabIndex = 18;
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(150, 94);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(210, 30);
            this.updateButton.TabIndex = 19;
            this.updateButton.Text = "Update Movie";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // deleteGroupBox
            // 
            this.deleteGroupBox.Controls.Add(this.label8);
            this.deleteGroupBox.Controls.Add(this.showIDDeleteTextBox);
            this.deleteGroupBox.Controls.Add(this.deleteButton);
            this.deleteGroupBox.Location = new System.Drawing.Point(404, 162);
            this.deleteGroupBox.Name = "deleteGroupBox";
            this.deleteGroupBox.Size = new System.Drawing.Size(380, 108);
            this.deleteGroupBox.TabIndex = 20;
            this.deleteGroupBox.TabStop = false;
            this.deleteGroupBox.Text = "Delete Showtime";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 33);
            this.label8.Name = "label8";
            this.label8.TabIndex = 21;
            this.label8.Text = "Show ID";
            // 
            // showIDDeleteTextBox
            // 
            this.showIDDeleteTextBox.Location = new System.Drawing.Point(150, 30);
            this.showIDDeleteTextBox.Name = "showIDDeleteTextBox";
            this.showIDDeleteTextBox.Size = new System.Drawing.Size(210, 22);
            this.showIDDeleteTextBox.TabIndex = 22;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(150, 62);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(210, 30);
            this.deleteButton.TabIndex = 23;
            this.deleteButton.Text = "Delete Showtime";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // selectGroupBox
            // 
            this.selectGroupBox.Controls.Add(this.label9);
            this.selectGroupBox.Controls.Add(this.genreSelectTextBox);
            this.selectGroupBox.Controls.Add(this.selectButton);
            this.selectGroupBox.Controls.Add(this.resultDataGrid);
            this.selectGroupBox.Location = new System.Drawing.Point(12, 344);
            this.selectGroupBox.Name = "selectGroupBox";
            this.selectGroupBox.Size = new System.Drawing.Size(772, 270);
            this.selectGroupBox.TabIndex = 24;
            this.selectGroupBox.TabStop = false;
            this.selectGroupBox.Text = "Movies by Genre";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 33);
            this.label9.Name = "label9";
            this.label9.TabIndex = 25;
            this.label9.Text = "Genre";
            // 
            // genreSelectTextBox
            // 
            this.genreSelectTextBox.Location = new System.Drawing.Point(160, 30);
            this.genreSelectTextBox.Name = "genreSelectTextBox";
            this.genreSelectTextBox.Size = new System.Drawing.Size(210, 22);
            this.genreSelectTextBox.TabIndex = 26;
            // 
            // selectButton
            // 
            this.selectButton.Location = new System.Drawing.Point(390, 26);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(180, 30);
            this.selectButton.TabIndex = 27;
            this.selectButton.Text = "Show Movies";
            this.selectButton.UseVisualStyleBackColor = true;
            this.selectButton.Click += new System.EventHandler(this.selectButton_Click);
            // 
            // resultDataGrid
            // 
            this.resultDataGrid.AllowUserToAddRows = false;
            this.resultDataGrid.AllowUserToDeleteRows = false;
            this.resultDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.resultDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultDataGrid.Location = new System.Drawing.Point(15, 70);
            this.resultDataGrid.Name = "resultDataGrid";
            this.resultDataGrid.ReadOnly = true;
            this.resultDataGrid.RowHeadersWidth = 51;
            this.resultDataGrid.Size = new System.Drawing.Size(742, 185);
            this.resultDataGrid.TabIndex = 28;
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(634, 624);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(150, 30);
            this.closeButton.TabIndex = 29;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // Cinema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 666);
            this.Controls.Add(this.insertGroupBox);
            this.Controls.Add(this.countGroupBox);
            this.Controls.Add(this.updateGroupBox);
            this.Controls.Add(this.deleteGroupBox);
            this.Controls.Add(this.selectGroupBox);
            this.Controls.Add(this.closeButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Cinema";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cinema";
            this.Load += new System.EventHandler(this.Cinema_Load);
            ((System.ComponentModel.ISupportInitialize)(this.resultDataGrid)).EndInit();
            this.insertGroupBox.ResumeLayout(false);
            this.insertGroupBox.PerformLayout();
            this.countGroupBox.ResumeLayout(false);
            this.countGroupBox.PerformLayout();
            this.updateGroupBox.ResumeLayout(false);
            this.updateGroupBox.PerformLayout();
            this.deleteGroupBox.ResumeLayout(false);
            this.deleteGroupBox.PerformLayout();
            this.selectGroupBox.ResumeLayout(false);
            this.selectGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox insertGroupBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox genreTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox durationTextBox;
        private System.Windows.Forms.Button insertButton;
        private System.Windows.Forms.GroupBox countGroupBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox movieIDCountTextBox;
        private System.Windows.Forms.Button countButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox countTextBox;
        private System.Windows.Forms.GroupBox updateGroupBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox movieIDUpdateTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox durationUpdateTextBox;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.GroupBox deleteGroupBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox showIDDeleteTextBox;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.GroupBox selectGroupBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox genreSelectTextBox;
        private System.Windows.Forms.Button selectButton;
        private System.Windows.Forms.DataGridView resultDataGrid;
        private System.Windows.Forms.Button closeButton;
    }
}