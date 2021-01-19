
namespace Vetera_MouseRec
{
    partial class Settings
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.text_smooth = new Vetera_MouseRec.CustomTextBox();
            this.smooth_min = new System.Windows.Forms.RichTextBox();
            this.smooth_max = new System.Windows.Forms.RichTextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.checkBox_Loop = new System.Windows.Forms.CheckBox();
            this.text_Loop_Lable = new Vetera_MouseRec.CustomTextBox();
            this.richText_LoopWaitTime = new System.Windows.Forms.RichTextBox();
            this.comboBox_Mode = new System.Windows.Forms.ComboBox();
            this.button_Save = new System.Windows.Forms.Button();
            this.toolTipMessage = new System.Windows.Forms.ToolTip(this.components);
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.richText_Pause = new System.Windows.Forms.RichTextBox();
            this.richText_Playback = new System.Windows.Forms.RichTextBox();
            this.text_Rec_Lable = new Vetera_MouseRec.CustomTextBox();
            this.text_Playback_Lable = new Vetera_MouseRec.CustomTextBox();
            this.text_Pause_Lable = new Vetera_MouseRec.CustomTextBox();
            this.richText_Rec = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.text_smooth)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.text_Loop_Lable)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.text_Rec_Lable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.text_Playback_Lable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.text_Pause_Lable)).BeginInit();
            this.tableLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.06135F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.93865F));
            this.tableLayoutPanel2.Controls.Add(this.text_smooth, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.smooth_min, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.smooth_max, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.richTextBox1, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.richTextBox2, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(821, 130);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // text_smooth
            // 
            this.text_smooth.Alignment = System.Drawing.StringAlignment.Center;
            this.text_smooth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.text_smooth.font = new System.Drawing.Font("Arial", 12F);
            this.text_smooth.LineAlignment = System.Drawing.StringAlignment.Center;
            this.text_smooth.Location = new System.Drawing.Point(3, 48);
            this.text_smooth.Name = "text_smooth";
            this.text_smooth.Size = new System.Drawing.Size(322, 79);
            this.text_smooth.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.text_smooth.TabIndex = 2;
            this.text_smooth.TabStop = false;
            this.text_smooth.Text_String = "Smooth transition(in ms)";
            this.text_smooth.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            // 
            // smooth_min
            // 
            this.smooth_min.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.smooth_min.Dock = System.Windows.Forms.DockStyle.Fill;
            this.smooth_min.Location = new System.Drawing.Point(331, 48);
            this.smooth_min.Name = "smooth_min";
            this.smooth_min.Size = new System.Drawing.Size(240, 79);
            this.smooth_min.TabIndex = 1;
            this.smooth_min.Text = "";
            this.smooth_min.TextChanged += new System.EventHandler(this.smooth_min_TextChanged);
            this.smooth_min.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.smooth_min_KeyPress);
            this.smooth_min.Leave += new System.EventHandler(this.smooth_min_Leave);
            // 
            // smooth_max
            // 
            this.smooth_max.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.smooth_max.Dock = System.Windows.Forms.DockStyle.Fill;
            this.smooth_max.Location = new System.Drawing.Point(577, 48);
            this.smooth_max.Name = "smooth_max";
            this.smooth_max.Size = new System.Drawing.Size(241, 79);
            this.smooth_max.TabIndex = 2;
            this.smooth_max.Text = "";
            this.smooth_max.TextChanged += new System.EventHandler(this.smooth_max_TextChanged);
            this.smooth_max.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.smooth_max_KeyPress);
            this.smooth_max.Leave += new System.EventHandler(this.smooth_max_Leave);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(331, 3);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(240, 39);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.TabStop = false;
            this.richTextBox1.Text = "MIN";
            // 
            // richTextBox2
            // 
            this.richTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox2.Location = new System.Drawing.Point(577, 3);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.Size = new System.Drawing.Size(241, 39);
            this.richTextBox2.TabIndex = 6;
            this.richTextBox2.TabStop = false;
            this.richTextBox2.Text = "MAX";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.Controls.Add(this.checkBox_Loop, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.text_Loop_Lable, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.richText_LoopWaitTime, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(815, 58);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // checkBox_Loop
            // 
            this.checkBox_Loop.AutoSize = true;
            this.checkBox_Loop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBox_Loop.FlatAppearance.BorderSize = 0;
            this.checkBox_Loop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox_Loop.Location = new System.Drawing.Point(655, 3);
            this.checkBox_Loop.Name = "checkBox_Loop";
            this.checkBox_Loop.Size = new System.Drawing.Size(157, 52);
            this.checkBox_Loop.TabIndex = 2;
            this.checkBox_Loop.Text = "Loop Playback";
            this.checkBox_Loop.UseVisualStyleBackColor = true;
            // 
            // text_Loop_Lable
            // 
            this.text_Loop_Lable.Alignment = System.Drawing.StringAlignment.Center;
            this.text_Loop_Lable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.text_Loop_Lable.font = new System.Drawing.Font("Arial", 12F);
            this.text_Loop_Lable.LineAlignment = System.Drawing.StringAlignment.Center;
            this.text_Loop_Lable.Location = new System.Drawing.Point(3, 3);
            this.text_Loop_Lable.Name = "text_Loop_Lable";
            this.text_Loop_Lable.Size = new System.Drawing.Size(483, 52);
            this.text_Loop_Lable.TabIndex = 6;
            this.text_Loop_Lable.TabStop = false;
            this.text_Loop_Lable.Text_String = "Loop wait time (in s)";
            this.text_Loop_Lable.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            // 
            // richText_LoopWaitTime
            // 
            this.richText_LoopWaitTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richText_LoopWaitTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richText_LoopWaitTime.Location = new System.Drawing.Point(492, 3);
            this.richText_LoopWaitTime.Name = "richText_LoopWaitTime";
            this.richText_LoopWaitTime.Size = new System.Drawing.Size(157, 52);
            this.richText_LoopWaitTime.TabIndex = 1;
            this.richText_LoopWaitTime.Text = "";
            this.richText_LoopWaitTime.TextChanged += new System.EventHandler(this.richText_LoopWaitTime_TextChanged);
            this.richText_LoopWaitTime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.richText_LoopWaitTime_KeyPress);
            this.richText_LoopWaitTime.Leave += new System.EventHandler(this.richText_LoopWaitTime_Leave);
            // 
            // comboBox_Mode
            // 
            this.comboBox_Mode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox_Mode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Mode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_Mode.FormattingEnabled = true;
            this.comboBox_Mode.Items.AddRange(new object[] {
            "Dark mode",
            "Light mode"});
            this.comboBox_Mode.Location = new System.Drawing.Point(3, 68);
            this.comboBox_Mode.Name = "comboBox_Mode";
            this.comboBox_Mode.Size = new System.Drawing.Size(815, 21);
            this.comboBox_Mode.TabIndex = 4;
            // 
            // button_Save
            // 
            this.button_Save.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button_Save.FlatAppearance.BorderSize = 0;
            this.button_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Save.Location = new System.Drawing.Point(20, 439);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(827, 30);
            this.button_Save.TabIndex = 5;
            this.button_Save.Text = "Save";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel1, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 0, 2);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(20, 30);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(827, 409);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.richText_Pause, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.richText_Playback, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.text_Rec_Lable, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.text_Playback_Lable, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.text_Pause_Lable, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.richText_Rec, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 139);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(821, 130);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // richText_Pause
            // 
            this.richText_Pause.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richText_Pause.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richText_Pause.Location = new System.Drawing.Point(549, 42);
            this.richText_Pause.Name = "richText_Pause";
            this.richText_Pause.Size = new System.Drawing.Size(269, 85);
            this.richText_Pause.TabIndex = 3;
            this.richText_Pause.Text = "";
            this.richText_Pause.KeyDown += new System.Windows.Forms.KeyEventHandler(this.richText_Pause_KeyDown);
            this.richText_Pause.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Refuse);
            // 
            // richText_Playback
            // 
            this.richText_Playback.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richText_Playback.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richText_Playback.Location = new System.Drawing.Point(276, 42);
            this.richText_Playback.Name = "richText_Playback";
            this.richText_Playback.Size = new System.Drawing.Size(267, 85);
            this.richText_Playback.TabIndex = 2;
            this.richText_Playback.Text = "";
            this.richText_Playback.KeyDown += new System.Windows.Forms.KeyEventHandler(this.richText_Playback_KeyDown);
            this.richText_Playback.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Refuse);
            // 
            // text_Rec_Lable
            // 
            this.text_Rec_Lable.Alignment = System.Drawing.StringAlignment.Center;
            this.text_Rec_Lable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.text_Rec_Lable.font = new System.Drawing.Font("Arial", 12F);
            this.text_Rec_Lable.LineAlignment = System.Drawing.StringAlignment.Center;
            this.text_Rec_Lable.Location = new System.Drawing.Point(3, 3);
            this.text_Rec_Lable.Name = "text_Rec_Lable";
            this.text_Rec_Lable.Size = new System.Drawing.Size(267, 33);
            this.text_Rec_Lable.TabIndex = 0;
            this.text_Rec_Lable.TabStop = false;
            this.text_Rec_Lable.Text_String = "Record Play/Stop Key";
            this.text_Rec_Lable.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            // 
            // text_Playback_Lable
            // 
            this.text_Playback_Lable.Alignment = System.Drawing.StringAlignment.Center;
            this.text_Playback_Lable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.text_Playback_Lable.font = new System.Drawing.Font("Arial", 12F);
            this.text_Playback_Lable.LineAlignment = System.Drawing.StringAlignment.Center;
            this.text_Playback_Lable.Location = new System.Drawing.Point(276, 3);
            this.text_Playback_Lable.Name = "text_Playback_Lable";
            this.text_Playback_Lable.Size = new System.Drawing.Size(267, 33);
            this.text_Playback_Lable.TabIndex = 1;
            this.text_Playback_Lable.TabStop = false;
            this.text_Playback_Lable.Text_String = "Playback Start/Stop Key";
            this.text_Playback_Lable.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            // 
            // text_Pause_Lable
            // 
            this.text_Pause_Lable.Alignment = System.Drawing.StringAlignment.Center;
            this.text_Pause_Lable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.text_Pause_Lable.font = new System.Drawing.Font("Arial", 12F);
            this.text_Pause_Lable.LineAlignment = System.Drawing.StringAlignment.Center;
            this.text_Pause_Lable.Location = new System.Drawing.Point(549, 3);
            this.text_Pause_Lable.Name = "text_Pause_Lable";
            this.text_Pause_Lable.Size = new System.Drawing.Size(269, 33);
            this.text_Pause_Lable.TabIndex = 2;
            this.text_Pause_Lable.TabStop = false;
            this.text_Pause_Lable.Text_String = "Playback Pause Key";
            this.text_Pause_Lable.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            // 
            // richText_Rec
            // 
            this.richText_Rec.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richText_Rec.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richText_Rec.Location = new System.Drawing.Point(3, 42);
            this.richText_Rec.Name = "richText_Rec";
            this.richText_Rec.Size = new System.Drawing.Size(267, 85);
            this.richText_Rec.TabIndex = 1;
            this.richText_Rec.Text = "";
            this.richText_Rec.KeyDown += new System.Windows.Forms.KeyEventHandler(this.richText_Rec_KeyDown);
            this.richText_Rec.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Refuse);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.comboBox_Mode, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 275);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(821, 131);
            this.tableLayoutPanel5.TabIndex = 4;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 489);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Controls.Add(this.button_Save);
            this.DisplayHeader = false;
            this.Name = "Settings";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Text = "Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Settings_FormClosing);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.text_smooth)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.text_Loop_Lable)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.text_Rec_Lable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.text_Playback_Lable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.text_Pause_Lable)).EndInit();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBox_Mode;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private CustomTextBox text_smooth;
        private System.Windows.Forms.RichTextBox smooth_min;
        private System.Windows.Forms.RichTextBox smooth_max;
        private System.Windows.Forms.ToolTip toolTipMessage;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.CheckBox checkBox_Loop;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button button_Save;
        private CustomTextBox text_Loop_Lable;
        private System.Windows.Forms.RichTextBox richText_LoopWaitTime;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RichTextBox richText_Pause;
        private System.Windows.Forms.RichTextBox richText_Playback;
        private CustomTextBox text_Rec_Lable;
        private CustomTextBox text_Playback_Lable;
        private CustomTextBox text_Pause_Lable;
        private System.Windows.Forms.RichTextBox richText_Rec;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
    }
}