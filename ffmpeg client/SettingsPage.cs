using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;


namespace ffmpeg_client
{
    internal class SettingsPage
    {
        private static SettingsPage Instance { get; set; }
        private int brightnessMode = 1;

        private SettingsPage() { }

        public static SettingsPage GetSettingsPage() 
        { 
            if (Instance == null)
                Instance = new SettingsPage();
            return Instance;
        }

        public void setBrightnessMode( Form form)
        {
            if (brightnessMode == 0)
            {
                brightnessMode = 1;
            }
            else
            {
                brightnessMode = 0;
            }

            if (brightnessMode == 0)
            {
                form.BackColor = SystemColors.ActiveCaption;
            }
            else
            {
                form.BackColor = Color.FromArgb(64, 64, 64);
            }

            SettingsSave.save(new SettingsSave(brightnessMode));

        }

        public void initializeBrightnessMode(Form form)
        {
            brightnessMode = SettingsSave.load().brightnessMode;

            if (brightnessMode == 0)
            {
                form.BackColor = SystemColors.ActiveCaption;
            }
            else
            {
                form.BackColor = Color.FromArgb(64, 64, 64);
            }
        }
    }

    public class SettingsSave
    {
        private static string filePath = "settings.json";
        public int brightnessMode { get; set; }

        public SettingsSave(int brightnessMode)
        {
            this.brightnessMode = brightnessMode;
        }

        public static void save(SettingsSave settingsSave)
        {
            string jsonString = JsonSerializer.Serialize(settingsSave, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, jsonString);

        }

        public static SettingsSave load()
        {
            try
            {
                string jsonString = File.ReadAllText(filePath);
                return JsonSerializer.Deserialize<SettingsSave>(jsonString);
            }
            catch (Exception)
            {
                return new SettingsSave(1);
            }
        }
    }
}
