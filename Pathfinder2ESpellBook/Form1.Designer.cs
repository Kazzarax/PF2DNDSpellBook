namespace Pathfinder2ESpellBook
{
    partial class Form1
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
            this.LoadSpellData = new System.Windows.Forms.Button();
            this.spellLoadingText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LoadSpellData
            // 
            this.LoadSpellData.Location = new System.Drawing.Point(12, 12);
            this.LoadSpellData.Name = "LoadSpellData";
            this.LoadSpellData.Size = new System.Drawing.Size(273, 23);
            this.LoadSpellData.TabIndex = 0;
            this.LoadSpellData.Text = "Load Spell Data";
            this.LoadSpellData.UseVisualStyleBackColor = true;
            this.LoadSpellData.Click += new System.EventHandler(this.LoadSpellData_Click);
            // 
            // spellLoadingText
            // 
            this.spellLoadingText.AutoSize = true;
            this.spellLoadingText.Location = new System.Drawing.Point(53, 38);
            this.spellLoadingText.Name = "spellLoadingText";
            this.spellLoadingText.Size = new System.Drawing.Size(192, 13);
            this.spellLoadingText.TabIndex = 1;
            this.spellLoadingText.Text = "Currently Loading Spell XXXX of XXXX.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 94);
            this.Controls.Add(this.spellLoadingText);
            this.Controls.Add(this.LoadSpellData);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LoadSpellData;
        private System.Windows.Forms.Label spellLoadingText;
    }
}

