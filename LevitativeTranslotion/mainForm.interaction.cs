using System;
using System.Windows.Forms;

namespace LevitativeTranslotion
{
    public partial class mainForm : Form
    {
        //Item interaction
        private void More_MouseEnter(object sender, EventArgs e)
        {
            More.BackgroundImage = Properties.Resources.more_enter;
        }

        private void More_MouseLeave(object sender, EventArgs e)
        {
            More.BackgroundImage = Properties.Resources.more_normal;
        }

        private void Switch_MouseEnter(object sender, EventArgs e)
        {
            if (running)
                Switch.BackgroundImage = Properties.Resources.switch_on_enter;
            else
                Switch.BackgroundImage = Properties.Resources.switch_off_enter;
        }

        private void Switch_MouseLeave(object sender, EventArgs e)
        {
            if (running)
                Switch.BackgroundImage = Properties.Resources.switch_on_normal;
            else
                Switch.BackgroundImage = Properties.Resources.switch_off_normal;
        }

        private void Minimize_MouseEnter(object sender, EventArgs e)
        {
            Minimize.BackgroundImage = Properties.Resources.minimize_enter;
        }

        private void Minimize_MouseLeave(object sender, EventArgs e)
        {
            Minimize.BackgroundImage = Properties.Resources.minimize_normal;
        }

        private void Minimize_MouseDown(object sender, MouseEventArgs e)
        {
            Minimize.BackgroundImage = Properties.Resources.minimize_click;
        }

        private void Minimize_MouseUp(object sender, MouseEventArgs e)
        {
            Minimize.BackgroundImage = Properties.Resources.minimize_enter;
        }

        private void Hotkey_MouseEnter(object sender, EventArgs e)
        {
            if (!Hotkey.Focused)
                Hotkey.BackgroundImage = Properties.Resources.hotkey_enter;
        }

        private void Hotkey_MouseLeave(object sender, EventArgs e)
        {
            if (!Hotkey.Focused)
                Hotkey.BackgroundImage = Properties.Resources.hotkey_normal;
        }

        private void Hotkey_Enter(object sender, EventArgs e)
        {
            Hotkey.BackgroundImage = Properties.Resources.hotkey_click;
        }

        private void Hotkey_Leave(object sender, EventArgs e)
        {
            Hotkey.BackgroundImage = Properties.Resources.hotkey_normal;
        }

        private void Trancore_MouseEnter(object sender, EventArgs e)
        {
            Trancore.BackgroundImage = Properties.Resources.trancore_enter;
        }

        private void Trancore_MouseLeave(object sender, EventArgs e)
        {
            Trancore.BackgroundImage = Properties.Resources.trancore_normal;
        }

        private void Trancore_MouseDown(object sender, MouseEventArgs e)
        {
            Trancore.BackgroundImage = Properties.Resources.trancore_click;
        }

        private void Trancore_MouseUp(object sender, MouseEventArgs e)
        {
            Trancore.BackgroundImage = Properties.Resources.trancore_enter;
        }

        //Form move
        private bool Drag;
        private int MouseX;
        private int MouseY;

        private void mainForm_MouseDown(object sender, MouseEventArgs e)
        {
            Drag = true;
            MouseX = Cursor.Position.X - this.Left;
            MouseY = Cursor.Position.Y - this.Top;
        }

        private void mainForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (Drag)
            {
                this.Top = Cursor.Position.Y - MouseY;
                this.Left = Cursor.Position.X - MouseX;
            }
        }

        private void mainForm_MouseUp(object sender, MouseEventArgs e)
        {
            Drag = false;
        }
    }
}
