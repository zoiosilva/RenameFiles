using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace RenameFiles
{
    public class RenomearArquivos
    {
        private static IDictionary<char, char> lista = WhatToFix.Fixes();

        public static void Executar(string rootPath)
        {
            var files = Directory.EnumerateFiles(rootPath, "*.*", SearchOption.AllDirectories);
            files.Where(NeedsFix).ToList().ForEach(Fix);
        }

        private static void Fix(string file)
        {
            var renamed = file;

            foreach (var item in lista)
            {
                if (file.Contains(item.Key))
                    renamed = renamed.Replace(item.Key, item.Value);
            }

            File.Move(file, renamed);
        }

        private static bool NeedsFix(string file)
        {
            return file.Any(c => lista.Keys.Contains(c));
        }
    }
}
