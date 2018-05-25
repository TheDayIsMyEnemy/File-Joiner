using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace FileJoiner
{
    public class FileJoiner
    {
        private Regex uReg = new Regex(@"using\s[A-Z][A-Za-z]+(\.[A-Z][A-Za-z]+)*;");
        private Regex nReg = new Regex(@"namespace\s+[A-Za-z.]+\s*{((\s*.*)+)}");

        public string ProjectPath { get; set; }
        public string Result { get; set; }

        public void JoinFiles()
        {
            var files = Directory.GetFiles
                (ProjectPath, "*.cs", SearchOption.AllDirectories)
                .Where(a => !a.Contains(@"obj\Debug\") && !a.Contains(@"\Properties\"));

            var text = files.Select(a => File.ReadAllText(a).Trim()).ToList();

            string usings = string.Join("\n", uReg.Matches(string.Join("\n", text))
                .OfType<Match>()
                .Select(f => f.Groups[0].Value)
                .Distinct()
                .OrderByDescending(v => v)) + "\n\n";

            Result = usings + string.Join("\n\n", text.Select(v => uReg.Replace(v, "").Trim())
                .Select(f => nReg.Replace(f, m => m.Groups[1].Value.ToString().Trim())));
        }
    }
}
