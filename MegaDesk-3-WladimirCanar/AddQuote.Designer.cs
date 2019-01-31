namespace MegaDesk_3_WladimirCanar
{
    partial class AddQuote
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
            this.BtnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.RichTextBox();
            this.textBoxSizeDeskWidth = new System.Windows.Forms.RichTextBox();
            this.textBoxNumberDrawers = new System.Windows.Forms.RichTextBox();
            this.comboSurfaceMaterials = new System.Windows.Forms.ComboBox();
            this.comboRushOrder = new System.Windows.Forms.ComboBox();
            this.deskBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxSizeDeskDepth = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.deskBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(211, 338);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(358, 85);
            this.BtnExit.TabIndex = 4;
            this.BtnExit.Text = "EXIT";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(206, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(206, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Size of desk:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(206, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Number of drawers:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(206, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Surface material:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(206, 280);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Rush order:";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(394, 54);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(175, 23);
            this.textBoxName.TabIndex = 10;
            this.textBoxName.Text = "";
            // 
            // textBoxSizeDeskWidth
            // 
            this.textBoxSizeDeskWidth.Location = new System.Drawing.Point(435, 130);
            this.textBoxSizeDeskWidth.Name = "textBoxSizeDeskWidth";
            this.textBoxSizeDeskWidth.Size = new System.Drawing.Size(134, 23);
            this.textBoxSizeDeskWidth.TabIndex = 11;
            this.textBoxSizeDeskWidth.Text = "";
            this.textBoxSizeDeskWidth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSizeDesk_KeyPress);
            // 
            // textBoxNumberDrawers
            // 
            this.textBoxNumberDrawers.Location = new System.Drawing.Point(435, 205);
            this.textBoxNumberDrawers.Name = "textBoxNumberDrawers";
            this.textBoxNumberDrawers.Size = new System.Drawing.Size(134, 23);
            this.textBoxNumberDrawers.TabIndex = 12;
            this.textBoxNumberDrawers.Text = "";
            // 
            // comboSurfaceMaterials
            // 
            this.comboSurfaceMaterials.FormattingEnabled = true;
            this.comboSurfaceMaterials.Location = new System.Drawing.Point(435, 242);
            this.comboSurfaceMaterials.Name = "comboSurfaceMaterials";
            this.comboSurfaceMaterials.Size = new System.Drawing.Size(134, 21);
            this.comboSurfaceMaterials.TabIndex = 13;
            // 
            // comboRushOrder
            // 
            this.comboRushOrder.FormattingEnabled = true;
            this.comboRushOrder.Location = new System.Drawing.Point(435, 280);
            this.comboRushOrder.Name = "comboRushOrder";
            this.comboRushOrder.Size = new System.Drawing.Size(134, 21);
            this.comboRushOrder.TabIndex = 14;
            // 
            // deskBindingSource
            // 
            this.deskBindingSource.DataSource = typeof(MegaDesk_3_WladimirCanar.Desk);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(240, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 25);
            this.label6.TabIndex = 15;
            this.label6.Text = "Width:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // textBoxSizeDeskDepth
            // 
            this.textBoxSizeDeskDepth.Location = new System.Drawing.Point(435, 159);
            this.textBoxSizeDeskDepth.Name = "textBoxSizeDeskDepth";
            this.textBoxSizeDeskDepth.Size = new System.Drawing.Size(134, 23);
            this.textBoxSizeDeskDepth.TabIndex = 16;
            this.textBoxSizeDeskDepth.Text = "";
            this.textBoxSizeDeskDepth.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxSizeDeskDepth_Validating);
            this.textBoxSizeDeskDepth.Validated += new System.EventHandler(this.textBoxSizeDeskDepth_Validated);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(240, 159);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 25);
            this.label7.TabIndex = 17;
            this.label7.Text = "Depth:";
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxSizeDeskDepth);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboRushOrder);
            this.Controls.Add(this.comboSurfaceMaterials);
            this.Controls.Add(this.textBoxNumberDrawers);
            this.Controls.Add(this.textBoxSizeDeskWidth);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnExit);
            this.Name = "AddQuote";
            this.Text = "AddQuote";
            ((System.ComponentModel.ISupportInitialize)(this.deskBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox textBoxName;
        private System.Windows.Forms.RichTextBox textBoxSizeDeskWidth;
        private System.Windows.Forms.RichTextBox textBoxNumberDrawers;
        private System.Windows.Forms.ComboBox comboSurfaceMaterials;
        private System.Windows.Forms.ComboBox comboRushOrder;
        private System.Windows.Forms.BindingSource deskBindingSource;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox textBoxSizeDeskDepth;
        private System.Windows.Forms.Label label7;
    }
}