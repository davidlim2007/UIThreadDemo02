namespace UIThreadDemo02
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
            this.btnCreateThread = new System.Windows.Forms.Button();
            this.btnCreateThreadWithParameter = new System.Windows.Forms.Button();
            this.btnCreateThreadAnonymousEntryPoint = new System.Windows.Forms.Button();
            this.btnThreadAbort = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCreateThread
            // 
            this.btnCreateThread.Location = new System.Drawing.Point(26, 188);
            this.btnCreateThread.Name = "btnCreateThread";
            this.btnCreateThread.Size = new System.Drawing.Size(348, 30);
            this.btnCreateThread.TabIndex = 0;
            this.btnCreateThread.Text = "Create Thread";
            this.btnCreateThread.UseVisualStyleBackColor = true;
            this.btnCreateThread.Click += new System.EventHandler(this.btnCreateThread_Click);
            // 
            // btnCreateThreadWithParameter
            // 
            this.btnCreateThreadWithParameter.Location = new System.Drawing.Point(26, 226);
            this.btnCreateThreadWithParameter.Name = "btnCreateThreadWithParameter";
            this.btnCreateThreadWithParameter.Size = new System.Drawing.Size(348, 30);
            this.btnCreateThreadWithParameter.TabIndex = 1;
            this.btnCreateThreadWithParameter.Text = "Create Thread with Parameter";
            this.btnCreateThreadWithParameter.UseVisualStyleBackColor = true;
            this.btnCreateThreadWithParameter.Click += new System.EventHandler(this.btnCreateThreadWithParameter_Click);
            // 
            // btnCreateThreadAnonymousEntryPoint
            // 
            this.btnCreateThreadAnonymousEntryPoint.Location = new System.Drawing.Point(26, 265);
            this.btnCreateThreadAnonymousEntryPoint.Name = "btnCreateThreadAnonymousEntryPoint";
            this.btnCreateThreadAnonymousEntryPoint.Size = new System.Drawing.Size(348, 30);
            this.btnCreateThreadAnonymousEntryPoint.TabIndex = 2;
            this.btnCreateThreadAnonymousEntryPoint.Text = "Create Thread with Anonymous Method";
            this.btnCreateThreadAnonymousEntryPoint.UseVisualStyleBackColor = true;
            this.btnCreateThreadAnonymousEntryPoint.Click += new System.EventHandler(this.btnCreateThreadAnonymousEntryPoint_Click);
            // 
            // btnThreadAbort
            // 
            this.btnThreadAbort.Location = new System.Drawing.Point(26, 306);
            this.btnThreadAbort.Name = "btnThreadAbort";
            this.btnThreadAbort.Size = new System.Drawing.Size(348, 30);
            this.btnThreadAbort.TabIndex = 3;
            this.btnThreadAbort.Text = "Thread Abortion";
            this.btnThreadAbort.UseVisualStyleBackColor = true;
            this.btnThreadAbort.Click += new System.EventHandler(this.btnThreadAbort_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 392);
            this.Controls.Add(this.btnThreadAbort);
            this.Controls.Add(this.btnCreateThreadAnonymousEntryPoint);
            this.Controls.Add(this.btnCreateThreadWithParameter);
            this.Controls.Add(this.btnCreateThread);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCreateThread;
        private System.Windows.Forms.Button btnCreateThreadWithParameter;
        private System.Windows.Forms.Button btnCreateThreadAnonymousEntryPoint;
        private System.Windows.Forms.Button btnThreadAbort;
    }
}

