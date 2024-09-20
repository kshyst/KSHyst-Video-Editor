using System;
using System.Diagnostics;
using System.IO;

namespace ffmpeg_client
{
    internal class CommandLineCreator
    {
        public static string CreateCommand(string inputLocation, string outputLocation, string outputFormat, string outputFPS, string outputResolution)
        {
            string command = "ffmpeg -i \"" + inputLocation + "\" -r \"" + outputFPS + "\" -vf \"scale = -2:" + outputResolution + "\" -c:v libx265 -crf 32 -c:a libopus -b:a 96K -strict experimental -max_muxing_queue_size 1024 \"" +
                outputLocation + "\\output." + outputFormat + "\" -y";

            return command;
        }

        public static void RunCommand(string command)
        {
            Process process = new Process();
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.Arguments = "/C " + command;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.RedirectStandardError = true;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.CreateNoWindow = true;

            // Event handlers for capturing real-time output
            process.OutputDataReceived += new DataReceivedEventHandler((sender, e) =>
            {
                if (!string.IsNullOrEmpty(e.Data))
                {
                    // Output to console
                    Console.WriteLine(e.Data);

                    // Optionally, write to a file in real-time
                    File.AppendAllText("C:\\Users\\KSHyst\\Desktop\\x.txt", e.Data + Environment.NewLine);
                }
            });

            process.ErrorDataReceived += new DataReceivedEventHandler((sender, e) =>
            {
                if (!string.IsNullOrEmpty(e.Data))
                {
                    // Output error to console
                    Console.WriteLine("Error: " + e.Data);

                    // Optionally, write error to a file in real-time
                    File.AppendAllText("C:\\Users\\KSHyst\\Desktop\\x.txt", "Error: " + e.Data + Environment.NewLine);
                }
            });

            // Start the process
            process.Start();

            // Begin reading output asynchronously
            process.BeginOutputReadLine();
            process.BeginErrorReadLine();

            // Wait for the process to exit
            process.WaitForExit();
        }
    }
}
