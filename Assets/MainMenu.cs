using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
<<<<<<< HEAD
    public void PlayGame(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
=======
    public Trophies locked;
    public void PlayGame(){
        if (locked.GetLock(0) == 0 || locked.GetLock(4) == 1) {
            Time.timeScale = 1f;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

        else 
        {
            Time.timeScale = 1f;
            SceneManager.LoadScene("Level1");
        }
       
>>>>>>> 5a1277ea4c1c9891472780e9841fd5e40b77a769
    }

}
