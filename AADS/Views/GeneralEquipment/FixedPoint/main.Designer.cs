
namespace AADS.Views.FixedPoint
{
    partial class main
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rdbSpecial = new System.Windows.Forms.RadioButton();
            this.rdbOBSPost = new System.Windows.Forms.RadioButton();
            this.rdbFRadar = new System.Windows.Forms.RadioButton();
            this.rdbMRadar = new System.Windows.Forms.RadioButton();
            this.rdbTactical = new System.Windows.Forms.RadioButton();
            this.btnADD = new System.Windows.Forms.Button();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLabel = new System.Windows.Forms.TextBox();
            this.txtNuber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Name = new System.Windows.Forms.Label();
            this.chbSimulated = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // rdbSpecial
            // 
            this.rdbSpecial.AutoSize = true;
            this.rdbSpecial.Location = new System.Drawing.Point(96, 137);
            this.rdbSpecial.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdbSpecial.Name = "rdbSpecial";
            this.rdbSpecial.Size = new System.Drawing.Size(86, 24);
            this.rdbSpecial.TabIndex = 40;
            this.rdbSpecial.TabStop = true;
            this.rdbSpecial.Text = "Special";
            this.rdbSpecial.UseVisualStyleBackColor = true;
            // 
            // rdbOBSPost
            // 
            this.rdbOBSPost.AutoSize = true;
            this.rdbOBSPost.Location = new System.Drawing.Point(190, 105);
            this.rdbOBSPost.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdbOBSPost.Name = "rdbOBSPost";
            this.rdbOBSPost.Size = new System.Drawing.Size(104, 24);
            this.rdbOBSPost.TabIndex = 39;
            this.rdbOBSPost.TabStop = true;
            this.rdbOBSPost.Text = "OBS Post";
            this.rdbOBSPost.UseVisualStyleBackColor = true;
            // 
            // rdbFRadar
            // 
            this.rdbFRadar.AutoSize = true;
            this.rdbFRadar.Location = new System.Drawing.Point(96, 105);
            this.rdbFRadar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdbFRadar.Name = "rdbFRadar";
            this.rdbFRadar.Size = new System.Drawing.Size(93, 24);
            this.rdbFRadar.TabIndex = 38;
            this.rdbFRadar.TabStop = true;
            this.rdbFRadar.Text = "F-Radar";
            this.rdbFRadar.UseVisualStyleBackColor = true;
            // 
            // rdbMRadar
            // 
            this.rdbMRadar.AutoSize = true;
            this.rdbMRadar.Location = new System.Drawing.Point(190, 73);
            this.rdbMRadar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdbMRadar.Name = "rdbMRadar";
            this.rdbMRadar.Size = new System.Drawing.Size(96, 24);
            this.rdbMRadar.TabIndex = 37;
            this.rdbMRadar.TabStop = true;
            this.rdbMRadar.Text = "M-Radar";
            this.rdbMRadar.UseVisualStyleBackColor = true;
            // 
            // rdbTactical
            // 
            this.rdbTactical.AutoSize = true;
            this.rdbTactical.Location = new System.Drawing.Point(96, 73);
            this.rdbTactical.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdbTactical.Name = "rdbTactical";
            this.rdbTactical.Size = new System.Drawing.Size(88, 24);
            this.rdbTactical.TabIndex = 36;
            this.rdbTactical.TabStop = true;
            this.rdbTactical.Text = "Tactical";
            this.rdbTactical.UseVisualStyleBackColor = true;
            // 
            // btnADD
            // 
            this.btnADD.Location = new System.Drawing.Point(145, 320);
            this.btnADD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnADD.Name = "btnADD";
            this.btnADD.Size = new System.Drawing.Size(84, 29);
            this.btnADD.TabIndex = 34;
            this.btnADD.Text = "ADD";
            this.btnADD.UseVisualStyleBackColor = true;
            this.btnADD.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtRemark
            // 
            this.txtRemark.Location = new System.Drawing.Point(96, 202);
            this.txtRemark.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRemark.Multiline = true;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(254, 110);
            this.txtRemark.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 20);
            this.label5.TabIndex = 32;
            this.label5.Text = "Remark : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(290, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 31;
            this.label4.Text = "Lat/Long";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(96, 168);
            this.txtLocation.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(190, 26);
            this.txtLocation.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 29;
            this.label3.Text = "Location : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 28;
            this.label1.Text = "Type : ";
            // 
            // txtLabel
            // 
            this.txtLabel.Location = new System.Drawing.Point(260, 37);
            this.txtLabel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLabel.Name = "txtLabel";
            this.txtLabel.Size = new System.Drawing.Size(102, 26);
            this.txtLabel.TabIndex = 27;
            // 
            // txtNuber
            // 
            this.txtNuber.Location = new System.Drawing.Point(96, 39);
            this.txtNuber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNuber.Name = "txtNuber";
            this.txtNuber.Size = new System.Drawing.Size(102, 26);
            this.txtNuber.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(204, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 25;
            this.label2.Text = "Label : ";
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Location = new System.Drawing.Point(17, 40);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(77, 20);
            this.Name.TabIndex = 24;
            this.Name.Text = "Number : ";
            // 
            // chbSimulated
            // 
            this.chbSimulated.AutoSize = true;
            this.chbSimulated.Location = new System.Drawing.Point(266, 5);
            this.chbSimulated.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chbSimulated.Name = "chbSimulated";
            this.chbSimulated.Size = new System.Drawing.Size(106, 24);
            this.chbSimulated.TabIndex = 23;
            this.chbSimulated.Text = "Simulated";
            this.chbSimulated.UseVisualStyleBackColor = true;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rdbSpecial);
            this.Controls.Add(this.rdbOBSPost);
            this.Controls.Add(this.rdbFRadar);
            this.Controls.Add(this.rdbMRadar);
            this.Controls.Add(this.rdbTactical);
            this.Controls.Add(this.btnADD);
            this.Controls.Add(this.txtRemark);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLabel);
            this.Controls.Add(this.txtNuber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.chbSimulated);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "main";
            this.Size = new System.Drawing.Size(377, 395);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdbSpecial;
        private System.Windows.Forms.RadioButton rdbOBSPost;
        private System.Windows.Forms.RadioButton rdbFRadar;
        private System.Windows.Forms.RadioButton rdbMRadar;
        private System.Windows.Forms.RadioButton rdbTactical;
        private System.Windows.Forms.Button btnADD;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLabel;
        private System.Windows.Forms.TextBox txtNuber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.CheckBox chbSimulated;
    }
}
