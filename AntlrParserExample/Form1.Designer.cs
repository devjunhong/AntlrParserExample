namespace AntlrParserExample
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
            this.formFloorPanel = new System.Windows.Forms.TableLayoutPanel();
            this.buttonFloorPanel = new System.Windows.Forms.TableLayoutPanel();
            this.parseBtn = new System.Windows.Forms.Button();
            this.editor = new System.Windows.Forms.TextBox();
            this.formFloorPanel.SuspendLayout();
            this.buttonFloorPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // formFloorPanel
            // 
            this.formFloorPanel.ColumnCount = 1;
            this.formFloorPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.formFloorPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.formFloorPanel.Controls.Add(this.buttonFloorPanel, 0, 0);
            this.formFloorPanel.Controls.Add(this.editor, 0, 1);
            this.formFloorPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formFloorPanel.Location = new System.Drawing.Point(0, 0);
            this.formFloorPanel.Name = "formFloorPanel";
            this.formFloorPanel.RowCount = 2;
            this.formFloorPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.formFloorPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.formFloorPanel.Size = new System.Drawing.Size(800, 450);
            this.formFloorPanel.TabIndex = 0;
            // 
            // buttonFloorPanel
            // 
            this.buttonFloorPanel.ColumnCount = 2;
            this.buttonFloorPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.buttonFloorPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.buttonFloorPanel.Controls.Add(this.parseBtn, 0, 0);
            this.buttonFloorPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonFloorPanel.Location = new System.Drawing.Point(0, 0);
            this.buttonFloorPanel.Margin = new System.Windows.Forms.Padding(0);
            this.buttonFloorPanel.Name = "buttonFloorPanel";
            this.buttonFloorPanel.RowCount = 1;
            this.buttonFloorPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.buttonFloorPanel.Size = new System.Drawing.Size(800, 30);
            this.buttonFloorPanel.TabIndex = 0;
            // 
            // parseBtn
            // 
            this.parseBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.parseBtn.Location = new System.Drawing.Point(3, 3);
            this.parseBtn.Name = "parseBtn";
            this.parseBtn.Size = new System.Drawing.Size(94, 24);
            this.parseBtn.TabIndex = 0;
            this.parseBtn.Text = "Parse";
            this.parseBtn.UseVisualStyleBackColor = true;
            this.parseBtn.Click += new System.EventHandler(this.parseBtn_Click);
            // 
            // editor
            // 
            this.editor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editor.Location = new System.Drawing.Point(3, 33);
            this.editor.Multiline = true;
            this.editor.Name = "editor";
            this.editor.Size = new System.Drawing.Size(794, 414);
            this.editor.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.formFloorPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.formFloorPanel.ResumeLayout(false);
            this.formFloorPanel.PerformLayout();
            this.buttonFloorPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel formFloorPanel;
        private System.Windows.Forms.TableLayoutPanel buttonFloorPanel;
        private System.Windows.Forms.Button parseBtn;
        private System.Windows.Forms.TextBox editor;
    }
}

