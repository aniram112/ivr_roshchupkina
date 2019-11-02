using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AchievementManager : MonoBehaviour
{
    public AchievementDatabase database;
    public AchievementNotificationController achievementNotificationController;

    public Achievements achievementToShow;

    public AchievementDropdown achievementDropdown;

    public void Start()
    {
        achievementDropdown.onValueChanged += ChangeAchievement;
    }

    public void ShowNotification()
    {
        Achievement achievement = database.achievements[(int)achievementToShow];
        Debug.Log((int)achievementToShow);

        achievementNotificationController.ShowNotification(achievement);
    }

    public void ChangeAchievement (Achievements ach)
    {
        achievementToShow = ach;
    }
}
