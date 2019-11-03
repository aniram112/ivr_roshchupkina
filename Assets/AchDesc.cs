using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AchDesc : MonoBehaviour

{
    public AchievementDatabase database;
    public Trophies locked;

    [SerializeField] Text DescText;

    public void Description(int i)
    {

        DescText.text = database.achievements[i].description;
    }
    public void Date(int i)
    {

        DescText.text = locked.GetDate(i);
    }
}

