using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class newScript : MonoBehaviour
{
    public TextMeshProUGUI displayFruitName2;
    public string[] fruitName2;
    public GameObject[] fruit2;
    int fruitNameIndex = 0;

    Renderer rend;
    public Material correctMaterial;
    public Material wrongMaterial;
    
    private int scoreValue = 0;
    public TextMeshProUGUI score;
    public TextMeshProUGUI message;

    private void Start()
    {
        rend = GetComponent<Renderer>();
        rend.enabled = true;

        displayFruitName2.text = fruitName2[fruitNameIndex];
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Fruit")
        {

            if (col.gameObject.name == fruitName2[fruitNameIndex])
            {
                rend.sharedMaterial = correctMaterial;
                scoreValue += 10;
                score.text = scoreValue.ToString();
                message.text = "Correct!";

                Destroy(col.gameObject);
                SetNextFruit();
            }
            else
            {
                rend.sharedMaterial = wrongMaterial;
                scoreValue -= 5;
                score.text = scoreValue.ToString();
                message.text = "Wrong!";
            }
                
        }
    }

    public void SetNextFruit()
    {
        fruitNameIndex++;
        displayFruitName2.text = fruitName2[fruitNameIndex];

        // Save the score value
        PlayerPrefs.SetInt("Score", scoreValue);
        PlayerPrefs.Save();     
    }

}
