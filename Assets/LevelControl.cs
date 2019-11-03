using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelControl : MonoBehaviour
{
    public string levelName;
    private float waittime;
    public AchievementDatabase database;
    public Trophies locked;
    public AchievementNotificationController achievementNotificationController;
    public GameObject task;

    IEnumerator myCor()
    {
        task.SetActive(false);
        achievementNotificationController.ShowNotification(database.achievements[0]);
        locked.Unlock(0);
        locked.Date(0);
        yield return new WaitForSeconds(3);
        //task.SetActive(true);

        SceneManager.LoadScene(levelName);
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
