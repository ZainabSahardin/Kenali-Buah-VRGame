using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EndingScript : MonoBehaviour
{
    
    public TextMeshProUGUI score;

    // Start is called before the first frame update
    void Start()
    {
        // Retrieve the saved score value
        int scoreValue = PlayerPrefs.GetInt("Score", 0);
    
        // Use the score value as needed (e.g., display it on a UI element)
        score.text = scoreValue.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
