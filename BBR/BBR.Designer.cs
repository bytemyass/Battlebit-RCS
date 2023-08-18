
namespace BBR
{
    partial class BBR
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BBR));
            this.WEAPONSELECT = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.FOV = new System.Windows.Forms.NumericUpDown();
            this.SENS = new System.Windows.Forms.NumericUpDown();
            this.SMOOTHING = new System.Windows.Forms.NumericUpDown();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.FOV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SENS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SMOOTHING)).BeginInit();
            this.SuspendLayout();
            // 
            // WEAPONSELECT
            // 
            this.WEAPONSELECT.BackColor = System.Drawing.Color.Gray;
            this.WEAPONSELECT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.WEAPONSELECT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WEAPONSELECT.FormattingEnabled = true;
            this.WEAPONSELECT.ItemHeight = 25;
            this.WEAPONSELECT.Items.AddRange(new object[] {
            "AK74",
            "M4A1",
            "AK15",
            "SCAR",
            "AUG",
            "SG550",
            "FAMAS",
            "ACR",
            "G36C",
            "HK419",
            "FAL",
            "AK5C",
            "MP7",
            "UMP-45",
            "PP2000",
            "PP19",
            "VECTOR",
            "MP5",
            "H-BADGER",
            "GROZA",
            "P90",
            "AS-VAL",
            "SCORPION",
            "L86A1",
            "MG36",
            "M249",
            "ULTIMAX"});
            this.WEAPONSELECT.Location = new System.Drawing.Point(4, 26);
            this.WEAPONSELECT.Name = "WEAPONSELECT";
            this.WEAPONSELECT.Size = new System.Drawing.Size(150, 225);
            this.WEAPONSELECT.TabIndex = 1;
            this.WEAPONSELECT.SelectedIndexChanged += new System.EventHandler(this.WEAPONSELECT_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(4, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "WEAPON SELECTION: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(247, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "FOV:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(173, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "SENSITIVITY:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(176, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "SMOOTHING:";
            // 
            // FOV
            // 
            this.FOV.Location = new System.Drawing.Point(303, 16);
            this.FOV.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.FOV.Name = "FOV";
            this.FOV.Size = new System.Drawing.Size(50, 20);
            this.FOV.TabIndex = 5;
            this.FOV.Value = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.FOV.ValueChanged += new System.EventHandler(this.FOV_ValueChanged);
            // 
            // SENS
            // 
            this.SENS.Location = new System.Drawing.Point(303, 45);
            this.SENS.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.SENS.Name = "SENS";
            this.SENS.Size = new System.Drawing.Size(50, 20);
            this.SENS.TabIndex = 6;
            this.SENS.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.SENS.ValueChanged += new System.EventHandler(this.SENS_ValueChanged);
            // 
            // SMOOTHING
            // 
            this.SMOOTHING.Location = new System.Drawing.Point(303, 74);
            this.SMOOTHING.Name = "SMOOTHING";
            this.SMOOTHING.Size = new System.Drawing.Size(50, 20);
            this.SMOOTHING.TabIndex = 7;
            this.SMOOTHING.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.SMOOTHING.ValueChanged += new System.EventHandler(this.SMOOTHING_ValueChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Black;
            this.checkBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.Color.White;
            this.checkBox1.Location = new System.Drawing.Point(321, 162);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(113, 28);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "TOGGLE";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(211, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(223, 39);
            this.label5.TabIndex = 9;
            this.label5.Text = "Make sure the FOV + Sensitivity(vertical) \r\nmatches what you have ingame.. \r\nSele" +
    "ct a weapon, toggle script and go kill kids\r\n";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkRed;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(381, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(54, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "EXIT";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BBR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(437, 257);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.SMOOTHING);
            this.Controls.Add(this.SENS);
            this.Controls.Add(this.FOV);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.WEAPONSELECT);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BBR";
            this.ShowIcon = false;
            this.Text = "Recoil Compensation System";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FOV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SENS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SMOOTHING)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox WEAPONSELECT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown FOV;
        private System.Windows.Forms.NumericUpDown SENS;
        private System.Windows.Forms.NumericUpDown SMOOTHING;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
    }
}

