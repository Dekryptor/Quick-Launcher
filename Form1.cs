using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BetterLauncher
{
    public partial class Form1 : MaterialForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MaterialSkinManager _manager = MaterialSkinManager.Instance;
            _manager.AddFormToManage(this);
            _manager.Theme = MaterialSkinManager.Themes.DARK;
            _manager.ColorScheme = new ColorScheme(Primary.dark, Primary.dark, Primary.dark, Accent.Red200, TextShade.WHITE);

            altis.Load("https://arma3-servers.net/server/31593/banners/banner-3.png");
            ts.Load("http://teamspeak-servers.org/server/6807/banners/banner-3.png");
            site.Load("https://i.gyazo.com/dd2cd55f269d54c50a14cd4d76bfe73e.png");
        }

        private void clickHandler(object sender, EventArgs e)
        {
            string _name = ((PictureBox)sender).Name;
            switch(_name)
            {
                case "altis":
                    System.Diagnostics.Process.Start("steam://rungameid/107410//+connect 162.248.92.58:2302");
                    break;
                case "ts":
                    System.Diagnostics.Process.Start("ts3server://ts3.a3lrp.com?port=9987");
                    break;
                case "site":
                    System.Diagnostics.Process.Start("http://forum.a3lrp.com");
                    break;
            }
        }
    }
}
