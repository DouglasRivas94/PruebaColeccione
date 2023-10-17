namespace Queue
{
    partial class QueuingForm
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
            this.btncashier = new System.Windows.Forms.Button();
            this.lblmean = new System.Windows.Forms.Label();
            this.lblposition = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btncashier
            // 
            this.btncashier.Location = new System.Drawing.Point(30, 79);
            this.btncashier.Name = "btncashier";
            this.btncashier.Size = new System.Drawing.Size(96, 82);
            this.btncashier.TabIndex = 0;
            this.btncashier.Text = "Cashier";
            this.btncashier.UseVisualStyleBackColor = true;
            this.btncashier.Click += new System.EventHandler(this.btncashier_Click);
            // 
            // lblmean
            // 
            this.lblmean.AutoSize = true;
            this.lblmean.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblmean.Location = new System.Drawing.Point(217, 54);
            this.lblmean.Name = "lblmean";
            this.lblmean.Size = new System.Drawing.Size(188, 30);
            this.lblmean.TabIndex = 1;
            this.lblmean.Text = "Position in Queue";
            // 
            // lblposition
            // 
            this.lblposition.AutoSize = true;
            this.lblposition.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblposition.Location = new System.Drawing.Point(240, 99);
            this.lblposition.Name = "lblposition";
            this.lblposition.Size = new System.Drawing.Size(128, 50);
            this.lblposition.TabIndex = 2;
            this.lblposition.Text = "label2";
            // 
            // QueuingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 222);
            this.Controls.Add(this.lblposition);
            this.Controls.Add(this.lblmean);
            this.Controls.Add(this.btncashier);
            this.Name = "QueuingForm";
            this.Text = "QueuingForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btncashier;
        private Label lblmean;
        private Label lblposition;
    }
}