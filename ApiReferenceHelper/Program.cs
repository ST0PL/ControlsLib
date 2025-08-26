using System.Reflection;

namespace ApiReferenceHelper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] namespaces = ["ControlsLib.Controls", "ControlsLib.AttachedProperties"];
            Assembly asm = Assembly.Load("ControlsLib");
            var types = asm.GetTypes().Where(t=>t.IsVisible && namespaces.Contains(t.Namespace))
                .Select(t=>new
                {
                    Name = $"- {t.Name}",
                    Properties = t.GetProperties(BindingFlags.DeclaredOnly |
                                                 BindingFlags.Public |
                                                 BindingFlags.Instance).Select(p=>$"- `{p.Name}`")
                });
            foreach(var type in types)
                Console.WriteLine($"{type.Name}\n    {string.Join("\n    ", type.Properties)}");
        }
    }
}
