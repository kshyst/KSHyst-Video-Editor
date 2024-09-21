using System;
using System.Diagnostics;
using System.Globalization;
using System.IO;

namespace ffmpeg_client
{
    internal class CommandLineCreator
    {
        private static CommandLineCreator Instance { get; set; }
        public ProgressBar ProgressBar { get; set; }
        public double fullTimeToConvert = 1;
        public double currentTimeConverted = 0;

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

        public void RunCommand(string command)
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
                        string videoDuration = e.Data.Substring(e.Data.IndexOf("Duration: ") + 10, 11);
                        //File.AppendAllText("C:\\Users\\KSHyst\\Desktop\\x.txt", videoDuration + Environment.NewLine);

                        fullTimeToConvert = convertTimeStringToSeconds(videoDuration);
                    }
                    else if (e.Data.Contains("time="))
                    {
                        //File.AppendAllText("C:\\Users\\KSHyst\\Desktop\\x.txt", e.Data.Substring(e.Data.IndexOf("time=") + 5, 11));

                        string timeConverted = e.Data.Substring(e.Data.IndexOf("time=") + 5, 11);
                        currentTimeConverted = convertTimeStringToSeconds(timeConverted);
                    }

                    //TODO
                    //UpdateProgressBar();
                }
            });

            process.Start();

            process.BeginOutputReadLine();
            process.BeginErrorReadLine();

            process.WaitForExit();
        }

        private static double convertTimeStringToSeconds(string timeString)
        {
            TimeSpan timeSpan = TimeSpan.ParseExact(timeString, @"hh\:mm\:ss\.ff", CultureInfo.InvariantCulture);

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
    }
}
