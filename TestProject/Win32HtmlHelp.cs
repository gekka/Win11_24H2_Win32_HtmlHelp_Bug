using System;
using System.Drawing;
using System.Windows.Forms;

namespace Win11_24H2_Win32_HtmlHelp_Bug
{
    using System.Runtime.InteropServices;
    using Windows.Win32.Foundation;
    using Windows.Win32.Data.HtmlHelp;
    using Windows.Win32.Graphics.Gdi;

    static class Win32HtmlHelp
    {
        const float FontScale = 1;

        public static string Make_szFont(Font font, WinGdiCharsets? charset)
        {
            string charset_text;
            if (charset == null)
            {
                charset_text = ""; // !!!! 24H2 Bug !!!!
            }
            else
            {
                charset_text = ((int)charset.Value).ToString();
            }

            return $"{font.Name},{font.Size * FontScale},{charset_text},";
        }

        public unsafe static Windows.Win32.Foundation.HWND ShowPopup(Control parent, string caption, Point location, bool setFont, WinGdiCharsets? charset)
        {
            IntPtr pszText = IntPtr.Zero;
            IntPtr pszFont = IntPtr.Zero;
            try
            {
                pszText = Marshal.StringToCoTaskMemUni(caption);

                
                if (setFont)
                {
                    string szFont = Make_szFont(parent.Font, charset);
                    pszFont = Marshal.StringToCoTaskMemUni(szFont);

                }
                else
                {
                    pszFont = IntPtr.Zero;
                }

                HH_POPUP popup = new HH_POPUP();
                popup.cbStruct = Marshal.SizeOf(popup);
                popup.hinst = HINSTANCE.Null;
                popup.idString = 0;
                popup.pszText = (sbyte*)pszText.ToPointer();
                popup.pt = location;
                popup.clrBackground = new COLORREF(unchecked((uint)-1));
                popup.clrForeground = new COLORREF(unchecked((uint)-1));
                popup.rcMargins = new RECT(-1, -1, -1, -1);
                popup.pszFont = (sbyte*)pszFont.ToPointer();


                HH_POPUP[] pps = new HH_POPUP[1] { popup };
                fixed (void* p = &pps[0])
                {
                    return Windows.Win32.PInvoke.HtmlHelp((HWND)parent.Handle, (PCWSTR)null, HTML_HELP_COMMAND.HH_DISPLAY_TEXT_POPUP, (nuint)p);
                }
            }
            finally
            {
                if (pszText != IntPtr.Zero) Marshal.FreeCoTaskMem(pszText);
                if (pszFont != IntPtr.Zero) Marshal.FreeCoTaskMem(pszFont);
            }


        }

        public static void SavePNG(Windows.Win32.Foundation.HWND hwnd, string file)
        {
            System.IO.File.Delete(file);
            using (System.IO.FileStream fs = new System.IO.FileStream(file, System.IO.FileMode.Create, System.IO.FileAccess.Write))
            {
                SavePNG(hwnd, fs);
            }
        }
        public static void SavePNG(Windows.Win32.Foundation.HWND hwnd, System.IO.FileStream file)
        {
            if (!Windows.Win32.PInvoke.GetWindowRect(hwnd, out var rect))
            {
                return;
            }

            using (var bmp = new System.Drawing.Bitmap(rect.Width, rect.Height))
            {
                using (var g = System.Drawing.Graphics.FromImage(bmp))
                {
                    var hdc = g.GetHdc();
                    try
                    {
                        if (!Windows.Win32.PInvoke.PrintWindow(hwnd, (HDC)hdc, 0))
                        {
                            return;
                        }
                    }
                    finally
                    {
                        g.ReleaseHdc();
                    }
                }

                bmp.Save(file, System.Drawing.Imaging.ImageFormat.Png);

            }

        }
    }

    enum WinGdiCharsets
    {
	//wingdi.h

        ANSI_CHARSET = 0,
        DEFAULT_CHARSET = 1,
        SYMBOL_CHARSET = 2,
        SHIFTJIS_CHARSET = 128,
        HANGEUL_CHARSET = 129,
        HANGUL_CHARSET = 129,
        GB2312_CHARSET = 134,
        CHINESEBIG5_CHARSET = 136,

        JOHAB_CHARSET = 130,
        HEBREW_CHARSET = 177,
        ARABIC_CHARSET = 178,
        GREEK_CHARSET = 161,
        TURKISH_CHARSET = 162,
        VIETNAMESE_CHARSET = 163,
        THAI_CHARSET = 222,
        EASTEUROPE_CHARSET = 238,
        RUSSIAN_CHARSET = 204,

        MAC_CHARSET = 77,
        BALTIC_CHARSET = 186,

        OEM_CHARSET = 255,
    }
}
