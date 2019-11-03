using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QTE : MonoBehaviour
{
    public Joystick joystick;
    public GameObject one;
    public GameObject two;
    public GameObject three;
    public GameObject four;
    public GameObject five;
    public Transform TriggerQTE;
    public Transform FinishQTE;
    public bool inQTE;
    public Transform gg;
    public Death ded;
    public int[] passed= new int[5] { 0, 0, 0, 0, 0 };
    public bool AisP;
    public static bool done;
    private bool correct;
    public static bool failed;



    private void Start()
    {
        AisP = false;
        done = false;
        correct = false;
        failed = false;
        passed = new int[5] { 0, 0, 0, 0, 0 };
    }


    public void ButA()
    {
        AisP = true;
    }

    IEnumerator myCor()
    {
        yield return new WaitForSeconds(10);
        if (!correct || !done)
        {
            failed = true;
            one.SetActive(false);


        }
    }


    void FixedUpdate(){
        Debug.Log(joystick.Horizontal);

        if (gg.position.x >= TriggerQTE.position.x && Mathf.Abs(gg.position.y - TriggerQTE.position.y)<=10 && !done)
        {   if (!failed) { 
                one.SetActive(true);
             }
            if (joystick.Vertical >= 0.9 && passed[0] == 0)
            {
                //one.SetActive(true);
                two.SetActive(true);
                correct = true;
                StartCoroutine(myCor());
                passed[0] = 1;
            }
            if (joystick.Horizontal >= 0.9 && passed[0] == 1 && passed[1] == 0)
            {
                //one.SetActive(true);
                three.SetActive(true);
                correct = true;
                StartCoroutine(myCor());
                passed[1] = 1;
            }
            if (AisP && passed[1] == 1 & passed[2] == 0)
            {
                //one.SetActive(true);
                four.SetActive(true);
                correct = true;
                StartCoroutine(myCor());
                passed[2] = 1;
            }
            if (joystick.Vertical <= -0.9 && passed[2] == 1 && passed[3] == 0)
            {
                //one.SetActive(true);
                five.SetActive(true);
                correct = true;
                StartCoroutine(myCor());
                passed[3] = 1;
            }
            if (joystick.Horizontal <= -0.9 && passed[3] == 1 && passed[4] == 0)
            {
                //one.SetActive(true);
                correct = true;
                StartCoroutine(myCor());
                passed[4] = 1;
            }

            if (passed[4] == 1 && !done)
            {

                gg.transform.position = FinishQTE.transform.position;
                done = true;
                one.SetActive(false);
                two.SetActive(false);
                three.SetActive(false);
                four.SetActive(false);
                five.SetActive(false);
            }
            else if (!done)
            {

                StartCoroutine(myCor());
            }

        }
        else{
            one.SetActive(false);
            two.SetActive(false);
            three.SetActive(false);
            four.SetActive(false);
            five.SetActive(false);
            failed = false;
            passed = new int[5] { 0, 0, 0, 0, 0 };
        }
       // Debug.Log(joystick.Horizontal);
    }
}
