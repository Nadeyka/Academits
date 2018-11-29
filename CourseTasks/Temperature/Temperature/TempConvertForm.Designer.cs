namespace Temperature
{
    partial class TempConvertForm
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
            this.tbInputTemp = new System.Windows.Forms.TextBox();
            this.lblInputTemp = new System.Windows.Forms.Label();
            this.btnTempConvert = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.cbFromTemp = new System.Windows.Forms.ComboBox();
            this.cbToTemp = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // tbInputTemp
            // 
            this.tbInputTemp.Location = new System.Drawing.Point(177, 26);
            this.tbInputTemp.Margin = new System.Windows.Forms.Padding(4);
            this.tbInputTemp.Name = "tbInputTemp";
            this.tbInputTemp.Size = new System.Drawing.Size(88, 23);
            this.tbInputTemp.TabIndex = 0;
            this.tbInputTemp.TextChanged += new System.EventHandler(this.tbInputTemp_TextChanged);
            // 
            // lblInputTemp
            // 
            this.lblInputTemp.AutoSize = true;
            this.lblInputTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblInputTemp.Location = new System.Drawing.Point(13, 26);
            this.lblInputTemp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInputTemp.Name = "lblInputTemp";
            this.lblInputTemp.Size = new System.Drawing.Size(156, 17);
            this.lblInputTemp.TabIndex = 1;
            this.lblInputTemp.Text = "Введите температуру:";
            // 
            // btnTempConvert
            // 
            this.btnTempConvert.Location = new System.Drawing.Point(13, 88);
            this.btnTempConvert.Name = "btnTempConvert";
            this.btnTempConvert.Size = new System.Drawing.Size(94, 27);
            this.btnTempConvert.TabIndex = 2;
            this.btnTempConvert.Text = "Перевести";
            this.btnTempConvert.UseVisualStyleBackColor = true;
            this.btnTempConvert.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(13, 56);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Перевести в шкалу:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(130, 93);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Результат:";
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelResult.Location = new System.Drawing.Point(209, 93);
            this.labelResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(66, 17);
            this.labelResult.TabIndex = 7;
            this.labelResult.Text = "градусов";
            // 
            // cbFromTemp
            // 
            this.cbFromTemp.FormattingEnabled = true;
            this.cbFromTemp.Items.AddRange(new object[] {
            "° Цельсия",
            "° Кельвина",
            "° Фаренгейта"});
            this.cbFromTemp.Location = new System.Drawing.Point(272, 26);
            this.cbFromTemp.Name = "cbFromTemp";
            this.cbFromTemp.Size = new System.Drawing.Size(122, 24);
            this.cbFromTemp.TabIndex = 8;
            // 
            // cbToTemp
            // 
            this.cbToTemp.FormattingEnabled = true;
            this.cbToTemp.Items.AddRange(new object[] {
            "° Цельсия",
            "° Кельвина",
            "° Фаренгейта"});
            this.cbToTemp.Location = new System.Drawing.Point(177, 56);
            this.cbToTemp.Name = "cbToTemp";
            this.cbToTemp.Size = new System.Drawing.Size(120, 24);
            this.cbToTemp.TabIndex = 9;
            // 
            // TempConvertForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 121);
            this.Controls.Add(this.cbToTemp);
            this.Controls.Add(this.cbFromTemp);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnTempConvert);
            this.Controls.Add(this.lblInputTemp);
            this.Controls.Add(this.tbInputTemp);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TempConvertForm";
            this.Text = "Перевод температур";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbInputTemp;
        private System.Windows.Forms.Label lblInputTemp;
        private System.Windows.Forms.Button btnTempConvert;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.ComboBox cbFromTemp;
        private System.Windows.Forms.ComboBox cbToTemp;
    }
}

