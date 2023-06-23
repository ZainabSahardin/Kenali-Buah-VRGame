using UnityEngine;
using System.Collections.Generic;
using System.IO;

public class Inventory : MonoBehaviour
{
    public List<Item> items = new List<Item>();
    public int languageID = 0;

    public void Start()
    {
        string filePath = "Assets/Media/Items.csv";
        char delimiter = ',';

        items = ReadCsvFile(filePath, delimiter);

        // Access the list of items
        foreach (Item item in items)
        {
            Debug.Log($"ID: {item.itemID}, Name: {item.name}, Pronunciation: {item.pronunciation}");
        }
    }

    private List<Item> ReadCsvFile(string filePath, char delimiter)
    {
        int fieldAdder = 2 * languageID;
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
                    name = fields[1+fieldAdder],
                    pronunciation = fields[2+fieldAdder]
                };

                items.Add(item);
            }
        }
        return items;
    }
}
