using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OpenAch : MonoBehaviour
{
    [SerializeField] Text TaskText;
    public Transform Name;
    private float waittime;
    public AchievementDatabase database;
    public Trophies locked;
    public AchievementNotificationController achievementNotificationController;
    public Death end;
    public GameObject task;
    IEnumerator myCor()
    {

        int i = 0;
        switch (Name.name)
        {
            case "Cameras":
                i = 1;
                TaskText.text = "...";
                yield return new WaitForSeconds(1);
                TaskText.text = "go upstairs";
                break;
            case "QTE":
                i = 2;
                break;
            case "Painting":
                i = 3;
                break;

            default:
                i=0;
                break;
        }

        if (locked.GetLock(i) == 0)
        {
            task.SetActive(false);
            achievementNotificationController.ShowNotification(database.achievements[i]);
            locked.Unlock(i);
            locked.Date(i);
            yield return new WaitForSeconds(4);
            task.SetActive(true);
            if (i == 3)
            {
                end.End();
            }
           
        }


    }

    void OnTriggerEnter2D(Collider2D other)

    {
        waittime = 3;
        if (other.CompareTag("Player"))
        {
            //achievementNotificationController.ShowNotification(database.achievements[0]);
            StartCoroutine(myCor());
            //end.Dead();
            //SceneManager.LoadScene(levelName);

        }

    }


}