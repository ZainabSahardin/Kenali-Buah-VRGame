using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void Home()
    {
        //go to a specific scene "the_scene_name"
        SceneManager.LoadScene("01 MAIN MENU"); 
    }

    public void Gallery()
    {
        //go to a specific scene "the_scene_name"
        SceneManager.LoadScene("02 GALLERY"); 
    }

    public void PlayGame()
    {
        // get the the current scene displayed using GetActiveScene and + 1 to go the next scene
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

        //go to a specific scene "the_scene_name"
        SceneManager.LoadScene("03 PLAY"); 
    }

    public void QuitGame()
    {
        Debug.Log("QUIT");
        Application.Quit();
    }

}
