using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ffmpeg_client
{
    internal class CommandLineCreator
    {
        public static string CreateCommand(string inputLocation , string outputLocation , string outputFormat, string outputFPS, string outputResolution)
        {
            string command = "ffmpeg -i \"" + inputLocation + "\" -r \"" + outputFPS + "\" -vf \"scale = -2:" + outputResolution + "\" -c:v libx265 -crf 32 -c:a libopus -b:a 96K -strict experimental -max_muxing_queue_size 1024 \"" + 
                outputLocation + "\\output." + outputFormat + "\"";

            return command;
        }

        public static void RunCommand(string command)
        {
            System.Diagnostics.ProcessStartInfo procStartInfo = new System.Diagnostics.ProcessStartInfo("cmd", "/c " + command);

            procStartInfo.RedirectStandardOutput = true;
            procStartInfo.UseShellExecute = false;
            procStartInfo.CreateNoWindow = true;

            System.Diagnostics.Process proc = new System.Diagnostics.Process();
            proc.StartInfo = procStartInfo;
            proc.Start();

            string result = proc.StandardOutput.ReadToEnd();

            Console.WriteLine(result);
        }
    }
}
