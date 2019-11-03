using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FrontDoor : MonoBehaviour
{
    [SerializeField] Text TaskText;
    IEnumerator myCor()
    {
        TaskText.text = "...";
        yield return new WaitForSeconds(1);
        TaskText.text = "check the other door";
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {

            StartCoroutine(myCor());
        }

    }
}
