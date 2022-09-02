using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSus2Editor
{
    public class Crewmate : PictureBox
    {

        public Crewmate()
        {

            SetStyle(ControlStyles.SupportsTransparentBackColor, true);

            BackgroundImage = Image.FromFile(@".\res\crewmate.png");

            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;

            Size = new Size(36, 36);
            BackColor = Color.LightGreen;
            
        }
    }
}
