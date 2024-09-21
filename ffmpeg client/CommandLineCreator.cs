using Microsoft.VisualBasic.Logging;
using System.Diagnostics;
using System.Globalization;

namespace ffmpeg_client
{
    internal class CommandLineCreator
    {
        private static CommandLineCreator Instance { get; set; }
        public ProgressBar ProgressBar { get; set; }
        public Form1 form { get; set; }
        private double fullTimeToConvert = 1;
        private double currentTimeConverted = 0;

        private CommandLineCreator() { }

        public static CommandLineCreator GetCommandLineCreator()
        {
            if(Instance == null)
                Instance = new CommandLineCreator();
            return Instance;
        }

        public string CreateCommand(string inputLocation, string outputLocation, string outputFormat, string outputFPS, string outputResolution)
        {
            string command = "ffmpeg -i \"" + inputLocation + "\" -r \"" + outputFPS + "\" -vf \"scale = -2:" + outputResolution + "\" -c:v libx265 -crf 32 -c:a libopus -b:a 96K -strict experimental -max_muxing_queue_size 1024 \"" +
                outputLocation + "\\output." + outputFormat + "\" -y";

            return command;
        }

        public async Task RunCommand(string command)
        {
            Process process = new Process();
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.Arguments = "/C " + command;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.RedirectStandardError = true;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.CreateNoWindow = true;

            process.ErrorDataReceived += new DataReceivedEventHandler((sender, e) =>
            {
                if (!string.IsNullOrEmpty(e.Data))
                {
                    if (e.Data.Contains("Duration: "))
                    {
                        string videoDuration = e.Data.Substring(e.Data.IndexOf("Duration: ") + 10, 8);
                        fullTimeToConvert = convertTimeStringToSeconds(videoDuration);
                    }
                    else if (e.Data.Contains("time="))
                    {
                        if (e.Data.Contains("time=N/A"))
                        {
                            UpdateLogs(1);
                        }
                        else
                        {
                            string timeConverted = e.Data.Substring(e.Data.IndexOf("time=") + 5, 8);
                            currentTimeConverted = convertTimeStringToSeconds(timeConverted);
                            UpdateLogs(2);
                        }
                    }
                    else if (e.Data.Contains("encoded "))
                    {
                        fullTimeToConvert = 1;
                        currentTimeConverted = 0;
                        UpdateLogs(0);
                    }

                    UpdateProgressBar();
                }
            });

            process.Start();

            process.BeginOutputReadLine();
            process.BeginErrorReadLine();

            await process.WaitForExitAsync();
        }

        private double convertTimeStringToSeconds(string timeString)
        {
            TimeSpan timeSpan = TimeSpan.ParseExact(timeString, @"hh\:mm\:ss", CultureInfo.InvariantCulture);
            double totalSeconds = timeSpan.TotalSeconds;

            return totalSeconds;
        }

        private void UpdateProgressBar()
        {
            if (ProgressBar.InvokeRequired)
            {
                ProgressBar.Invoke(new Action(UpdateProgressBar));
            }
            else
            {
                ProgressBar.Value = Convert.ToInt32(currentTimeConverted / fullTimeToConvert * 100);
            }
        }

        private void UpdateLogs(int mode)
        {
            if(form.InvokeRequired)
            {
                form.Invoke(new Action(() => UpdateLogs(mode)));
            }
            else
            {
                switch (mode)
                {
                    case 0:
                        form.logs.Text = "Conversion Successful";
                        form.logs.ForeColor = Color.Green;
                        break;
                    case 1:
                        form.logs.Text = "Error";
                        form.logs.ForeColor = Color.Red;
                        break;
                    case 2:
                        form.logs.Text = "Converting in Progress...";
                        form.logs.ForeColor = Color.Blue;
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
