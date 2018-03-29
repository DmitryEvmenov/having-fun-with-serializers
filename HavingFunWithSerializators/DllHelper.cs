using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;


namespace HavingFunWithSerializators
{
    static class DllHelper
    {
        public static void LoadAllBinDirectoryAssemblies(string path = "D://serz")
        {
            var binPath = Path.Combine(path);

            foreach (string dll in Directory.GetFiles(binPath, "*.dll", SearchOption.AllDirectories))
            {
                try
                {
                    Assembly.LoadFile(dll);
                }
                catch (FileLoadException loadEx)
                { } // The Assembly has already been loaded.
                catch (BadImageFormatException imgEx)
                { } // If a BadImageFormatException exception is thrown, the file is not an assembly.

            } // foreach dll
        }

        public static List<Type> GetTypes(Type assignableFromType)
        => AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(s => s.GetTypes())
                .Where(p => assignableFromType.IsAssignableFrom(p) && p.IsClass && !p.IsAbstract)
                .ToList();

    }
}
