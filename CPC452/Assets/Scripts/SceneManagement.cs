using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour
{
    public void NextScene()
    {
        // get the the current scene displayed using GetActiveScene and + 1 to go the next scene
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

        //go to a specific scene "the_scene_name"
        SceneManager.LoadScene("Workspace mouse input 1"); 
    }

    public void PrevScene()
    {
        // get the the current scene displayed using GetActiveScene and + 1 to go the next scene
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

        //go to a specific scene "the_scene_name"
        SceneManager.LoadScene("Workspace mouse input");
    }
    public void QuitGame()
    {
        Debug.Log("QUIT");
        Application.Quit();
    }
    
}
