namespace Vetera_MouseRec
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer_add_events = new System.Windows.Forms.Timer(this.components);
            this.timer_hotkey_options = new System.Windows.Forms.Timer(this.components);
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.metroTabControl_min = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage_Main = new MetroFramework.Controls.MetroTabPage();
            this.panal_main = new System.Windows.Forms.Panel();
            this.metroTabPage_Create = new MetroFramework.Controls.MetroTabPage();
            this.panel_create = new System.Windows.Forms.Panel();
            this.timer_rec_events = new System.Windows.Forms.Timer(this.components);
            this.timer_hotkey_press = new System.Windows.Forms.Timer(this.components);
            this.infoTextBox = new System.Windows.Forms.RichTextBox();
            this.button_option = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.metroTabControl_min.SuspendLayout();
            this.metroTabPage_Main.SuspendLayout();
            this.metroTabPage_Create.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.button_option)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer_add_events
            // 
            this.timer_add_events.Interval = 1;
            this.timer_add_events.Tick += new System.EventHandler(this.timer_add_events_Tick);
            // 
            // timer_hotkey_options
            // 
            this.timer_hotkey_options.Interval = 20;
            this.timer_hotkey_options.Tick += new System.EventHandler(this.timer_hotkey_options_Tick);
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = this;
            this.metroStyleManager1.Style = MetroFramework.MetroColorStyle.Purple;
            // 
            // metroTabControl_min
            // 
            this.metroTabControl_min.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.metroTabControl_min.Controls.Add(this.metroTabPage_Main);
            this.metroTabControl_min.Controls.Add(this.metroTabPage_Create);
            this.metroTabControl_min.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl_min.FontSize = MetroFramework.MetroTabControlSize.Tall;
            this.metroTabControl_min.ItemSize = new System.Drawing.Size(80, 50);
            this.metroTabControl_min.Location = new System.Drawing.Point(20, 30);
            this.metroTabControl_min.Name = "metroTabControl_min";
            this.metroTabControl_min.SelectedIndex = 0;
            this.metroTabControl_min.Size = new System.Drawing.Size(572, 264);
            this.metroTabControl_min.TabIndex = 0;
            this.metroTabControl_min.UseSelectable = true;
            this.metroTabControl_min.MouseClick += new System.Windows.Forms.MouseEventHandler(this.metroTabControl_main_MouseClick);
            // 
            // metroTabPage_Main
            // 
            this.metroTabPage_Main.Controls.Add(this.panal_main);
            this.metroTabPage_Main.HorizontalScrollbarBarColor = true;
            this.metroTabPage_Main.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage_Main.HorizontalScrollbarSize = 10;
            this.metroTabPage_Main.Location = new System.Drawing.Point(4, 54);
            this.metroTabPage_Main.Name = "metroTabPage_Main";
            this.metroTabPage_Main.Size = new System.Drawing.Size(564, 206);
            this.metroTabPage_Main.TabIndex = 0;
            this.metroTabPage_Main.Text = "Main";
            this.metroTabPage_Main.VerticalScrollbarBarColor = true;
            this.metroTabPage_Main.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage_Main.VerticalScrollbarSize = 10;
            // 
            // panal_main
            // 
            this.panal_main.BackColor = System.Drawing.Color.Transparent;
            this.panal_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panal_main.Location = new System.Drawing.Point(0, 0);
            this.panal_main.Margin = new System.Windows.Forms.Padding(0);
            this.panal_main.Name = "panal_main";
            this.panal_main.Size = new System.Drawing.Size(564, 206);
            this.panal_main.TabIndex = 2;
            // 
            // metroTabPage_Create
            // 
            this.metroTabPage_Create.Controls.Add(this.panel_create);
            this.metroTabPage_Create.HorizontalScrollbarBarColor = true;
            this.metroTabPage_Create.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage_Create.HorizontalScrollbarSize = 10;
            this.metroTabPage_Create.Location = new System.Drawing.Point(4, 54);
            this.metroTabPage_Create.Name = "metroTabPage_Create";
            this.metroTabPage_Create.Size = new System.Drawing.Size(564, 206);
            this.metroTabPage_Create.TabIndex = 1;
            this.metroTabPage_Create.Text = "Create Playback";
            this.metroTabPage_Create.VerticalScrollbarBarColor = true;
            this.metroTabPage_Create.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage_Create.VerticalScrollbarSize = 10;
            this.metroTabPage_Create.Click += new System.EventHandler(this.metroTabPage_Create_Click);
            // 
            // panel_create
            // 
            this.panel_create.BackColor = System.Drawing.Color.Transparent;
            this.panel_create.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_create.Location = new System.Drawing.Point(0, 0);
            this.panel_create.Name = "panel_create";
            this.panel_create.Size = new System.Drawing.Size(564, 206);
            this.panel_create.TabIndex = 2;
            // 
            // timer_rec_events
            // 
            this.timer_rec_events.Interval = 5;
            this.timer_rec_events.Tick += new System.EventHandler(this.timer_rec_events_Tick);
            // 
            // timer_hotkey_press
            // 
            this.timer_hotkey_press.Interval = 1;
            this.timer_hotkey_press.Tick += new System.EventHandler(this.timer_hotkey_press_Tick);
            // 
            // infoTextBox
            // 
            this.infoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.infoTextBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.infoTextBox.Location = new System.Drawing.Point(20, 278);
            this.infoTextBox.Multiline = false;
            this.infoTextBox.Name = "infoTextBox";
            this.infoTextBox.ReadOnly = true;
            this.infoTextBox.Size = new System.Drawing.Size(572, 16);
            this.infoTextBox.TabIndex = 1;
            this.infoTextBox.Text = "Launch..";
            // 
            // button_option
            // 
            this.button_option.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_option.Image = ((System.Drawing.Image)(resources.GetObject("button_option.Image")));
            this.button_option.Location = new System.Drawing.Point(546, 0);
            this.button_option.Name = "button_option";
            this.button_option.Size = new System.Drawing.Size(26, 20);
            this.button_option.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.button_option.TabIndex = 2;
            this.button_option.TabStop = false;
            this.button_option.Click += new System.EventHandler(this.button_option_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_option);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(20, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(572, 20);
            this.panel1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(612, 314);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.infoTextBox);
            this.Controls.Add(this.metroTabControl_min);
            this.DisplayHeader = false;
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "Macro Recorder";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.metroTabControl_min.ResumeLayout(false);
            this.metroTabPage_Main.ResumeLayout(false);
            this.metroTabPage_Create.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.button_option)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer_add_events;
        private System.Windows.Forms.Timer timer_hotkey_options;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private MetroFramework.Controls.MetroTabControl metroTabControl_min;
        private MetroFramework.Controls.MetroTabPage metroTabPage_Main;
        private MetroFramework.Controls.MetroTabPage metroTabPage_Create;
        private System.Windows.Forms.Panel panal_main;
        private System.Windows.Forms.Timer timer_rec_events;
        private System.Windows.Forms.Timer timer_hotkey_press;
        private System.Windows.Forms.Panel panel_create;
        private System.Windows.Forms.RichTextBox infoTextBox;
        private System.Windows.Forms.PictureBox button_option;
        private System.Windows.Forms.Panel panel1;
    }
}

