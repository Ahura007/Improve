namespace CamundaForm.CamundaForms
{
    partial class FrmNextStep
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
            BtnStepA = new Button();
            BtnStepB = new Button();
            BtnStepC = new Button();
            BtnStepD = new Button();
            SuspendLayout();
            // 
            // BtnStepA
            // 
            BtnStepA.Dock = DockStyle.Left;
            BtnStepA.Location = new Point(0, 0);
            BtnStepA.Name = "BtnStepA";
            BtnStepA.Size = new Size(215, 216);
            BtnStepA.TabIndex = 0;
            BtnStepA.Text = "A";
            BtnStepA.UseVisualStyleBackColor = true;
            BtnStepA.Click += BtnStepA_Click;
            // 
            // BtnStepB
            // 
            BtnStepB.Dock = DockStyle.Left;
            BtnStepB.Location = new Point(215, 0);
            BtnStepB.Name = "BtnStepB";
            BtnStepB.Size = new Size(215, 216);
            BtnStepB.TabIndex = 1;
            BtnStepB.Text = "B";
            BtnStepB.UseVisualStyleBackColor = true;
            BtnStepB.Click += BtnStepB_Click;
            // 
            // BtnStepC
            // 
            BtnStepC.Dock = DockStyle.Left;
            BtnStepC.Location = new Point(430, 0);
            BtnStepC.Name = "BtnStepC";
            BtnStepC.Size = new Size(215, 216);
            BtnStepC.TabIndex = 2;
            BtnStepC.Text = "C";
            BtnStepC.UseVisualStyleBackColor = true;
            BtnStepC.Click += BtnStepC_Click;
            // 
            // BtnStepD
            // 
            BtnStepD.Dock = DockStyle.Left;
            BtnStepD.Location = new Point(645, 0);
            BtnStepD.Name = "BtnStepD";
            BtnStepD.Size = new Size(215, 216);
            BtnStepD.TabIndex = 3;
            BtnStepD.Text = "D";
            BtnStepD.UseVisualStyleBackColor = true;
            BtnStepD.Click += BtnStepD_Click;
            // 
            // FrmNextStep
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(859, 216);
            Controls.Add(BtnStepD);
            Controls.Add(BtnStepC);
            Controls.Add(BtnStepB);
            Controls.Add(BtnStepA);
            Name = "FrmNextStep";
            StartPosition = FormStartPosition.CenterParent;
            Text = "فرم گام بعدی";
            ResumeLayout(false);
        }

        #endregion

        private Button BtnNextStep;
        private Button BtnStepA;
        private Button BtnStepB;
        private Button BtnStepC;
        private Button button2;
        private Button BtnStepD;
    }
}