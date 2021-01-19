namespace Vetera_MouseRec
{
    partial class Play
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ProgressBar = new Vetera_MouseRec.CustomProgressBar();
            this.play_text_name = new Vetera_MouseRec.CustomTextBox();
            this.update = new System.Windows.Forms.Timer(this.components);
            this.play_text_title = new Vetera_MouseRec.CustomTextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProgressBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.play_text_name)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.play_text_title)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.5F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.play_text_name, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.play_text_title, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(807, 126);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ProgressBar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(305, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(499, 57);
            this.panel1.TabIndex = 2;
            // 
            // ProgressBar
            // 
            this.ProgressBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProgressBar.Location = new System.Drawing.Point(0, 0);
            this.ProgressBar.MaxValue = 100;
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.ProgressBackgrund = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.ProgressBar.ProgressForeground = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(65)))), ((int)(((byte)(153)))));
            this.ProgressBar.Size = new System.Drawing.Size(499, 57);
            this.ProgressBar.TabIndex = 3;
            this.ProgressBar.TabStop = false;
            this.ProgressBar.text = "Hier Text";
            this.ProgressBar.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.ProgressBar.TextSize = 16;
            this.ProgressBar.Value = 0;
            // 
            // play_text_name
            // 
            this.play_text_name.Alignment = System.Drawing.StringAlignment.Center;
            this.play_text_name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.play_text_name.font = new System.Drawing.Font("Arial", 12F);
            this.play_text_name.LineAlignment = System.Drawing.StringAlignment.Center;
            this.play_text_name.Location = new System.Drawing.Point(3, 66);
            this.play_text_name.Name = "play_text_name";
            this.play_text_name.Size = new System.Drawing.Size(296, 57);
            this.play_text_name.TabIndex = 3;
            this.play_text_name.TabStop = false;
            this.play_text_name.Text_String = "null";
            this.play_text_name.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            // 
            // update
            // 
            this.update.Interval = 5;
            this.update.Tick += new System.EventHandler(this.update_Tick);
            // 
            // play_text_title
            // 
            this.play_text_title.Alignment = System.Drawing.StringAlignment.Center;
            this.play_text_title.Dock = System.Windows.Forms.DockStyle.Fill;
            this.play_text_title.font = new System.Drawing.Font("Arial", 12F);
            this.play_text_title.LineAlignment = System.Drawing.StringAlignment.Center;
            this.play_text_title.Location = new System.Drawing.Point(305, 3);
            this.play_text_title.Name = "play_text_title";
            this.play_text_title.Size = new System.Drawing.Size(499, 57);
            this.play_text_title.TabIndex = 4;
            this.play_text_title.TabStop = false;
            this.play_text_title.Text_String = "null";
            this.play_text_title.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            // 
            // Play
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.ClientSize = new System.Drawing.Size(807, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Text = "Play";
            this.Load += new System.EventHandler(this.Play_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProgressBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.play_text_name)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.play_text_title)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Timer update;
        private System.Windows.Forms.Panel panel1;
        private CustomProgressBar ProgressBar;
        private CustomTextBox play_text_name;
        private CustomTextBox play_text_title;
    }
}