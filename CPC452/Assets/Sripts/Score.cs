using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Score : MonoBehaviour
{
    private int scoreValue = 0;
    public Text score;
    public static Fruit currentFruit;
    public Text fruitName;

    public void Start()
    {
        GenerateNewFruit();
    }

    public void GenerateFruit()
    {
        currentFruit = Gallery.fruits[Gallery.currentIndex];
        fruitName.text = currentFruit.name;
        Debug.Log(currentFruit.name);
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        scoreValue += 10;
        score.text = scoreValue.ToString();
    }
}
