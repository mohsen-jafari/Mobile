namespace FormsMobile
{
    partial class HomeForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxBrand = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxWeight = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.chBoxOtg = new System.Windows.Forms.CheckBox();
            this.chBox2g = new System.Windows.Forms.CheckBox();
            this.chBox3g = new System.Windows.Forms.CheckBox();
            this.chBox4g = new System.Windows.Forms.CheckBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonImage = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonForward = new System.Windows.Forms.Button();
            this.buttonListShow = new System.Windows.Forms.Button();
            this.buttonAddMoile = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1008, 129);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = ": اسم گوشی ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(671, 121);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(325, 22);
            this.textBoxName.TabIndex = 2;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1005, 162);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = ": نام برند را انتخاب کنید ";
            // 
            // listBoxBrand
            // 
            this.listBoxBrand.FormattingEnabled = true;
            this.listBoxBrand.ItemHeight = 16;
            this.listBoxBrand.Items.AddRange(new object[] {
            "apple",
            "Xiaomi",
            "Samsung",
            "LG"});
            this.listBoxBrand.Location = new System.Drawing.Point(671, 162);
            this.listBoxBrand.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBoxBrand.Name = "listBoxBrand";
            this.listBoxBrand.Size = new System.Drawing.Size(325, 84);
            this.listBoxBrand.TabIndex = 4;
            this.listBoxBrand.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1005, 284);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = ": تاریخ تولید";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1005, 330);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = ": وزن موبایل به عدد (گرم)";
            // 
            // textBoxWeight
            // 
            this.textBoxWeight.Location = new System.Drawing.Point(672, 326);
            this.textBoxWeight.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxWeight.Name = "textBoxWeight";
            this.textBoxWeight.Size = new System.Drawing.Size(324, 22);
            this.textBoxWeight.TabIndex = 8;
            this.textBoxWeight.TextChanged += new System.EventHandler(this.textBoxWeight_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1005, 377);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = ": otg پشتیبانی از ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1005, 426);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = ": پشتیبانی از شبکه های ارتباطی ";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(672, 277);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(325, 22);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(16, 239);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(236, 64);
            this.button2.TabIndex = 13;
            this.button2.Text = "ثبت";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // chBoxOtg
            // 
            this.chBoxOtg.AutoSize = true;
            this.chBoxOtg.Location = new System.Drawing.Point(939, 377);
            this.chBoxOtg.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chBoxOtg.Name = "chBoxOtg";
            this.chBoxOtg.Size = new System.Drawing.Size(50, 21);
            this.chBoxOtg.TabIndex = 17;
            this.chBoxOtg.Text = "دارد";
            this.chBoxOtg.UseVisualStyleBackColor = true;
            this.chBoxOtg.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // chBox2g
            // 
            this.chBox2g.AutoSize = true;
            this.chBox2g.Location = new System.Drawing.Point(939, 421);
            this.chBox2g.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chBox2g.Name = "chBox2g";
            this.chBox2g.Size = new System.Drawing.Size(49, 21);
            this.chBox2g.TabIndex = 18;
            this.chBox2g.Text = "2G";
            this.chBox2g.UseVisualStyleBackColor = true;
            this.chBox2g.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged_1);
            // 
            // chBox3g
            // 
            this.chBox3g.AutoSize = true;
            this.chBox3g.Location = new System.Drawing.Point(877, 421);
            this.chBox3g.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chBox3g.Name = "chBox3g";
            this.chBox3g.Size = new System.Drawing.Size(49, 21);
            this.chBox3g.TabIndex = 19;
            this.chBox3g.Text = "3G";
            this.chBox3g.UseVisualStyleBackColor = true;
            this.chBox3g.CheckedChanged += new System.EventHandler(this.chBox3g_CheckedChanged);
            // 
            // chBox4g
            // 
            this.chBox4g.AutoSize = true;
            this.chBox4g.Location = new System.Drawing.Point(816, 421);
            this.chBox4g.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chBox4g.Name = "chBox4g";
            this.chBox4g.Size = new System.Drawing.Size(49, 21);
            this.chBox4g.TabIndex = 20;
            this.chBox4g.Text = "4G";
            this.chBox4g.UseVisualStyleBackColor = true;
            this.chBox4g.CheckedChanged += new System.EventHandler(this.chkBox4g_CheckedChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(312, 60);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(297, 335);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // buttonImage
            // 
            this.buttonImage.Location = new System.Drawing.Point(324, 422);
            this.buttonImage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonImage.Name = "buttonImage";
            this.buttonImage.Size = new System.Drawing.Size(273, 28);
            this.buttonImage.TabIndex = 22;
            this.buttonImage.Text = "ثبت عکس";
            this.buttonImage.UseVisualStyleBackColor = true;
            this.buttonImage.Click += new System.EventHandler(this.buttonImage_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(864, 60);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(136, 28);
            this.buttonBack.TabIndex = 30;
            this.buttonBack.Text = "قبلی";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonForward
            // 
            this.buttonForward.Location = new System.Drawing.Point(672, 60);
            this.buttonForward.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonForward.Name = "buttonForward";
            this.buttonForward.Size = new System.Drawing.Size(140, 28);
            this.buttonForward.TabIndex = 31;
            this.buttonForward.Text = "بعدی";
            this.buttonForward.UseVisualStyleBackColor = true;
            this.buttonForward.Click += new System.EventHandler(this.buttonForward_Click);
            // 
            // buttonListShow
            // 
            this.buttonListShow.Location = new System.Drawing.Point(16, 327);
            this.buttonListShow.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonListShow.Name = "buttonListShow";
            this.buttonListShow.Size = new System.Drawing.Size(236, 68);
            this.buttonListShow.TabIndex = 37;
            this.buttonListShow.Text = "نمایش لیست";
            this.buttonListShow.UseVisualStyleBackColor = true;
            this.buttonListShow.Click += new System.EventHandler(this.buttonListShow_Click);
            // 
            // buttonAddMoile
            // 
            this.buttonAddMoile.Location = new System.Drawing.Point(16, 151);
            this.buttonAddMoile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAddMoile.Name = "buttonAddMoile";
            this.buttonAddMoile.Size = new System.Drawing.Size(236, 68);
            this.buttonAddMoile.TabIndex = 38;
            this.buttonAddMoile.Text = "اضافه کردن موبایل";
            this.buttonAddMoile.UseVisualStyleBackColor = true;
            this.buttonAddMoile.Click += new System.EventHandler(this.buttonAddMoile_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.ForeColor = System.Drawing.Color.Red;
            this.buttonCancel.Location = new System.Drawing.Point(16, 151);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(236, 68);
            this.buttonCancel.TabIndex = 39;
            this.buttonCancel.Text = "لغو اضافه کردن";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1245, 481);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAddMoile);
            this.Controls.Add(this.buttonListShow);
            this.Controls.Add(this.buttonForward);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonImage);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.chBox4g);
            this.Controls.Add(this.chBox3g);
            this.Controls.Add(this.chBox2g);
            this.Controls.Add(this.chBoxOtg);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxWeight);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBoxBrand);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "HomeForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBoxBrand;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxWeight;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox chBoxOtg;
        private System.Windows.Forms.CheckBox chBox2g;
        private System.Windows.Forms.CheckBox chBox3g;
        private System.Windows.Forms.CheckBox chBox4g;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonImage;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonForward;
        private System.Windows.Forms.Button buttonListShow;
        private System.Windows.Forms.Button buttonAddMoile;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

