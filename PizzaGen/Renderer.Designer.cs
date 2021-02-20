namespace PizzaGen
{
    partial class Renderer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Renderer));
            this.pbViewPort = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtVal = new System.Windows.Forms.TextBox();
            this.btnFont = new System.Windows.Forms.Button();
            this.FDSelect = new System.Windows.Forms.FontDialog();
            this.btnExport = new System.Windows.Forms.Button();
            this.SFDSave = new System.Windows.Forms.SaveFileDialog();
            this.lblFontStyle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbViewPort)).BeginInit();
            this.SuspendLayout();
            // 
            // pbViewPort
            // 
            this.pbViewPort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbViewPort.Location = new System.Drawing.Point(12, 12);
            this.pbViewPort.Name = "pbViewPort";
            this.pbViewPort.Size = new System.Drawing.Size(486, 426);
            this.pbViewPort.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbViewPort.TabIndex = 0;
            this.pbViewPort.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(505, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Text:";
            // 
            // txtVal
            // 
            this.txtVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVal.Location = new System.Drawing.Point(509, 36);
            this.txtVal.Name = "txtVal";
            this.txtVal.Size = new System.Drawing.Size(284, 26);
            this.txtVal.TabIndex = 2;
            this.txtVal.TextChanged += new System.EventHandler(this.txtVal_TextChanged);
            // 
            // btnFont
            // 
            this.btnFont.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFont.Location = new System.Drawing.Point(509, 68);
            this.btnFont.Name = "btnFont";
            this.btnFont.Size = new System.Drawing.Size(92, 34);
            this.btnFont.TabIndex = 3;
            this.btnFont.Text = "Font";
            this.btnFont.UseVisualStyleBackColor = true;
            this.btnFont.Click += new System.EventHandler(this.btnFont_Click);
            // 
            // btnExport
            // 
            this.btnExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.Location = new System.Drawing.Point(701, 408);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(92, 34);
            this.btnExport.TabIndex = 5;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // SFDSave
            // 
            this.SFDSave.Filter = "Gif Files|*.gif";
            // 
            // lblFontStyle
            // 
            this.lblFontStyle.AutoSize = true;
            this.lblFontStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFontStyle.Location = new System.Drawing.Point(607, 73);
            this.lblFontStyle.Name = "lblFontStyle";
            this.lblFontStyle.Size = new System.Drawing.Size(109, 25);
            this.lblFontStyle.TabIndex = 6;
            this.lblFontStyle.Text = "Font Style";
            // 
            // Renderer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblFontStyle);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnFont);
            this.Controls.Add(this.txtVal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbViewPort);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Renderer";
            this.Text = "PizzaGen";
            this.Load += new System.EventHandler(this.Renderer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbViewPort)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbViewPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtVal;
        private System.Windows.Forms.Button btnFont;
        private System.Windows.Forms.FontDialog FDSelect;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.SaveFileDialog SFDSave;
        private System.Windows.Forms.Label lblFontStyle;
    }
}