using UnityEngine;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public static class Gallery
{
    public static int currentID = 0;
    public static List<Item> items = ReadFile("Assets/Media/Items.csv", ',');

    private static List<Item> ReadFile(string filePath, char delimiter)
    {
        List<Item> fileData = new List<Item>();
        using (var reader = new StreamReader(filePath))
        {
            // Skip the header line
            reader.ReadLine();

            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                string[] fields = line.Split(delimiter);

                // Create a new Person instance and populate its properties
                Item item = new Item
                {
                    itemID = int.Parse(fields[0]),
                    name = fields[1],
                    pronunciation = fields[2]
                };

                fileData.Add(item);
            }
        }
        return fileData.OrderBy(ID => Random.value).ToList();
    }
}
