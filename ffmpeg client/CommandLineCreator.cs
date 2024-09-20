using System;
using System.Collections.Generic;
using System.Diagnostics;
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
                outputLocation + "\\output." + outputFormat + "\" -y";

            return command;
        }

        public static void RunCommand(string command)
        {
            Process process = new Process();
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.Arguments = "/C " + command ;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.CreateNoWindow = true;

            process.Start();

            string result = process.StandardOutput.ReadToEnd();
            //Console.WriteLine(result);

            process.WaitForExit();
        }

        private static void EnterYes()
        {
            
        }
    }
}
