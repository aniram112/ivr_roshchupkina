using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public Trophies locked;
    public void PlayGame(){
        if (locked.GetLock(0) == 0 || locked.GetLock(3) == 1) {
            Time.timeScale = 1f;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

        else 
        {
            Time.timeScale = 1f;
            SceneManager.LoadScene("Level1");
        }
       

    }

}
