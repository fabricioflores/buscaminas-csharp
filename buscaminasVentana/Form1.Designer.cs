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
            this.rb_easy = new System.Windows.Forms.RadioButton();
            this.rb_hard = new System.Windows.Forms.RadioButton();
            this.btn_start = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lyt_container
            // 
            this.lyt_container.ColumnCount = 8;
            this.lyt_container.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.lyt_container.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.lyt_container.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.lyt_container.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.lyt_container.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.lyt_container.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.lyt_container.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.lyt_container.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.lyt_container.Location = new System.Drawing.Point(12, 79);
            this.lyt_container.Name = "lyt_container";
            this.lyt_container.RowCount = 8;
            this.lyt_container.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.lyt_container.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.lyt_container.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.lyt_container.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.lyt_container.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.lyt_container.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.lyt_container.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.lyt_container.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.lyt_container.Size = new System.Drawing.Size(291, 321);
            this.lyt_container.TabIndex = 0;
            // 
            // rb_easy
            // 
            this.rb_easy.AutoSize = true;
            this.rb_easy.Location = new System.Drawing.Point(23, 13);
            this.rb_easy.Name = "rb_easy";
            this.rb_easy.Size = new System.Drawing.Size(47, 17);
            this.rb_easy.TabIndex = 1;
            this.rb_easy.TabStop = true;
            this.rb_easy.Text = "Fácil";
            this.rb_easy.UseVisualStyleBackColor = true;
            this.rb_easy.CheckedChanged += new System.EventHandler(this.rb_easy_CheckedChanged);
            // 
            // rb_hard
            // 
            this.rb_hard.AutoSize = true;
            this.rb_hard.Location = new System.Drawing.Point(23, 47);
            this.rb_hard.Name = "rb_hard";
            this.rb_hard.Size = new System.Drawing.Size(52, 17);
            this.rb_hard.TabIndex = 2;
            this.rb_hard.TabStop = true;
            this.rb_hard.Text = "Difícil";
            this.rb_hard.UseVisualStyleBackColor = true;
            this.rb_hard.CheckedChanged += new System.EventHandler(this.rb_hard_CheckedChanged);
            // 
            // btn_start
            // 
            this.btn_start.Enabled = false;
            this.btn_start.Location = new System.Drawing.Point(212, 27);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(75, 23);
            this.btn_start.TabIndex = 3;
            this.btn_start.Text = "Empezar";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 408);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.rb_hard);
            this.Controls.Add(this.rb_easy);
            this.Controls.Add(this.lyt_container);
            this.Name = "Form1";
            this.Text = "Buscaminas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel lyt_container;
        private System.Windows.Forms.RadioButton rb_easy;
        private System.Windows.Forms.RadioButton rb_hard;
        private System.Windows.Forms.Button btn_start;
    }
}

