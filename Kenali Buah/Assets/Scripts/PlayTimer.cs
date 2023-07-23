using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;
using UnityEngine.SceneManagement;

public class PlayTimer : MonoBehaviour
{
    public Image uiFill;
    public TextMeshProUGUI uiText;

    public int Duration;

    private int remainingDuration;

    private bool Pause;

    private void Start()
    {
        remainingDuration = Duration;
        StartCoroutine(UpdateTimer());
    }

    private IEnumerator UpdateTimer()
    {
        while(remainingDuration >= 0)
        {
            if (!Pause)
            {
                uiText.text = $"{remainingDuration}";
                uiFill.fillAmount = Mathf.InverseLerp(0, Duration, remainingDuration);
                remainingDuration--;
                yield return new WaitForSeconds(1f);
            }
            yield return null;
        }
        OnEnd();
    }

    private void OnEnd()
    {
        print("Time's Up!");
        //go to a specific scene "the_scene_name"
        SceneManager.LoadScene("04 ENDING"); 
    }
}
