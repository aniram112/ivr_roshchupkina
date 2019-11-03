using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    public GameObject guard;
    public GameObject player;
    public void Menu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void Pausa(){
        Time.timeScale = 0f;
    }
    public void Continue()
    {
        Time.timeScale = 1f;
    }





}
