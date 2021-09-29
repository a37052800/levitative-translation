
namespace LevitativeTranslotion
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.設定ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.結束ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.Trancore = new System.Windows.Forms.Button();
            this.Hotkey = new System.Windows.Forms.Button();
            this.Minimize = new System.Windows.Forms.Button();
            this.Switch = new System.Windows.Forms.Button();
            this.More = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "懸浮翻譯";
            this.notifyIcon1.Visible = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.contextMenuStrip1.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.設定ToolStripMenuItem,
            this.結束ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(109, 64);
            // 
            // 設定ToolStripMenuItem
            // 
            this.設定ToolStripMenuItem.Name = "設定ToolStripMenuItem";
            this.設定ToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.設定ToolStripMenuItem.Size = new System.Drawing.Size(108, 30);
            this.設定ToolStripMenuItem.Text = "設定";
            this.設定ToolStripMenuItem.Click += new System.EventHandler(this.設定ToolStripMenuItem_Click);
            // 
            // 結束ToolStripMenuItem
            // 
            this.結束ToolStripMenuItem.Name = "結束ToolStripMenuItem";
            this.結束ToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.結束ToolStripMenuItem.Size = new System.Drawing.Size(108, 30);
            this.結束ToolStripMenuItem.Text = "結束";
            this.結束ToolStripMenuItem.Click += new System.EventHandler(this.結束ToolStripMenuItem_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "csv";
            this.saveFileDialog1.FileName = "單字本.csv";
            this.saveFileDialog1.Filter = "逗點分隔檔案|*.csv";
            // 
            // Trancore
            // 
            this.Trancore.BackgroundImage = global::LevitativeTranslotion.Properties.Resources.trancore_normal;
            this.Trancore.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Trancore.FlatAppearance.BorderSize = 0;
            this.Trancore.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Trancore.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Trancore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Trancore.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Trancore.Location = new System.Drawing.Point(60, 194);
            this.Trancore.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Trancore.Name = "Trancore";
            this.Trancore.Size = new System.Drawing.Size(317, 34);
            this.Trancore.TabIndex = 1;
            this.Trancore.UseVisualStyleBackColor = true;
            this.Trancore.Click += new System.EventHandler(this.Trancore_Click);
            this.Trancore.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Trancore_MouseDown);
            this.Trancore.MouseEnter += new System.EventHandler(this.Trancore_MouseEnter);
            this.Trancore.MouseLeave += new System.EventHandler(this.Trancore_MouseLeave);
            this.Trancore.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Trancore_MouseUp);
            // 
            // Hotkey
            // 
            this.Hotkey.BackgroundImage = global::LevitativeTranslotion.Properties.Resources.hotkey_normal;
            this.Hotkey.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Hotkey.FlatAppearance.BorderSize = 0;
            this.Hotkey.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Hotkey.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Hotkey.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Hotkey.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Hotkey.Location = new System.Drawing.Point(163, 103);
            this.Hotkey.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Hotkey.Name = "Hotkey";
            this.Hotkey.Size = new System.Drawing.Size(111, 49);
            this.Hotkey.TabIndex = 1;
            this.Hotkey.UseVisualStyleBackColor = true;
            this.Hotkey.Enter += new System.EventHandler(this.Hotkey_Enter);
            this.Hotkey.KeyUp += new System.Windows.Forms.KeyEventHandler(this.HotKeySlector_KeyUp);
            this.Hotkey.Leave += new System.EventHandler(this.Hotkey_Leave);
            this.Hotkey.MouseEnter += new System.EventHandler(this.Hotkey_MouseEnter);
            this.Hotkey.MouseLeave += new System.EventHandler(this.Hotkey_MouseLeave);
            // 
            // Minimize
            // 
            this.Minimize.BackgroundImage = global::LevitativeTranslotion.Properties.Resources.minimize_normal;
            this.Minimize.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Minimize.FlatAppearance.BorderSize = 0;
            this.Minimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Minimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Minimize.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Minimize.Location = new System.Drawing.Point(398, 12);
            this.Minimize.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Minimize.Name = "Minimize";
            this.Minimize.Size = new System.Drawing.Size(32, 32);
            this.Minimize.TabIndex = 1;
            this.Minimize.UseVisualStyleBackColor = true;
            this.Minimize.Click += new System.EventHandler(this.Minimize_Click);
            this.Minimize.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Minimize_MouseDown);
            this.Minimize.MouseEnter += new System.EventHandler(this.Minimize_MouseEnter);
            this.Minimize.MouseLeave += new System.EventHandler(this.Minimize_MouseLeave);
            this.Minimize.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Minimize_MouseUp);
            // 
            // Switch
            // 
            this.Switch.BackgroundImage = global::LevitativeTranslotion.Properties.Resources.switch_off_normal;
            this.Switch.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Switch.FlatAppearance.BorderSize = 0;
            this.Switch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Switch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Switch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Switch.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Switch.Location = new System.Drawing.Point(37, 13);
            this.Switch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Switch.Name = "Switch";
            this.Switch.Size = new System.Drawing.Size(71, 30);
            this.Switch.TabIndex = 1;
            this.Switch.UseVisualStyleBackColor = true;
            this.Switch.Click += new System.EventHandler(this.Switch_Click);
            this.Switch.MouseEnter += new System.EventHandler(this.Switch_MouseEnter);
            this.Switch.MouseLeave += new System.EventHandler(this.Switch_MouseLeave);
            // 
            // More
            // 
            this.More.BackgroundImage = global::LevitativeTranslotion.Properties.Resources.more_normal;
            this.More.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.More.FlatAppearance.BorderSize = 0;
            this.More.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.More.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.More.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.More.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.More.Location = new System.Drawing.Point(14, 19);
            this.More.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.More.Name = "More";
            this.More.Size = new System.Drawing.Size(7, 19);
            this.More.TabIndex = 1;
            this.More.UseVisualStyleBackColor = true;
            this.More.Click += new System.EventHandler(this.More_Click);
            this.More.MouseEnter += new System.EventHandler(this.More_MouseEnter);
            this.More.MouseLeave += new System.EventHandler(this.More_MouseLeave);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(441, 276);
            this.Controls.Add(this.Trancore);
            this.Controls.Add(this.Hotkey);
            this.Controls.Add(this.Minimize);
            this.Controls.Add(this.Switch);
            this.Controls.Add(this.More);
            this.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "mainForm";
            this.Opacity = 0.96D;
            this.ShowIcon = false;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.mainForm_FormClosed);
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.mainForm_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mainForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mainForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mainForm_MouseUp);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 設定ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 結束ToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button More;
        private System.Windows.Forms.Button Switch;
        private System.Windows.Forms.Button Minimize;
        private System.Windows.Forms.Button Hotkey;
        private System.Windows.Forms.Button Trancore;
    }
}