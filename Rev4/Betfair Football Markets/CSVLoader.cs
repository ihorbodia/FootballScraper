using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Betfair_Football_Markets
{
    internal class CSVLoader
    {
        internal static IEnumerable<T> Read<T>(string text)
        {
            string line;
            using (var sr = new StreamReader(File.OpenRead(text)))
                while (!sr.EndOfStream)
                {
                    line = sr.ReadLine();
                    string[] values = line.Split(',').Skip(1).ToArray();
                    if (values.Length == 0)
                        continue;
                    if (values[0].StartsWith("#") || values[0] == string.Empty)
                        continue;
                    yield return (T)Activator.CreateInstance(typeof(T), new object[] { values });
                }
        }
    }
}