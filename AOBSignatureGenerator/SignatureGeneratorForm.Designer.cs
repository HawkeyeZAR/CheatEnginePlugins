
namespace AOBSignatureGenerator
{
    partial class SignatureGeneratorForm
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
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            this.labelInputData = new System.Windows.Forms.Label();
            this.labelOutputData = new System.Windows.Forms.Label();
            this.buttonAOB = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxOutput2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxInput
            // 
            this.textBoxInput.Location = new System.Drawing.Point(12, 31);
            this.textBoxInput.Multiline = true;
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(776, 160);
            this.textBoxInput.TabIndex = 0;
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.Location = new System.Drawing.Point(12, 232);
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.Size = new System.Drawing.Size(776, 22);
            this.textBoxOutput.TabIndex = 1;
            // 
            // labelInputData
            // 
            this.labelInputData.AutoSize = true;
            this.labelInputData.Location = new System.Drawing.Point(13, 9);
            this.labelInputData.Name = "labelInputData";
            this.labelInputData.Size = new System.Drawing.Size(158, 16);
            this.labelInputData.TabIndex = 2;
            this.labelInputData.Text = "Enter your AOB data here";
            // 
            // labelOutputData
            // 
            this.labelOutputData.AutoSize = true;
            this.labelOutputData.Location = new System.Drawing.Point(12, 210);
            this.labelOutputData.Name = "labelOutputData";
            this.labelOutputData.Size = new System.Drawing.Size(209, 16);
            this.labelOutputData.TabIndex = 3;
            this.labelOutputData.Text = "AOB Signature Data With Spacing";
            // 
            // buttonAOB
            // 
            this.buttonAOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAOB.Location = new System.Drawing.Point(335, 319);
            this.buttonAOB.Name = "buttonAOB";
            this.buttonAOB.Size = new System.Drawing.Size(126, 41);
            this.buttonAOB.TabIndex = 4;
            this.buttonAOB.Text = "Create Signature";
            this.buttonAOB.UseVisualStyleBackColor = true;
            this.buttonAOB.Click += new System.EventHandler(this.buttonAOB_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 271);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "AOB Signature Data No Spacing";
            // 
            // textBoxOutput2
            // 
            this.textBoxOutput2.Location = new System.Drawing.Point(12, 291);
            this.textBoxOutput2.Name = "textBoxOutput2";
            this.textBoxOutput2.Size = new System.Drawing.Size(776, 22);
            this.textBoxOutput2.TabIndex = 6;
            // 
            // SignatureGeneratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 373);
            this.Controls.Add(this.textBoxOutput2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAOB);
            this.Controls.Add(this.labelOutputData);
            this.Controls.Add(this.labelInputData);
            this.Controls.Add(this.textBoxOutput);
            this.Controls.Add(this.textBoxInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "SignatureGeneratorForm";
            this.Text = "AOB Signature Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.TextBox textBoxOutput;
        private System.Windows.Forms.Label labelInputData;
        private System.Windows.Forms.Label labelOutputData;
        private System.Windows.Forms.Button buttonAOB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxOutput2;
    }
}