
namespace excel2vcf
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.device = new System.Windows.Forms.GroupBox();
            this.iconIOS = new System.Windows.Forms.PictureBox();
            this.radioButtonIOS = new System.Windows.Forms.RadioButton();
            this.radioButtonAndroid = new System.Windows.Forms.RadioButton();
            this.iconAndroid = new System.Windows.Forms.PictureBox();
            this.device.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconIOS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconAndroid)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(163, 53);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(637, 35);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dosya Seç";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(806, 51);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(43, 40);
            this.button1.TabIndex = 2;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(163, 157);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(637, 624);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(806, 291);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 40);
            this.button2.TabIndex = 4;
            this.button2.Text = "Çevir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(806, 337);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(131, 40);
            this.button3.TabIndex = 4;
            this.button3.Text = "İndir";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(163, 105);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(233, 35);
            this.textBox2.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 30);
            this.label2.TabIndex = 6;
            this.label2.Text = "İsim Başına ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(419, 107);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(178, 34);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "Başlık Satırı Var";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // device
            // 
            this.device.Controls.Add(this.iconIOS);
            this.device.Controls.Add(this.iconAndroid);
            this.device.Controls.Add(this.radioButtonIOS);
            this.device.Controls.Add(this.radioButtonAndroid);
            this.device.Location = new System.Drawing.Point(806, 157);
            this.device.Name = "device";
            this.device.Size = new System.Drawing.Size(173, 116);
            this.device.TabIndex = 8;
            this.device.TabStop = false;
            this.device.Text = "Cihaz";
            // 
            // iconIOS
            // 
            this.iconIOS.Image = global::csv2vcf.Properties.Resources.icon_apple;
            this.iconIOS.Location = new System.Drawing.Point(116, 75);
            this.iconIOS.Name = "iconIOS";
            this.iconIOS.Size = new System.Drawing.Size(41, 35);
            this.iconIOS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconIOS.TabIndex = 3;
            this.iconIOS.TabStop = false;
            // 
            // radioButtonIOS
            // 
            this.radioButtonIOS.AutoSize = true;
            this.radioButtonIOS.Location = new System.Drawing.Point(7, 76);
            this.radioButtonIOS.Name = "radioButtonIOS";
            this.radioButtonIOS.Size = new System.Drawing.Size(102, 34);
            this.radioButtonIOS.TabIndex = 1;
            this.radioButtonIOS.TabStop = true;
            this.radioButtonIOS.Text = "iPhone";
            this.radioButtonIOS.UseVisualStyleBackColor = true;
            // 
            // radioButtonAndroid
            // 
            this.radioButtonAndroid.AutoSize = true;
            this.radioButtonAndroid.Location = new System.Drawing.Point(7, 35);
            this.radioButtonAndroid.Name = "radioButtonAndroid";
            this.radioButtonAndroid.Size = new System.Drawing.Size(112, 34);
            this.radioButtonAndroid.TabIndex = 0;
            this.radioButtonAndroid.TabStop = true;
            this.radioButtonAndroid.Text = "Android";
            this.radioButtonAndroid.UseVisualStyleBackColor = true;
            // 
            // iconAndroid
            // 
            this.iconAndroid.Image = global::csv2vcf.Properties.Resources.icon_android;
            this.iconAndroid.Location = new System.Drawing.Point(116, 36);
            this.iconAndroid.Name = "iconAndroid";
            this.iconAndroid.Size = new System.Drawing.Size(41, 33);
            this.iconAndroid.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconAndroid.TabIndex = 2;
            this.iconAndroid.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 808);
            this.Controls.Add(this.device);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.MaximumSize = new System.Drawing.Size(1054, 872);
            this.MinimumSize = new System.Drawing.Size(1054, 872);
            this.Name = "Form1";
            this.Text = "csv2vcf";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.device.ResumeLayout(false);
            this.device.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconIOS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconAndroid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox device;
        private System.Windows.Forms.RadioButton radioButtonIOS;
        private System.Windows.Forms.RadioButton radioButtonAndroid;
        private System.Windows.Forms.PictureBox iconIOS;
        private System.Windows.Forms.PictureBox iconAndroid;
    }
}

