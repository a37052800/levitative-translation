﻿
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
            this.Trancore = new System.Windows.Forms.Button();
            this.Hotkey = new System.Windows.Forms.Button();
            this.Minimize = new System.Windows.Forms.Button();
            this.Switch = new System.Windows.Forms.Button();
            this.More = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "懸浮翻譯";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);
            this.notifyIcon1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseClick);
            // 
            // Trancore
            // 
            this.Trancore.BackgroundImage = global::LevitativeTranslotion.Properties.Resources.trancore_normal;
            this.Trancore.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Trancore.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Trancore.FlatAppearance.BorderSize = 0;
            this.Trancore.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Trancore.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Trancore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Trancore.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Trancore.Location = new System.Drawing.Point(48, 155);
            this.Trancore.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Trancore.Name = "Trancore";
            this.Trancore.Size = new System.Drawing.Size(254, 27);
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
            this.Hotkey.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Hotkey.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Hotkey.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Hotkey.FlatAppearance.BorderSize = 0;
            this.Hotkey.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Hotkey.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Hotkey.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Hotkey.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Hotkey.Location = new System.Drawing.Point(130, 82);
            this.Hotkey.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Hotkey.Name = "Hotkey";
            this.Hotkey.Size = new System.Drawing.Size(89, 39);
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
            this.Minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Minimize.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Minimize.FlatAppearance.BorderSize = 0;
            this.Minimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Minimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Minimize.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Minimize.Location = new System.Drawing.Point(318, 10);
            this.Minimize.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Minimize.Name = "Minimize";
            this.Minimize.Size = new System.Drawing.Size(26, 26);
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
            this.Switch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Switch.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Switch.FlatAppearance.BorderSize = 0;
            this.Switch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Switch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Switch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Switch.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Switch.Location = new System.Drawing.Point(30, 10);
            this.Switch.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Switch.Name = "Switch";
            this.Switch.Size = new System.Drawing.Size(57, 24);
            this.Switch.TabIndex = 1;
            this.Switch.UseVisualStyleBackColor = true;
            this.Switch.Click += new System.EventHandler(this.Switch_Click);
            this.Switch.MouseEnter += new System.EventHandler(this.Switch_MouseEnter);
            this.Switch.MouseLeave += new System.EventHandler(this.Switch_MouseLeave);
            // 
            // More
            // 
            this.More.BackgroundImage = global::LevitativeTranslotion.Properties.Resources.more_normal;
            this.More.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.More.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.More.FlatAppearance.BorderSize = 0;
            this.More.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.More.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.More.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.More.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.More.Location = new System.Drawing.Point(11, 15);
            this.More.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.More.Name = "More";
            this.More.Size = new System.Drawing.Size(6, 15);
            this.More.TabIndex = 1;
            this.More.UseVisualStyleBackColor = true;
            this.More.Click += new System.EventHandler(this.More_Click);
            this.More.MouseEnter += new System.EventHandler(this.More_MouseEnter);
            this.More.MouseLeave += new System.EventHandler(this.More_MouseLeave);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(353, 221);
            this.Controls.Add(this.Trancore);
            this.Controls.Add(this.Hotkey);
            this.Controls.Add(this.Minimize);
            this.Controls.Add(this.Switch);
            this.Controls.Add(this.More);
            this.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.Name = "mainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "懸浮翻譯";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.mainForm_FormClosed);
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.mainForm_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mainForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mainForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mainForm_MouseUp);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button More;
        private System.Windows.Forms.Button Switch;
        private System.Windows.Forms.Button Minimize;
        private System.Windows.Forms.Button Hotkey;
        private System.Windows.Forms.Button Trancore;
    }
}