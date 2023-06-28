using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Gameplay : MonoBehaviour, IPointerClickHandler
{
    private int scoreValue = 0;
    public Text score;
    public static Fruit currentFruit;
    public Text fruitName;
    public AudioSource pronunciation;

    public void Start()
    {
        GenerateFruit();

    }

    public void GenerateFruit()
    {
        currentFruit = Gallery.fruits[Gallery.currentIndex];
        fruitName.text = currentFruit.name;
        pronunciation.clip = Resources.Load<AudioClip>("Assets/Media/" + currentFruit.pronunciation); ;
        print("Assets/Media/" + currentFruit.pronunciation);
        pronunciation.Play();
    }

    public void PlayAudio()
    {
        if (pronunciation.clip != null)
        {
            // Play the audio
            pronunciation.Play();
        }
        else
        {
            Debug.LogWarning("No audio clip loaded");
        }
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        scoreValue += 10;
        score.text = scoreValue.ToString();
        pronunciation.Play();
    }
}
