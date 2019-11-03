using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
<<<<<<< HEAD
    public GameObject guard;
    public GameObject player;
=======
    public Trophies locked;
    public Transform player;
    public Transform cam;
    public Transform qte;



>>>>>>> 5a1277ea4c1c9891472780e9841fd5e40b77a769
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
<<<<<<< HEAD
=======
    public void Restart(){
        if (locked.GetLock(1)==0) { SceneManager.LoadScene("Level1"); }
        else if (locked.GetLock(2) == 0 && locked.GetLock(1) == 1) { player.transform.position = cam.transform.position; }
        else if (locked.GetLock(3) == 0 && locked.GetLock(2) == 1 && locked.GetLock(1) == 1) { player.transform.position = qte.transform.position; }
        Time.timeScale = 1f;



    }
>>>>>>> 5a1277ea4c1c9891472780e9841fd5e40b77a769





}
