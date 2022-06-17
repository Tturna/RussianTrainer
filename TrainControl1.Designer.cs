namespace RussianTrainer
{
    partial class TrainControl1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.trainBaseControl1 = new RussianTrainer.TrainBaseControl();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // trainBaseControl1
            // 
            this.trainBaseControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.trainBaseControl1.Location = new System.Drawing.Point(0, 0);
            this.trainBaseControl1.Name = "trainBaseControl1";
            this.trainBaseControl1.Size = new System.Drawing.Size(940, 477);
            this.trainBaseControl1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(391, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "The training will include this and\r\nthat kinda stuff fuck you lmao";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(428, 209);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(82, 23);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start Training";
            this.btnStart.UseVisualStyleBackColor = true;
            // 
            // TrainControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trainBaseControl1);
            this.Name = "TrainControl1";
            this.Size = new System.Drawing.Size(940, 477);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TrainBaseControl trainBaseControl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStart;
    }
}
