﻿namespace PATIENT_TREATMENT_ADVISOR
{
    partial class QuestionForm
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
            this.QDiaVomCV = new System.Windows.Forms.CheckBox();
            this.QLungCB = new System.Windows.Forms.CheckBox();
            this.QFeverCB = new System.Windows.Forms.CheckBox();
            this.QSmokerCB = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AcceptBtn = new System.Windows.Forms.Button();
            this.QVegCB = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // QDiaVomCV
            // 
            this.QDiaVomCV.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.QDiaVomCV.AutoSize = true;
            this.QDiaVomCV.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.QDiaVomCV.Location = new System.Drawing.Point(65, 68);
            this.QDiaVomCV.Name = "QDiaVomCV";
            this.QDiaVomCV.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.QDiaVomCV.Size = new System.Drawing.Size(247, 27);
            this.QDiaVomCV.TabIndex = 51;
            this.QDiaVomCV.Text = "סובל משילשולים ו/או הקאות";
            this.QDiaVomCV.UseVisualStyleBackColor = true;
            // 
            // QLungCB
            // 
            this.QLungCB.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.QLungCB.AutoSize = true;
            this.QLungCB.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.QLungCB.Location = new System.Drawing.Point(133, 167);
            this.QLungCB.Name = "QLungCB";
            this.QLungCB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.QLungCB.Size = new System.Drawing.Size(179, 27);
            this.QLungCB.TabIndex = 50;
            this.QLungCB.Text = "סובל ממחלת ריאות";
            this.QLungCB.UseVisualStyleBackColor = true;
            // 
            // QFeverCB
            // 
            this.QFeverCB.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.QFeverCB.AutoSize = true;
            this.QFeverCB.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.QFeverCB.Location = new System.Drawing.Point(197, 134);
            this.QFeverCB.Name = "QFeverCB";
            this.QFeverCB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.QFeverCB.Size = new System.Drawing.Size(115, 27);
            this.QFeverCB.TabIndex = 49;
            this.QFeverCB.Text = "סובל מחום";
            this.QFeverCB.UseVisualStyleBackColor = true;
            // 
            // QSmokerCB
            // 
            this.QSmokerCB.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.QSmokerCB.AutoSize = true;
            this.QSmokerCB.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.QSmokerCB.Location = new System.Drawing.Point(240, 35);
            this.QSmokerCB.Name = "QSmokerCB";
            this.QSmokerCB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.QSmokerCB.Size = new System.Drawing.Size(72, 27);
            this.QSmokerCB.TabIndex = 48;
            this.QSmokerCB.Text = "מעשן";
            this.QSmokerCB.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(52, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(273, 23);
            this.label2.TabIndex = 55;
            this.label2.Text = "לפני היעוץ, יש לסמן ✓ אם המטופל";
            // 
            // AcceptBtn
            // 
            this.AcceptBtn.BackColor = System.Drawing.Color.LightGreen;
            this.AcceptBtn.Location = new System.Drawing.Point(133, 200);
            this.AcceptBtn.Name = "AcceptBtn";
            this.AcceptBtn.Size = new System.Drawing.Size(94, 29);
            this.AcceptBtn.TabIndex = 56;
            this.AcceptBtn.Text = "אישור";
            this.AcceptBtn.UseVisualStyleBackColor = false;
            this.AcceptBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // QVegCB
            // 
            this.QVegCB.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.QVegCB.AutoSize = true;
            this.QVegCB.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.QVegCB.Location = new System.Drawing.Point(154, 101);
            this.QVegCB.Name = "QVegCB";
            this.QVegCB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.QVegCB.Size = new System.Drawing.Size(158, 27);
            this.QVegCB.TabIndex = 52;
            this.QVegCB.Text = "צמחוני או טבעוני";
            this.QVegCB.UseVisualStyleBackColor = true;
            // 
            // QuestionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(341, 234);
            this.Controls.Add(this.AcceptBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.QVegCB);
            this.Controls.Add(this.QDiaVomCV);
            this.Controls.Add(this.QLungCB);
            this.Controls.Add(this.QFeverCB);
            this.Controls.Add(this.QSmokerCB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "QuestionForm";
            this.Text = "QuestionForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CheckBox QDiaVomCV;
        private CheckBox QLungCB;
        private CheckBox QFeverCB;
        private CheckBox QSmokerCB;
        private Label label2;
        private Button AcceptBtn;
        private CheckBox QVegCB;
    }
}