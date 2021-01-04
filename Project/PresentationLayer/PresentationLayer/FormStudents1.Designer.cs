
namespace PresentationLayer
{
    partial class FormStudents1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStudents1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelHomework = new System.Windows.Forms.Label();
            this.labelSeminaryWork = new System.Windows.Forms.Label();
            this.labelColloquim = new System.Windows.Forms.Label();
            this.labelIndexNumber = new System.Windows.Forms.Label();
            this.labelSurname = new System.Windows.Forms.Label();
            this.labelActivity = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.textBoxIndexNumber = new System.Windows.Forms.TextBox();
            this.textBoxColloquim = new System.Windows.Forms.TextBox();
            this.textBoxSeminaryWork = new System.Windows.Forms.TextBox();
            this.textBoxHomework = new System.Windows.Forms.TextBox();
            this.textBoxActivity = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonShow = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.labelIdNew = new System.Windows.Forms.Label();
            this.textBoxIdNew = new System.Windows.Forms.TextBox();
            this.listBoxStudents = new System.Windows.Forms.ListBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkTurquoise;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(355, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "RECORDING STUDENTS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(750, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(325, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "SUBJECT: SOFTVERSKO INZENJERSTVO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(807, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(283, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "PROFFESOR: MARIJA BLAGOJEVIC";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(31, 117);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(50, 16);
            this.labelName.TabIndex = 4;
            this.labelName.Text = "NAME:";
            // 
            // labelHomework
            // 
            this.labelHomework.AutoSize = true;
            this.labelHomework.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHomework.Location = new System.Drawing.Point(444, 217);
            this.labelHomework.Name = "labelHomework";
            this.labelHomework.Size = new System.Drawing.Size(92, 16);
            this.labelHomework.TabIndex = 5;
            this.labelHomework.Text = "HOMEWORK:";
            // 
            // labelSeminaryWork
            // 
            this.labelSeminaryWork.AutoSize = true;
            this.labelSeminaryWork.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSeminaryWork.Location = new System.Drawing.Point(444, 170);
            this.labelSeminaryWork.Name = "labelSeminaryWork";
            this.labelSeminaryWork.Size = new System.Drawing.Size(116, 16);
            this.labelSeminaryWork.TabIndex = 6;
            this.labelSeminaryWork.Text = "SEMINRY WORK:";
            // 
            // labelColloquim
            // 
            this.labelColloquim.AutoSize = true;
            this.labelColloquim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelColloquim.Location = new System.Drawing.Point(447, 115);
            this.labelColloquim.Name = "labelColloquim";
            this.labelColloquim.Size = new System.Drawing.Size(88, 16);
            this.labelColloquim.TabIndex = 7;
            this.labelColloquim.Text = "COLLOQUIM:";
            this.labelColloquim.Click += new System.EventHandler(this.labelColloquim_Click);
            // 
            // labelIndexNumber
            // 
            this.labelIndexNumber.AutoSize = true;
            this.labelIndexNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIndexNumber.Location = new System.Drawing.Point(31, 211);
            this.labelIndexNumber.Name = "labelIndexNumber";
            this.labelIndexNumber.Size = new System.Drawing.Size(113, 16);
            this.labelIndexNumber.TabIndex = 8;
            this.labelIndexNumber.Text = "INDEX NUMBER:";
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSurname.Location = new System.Drawing.Point(31, 164);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(79, 16);
            this.labelSurname.TabIndex = 9;
            this.labelSurname.Text = "SURNAME:";
            this.labelSurname.Click += new System.EventHandler(this.label9_Click);
            // 
            // labelActivity
            // 
            this.labelActivity.AutoSize = true;
            this.labelActivity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelActivity.Location = new System.Drawing.Point(447, 266);
            this.labelActivity.Name = "labelActivity";
            this.labelActivity.Size = new System.Drawing.Size(71, 16);
            this.labelActivity.TabIndex = 10;
            this.labelActivity.Text = "ACTIVITY:";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(165, 116);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(147, 20);
            this.textBoxName.TabIndex = 11;
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(165, 163);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(147, 20);
            this.textBoxSurname.TabIndex = 12;
            // 
            // textBoxIndexNumber
            // 
            this.textBoxIndexNumber.Location = new System.Drawing.Point(165, 210);
            this.textBoxIndexNumber.Name = "textBoxIndexNumber";
            this.textBoxIndexNumber.Size = new System.Drawing.Size(147, 20);
            this.textBoxIndexNumber.TabIndex = 13;
            // 
            // textBoxColloquim
            // 
            this.textBoxColloquim.Location = new System.Drawing.Point(584, 112);
            this.textBoxColloquim.Name = "textBoxColloquim";
            this.textBoxColloquim.Size = new System.Drawing.Size(147, 20);
            this.textBoxColloquim.TabIndex = 14;
            // 
            // textBoxSeminaryWork
            // 
            this.textBoxSeminaryWork.Location = new System.Drawing.Point(584, 170);
            this.textBoxSeminaryWork.Name = "textBoxSeminaryWork";
            this.textBoxSeminaryWork.Size = new System.Drawing.Size(147, 20);
            this.textBoxSeminaryWork.TabIndex = 15;
            // 
            // textBoxHomework
            // 
            this.textBoxHomework.Location = new System.Drawing.Point(584, 217);
            this.textBoxHomework.Name = "textBoxHomework";
            this.textBoxHomework.Size = new System.Drawing.Size(147, 20);
            this.textBoxHomework.TabIndex = 16;
            // 
            // textBoxActivity
            // 
            this.textBoxActivity.Location = new System.Drawing.Point(584, 266);
            this.textBoxActivity.Name = "textBoxActivity";
            this.textBoxActivity.Size = new System.Drawing.Size(147, 20);
            this.textBoxActivity.TabIndex = 17;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(804, 112);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(276, 149);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // buttonInsert
            // 
            this.buttonInsert.BackColor = System.Drawing.Color.MediumTurquoise;
            this.buttonInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInsert.Location = new System.Drawing.Point(76, 263);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(204, 23);
            this.buttonInsert.TabIndex = 19;
            this.buttonInsert.Text = "INSERT";
            this.buttonInsert.UseVisualStyleBackColor = false;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate.Location = new System.Drawing.Point(447, 333);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(209, 23);
            this.buttonUpdate.TabIndex = 20;
            this.buttonUpdate.Text = "UPDATE";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonShow
            // 
            this.buttonShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonShow.Location = new System.Drawing.Point(34, 333);
            this.buttonShow.Name = "buttonShow";
            this.buttonShow.Size = new System.Drawing.Size(204, 23);
            this.buttonShow.TabIndex = 21;
            this.buttonShow.Text = "SHOW";
            this.buttonShow.UseVisualStyleBackColor = true;
            this.buttonShow.Click += new System.EventHandler(this.buttonShow_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.Location = new System.Drawing.Point(804, 333);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(204, 23);
            this.buttonDelete.TabIndex = 22;
            this.buttonDelete.Text = "DELETE";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // labelIdNew
            // 
            this.labelIdNew.AutoSize = true;
            this.labelIdNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIdNew.Location = new System.Drawing.Point(801, 292);
            this.labelIdNew.Name = "labelIdNew";
            this.labelIdNew.Size = new System.Drawing.Size(59, 16);
            this.labelIdNew.TabIndex = 23;
            this.labelIdNew.Text = "ID NEW:";
            // 
            // textBoxIdNew
            // 
            this.textBoxIdNew.Location = new System.Drawing.Point(896, 292);
            this.textBoxIdNew.Name = "textBoxIdNew";
            this.textBoxIdNew.Size = new System.Drawing.Size(99, 20);
            this.textBoxIdNew.TabIndex = 24;
            // 
            // listBoxStudents
            // 
            this.listBoxStudents.FormattingEnabled = true;
            this.listBoxStudents.Location = new System.Drawing.Point(34, 595);
            this.listBoxStudents.Name = "listBoxStudents";
            this.listBoxStudents.Size = new System.Drawing.Size(1046, 56);
            this.listBoxStudents.TabIndex = 25;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(34, 419);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1041, 164);
            this.dataGridView1.TabIndex = 26;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // FormStudents1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 672);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.listBoxStudents);
            this.Controls.Add(this.textBoxIdNew);
            this.Controls.Add(this.labelIdNew);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonShow);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonInsert);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBoxActivity);
            this.Controls.Add(this.textBoxHomework);
            this.Controls.Add(this.textBoxSeminaryWork);
            this.Controls.Add(this.textBoxColloquim);
            this.Controls.Add(this.textBoxIndexNumber);
            this.Controls.Add(this.textBoxSurname);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelActivity);
            this.Controls.Add(this.labelSurname);
            this.Controls.Add(this.labelIndexNumber);
            this.Controls.Add(this.labelColloquim);
            this.Controls.Add(this.labelSeminaryWork);
            this.Controls.Add(this.labelHomework);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormStudents1";
            this.Text = "FormStudents1";
            this.Load += new System.EventHandler(this.FormStudents1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelHomework;
        private System.Windows.Forms.Label labelSeminaryWork;
        private System.Windows.Forms.Label labelColloquim;
        private System.Windows.Forms.Label labelIndexNumber;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.Label labelActivity;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.TextBox textBoxIndexNumber;
        private System.Windows.Forms.TextBox textBoxColloquim;
        private System.Windows.Forms.TextBox textBoxSeminaryWork;
        private System.Windows.Forms.TextBox textBoxHomework;
        private System.Windows.Forms.TextBox textBoxActivity;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonShow;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Label labelIdNew;
        private System.Windows.Forms.TextBox textBoxIdNew;
        private System.Windows.Forms.ListBox listBoxStudents;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}