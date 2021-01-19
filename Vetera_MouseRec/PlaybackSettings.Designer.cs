
namespace Vetera_MouseRec
{
    partial class PlaybackSettings
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
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.pixelVar_max = new System.Windows.Forms.RichTextBox();
            this.pixelVar_min = new System.Windows.Forms.RichTextBox();
            this.timeVar_max = new System.Windows.Forms.RichTextBox();
            this.customTextBox1 = new Vetera_MouseRec.CustomTextBox();
            this.timeVar_min = new System.Windows.Forms.RichTextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.customTextBox2 = new Vetera_MouseRec.CustomTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.playbackSettings_button_save = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolTipMessage = new System.Windows.Forms.ToolTip(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.comboBox_PlaybackMode = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.randomNumber = new System.Windows.Forms.RichTextBox();
            this.customTextBox3 = new Vetera_MouseRec.CustomTextBox();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customTextBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customTextBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customTextBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel3.Controls.Add(this.pixelVar_max, 2, 2);
            this.tableLayoutPanel3.Controls.Add(this.pixelVar_min, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.timeVar_max, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.customTextBox1, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.timeVar_min, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.richTextBox1, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.customTextBox2, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.richTextBox2, 2, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(20, 60);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(814, 123);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // pixelVar_max
            // 
            this.pixelVar_max.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pixelVar_max.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pixelVar_max.Location = new System.Drawing.Point(572, 76);
            this.pixelVar_max.Name = "pixelVar_max";
            this.pixelVar_max.Size = new System.Drawing.Size(239, 44);
            this.pixelVar_max.TabIndex = 3;
            this.pixelVar_max.Text = "";
            this.pixelVar_max.TextChanged += new System.EventHandler(this.pixelVar_max_TextChanged);
            this.pixelVar_max.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pixelVar_max_KeyPress);
            this.pixelVar_max.Leave += new System.EventHandler(this.pixelVar_max_Leave);
            // 
            // pixelVar_min
            // 
            this.pixelVar_min.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pixelVar_min.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pixelVar_min.Location = new System.Drawing.Point(328, 76);
            this.pixelVar_min.Name = "pixelVar_min";
            this.pixelVar_min.Size = new System.Drawing.Size(238, 44);
            this.pixelVar_min.TabIndex = 2;
            this.pixelVar_min.Text = "";
            this.pixelVar_min.TextChanged += new System.EventHandler(this.pixelVar_min_TextChanged);
            this.pixelVar_min.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pixelVar_min_KeyPress);
            this.pixelVar_min.Leave += new System.EventHandler(this.pixelVar_min_Leave);
            // 
            // timeVar_max
            // 
            this.timeVar_max.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.timeVar_max.Dock = System.Windows.Forms.DockStyle.Fill;
            this.timeVar_max.Location = new System.Drawing.Point(572, 27);
            this.timeVar_max.Name = "timeVar_max";
            this.timeVar_max.Size = new System.Drawing.Size(239, 43);
            this.timeVar_max.TabIndex = 1;
            this.timeVar_max.Text = "";
            this.timeVar_max.TextChanged += new System.EventHandler(this.timeVar_max_TextChanged);
            this.timeVar_max.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.timeVar_max_KeyPress);
            this.timeVar_max.Leave += new System.EventHandler(this.timeVar_max_Leave);
            // 
            // customTextBox1
            // 
            this.customTextBox1.Alignment = System.Drawing.StringAlignment.Center;
            this.customTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customTextBox1.font = new System.Drawing.Font("Arial", 12F);
            this.customTextBox1.LineAlignment = System.Drawing.StringAlignment.Center;
            this.customTextBox1.Location = new System.Drawing.Point(3, 76);
            this.customTextBox1.Name = "customTextBox1";
            this.customTextBox1.Size = new System.Drawing.Size(319, 44);
            this.customTextBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.customTextBox1.TabIndex = 1;
            this.customTextBox1.TabStop = false;
            this.customTextBox1.Text_String = "Pixel Variation (in px)";
            this.customTextBox1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            // 
            // timeVar_min
            // 
            this.timeVar_min.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.timeVar_min.Dock = System.Windows.Forms.DockStyle.Fill;
            this.timeVar_min.Location = new System.Drawing.Point(328, 27);
            this.timeVar_min.Name = "timeVar_min";
            this.timeVar_min.Size = new System.Drawing.Size(238, 43);
            this.timeVar_min.TabIndex = 0;
            this.timeVar_min.Text = "";
            this.timeVar_min.TextChanged += new System.EventHandler(this.timeVar_min_TextChanged);
            this.timeVar_min.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.timeVar_min_KeyPress);
            this.timeVar_min.Leave += new System.EventHandler(this.timeVar_min_Leave);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(328, 3);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox1.Size = new System.Drawing.Size(238, 18);
            this.richTextBox1.TabIndex = 100;
            this.richTextBox1.TabStop = false;
            this.richTextBox1.Text = "MIN";
            // 
            // customTextBox2
            // 
            this.customTextBox2.Alignment = System.Drawing.StringAlignment.Center;
            this.customTextBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customTextBox2.font = new System.Drawing.Font("Arial", 12F);
            this.customTextBox2.LineAlignment = System.Drawing.StringAlignment.Center;
            this.customTextBox2.Location = new System.Drawing.Point(3, 27);
            this.customTextBox2.Name = "customTextBox2";
            this.customTextBox2.Size = new System.Drawing.Size(319, 43);
            this.customTextBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.customTextBox2.TabIndex = 1;
            this.customTextBox2.TabStop = false;
            this.customTextBox2.Text_String = "Time Variation (in ms)";
            this.customTextBox2.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            // 
            // richTextBox2
            // 
            this.richTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox2.Location = new System.Drawing.Point(572, 3);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox2.Size = new System.Drawing.Size(239, 18);
            this.richTextBox2.TabIndex = 101;
            this.richTextBox2.TabStop = false;
            this.richTextBox2.Text = "MAX";
            // 
            // playbackSettings_button_save
            // 
            this.playbackSettings_button_save.Dock = System.Windows.Forms.DockStyle.Right;
            this.playbackSettings_button_save.FlatAppearance.BorderSize = 0;
            this.playbackSettings_button_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playbackSettings_button_save.Location = new System.Drawing.Point(634, 0);
            this.playbackSettings_button_save.Name = "playbackSettings_button_save";
            this.playbackSettings_button_save.Size = new System.Drawing.Size(180, 94);
            this.playbackSettings_button_save.TabIndex = 0;
            this.playbackSettings_button_save.Text = "Save";
            this.playbackSettings_button_save.UseVisualStyleBackColor = true;
            this.playbackSettings_button_save.Click += new System.EventHandler(this.playbackSettings_button_save_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.playbackSettings_button_save);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(20, 331);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(814, 94);
            this.panel1.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.comboBox_PlaybackMode, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(20, 183);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(814, 73);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // comboBox_PlaybackMode
            // 
            this.comboBox_PlaybackMode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox_PlaybackMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_PlaybackMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_PlaybackMode.FormattingEnabled = true;
            this.comboBox_PlaybackMode.Items.AddRange(new object[] {
            "In order",
            "Random (Only random order)",
            "Random (Totlay random)"});
            this.comboBox_PlaybackMode.Location = new System.Drawing.Point(3, 3);
            this.comboBox_PlaybackMode.Name = "comboBox_PlaybackMode";
            this.comboBox_PlaybackMode.Size = new System.Drawing.Size(808, 21);
            this.comboBox_PlaybackMode.TabIndex = 0;
            this.comboBox_PlaybackMode.SelectedIndexChanged += new System.EventHandler(this.comboBox_PlaybackMode_SelectedIndexChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel2.Controls.Add(this.randomNumber, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.customTextBox3, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 28);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(808, 42);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // randomNumber
            // 
            this.randomNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.randomNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.randomNumber.Location = new System.Drawing.Point(326, 3);
            this.randomNumber.Name = "randomNumber";
            this.randomNumber.Size = new System.Drawing.Size(479, 36);
            this.randomNumber.TabIndex = 3;
            this.randomNumber.Text = "";
            this.randomNumber.TextChanged += new System.EventHandler(this.randomNumber_TextChanged);
            this.randomNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.randomNumber_KeyPress);
            this.randomNumber.Leave += new System.EventHandler(this.randomNumber_Leave);
            // 
            // customTextBox3
            // 
            this.customTextBox3.Alignment = System.Drawing.StringAlignment.Center;
            this.customTextBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customTextBox3.font = new System.Drawing.Font("Arial", 12F);
            this.customTextBox3.LineAlignment = System.Drawing.StringAlignment.Center;
            this.customTextBox3.Location = new System.Drawing.Point(3, 3);
            this.customTextBox3.Name = "customTextBox3";
            this.customTextBox3.Size = new System.Drawing.Size(317, 36);
            this.customTextBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.customTextBox3.TabIndex = 2;
            this.customTextBox3.TabStop = false;
            this.customTextBox3.Text_String = "Pick X Items";
            this.customTextBox3.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            // 
            // PlaybackSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 445);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Name = "PlaybackSettings";
            this.Text = "Settings...";
            this.Load += new System.EventHandler(this.PlaybackSettings_Load);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customTextBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customTextBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customTextBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RichTextBox pixelVar_min;
        private CustomTextBox customTextBox1;
        private System.Windows.Forms.RichTextBox pixelVar_max;
        private System.Windows.Forms.RichTextBox timeVar_min;
        private CustomTextBox customTextBox2;
        private System.Windows.Forms.RichTextBox timeVar_max;
        private System.Windows.Forms.Button playbackSettings_button_save;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolTip toolTipMessage;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox comboBox_PlaybackMode;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.RichTextBox randomNumber;
        private CustomTextBox customTextBox3;
    }
}