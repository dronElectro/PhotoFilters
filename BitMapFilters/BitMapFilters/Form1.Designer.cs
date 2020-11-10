namespace BitMapFilters
{
    partial class BitMapFilersForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.MainImagePB = new System.Windows.Forms.PictureBox();
            this.ChooseMainImageB = new System.Windows.Forms.Button();
            this.ApplyFiltersTB = new System.Windows.Forms.TrackBar();
            this.ChooseLogoB = new System.Windows.Forms.Button();
            this.LogoPB = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.MainImagePB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ApplyFiltersTB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPB)).BeginInit();
            this.SuspendLayout();
            // 
            // MainImagePB
            // 
            this.MainImagePB.Location = new System.Drawing.Point(12, 12);
            this.MainImagePB.Name = "MainImagePB";
            this.MainImagePB.Size = new System.Drawing.Size(747, 426);
            this.MainImagePB.TabIndex = 0;
            this.MainImagePB.TabStop = false;
            // 
            // ChooseMainImageB
            // 
            this.ChooseMainImageB.Location = new System.Drawing.Point(787, 12);
            this.ChooseMainImageB.Name = "ChooseMainImageB";
            this.ChooseMainImageB.Size = new System.Drawing.Size(148, 47);
            this.ChooseMainImageB.TabIndex = 1;
            this.ChooseMainImageB.Text = "Выбрать изображение";
            this.ChooseMainImageB.UseVisualStyleBackColor = true;
            this.ChooseMainImageB.Click += new System.EventHandler(this.button1_Click);
            // 
            // ApplyFiltersTB
            // 
            this.ApplyFiltersTB.Location = new System.Drawing.Point(787, 65);
            this.ApplyFiltersTB.Name = "ApplyFiltersTB";
            this.ApplyFiltersTB.Size = new System.Drawing.Size(148, 56);
            this.ApplyFiltersTB.TabIndex = 2;
            this.ApplyFiltersTB.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // ChooseLogoB
            // 
            this.ChooseLogoB.Location = new System.Drawing.Point(787, 185);
            this.ChooseLogoB.Name = "ChooseLogoB";
            this.ChooseLogoB.Size = new System.Drawing.Size(148, 23);
            this.ChooseLogoB.TabIndex = 3;
            this.ChooseLogoB.Text = "Выбрать логотип";
            this.ChooseLogoB.UseVisualStyleBackColor = true;
            this.ChooseLogoB.Click += new System.EventHandler(this.button2_Click);
            // 
            // LogoPB
            // 
            this.LogoPB.Location = new System.Drawing.Point(787, 234);
            this.LogoPB.MaximumSize = new System.Drawing.Size(148, 102);
            this.LogoPB.MinimumSize = new System.Drawing.Size(148, 102);
            this.LogoPB.Name = "LogoPB";
            this.LogoPB.Size = new System.Drawing.Size(148, 102);
            this.LogoPB.TabIndex = 4;
            this.LogoPB.TabStop = false;
            // 
            // BitMapFilersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 450);
            this.Controls.Add(this.LogoPB);
            this.Controls.Add(this.ChooseLogoB);
            this.Controls.Add(this.ApplyFiltersTB);
            this.Controls.Add(this.ChooseMainImageB);
            this.Controls.Add(this.MainImagePB);
            this.Name = "BitMapFilersForm";
            this.Text = "BitMapFilters";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MainImagePB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ApplyFiltersTB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox MainImagePB;
        private System.Windows.Forms.Button ChooseMainImageB;
        private System.Windows.Forms.TrackBar ApplyFiltersTB;
        private System.Windows.Forms.Button ChooseLogoB;
        private System.Windows.Forms.PictureBox LogoPB;
    }
}

