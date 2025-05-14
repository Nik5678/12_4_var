namespace _12_4_вариант
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
            pictureBoxOriginal = new PictureBox();
            pictureBoxProcessed = new PictureBox();
            radioButtonR = new RadioButton();
            radioButtonG = new RadioButton();
            radioButtonB = new RadioButton();
            btnLoad = new Button();
            btnApply = new Button();
            btnSave = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxOriginal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxProcessed).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxOriginal
            // 
            pictureBoxOriginal.BorderStyle = BorderStyle.Fixed3D;
            pictureBoxOriginal.Location = new Point(22, 17);
            pictureBoxOriginal.Name = "pictureBoxOriginal";
            pictureBoxOriginal.Size = new Size(472, 463);
            pictureBoxOriginal.TabIndex = 0;
            pictureBoxOriginal.TabStop = false;
            // 
            // pictureBoxProcessed
            // 
            pictureBoxProcessed.BorderStyle = BorderStyle.Fixed3D;
            pictureBoxProcessed.Location = new Point(568, 17);
            pictureBoxProcessed.Name = "pictureBoxProcessed";
            pictureBoxProcessed.Size = new Size(568, 463);
            pictureBoxProcessed.TabIndex = 1;
            pictureBoxProcessed.TabStop = false;
            // 
            // radioButtonR
            // 
            radioButtonR.AutoSize = true;
            radioButtonR.Location = new Point(433, 503);
            radioButtonR.Name = "radioButtonR";
            radioButtonR.Size = new Size(74, 19);
            radioButtonR.TabIndex = 2;
            radioButtonR.TabStop = true;
            radioButtonR.Text = "Красный";
            radioButtonR.UseVisualStyleBackColor = true;
            // 
            // radioButtonG
            // 
            radioButtonG.AutoSize = true;
            radioButtonG.Location = new Point(433, 528);
            radioButtonG.Name = "radioButtonG";
            radioButtonG.Size = new Size(74, 19);
            radioButtonG.TabIndex = 3;
            radioButtonG.TabStop = true;
            radioButtonG.Text = "Зелёный";
            radioButtonG.UseVisualStyleBackColor = true;
            // 
            // radioButtonB
            // 
            radioButtonB.AutoSize = true;
            radioButtonB.Location = new Point(433, 553);
            radioButtonB.Name = "radioButtonB";
            radioButtonB.Size = new Size(61, 19);
            radioButtonB.TabIndex = 4;
            radioButtonB.TabStop = true;
            radioButtonB.Text = "Синий";
            radioButtonB.UseVisualStyleBackColor = true;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(22, 503);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(114, 52);
            btnLoad.TabIndex = 5;
            btnLoad.Text = "Загрузить изображение";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnApply
            // 
            btnApply.Location = new Point(163, 503);
            btnApply.Name = "btnApply";
            btnApply.Size = new Size(97, 49);
            btnApply.TabIndex = 6;
            btnApply.Text = "Применить фильтр";
            btnApply.UseVisualStyleBackColor = true;
            btnApply.Click += btnApply_Click_1;
            // 
            // btnSave
            // 
            pictureBoxOriginal.Image = _originalImage;
            pictureBoxProcessed.Image = _processedImage;
            btnSave.Location = new Point(299, 503);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(103, 48);
            btnSave.TabIndex = 7;
            btnSave.Text = "Сохранить результат";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1256, 610);
            Controls.Add(btnSave);
            Controls.Add(btnApply);
            Controls.Add(btnLoad);
            Controls.Add(radioButtonB);
            Controls.Add(radioButtonG);
            Controls.Add(radioButtonR);
            Controls.Add(pictureBoxProcessed);
            Controls.Add(pictureBoxOriginal);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBoxOriginal).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxProcessed).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBoxOriginal;
        private PictureBox pictureBoxProcessed;
        private RadioButton radioButtonR;
        private RadioButton radioButtonG;
        private RadioButton radioButtonB;
        private Button btnLoad;
        private Button btnApply;
        private Button btnSave;
    }
}
