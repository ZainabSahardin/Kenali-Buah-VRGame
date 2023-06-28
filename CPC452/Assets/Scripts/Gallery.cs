using UnityEngine;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public static class Gallery
{
    public static int currentIndex = 0;
    public static List<Fruit> fruits = ReadFile("Assets/Media/Items.csv", ',');

    private static List<Fruit> ReadFile(string filePath, char delimiter)
    {
        List<Fruit> fileData = new List<Fruit>();
        using (var reader = new StreamReader(filePath))
        {
            // Skip the header line
            reader.ReadLine();

            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                string[] fields = line.Split(delimiter);

                // Create a new Person instance and populate its properties
                Fruit fruit = new Fruit
                {
                    ID = int.Parse(fields[0]),
                    name = fields[1],
                    pronunciation = fields[2]
                };

                fileData.Add(fruit);
            }
        }
        return fileData.OrderBy(ID => Random.value).ToList();
    }

    public static Fruit GetNextFruit()
    {
        currentIndex++;
        return fruits[currentIndex];
    }
}
