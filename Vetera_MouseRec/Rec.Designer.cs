namespace Vetera_MouseRec
{
    partial class Rec
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
            this.timer_spinner = new System.Windows.Forms.Timer(this.components);
            this.rec_spinner = new MetroFramework.Controls.MetroProgressSpinner();
            this.rec_text_count = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // timer_spinner
            // 
            this.timer_spinner.Interval = 50;
            this.timer_spinner.Tick += new System.EventHandler(this.timer_spinner_Tick);
            // 
            // rec_spinner
            // 
            this.rec_spinner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.rec_spinner.CustomBackground = true;
            this.rec_spinner.Location = new System.Drawing.Point(435, 103);
            this.rec_spinner.Maximum = 100;
            this.rec_spinner.MaximumSize = new System.Drawing.Size(200, 200);
            this.rec_spinner.MinimumSize = new System.Drawing.Size(200, 200);
            this.rec_spinner.Name = "rec_spinner";
            this.rec_spinner.Size = new System.Drawing.Size(200, 200);
            this.rec_spinner.Speed = 0.5F;
            this.rec_spinner.Style = MetroFramework.MetroColorStyle.Red;
            this.rec_spinner.TabIndex = 0;
            this.rec_spinner.TabStop = false;
            this.rec_spinner.Theme = MetroFramework.MetroThemeStyle.Light;
            this.rec_spinner.UseCustomBackColor = true;
            this.rec_spinner.UseCustomForeColor = true;
            this.rec_spinner.UseSelectable = true;
            this.rec_spinner.Value = 100;
            // 
            // rec_text_count
            // 
            this.rec_text_count.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.rec_text_count.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rec_text_count.CausesValidation = false;
            this.rec_text_count.Cursor = System.Windows.Forms.Cursors.Default;
            this.rec_text_count.Enabled = false;
            this.rec_text_count.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rec_text_count.ForeColor = System.Drawing.Color.White;
            this.rec_text_count.Location = new System.Drawing.Point(486, 191);
            this.rec_text_count.Name = "rec_text_count";
            this.rec_text_count.ReadOnly = true;
            this.rec_text_count.Size = new System.Drawing.Size(99, 31);
            this.rec_text_count.TabIndex = 1;
            this.rec_text_count.Text = "0";
            this.rec_text_count.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Rec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.ClientSize = new System.Drawing.Size(1003, 471);
            this.Controls.Add(this.rec_text_count);
            this.Controls.Add(this.rec_spinner);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Rec";
            this.Text = "Rec";
            this.Load += new System.EventHandler(this.Rec_Load);
            this.SizeChanged += new System.EventHandler(this.Rec_SizeChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer_spinner;
        private MetroFramework.Controls.MetroProgressSpinner rec_spinner;
        private System.Windows.Forms.TextBox rec_text_count;
    }
}