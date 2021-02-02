
namespace LexicalAnalyzer
{
    partial class frmMain
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
            this.btnBrowseFile = new System.Windows.Forms.Button();
            this.btnStartLexical = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCopyright = new System.Windows.Forms.LinkLabel();
            this.lstSourceView = new System.Windows.Forms.ListBox();
            this.lstLexicalOutputView = new System.Windows.Forms.ListBox();
            this.lstConsoleError = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBrowseFile
            // 
            this.btnBrowseFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowseFile.Location = new System.Drawing.Point(430, 136);
            this.btnBrowseFile.Name = "btnBrowseFile";
            this.btnBrowseFile.Size = new System.Drawing.Size(154, 54);
            this.btnBrowseFile.TabIndex = 3;
            this.btnBrowseFile.Text = "Broese File";
            this.btnBrowseFile.UseVisualStyleBackColor = true;
            this.btnBrowseFile.Click += new System.EventHandler(this.btnBrowseFile_Click);
            // 
            // btnStartLexical
            // 
            this.btnStartLexical.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartLexical.Location = new System.Drawing.Point(430, 207);
            this.btnStartLexical.Name = "btnStartLexical";
            this.btnStartLexical.Size = new System.Drawing.Size(154, 54);
            this.btnStartLexical.TabIndex = 4;
            this.btnStartLexical.Text = "Start Lexical";
            this.btnStartLexical.UseVisualStyleBackColor = true;
            this.btnStartLexical.Click += new System.EventHandler(this.btnStartLexical_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Source code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(585, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Lexical output";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 547);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "powered by";
            // 
            // lblCopyright
            // 
            this.lblCopyright.AutoSize = true;
            this.lblCopyright.Location = new System.Drawing.Point(89, 547);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(102, 17);
            this.lblCopyright.TabIndex = 10;
            this.lblCopyright.TabStop = true;
            this.lblCopyright.Text = "ahmadrezadev";
            this.lblCopyright.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblCopyright_LinkClicked);
            // 
            // lstSourceView
            // 
            this.lstSourceView.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstSourceView.FormattingEnabled = true;
            this.lstSourceView.ItemHeight = 26;
            this.lstSourceView.Location = new System.Drawing.Point(12, 32);
            this.lstSourceView.Name = "lstSourceView";
            this.lstSourceView.Size = new System.Drawing.Size(412, 342);
            this.lstSourceView.TabIndex = 11;
            // 
            // lstLexicalOutputView
            // 
            this.lstLexicalOutputView.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstLexicalOutputView.ForeColor = System.Drawing.Color.Green;
            this.lstLexicalOutputView.FormattingEnabled = true;
            this.lstLexicalOutputView.ItemHeight = 26;
            this.lstLexicalOutputView.Location = new System.Drawing.Point(590, 32);
            this.lstLexicalOutputView.Name = "lstLexicalOutputView";
            this.lstLexicalOutputView.Size = new System.Drawing.Size(412, 342);
            this.lstLexicalOutputView.TabIndex = 12;
            // 
            // lstConsoleError
            // 
            this.lstConsoleError.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstConsoleError.ForeColor = System.Drawing.Color.Red;
            this.lstConsoleError.FormattingEnabled = true;
            this.lstConsoleError.ItemHeight = 26;
            this.lstConsoleError.Location = new System.Drawing.Point(12, 410);
            this.lstConsoleError.Name = "lstConsoleError";
            this.lstConsoleError.Size = new System.Drawing.Size(990, 134);
            this.lstConsoleError.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(672, 547);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(330, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "University project of Islamic Azad University of Arak";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 382);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 25);
            this.label5.TabIndex = 15;
            this.label5.Text = "Console";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 569);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lstConsoleError);
            this.Controls.Add(this.lstLexicalOutputView);
            this.Controls.Add(this.lstSourceView);
            this.Controls.Add(this.lblCopyright);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStartLexical);
            this.Controls.Add(this.btnBrowseFile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lexical Analyzer (C / C++ Language)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBrowseFile;
        private System.Windows.Forms.Button btnStartLexical;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel lblCopyright;
        private System.Windows.Forms.ListBox lstSourceView;
        private System.Windows.Forms.ListBox lstLexicalOutputView;
        private System.Windows.Forms.ListBox lstConsoleError;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

