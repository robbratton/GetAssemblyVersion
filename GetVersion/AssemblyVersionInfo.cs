using System;
using System.Diagnostics;
using System.IO;
using System.Text;
// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable UnusedMember.Global

namespace GetVersion
{
    /// <summary>
    /// Version information for an Assembly
    /// </summary>
    public class AssemblyVersionInfo
    {
        #region Properties
        /// <summary>
        /// The File Version of this Assembly
        /// </summary>
        public string FileVersion { get; }

        /// <summary>
        /// The Product Version of this Assembly
        /// </summary>
        public string ProductVersion { get; }

        #endregion Properties

        #region Constructors

        /// <summary>
        /// Constructor: From an assembly file
        /// </summary>
        /// <param name="file"></param>
        /// <exception cref="ArgumentException"></exception>
        /// <exception cref="FileNotFoundException"></exception>
        public AssemblyVersionInfo(string file)
        {
            if (string.IsNullOrWhiteSpace(file))
            {
                throw new ArgumentException("Must not be null or whitespace.", nameof(file));
            }

            if (!file.ToLower().EndsWith(".exe") && !file.ToLower().EndsWith(".dll"))
            {
                throw new ArgumentException("Must have an EXE or DLL extension.", nameof(file));
            }

            if (!File.Exists(file))
            {
                throw new FileNotFoundException("File must exist.", nameof(file));
            }

            var info = FileVersionInfo.GetVersionInfo(file);

            FileVersion = info.FileVersion;
            ProductVersion = info.ProductVersion;
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="fileVersion"></param>
        /// <param name="productVersion"></param>
        public AssemblyVersionInfo(string fileVersion, string productVersion)
        {
            FileVersion = fileVersion;
            ProductVersion = productVersion;
        }

        #endregion Constructors

        #region ToString Implementations

        /// <inheritdoc />
        public override string ToString()
        {
            return ToString(OutputFormat.PlainText, true, true);
        }

        /// <summary>
        /// Convert this instance to a string
        /// </summary>
        /// <param name="outputFormat"></param>
        /// <param name="showFileVersion"></param>
        /// <param name="showProdVersion"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public string ToString(OutputFormat outputFormat, bool showFileVersion, bool showProdVersion)
        {
            var output = new StringBuilder();

            if (showFileVersion)
            {
                if (outputFormat == OutputFormat.PlainText)
                {
                    output.Append("File Version: ");
                }

                output.Append(FileVersion);
            }

            if (showFileVersion && showProdVersion)
            {
                switch (outputFormat)
                {
                    case OutputFormat.PlainText:
                        output.Append(", ");
                        break;
                    case OutputFormat.TabDelimited:
                        output.Append("\t");
                        break;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(outputFormat), outputFormat, null);
                }
            }

            if (showProdVersion)
            {
                if (outputFormat == OutputFormat.PlainText)
                {
                    output.Append("Product Version: ");
                }

                output.Append(ProductVersion);
            }

            return output.ToString();
        }

        #endregion ToString Implementations
    }
}
