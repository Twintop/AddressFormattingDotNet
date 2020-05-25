using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using YamlDotNet.Serialization;

namespace AddressFormattingDotNet.Helpers
{
    public static class YamlHelper
    {
        public static IEnumerable<string> ReadDocumentsFromFilePath(string filePath)
        {
            var componentsYaml = File.ReadLines(filePath).ToList();
            var documents = new List<string>();
            var doc = string.Empty;

            for (var x = 0; x < componentsYaml.Count(); x++)
            {
                if (componentsYaml[x].StartsWith("---"))
                {
                    documents.Add(doc);
                    doc = string.Empty;
                }
                else if (componentsYaml[x].StartsWith("#"))
                {
                    continue;
                }
                else
                {
                    doc = $"{doc}{(string.IsNullOrWhiteSpace(doc) ? string.Empty : Environment.NewLine)}{componentsYaml[x]}";
                }
            }

            if (!string.IsNullOrWhiteSpace(doc))
            {
                documents.Add(doc);
            }

            return documents;
        }

        public static IEnumerable<T> DeserializeListFromFilePath<T>(string filePath)
        {
            var deserializer = new DeserializerBuilder().Build();
            var documents = ReadDocumentsFromFilePath(filePath);
            var returnList = new List<T>();
            foreach (var document in documents)
            {
                 returnList.Add(deserializer.Deserialize<T>(document));
            }

            return returnList;
        }
    }
}