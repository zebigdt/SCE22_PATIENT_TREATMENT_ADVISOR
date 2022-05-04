﻿namespace PATIENT_TREATMENT_ADVISOR
{
    partial class TreatmentPage
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
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.AddPatientButton = new System.Windows.Forms.Button();
            this.ImportPatientButton = new System.Windows.Forms.Button();
            this.DiagnosisAndRecommendationButton = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.FirstNameColumn = new System.Windows.Forms.ColumnHeader();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // AddPatientButton
            // 
            this.AddPatientButton.Location = new System.Drawing.Point(463, 338);
            this.AddPatientButton.Name = "AddPatientButton";
            this.AddPatientButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.AddPatientButton.Size = new System.Drawing.Size(201, 74);
            this.AddPatientButton.TabIndex = 0;
            this.AddPatientButton.Text = "הוסף מטופל";
            this.AddPatientButton.UseVisualStyleBackColor = true;
            this.AddPatientButton.Click += new System.EventHandler(this.AddPatientButton_Click);
            // 
            // ImportPatientButton
            // 
            this.ImportPatientButton.Location = new System.Drawing.Point(256, 338);
            this.ImportPatientButton.Name = "ImportPatientButton";
            this.ImportPatientButton.Size = new System.Drawing.Size(201, 74);
            this.ImportPatientButton.TabIndex = 0;
            this.ImportPatientButton.Text = "ייבא מטופל מקובץ אקסל";
            this.ImportPatientButton.UseVisualStyleBackColor = true;
            // 
            // DiagnosisAndRecommendationButton
            // 
            this.DiagnosisAndRecommendationButton.Location = new System.Drawing.Point(49, 338);
            this.DiagnosisAndRecommendationButton.Name = "DiagnosisAndRecommendationButton";
            this.DiagnosisAndRecommendationButton.Size = new System.Drawing.Size(201, 74);
            this.DiagnosisAndRecommendationButton.TabIndex = 0;
            this.DiagnosisAndRecommendationButton.Text = "אבחון והמלצות";
            this.DiagnosisAndRecommendationButton.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.FirstNameColumn});
            this.listView1.Location = new System.Drawing.Point(49, 65);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(615, 267);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // FirstNameColumn
            // 
            this.FirstNameColumn.Text = "שם פרטי";
            // 
            // TreatmentPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 450);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.DiagnosisAndRecommendationButton);
            this.Controls.Add(this.ImportPatientButton);
            this.Controls.Add(this.AddPatientButton);
            this.Name = "TreatmentPage";
            this.Text = "TreatmentPage";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TreatmentPage_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private BindingSource bindingSource1;
        private Button AddPatientButton;
        private Button ImportPatientButton;
        private Button DiagnosisAndRecommendationButton;
        private ListView listView1;
        private ColumnHeader FirstNameColumn;
    }
}