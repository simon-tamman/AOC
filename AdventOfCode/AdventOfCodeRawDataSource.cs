using System;
using System.IO;
using System.Reflection;

namespace AdventOfCode
{
    public abstract class AdventOfCodeRawDataSource
    {
        private const string Namespace = nameof(AdventOfCode);
        private const string Folder = "Input";
        protected abstract string FileNameAndExtension { get; }

        protected Stream Load()
        {
            var assembly = Assembly.GetAssembly(typeof(AdventOfCodeRawDataSource));
            if (assembly == null) throw new WtfException("can't find assembly");
            var stream = assembly.GetManifestResourceStream($"{Namespace}.{Folder}.{FileNameAndExtension}");
            if (stream == null) throw new WtfException("embedded resource doesn't exist");
            return stream;
        }
    }
}