using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DisplayFruits1 : MonoBehaviour
{
    public TextMeshProUGUI fruitName;
    public string[] fruitNameGallery;
    public GameObject[] fruit3D;
    int indexNo = 0;

    // Start is called before the first frame update
    void Start()
    {
        DisplayNextFruits();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void DisplayNextFruits()
    {
        ChangeFruit();
        indexNo++;
    }

    public void DisplayPrevFruits()
    {
        ChangeFruit();
        indexNo--;
    }

    public void ChangeFruit()
    {
        // Deactivate all fruits
        foreach (GameObject fruit in fruit3D)
        {
            fruit.SetActive(false);
        }

        // Activate the current fruit
        fruit3D[indexNo].SetActive(true);
        fruitName.text = fruitNameGallery[indexNo];
    }
}
