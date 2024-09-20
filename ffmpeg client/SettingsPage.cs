using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ffmpeg_client
{
    internal class SettingsPage
    {
        private int brightnessMode = 1;

        public void setBrightnessMode( Form form)
        {
            if (brightnessMode == 0)
            {
                brightnessMode = 1;
                form.BackColor = SystemColors.ActiveCaption;
            }
            else
            {
                brightnessMode = 0;
                form.BackColor = Color.FromArgb(64, 64, 64);
            }
        }

    }
}
