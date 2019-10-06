using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Stairs : MonoBehaviour
{
    public string levelName;
    public Transform player;
    public Transform destination;
    public Joystick joystick;
    public float joy2;
    public float joy1;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && joy1<=joystick.Vertical && joystick.Vertical<=joy2)
        {
            player.transform.position = destination.transform.position;

        }


    }


}
