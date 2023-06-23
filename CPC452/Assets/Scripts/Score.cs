using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Score : MonoBehaviour, IPointerClickHandler
{
    private int scoreValue = 0;
    public Text score;

    public void OnPointerClick(PointerEventData eventData)
    {
        scoreValue += 10;
        score.text = scoreValue.ToString();
    }
}
