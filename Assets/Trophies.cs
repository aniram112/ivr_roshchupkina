using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trophies : MonoBehaviour
{
    public static int[] Locked = new  int[5] {0,0,0,0,0};
    public GameObject[] ach = new GameObject[5];

    void Update()
    {
        for (int i = 0; i < 5;i++){
            if (Locked[i] == 0) ach[i].SetActive(false);
            else ach[i].SetActive(true);
        }
    }

    public void Unlock(int a){
        Locked[a] = 1;
    }
}
