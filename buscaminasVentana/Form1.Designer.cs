namespace buscaminasVentana
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
            this.lyt_container = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();
            // 
            // lyt_container
            // 
            this.lyt_container.ColumnCount = 5;
            this.lyt_container.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.lyt_container.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.lyt_container.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.lyt_container.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.lyt_container.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.lyt_container.Location = new System.Drawing.Point(12, 12);
            this.lyt_container.Name = "lyt_container";
            this.lyt_container.RowCount = 5;
            this.lyt_container.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.lyt_container.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.lyt_container.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.lyt_container.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.lyt_container.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.lyt_container.Size = new System.Drawing.Size(474, 336);
            this.lyt_container.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 401);
            this.Controls.Add(this.lyt_container);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel lyt_container;
    }
}

