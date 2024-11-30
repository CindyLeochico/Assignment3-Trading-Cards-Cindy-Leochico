namespace TrendingCards
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
            label1 = new Label();
            comboBoxTeams = new ComboBox();
            listBoxPlayers = new ListBox();
            groupBox1 = new GroupBox();
            label9 = new Label();
            textBoxPhotoPath = new TextBox();
            pictureBoxPhoto = new PictureBox();
            buttonDelete = new Button();
            buttonSave = new Button();
            buttonAdd = new Button();
            numericUpDownSteals = new NumericUpDown();
            numericUpDownRebounds = new NumericUpDown();
            numericUpDownAssists = new NumericUpDown();
            numericUpDownPoints = new NumericUpDown();
            textBoxPosition = new TextBox();
            textBoxTeam = new TextBox();
            textBoxName = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            groupBox2 = new GroupBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPhoto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSteals).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownRebounds).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAssists).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPoints).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 47);
            label1.Name = "label1";
            label1.Size = new Size(92, 20);
            label1.TabIndex = 0;
            label1.Text = "Select Team:";
            // 
            // comboBoxTeams
            // 
            comboBoxTeams.FormattingEnabled = true;
            comboBoxTeams.Location = new Point(119, 39);
            comboBoxTeams.Name = "comboBoxTeams";
            comboBoxTeams.Size = new Size(205, 28);
            comboBoxTeams.TabIndex = 1;
            comboBoxTeams.SelectedIndexChanged += comboBoxTeams_SelectedIndexChanged;
            // 
            // listBoxPlayers
            // 
            listBoxPlayers.FormattingEnabled = true;
            listBoxPlayers.Location = new Point(17, 82);
            listBoxPlayers.Name = "listBoxPlayers";
            listBoxPlayers.Size = new Size(307, 304);
            listBoxPlayers.TabIndex = 2;
            listBoxPlayers.SelectedIndexChanged += listBoxPlayers_SelectedIndexChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(textBoxPhotoPath);
            groupBox1.Controls.Add(pictureBoxPhoto);
            groupBox1.Controls.Add(buttonDelete);
            groupBox1.Controls.Add(buttonSave);
            groupBox1.Controls.Add(buttonAdd);
            groupBox1.Controls.Add(numericUpDownSteals);
            groupBox1.Controls.Add(numericUpDownRebounds);
            groupBox1.Controls.Add(numericUpDownAssists);
            groupBox1.Controls.Add(numericUpDownPoints);
            groupBox1.Controls.Add(textBoxPosition);
            groupBox1.Controls.Add(textBoxTeam);
            groupBox1.Controls.Add(textBoxName);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(397, 42);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(678, 397);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Player Details";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(16, 335);
            label9.Name = "label9";
            label9.Size = new Size(80, 20);
            label9.TabIndex = 19;
            label9.Text = "Photo Path";
            // 
            // textBoxPhotoPath
            // 
            textBoxPhotoPath.Location = new Point(95, 328);
            textBoxPhotoPath.Name = "textBoxPhotoPath";
            textBoxPhotoPath.Size = new Size(556, 27);
            textBoxPhotoPath.TabIndex = 18;
            // 
            // pictureBoxPhoto
            // 
            pictureBoxPhoto.Location = new Point(335, 33);
            pictureBoxPhoto.Name = "pictureBoxPhoto";
            pictureBoxPhoto.Size = new Size(201, 276);
            pictureBoxPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxPhoto.TabIndex = 17;
            pictureBoxPhoto.TabStop = false;
            pictureBoxPhoto.Click += pictureBoxPhoto_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(556, 207);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(94, 29);
            buttonDelete.TabIndex = 16;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(556, 155);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(94, 29);
            buttonSave.TabIndex = 15;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(556, 101);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(94, 29);
            buttonAdd.TabIndex = 14;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // numericUpDownSteals
            // 
            numericUpDownSteals.Location = new Point(95, 282);
            numericUpDownSteals.Name = "numericUpDownSteals";
            numericUpDownSteals.Size = new Size(207, 27);
            numericUpDownSteals.TabIndex = 13;
            // 
            // numericUpDownRebounds
            // 
            numericUpDownRebounds.Location = new Point(95, 244);
            numericUpDownRebounds.Name = "numericUpDownRebounds";
            numericUpDownRebounds.Size = new Size(207, 27);
            numericUpDownRebounds.TabIndex = 12;
            // 
            // numericUpDownAssists
            // 
            numericUpDownAssists.Location = new Point(95, 200);
            numericUpDownAssists.Name = "numericUpDownAssists";
            numericUpDownAssists.Size = new Size(207, 27);
            numericUpDownAssists.TabIndex = 11;
            // 
            // numericUpDownPoints
            // 
            numericUpDownPoints.Location = new Point(95, 158);
            numericUpDownPoints.Name = "numericUpDownPoints";
            numericUpDownPoints.Size = new Size(207, 27);
            numericUpDownPoints.TabIndex = 10;
            numericUpDownPoints.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // textBoxPosition
            // 
            textBoxPosition.Location = new Point(95, 116);
            textBoxPosition.Name = "textBoxPosition";
            textBoxPosition.Size = new Size(207, 27);
            textBoxPosition.TabIndex = 9;
            // 
            // textBoxTeam
            // 
            textBoxTeam.Location = new Point(95, 76);
            textBoxTeam.Name = "textBoxTeam";
            textBoxTeam.Size = new Size(207, 27);
            textBoxTeam.TabIndex = 8;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(95, 33);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(207, 27);
            textBoxName.TabIndex = 7;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(16, 289);
            label8.Name = "label8";
            label8.Size = new Size(48, 20);
            label8.TabIndex = 6;
            label8.Text = "Steals";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(16, 251);
            label7.Name = "label7";
            label7.Size = new Size(75, 20);
            label7.TabIndex = 5;
            label7.Text = "Rebounds";
            label7.Click += label7_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(16, 207);
            label6.Name = "label6";
            label6.Size = new Size(55, 20);
            label6.TabIndex = 4;
            label6.Text = "Blocks ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 164);
            label5.Name = "label5";
            label5.Size = new Size(48, 20);
            label5.TabIndex = 3;
            label5.Text = "Points";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 123);
            label4.Name = "label4";
            label4.Size = new Size(61, 20);
            label4.TabIndex = 2;
            label4.Text = "Position";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 82);
            label3.Name = "label3";
            label3.Size = new Size(45, 20);
            label3.TabIndex = 1;
            label3.Text = "Team";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 39);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 0;
            label2.Text = "Name";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(listBoxPlayers);
            groupBox2.Controls.Add(comboBoxTeams);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(28, 42);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(344, 342);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Players";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RosyBrown;
            ClientSize = new Size(1117, 459);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Trading Cards";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPhoto).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSteals).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownRebounds).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAssists).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPoints).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private ComboBox comboBoxTeams;
        private ListBox listBoxPlayers;
        private GroupBox groupBox1;
        private NumericUpDown numericUpDownSteals;
        private NumericUpDown numericUpDownRebounds;
        private NumericUpDown numericUpDownAssists;
        private NumericUpDown numericUpDownPoints;
        private TextBox textBoxPosition;
        private TextBox textBoxTeam;
        private TextBox textBoxName;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button buttonDelete;
        private Button buttonSave;
        private Button buttonAdd;
        private GroupBox groupBox2;
        private PictureBox pictureBoxPhoto;
        private Label label9;
        private TextBox textBoxPhotoPath;
    }
}
