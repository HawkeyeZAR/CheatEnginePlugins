
namespace AOBSignatureGenerator.Forms
{
    partial class HideShowMainForm
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
            this.checkBoxShowHide = new System.Windows.Forms.CheckBox();
            this.checkBoxOnTop = new System.Windows.Forms.CheckBox();
            this.labelWindowStatus = new System.Windows.Forms.Label();
            this.checkBoxHideAll = new System.Windows.Forms.CheckBox();
            this.trackBarOpaque = new System.Windows.Forms.TrackBar();
            this.labelOpaque = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarOpaque)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBoxShowHide
            // 
            this.checkBoxShowHide.AutoSize = true;
            this.checkBoxShowHide.Location = new System.Drawing.Point(12, 39);
            this.checkBoxShowHide.Name = "checkBoxShowHide";
            this.checkBoxShowHide.Size = new System.Drawing.Size(173, 20);
            this.checkBoxShowHide.TabIndex = 2;
            this.checkBoxShowHide.Text = "Hide/Show Main Screen";
            this.checkBoxShowHide.UseVisualStyleBackColor = true;
            this.checkBoxShowHide.CheckedChanged += new System.EventHandler(this.checkBoxShowHide_CheckedChanged);
            // 
            // checkBoxOnTop
            // 
            this.checkBoxOnTop.AutoSize = true;
            this.checkBoxOnTop.Location = new System.Drawing.Point(12, 12);
            this.checkBoxOnTop.Name = "checkBoxOnTop";
            this.checkBoxOnTop.Size = new System.Drawing.Size(197, 20);
            this.checkBoxOnTop.TabIndex = 3;
            this.checkBoxOnTop.Text = "MainWindow Always OnTop";
            this.checkBoxOnTop.UseVisualStyleBackColor = true;
            this.checkBoxOnTop.CheckedChanged += new System.EventHandler(this.checkBoxOnTop_CheckedChanged);
            // 
            // labelWindowStatus
            // 
            this.labelWindowStatus.AutoSize = true;
            this.labelWindowStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWindowStatus.Location = new System.Drawing.Point(9, 159);
            this.labelWindowStatus.Name = "labelWindowStatus";
            this.labelWindowStatus.Size = new System.Drawing.Size(54, 16);
            this.labelWindowStatus.TabIndex = 4;
            this.labelWindowStatus.Text = "Status:";
            // 
            // checkBoxHideAll
            // 
            this.checkBoxHideAll.AutoSize = true;
            this.checkBoxHideAll.Location = new System.Drawing.Point(12, 65);
            this.checkBoxHideAll.Name = "checkBoxHideAll";
            this.checkBoxHideAll.Size = new System.Drawing.Size(150, 20);
            this.checkBoxHideAll.TabIndex = 5;
            this.checkBoxHideAll.Text = "Hide All CE Screens";
            this.checkBoxHideAll.UseVisualStyleBackColor = true;
            this.checkBoxHideAll.CheckedChanged += new System.EventHandler(this.checkBoxHideAll_CheckedChanged);
            // 
            // trackBarOpaque
            // 
            this.trackBarOpaque.AutoSize = false;
            this.trackBarOpaque.Location = new System.Drawing.Point(-3, 112);
            this.trackBarOpaque.Maximum = 255;
            this.trackBarOpaque.Minimum = 30;
            this.trackBarOpaque.Name = "trackBarOpaque";
            this.trackBarOpaque.Size = new System.Drawing.Size(288, 35);
            this.trackBarOpaque.TabIndex = 6;
            this.trackBarOpaque.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackBarOpaque.Value = 30;
            this.trackBarOpaque.ValueChanged += new System.EventHandler(this.slider_valueChanged);
            // 
            // labelOpaque
            // 
            this.labelOpaque.AutoSize = true;
            this.labelOpaque.Location = new System.Drawing.Point(9, 93);
            this.labelOpaque.Name = "labelOpaque";
            this.labelOpaque.Size = new System.Drawing.Size(135, 16);
            this.labelOpaque.TabIndex = 7;
            this.labelOpaque.Text = "Ajust Opacity of forms";
            // 
            // HideShowMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 179);
            this.Controls.Add(this.labelOpaque);
            this.Controls.Add(this.trackBarOpaque);
            this.Controls.Add(this.checkBoxHideAll);
            this.Controls.Add(this.labelWindowStatus);
            this.Controls.Add(this.checkBoxOnTop);
            this.Controls.Add(this.checkBoxShowHide);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HideShowMainForm";
            this.Text = "Main Window Display Options";
            ((System.ComponentModel.ISupportInitialize)(this.trackBarOpaque)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxShowHide;
        private System.Windows.Forms.CheckBox checkBoxOnTop;
        private System.Windows.Forms.Label labelWindowStatus;
        private System.Windows.Forms.CheckBox checkBoxHideAll;
        private System.Windows.Forms.TrackBar trackBarOpaque;
        private System.Windows.Forms.Label labelOpaque;
    }
}