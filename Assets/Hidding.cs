using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Hidding : MonoBehaviour
{
    public GameObject player;
    public static bool disabled = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (disabled) player.SetActive(false);
        else player.SetActive(true);

    }

 
}
