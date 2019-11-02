using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour
{
    public GameObject death;
    public GameObject end;
    public GameObject pau;
    public GameObject joy; 
    public GameObject but;
    public GameObject task;

    public void Dead(){
        death.SetActive(true);
        but.SetActive(false);
        joy.SetActive(false);
        pau.SetActive(false);
        task.SetActive(false);
        Time.timeScale = 0f;

    }

    public void End()
    {
        end.SetActive(true);
        but.SetActive(false);
        joy.SetActive(false);
        task.SetActive(false);
        pau.SetActive(false);
        Time.timeScale = 0f;

    }
}
