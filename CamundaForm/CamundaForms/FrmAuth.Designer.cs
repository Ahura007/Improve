namespace CamundaForm.CamundaForms
{
    partial class FrmAuth
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
            BtnAuthPost = new Button();
            BtnGetToken = new Button();
            SuspendLayout();
            // 
            // BtnAuthPost
            // 
            BtnAuthPost.Dock = DockStyle.Top;
            BtnAuthPost.Location = new Point(0, 0);
            BtnAuthPost.Name = "BtnAuthPost";
            BtnAuthPost.Size = new Size(248, 78);
            BtnAuthPost.TabIndex = 2;
            BtnAuthPost.Text = "توکن جدید";
            BtnAuthPost.UseVisualStyleBackColor = true;
            BtnAuthPost.Click += BtnAuthPost_Click;
            // 
            // BtnGetToken
            // 
            BtnGetToken.Dock = DockStyle.Bottom;
            BtnGetToken.Location = new Point(0, 77);
            BtnGetToken.Name = "BtnGetToken";
            BtnGetToken.Size = new Size(248, 82);
            BtnGetToken.TabIndex = 3;
            BtnGetToken.Text = "گرفتن توکن قبلی";
            BtnGetToken.UseVisualStyleBackColor = true;
            BtnGetToken.Click += BtnGetToken_Click;
            // 
            // FrmAuth
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(248, 159);
            Controls.Add(BtnGetToken);
            Controls.Add(BtnAuthPost);
            Name = "FrmAuth";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FrmAuth";
            ResumeLayout(false);
        }

        #endregion

        private Button BtnAuthPost;
        private Button BtnGetToken;
    }
}