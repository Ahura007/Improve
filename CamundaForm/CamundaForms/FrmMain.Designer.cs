namespace CamundaForm.CamundaForms
{
    partial class FrmMain
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
            BtnGetAllWorkFlow = new Button();
            BtnAuth = new Button();
            BtnStartNewInstance = new Button();
            BtnNextStep = new Button();
            listBox1 = new ListBox();
            BtnDelete = new Button();
            button1 = new Button();
            BtnEvaluated = new Button();
            SuspendLayout();
            // 
            // BtnGetAllWorkFlow
            // 
            BtnGetAllWorkFlow.Location = new Point(12, 159);
            BtnGetAllWorkFlow.Name = "BtnGetAllWorkFlow";
            BtnGetAllWorkFlow.Size = new Size(148, 34);
            BtnGetAllWorkFlow.TabIndex = 0;
            BtnGetAllWorkFlow.Text = "واکشی تمام ورک فلوهای اصلی";
            BtnGetAllWorkFlow.UseVisualStyleBackColor = true;
            BtnGetAllWorkFlow.Click += BtnGetAllWorkFlow_Click;
            // 
            // BtnAuth
            // 
            BtnAuth.Location = new Point(12, 199);
            BtnAuth.Name = "BtnAuth";
            BtnAuth.Size = new Size(148, 34);
            BtnAuth.TabIndex = 1;
            BtnAuth.Text = "احراز هویت";
            BtnAuth.UseVisualStyleBackColor = true;
            BtnAuth.Click += BtnAuth_Click;
            // 
            // BtnStartNewInstance
            // 
            BtnStartNewInstance.Location = new Point(784, 239);
            BtnStartNewInstance.Name = "BtnStartNewInstance";
            BtnStartNewInstance.Size = new Size(134, 34);
            BtnStartNewInstance.TabIndex = 2;
            BtnStartNewInstance.Text = "شروع گردش کار";
            BtnStartNewInstance.UseVisualStyleBackColor = true;
            BtnStartNewInstance.Click += BtnStartNewInstance_Click;
            // 
            // BtnNextStep
            // 
            BtnNextStep.Location = new Point(784, 279);
            BtnNextStep.Name = "BtnNextStep";
            BtnNextStep.Size = new Size(134, 34);
            BtnNextStep.TabIndex = 3;
            BtnNextStep.Text = "گام بعدی";
            BtnNextStep.UseVisualStyleBackColor = true;
            BtnNextStep.Click += BtnNextStep_Click;
            // 
            // listBox1
            // 
            listBox1.Dock = DockStyle.Top;
            listBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 21;
            listBox1.Location = new Point(0, 0);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(918, 130);
            listBox1.TabIndex = 4;
            listBox1.MouseClick += listBox1_MouseClick;
            listBox1.MouseDoubleClick += listBox1_MouseDoubleClick;
            // 
            // BtnDelete
            // 
            BtnDelete.Location = new Point(575, 199);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(134, 34);
            BtnDelete.TabIndex = 6;
            BtnDelete.Text = "حذف پردازش";
            BtnDelete.UseVisualStyleBackColor = true;
            BtnDelete.Click += BtnDelete_Click;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Top;
            button1.Location = new Point(0, 130);
            button1.Name = "button1";
            button1.Size = new Size(918, 40);
            button1.TabIndex = 7;
            button1.Text = "Refresh";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // BtnEvaluated
            // 
            BtnEvaluated.Location = new Point(784, 199);
            BtnEvaluated.Name = "BtnEvaluated";
            BtnEvaluated.Size = new Size(134, 34);
            BtnEvaluated.TabIndex = 8;
            BtnEvaluated.Text = "شروع گردش کار";
            BtnEvaluated.UseVisualStyleBackColor = true;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(918, 450);
            Controls.Add(BtnEvaluated);
            Controls.Add(button1);
            Controls.Add(BtnDelete);
            Controls.Add(listBox1);
            Controls.Add(BtnNextStep);
            Controls.Add(BtnStartNewInstance);
            Controls.Add(BtnAuth);
            Controls.Add(BtnGetAllWorkFlow);
            Name = "FrmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main";
            ResumeLayout(false);
        }

        #endregion

        private Button BtnGetAllWorkFlow;
        private Button BtnAuth;
        private Button BtnStartNewInstance;
        private Button BtnNextStep;
        private ListBox listBox1;
        private Button BtnDelete;
        private Button button1;
        private Button BtnEvaluated;
    }
}