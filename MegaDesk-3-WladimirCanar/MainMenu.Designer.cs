namespace MegaDesk_3_WladimirCanar
{
    partial class MainMenu
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
            this.components = new System.ComponentModel.Container();
            this.BtnAddQuote = new System.Windows.Forms.Button();
            this.BtnViewQuote = new System.Windows.Forms.Button();
            this.BtnSearchQuote = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // BtnAddQuote
            // 
            this.BtnAddQuote.Location = new System.Drawing.Point(211, 78);
            this.BtnAddQuote.Name = "BtnAddQuote";
            this.BtnAddQuote.Size = new System.Drawing.Size(358, 86);
            this.BtnAddQuote.TabIndex = 0;
            this.BtnAddQuote.Text = "ADD A NEW QUOTE";
            this.BtnAddQuote.UseVisualStyleBackColor = true;
            this.BtnAddQuote.Click += new System.EventHandler(this.BtnAddQuote_Click);
            // 
            // BtnViewQuote
            // 
            this.BtnViewQuote.Location = new System.Drawing.Point(211, 170);
            this.BtnViewQuote.Name = "BtnViewQuote";
            this.BtnViewQuote.Size = new System.Drawing.Size(358, 84);
            this.BtnViewQuote.TabIndex = 1;
            this.BtnViewQuote.Text = "VIEW QUOTES";
            this.BtnViewQuote.UseVisualStyleBackColor = true;
            this.BtnViewQuote.Click += new System.EventHandler(this.BtnViewQuote_Click);
            // 
            // BtnSearchQuote
            // 
            this.BtnSearchQuote.Location = new System.Drawing.Point(211, 260);
            this.BtnSearchQuote.Name = "BtnSearchQuote";
            this.BtnSearchQuote.Size = new System.Drawing.Size(358, 82);
            this.BtnSearchQuote.TabIndex = 2;
            this.BtnSearchQuote.Text = "SEARCH QUOTES";
            this.BtnSearchQuote.UseVisualStyleBackColor = true;
            this.BtnSearchQuote.Click += new System.EventHandler(this.BtnSearchQuote_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(211, 348);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(358, 85);
            this.BtnExit.TabIndex = 3;
            this.BtnExit.Text = "EXIT";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(262, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "QUOTE YOUR DESK";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // imageList2
            // 
            this.imageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList2.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnSearchQuote);
            this.Controls.Add(this.BtnViewQuote);
            this.Controls.Add(this.BtnAddQuote);
            this.Name = "MainMenu";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnAddQuote;
        private System.Windows.Forms.Button BtnViewQuote;
        private System.Windows.Forms.Button BtnSearchQuote;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList imageList2;
    }
}

