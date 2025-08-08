#nullable enable

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Windows.Win32.Foundation;

namespace Win11_24H2_Win32_HtmlHelp_Bug
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.listBox1.Items.AddRange(Enum.GetValues(typeof(WinGdiCharsets)).OfType<object>().ToArray());
            this.listBox1.SelectedIndex = -1;
            this.listBox1.SelectedIndexChanged += ListBox1_SelectedIndexChanged;

            this.lblSystemLCID.Text = "SystemLCID= " + Windows.Win32.PInvoke.GetSystemDefaultLCID().ToString();
        }



        private void btnHelpShowPopup_Click(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            var p = btn.PointToScreen(new Point(0, 0));
            System.Windows.Forms.Help.ShowPopup(btn, this.textBox1.Text, p);

            this.lblFont.Text = "";

            var hwnd = Windows.Win32.PInvoke.FindWindow("hh_popup", null);
            if (hwnd != null)
            {
                SavePNG(hwnd, "Help.ShowPopup");
            }
        }

        private void btnNoFont_Click(object sender, EventArgs e)
        {
            ShowHtmlHelp((Button)sender, false, null, "No Font");
        }

        private void btnNoCharSet_Click(object sender, EventArgs e)
        {
            ShowHtmlHelp((Button)sender, true, null, "No CharSet");
        }


        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var listBox = (ListBox)sender;
            if (listBox.SelectedIndex < 0)
            {
                return;
            }
            var rect = listBox.GetItemRectangle(this.listBox1.SelectedIndex);

            var charset = (WinGdiCharsets)listBox.SelectedItem;

            ShowHtmlHelp(listBox1, true, charset, $"CharSet={(int)charset:0}_{charset}", rect.Y);
        }


        private void ShowHtmlHelp(Control parent, bool setFont, WinGdiCharsets? charset, string fileName, int offsetY = 0)
        {
            var p = parent.PointToScreen(new Point(-70, offsetY));
            this.lblFont.Text = "szFont= " + Win32HtmlHelp.Make_szFont(parent.Font, charset);


            var hwnd = Win32HtmlHelp.ShowPopup(parent, this.textBox1.Text, p, setFont, charset);

            SavePNG(hwnd, fileName);
        }

        private void SavePNG(HWND hwnd, string name)
        {
            if (hwnd.IsNull)
            {
                return;
            }

            if (this.chkSavePNG.Checked)
            {
                System.IO.Directory.CreateDirectory("PNG");
                Win32HtmlHelp.SavePNG(hwnd, System.IO.Path.Combine("PNG", name + ".png"));
            }

        }
    }
}
