using System;
using System.Globalization;
using System.Reflection;
using System.Windows.Forms;

namespace SubtitleFileNameSync
{
    static partial class BuildConfig
    {
        public static string BuildDate;
        public static string BuildType;
    }

    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            AppDomain.CurrentDomain.AssemblyResolve += AssemblyResolve;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }

        static Assembly AssemblyResolve(object sender, ResolveEventArgs args)
        {
            var assemblyName = new AssemblyName(args.Name);
            var path = $"{assemblyName.Name}.dll";
            var culture = assemblyName.CultureInfo;

            if (culture != null && !culture.Equals(CultureInfo.InvariantCulture))
            {
                path = $@"{culture}\{path}";
            }

            using (var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(path))
            {
                if (stream == null)
                {
                    return null;
                }

                var assemblyRawBytes = new byte[stream.Length];
                stream.Read(assemblyRawBytes, 0, assemblyRawBytes.Length);
                return Assembly.Load(assemblyRawBytes);
            }
        }
    }
}
