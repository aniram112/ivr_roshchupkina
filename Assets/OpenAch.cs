using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class OpenAch : MonoBehaviour
{

    public Transform Name;
    private float waittime;
    public AchievementDatabase database;
    public Trophies locked;
    public AchievementNotificationController achievementNotificationController;

    IEnumerator myCor()
    {
        int i = 0;
        switch (Name.name)
        {
            case "Cameras":
                i = 1;
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
    

        achievementNotificationController.ShowNotification(database.achievements[i]);
        locked.Unlock(i);
        yield return new WaitForSeconds(3);

    }

    void OnTriggerEnter2D(Collider2D other)

    {
        waittime = 3;
        if (other.CompareTag("Player"))
        {
            //achievementNotificationController.ShowNotification(database.achievements[0]);
            StartCoroutine(myCor());
            //SceneManager.LoadScene(levelName);

        }

    }


}