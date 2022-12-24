namespace GRM_GT2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.NumberOfTeethInitial = new System.Windows.Forms.Label();
            this.RadiusInitial = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NumberOfTeethResult = new System.Windows.Forms.Label();
            this.RadiusResult = new System.Windows.Forms.Label();
            this.NumberOfTeethResultOutput = new System.Windows.Forms.Label();
            this.RadiusResultOutput = new System.Windows.Forms.Label();
            this.InputRadius = new System.Windows.Forms.NumericUpDown();
            this.InputNumberOfTeeth = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InputRadius)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InputNumberOfTeeth)).BeginInit();
            this.SuspendLayout();
            // 
            // NumberOfTeethInitial
            // 
            this.NumberOfTeethInitial.AutoSize = true;
            this.NumberOfTeethInitial.Location = new System.Drawing.Point(13, 9);
            this.NumberOfTeethInitial.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NumberOfTeethInitial.Name = "NumberOfTeethInitial";
            this.NumberOfTeethInitial.Size = new System.Drawing.Size(148, 17);
            this.NumberOfTeethInitial.TabIndex = 0;
            this.NumberOfTeethInitial.Text = "Количество зубьев";
            // 
            // RadiusInitial
            // 
            this.RadiusInitial.AutoSize = true;
            this.RadiusInitial.Location = new System.Drawing.Point(14, 62);
            this.RadiusInitial.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RadiusInitial.Name = "RadiusInitial";
            this.RadiusInitial.Size = new System.Drawing.Size(60, 17);
            this.RadiusInitial.TabIndex = 1;
            this.RadiusInitial.Text = "Радиус";
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(13, 134);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(331, 25);
            this.button1.TabIndex = 2;
            this.button1.Text = "Расчитать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GRM_GT2.Properties.Resources.pQbMIQIPy6OdItCnK8jv89BMRQt4aa9dzrBrm7CAdZ4FxSayVO;
            this.pictureBox1.Location = new System.Drawing.Point(-6, 152);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(369, 255);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(148, 32);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 17);
            this.label3.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(148, 78);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 17);
            this.label4.TabIndex = 7;
            // 
            // NumberOfTeethResult
            // 
            this.NumberOfTeethResult.AutoSize = true;
            this.NumberOfTeethResult.Location = new System.Drawing.Point(196, 62);
            this.NumberOfTeethResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NumberOfTeethResult.Name = "NumberOfTeethResult";
            this.NumberOfTeethResult.Size = new System.Drawing.Size(148, 17);
            this.NumberOfTeethResult.TabIndex = 8;
            this.NumberOfTeethResult.Text = "Количество зубьев";
            this.NumberOfTeethResult.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // RadiusResult
            // 
            this.RadiusResult.AutoSize = true;
            this.RadiusResult.Location = new System.Drawing.Point(196, 9);
            this.RadiusResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RadiusResult.Name = "RadiusResult";
            this.RadiusResult.Size = new System.Drawing.Size(60, 17);
            this.RadiusResult.TabIndex = 9;
            this.RadiusResult.Text = "Радиус";
            this.RadiusResult.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // NumberOfTeethResultOutput
            // 
            this.NumberOfTeethResultOutput.AutoSize = true;
            this.NumberOfTeethResultOutput.Location = new System.Drawing.Point(196, 37);
            this.NumberOfTeethResultOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NumberOfTeethResultOutput.Name = "NumberOfTeethResultOutput";
            this.NumberOfTeethResultOutput.Size = new System.Drawing.Size(48, 17);
            this.NumberOfTeethResultOutput.TabIndex = 10;
            this.NumberOfTeethResultOutput.Text = "label1";
            this.NumberOfTeethResultOutput.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // RadiusResultOutput
            // 
            this.RadiusResultOutput.AutoSize = true;
            this.RadiusResultOutput.Location = new System.Drawing.Point(196, 91);
            this.RadiusResultOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RadiusResultOutput.Name = "RadiusResultOutput";
            this.RadiusResultOutput.Size = new System.Drawing.Size(48, 17);
            this.RadiusResultOutput.TabIndex = 11;
            this.RadiusResultOutput.Text = "label2";
            this.RadiusResultOutput.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // InputRadius
            // 
            this.InputRadius.DecimalPlaces = 2;
            this.InputRadius.Location = new System.Drawing.Point(14, 89);
            this.InputRadius.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.InputRadius.Name = "InputRadius";
            this.InputRadius.Size = new System.Drawing.Size(147, 24);
            this.InputRadius.TabIndex = 12;
            // 
            // InputNumberOfTeeth
            // 
            this.InputNumberOfTeeth.Location = new System.Drawing.Point(14, 35);
            this.InputNumberOfTeeth.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.InputNumberOfTeeth.Name = "InputNumberOfTeeth";
            this.InputNumberOfTeeth.Size = new System.Drawing.Size(147, 24);
            this.InputNumberOfTeeth.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(40)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(357, 379);
            this.Controls.Add(this.InputNumberOfTeeth);
            this.Controls.Add(this.InputRadius);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.RadiusResultOutput);
            this.Controls.Add(this.NumberOfTeethResultOutput);
            this.Controls.Add(this.RadiusResult);
            this.Controls.Add(this.NumberOfTeethResult);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.RadiusInitial);
            this.Controls.Add(this.NumberOfTeethInitial);
            this.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "GRM GT2";
            this.TransparencyKey = System.Drawing.Color.WhiteSmoke;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InputRadius)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InputNumberOfTeeth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label NumberOfTeethInitial;
        private Label RadiusInitial;
        private Button button1;
        private PictureBox pictureBox1;
        private Label label3;
        private Label label4;
        private Label NumberOfTeethResult;
        private Label RadiusResult;
        private Label NumberOfTeethResultOutput;
        private Label RadiusResultOutput;
        private NumericUpDown InputRadius;
        private NumericUpDown InputNumberOfTeeth;
    }
}