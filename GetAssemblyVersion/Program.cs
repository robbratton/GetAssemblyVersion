using Mono.Options;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;

namespace GetAssemblyVersion
{
    /// <summary>
    /// Command-Line Program Main Class
    /// </summary>
    public static class Program
    {
        private static int Main(string[] args)
        {
            ExitCode exitCode;

            try
            {
                exitCode = ProcessOptions(
                    args,
                    out var showFileVersion,
                    out var showProdVersion,
                    out var format,
                    out var recursive,
                    out var paths);

                if (exitCode == 0)
                {
                    foreach (var path in paths)
                    {
                        CheckPath(path);
                    }

                    if (format == OutputFormat.TabDelimited)
                    {
                        WriteHeader(showFileVersion, showProdVersion);
                    }

                    foreach (var path in paths)
                    {
                        var files = GetFiles(path, recursive);
                        foreach (var file in files)
                        {
                            var versionInfo = new AssemblyVersionInfo(file);

                            WriteOutput(file, versionInfo, format, showFileVersion, showProdVersion);
                        }
                    }
                }
            }
            catch (Exception exception)
            {
                Console.Error.WriteLine(exception.ToString());
                exitCode = ExitCode.Exception;
            }

            if (Debugger.IsAttached)
            {
                Console.WriteLine("");
                Console.WriteLine("Exit code: " + exitCode + " (" + (int)exitCode + ")");
                Console.WriteLine("DEBUG: Press x to exit.");
                while (Console.ReadKey(true).KeyChar != 'x')
                {
                    Thread.Sleep(1000);
                }
            }

            return (int)exitCode;
        }

        private static ExitCode ProcessOptions(
            IEnumerable<string> args,
            out bool showFileVersionOut,
            out bool showProdVersionOut,
            out OutputFormat outputFormatOut,
            out bool recursiveOut,
            out IEnumerable<string> pathsOut)
        {
            var exitCode = ExitCode.Success;

            var showVersion = false;
            var showHelp = false;
            var showFileVersion = true;
            var showProdVersion = true;
            var format = OutputFormat.PlainText;
            var recursive = false;

            var options = new OptionSet
            {
                {
                    "f|fileVersion=", "Show the File Version", v =>
                    {
                        if (v != null)
                        {
                            showFileVersion = !v.Any() || bool.Parse(v);
                        }
                    }
                },
                {
                    "p|productVersion=", "Show the Product Version", v =>
                    {
                        if (v != null)
                        {
                            showProdVersion = !v.Any() || bool.Parse(v);
                        }
                    }
                },
                {
                    "o|output=", "Output OutputFormat: PlainText, TabDelimited", v =>
                    {
                        if (v != null)
                        {
                            if (!Enum.TryParse(v, out format))
                            {
                                // ReSharper disable once NotResolvedInText
                                throw new ArgumentOutOfRangeException("output");
                            }
                        }
                    }
                },
                {
                    "r|recursive=", "Include Subdirectories", v =>
                    {
                        if (v != null)
                        {
                            recursive = !v.Any() || bool.Parse(v);
                        }
                    }
                },
                {
                    "v|version", "Show the Version of this Program", v => { showVersion = v != null; }
                },
                {
                    "h|help|?", "Help", v => { showHelp = v != null; }
                }
            };

            var paths = new List<string>();

            try
            {
                paths.AddRange(options.Parse(args));
                if (!paths.Any())
                {
                    paths.Add(".");
                }
            }
            catch (OptionException e)
            {
                Console.Write("GetVersion: ");
                Console.WriteLine(e.Message);
                Console.WriteLine("Try `GetVersion --help' for more information.");
                exitCode = ExitCode.ArgumentError;
            }

            if (showVersion)
            {
                Console.WriteLine(GetStartupInformation());
                exitCode = ExitCode.Usage;
            }

            if (showHelp)
            {
                Console.WriteLine("Usage: GetVersion [options] [path1] [path2] [...]");
                options.WriteOptionDescriptions(Console.Out);
                exitCode = ExitCode.Usage;
            }

            // set output values
            showFileVersionOut = showFileVersion;
            showProdVersionOut = showProdVersion;
            outputFormatOut = format;
            recursiveOut = recursive;
            pathsOut = paths.AsEnumerable();

            return exitCode;
        }

        private static IEnumerable<string> GetFiles(string path, bool recursive)
        {
            CheckPath(path);

            var searchOption = recursive ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly;

            var output = new List<string>();

            output.AddRange(Directory.GetFiles(path, "*.exe", searchOption));
            output.AddRange(Directory.GetFiles(path, "*.dll", searchOption));

            return output;
        }

        private static void CheckPath(string path)
        {
            if (string.IsNullOrWhiteSpace(path))
            {
                throw new ArgumentException("Must not be null or whitespace.", nameof(path));
            }

            if (!Directory.Exists(path))
            {
                throw new DirectoryNotFoundException($"Directory {path} does not exist.");
            }
        }

        private static void WriteHeader(bool showFileVersion, bool showProdVersion)
        {
            var output = new StringBuilder();

            output.Append("File");

            if (showFileVersion)
            {
                output.Append("\tFile Version");
            }

            if (showProdVersion)
            {
                output.Append("\tProduct Version");
            }

            Console.WriteLine(output.ToString());
        }

        private static void WriteOutput(
            string file,
            AssemblyVersionInfo assemblyVersionInfo,
            OutputFormat outputFormat,
            bool showFileVersion,
            bool showProdVersion)
        {
            var output = new StringBuilder();

            output.Append(file);

            switch (outputFormat)
            {
                case OutputFormat.PlainText:
                    output.Append(": ");
                    break;
                case OutputFormat.TabDelimited:
                    output.Append("\t");
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(outputFormat), outputFormat, null);
            }

            output.Append(assemblyVersionInfo.ToString(outputFormat, showFileVersion, showProdVersion));

            Console.WriteLine(output.ToString());
        }

        // ExitCodes
        private enum ExitCode
        {
            Success = 0,
            Usage,
            ArgumentError,
            Exception
        }

        private static string GetStartupInformation()
        {
            var output = new StringBuilder();

            var entryAssembly = Assembly.GetEntryAssembly();
            var assemblyInfo = entryAssembly.GetName();
            output.AppendLine($"{assemblyInfo.Name} {assemblyInfo.Version}");

            var versionInfo = FileVersionInfo.GetVersionInfo(entryAssembly.Location);
            if (!string.IsNullOrWhiteSpace(versionInfo.CompanyName))
            {
                output.AppendLine($"Company: {versionInfo.CompanyName}");
            }

            if (!string.IsNullOrWhiteSpace(versionInfo.LegalCopyright))
            {
                output.AppendLine(versionInfo.LegalCopyright);
            }

            if (!string.IsNullOrWhiteSpace(versionInfo.Comments))
            {
                output.AppendLine($"Comments: {versionInfo.Comments}");
            }

            output.AppendLine("");

            return output.ToString();
        }
    }
}