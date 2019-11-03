using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Dropdown))]
public class AchievementDropdown : MonoBehaviour
{
    private Dropdown m_dropdown;
    private Dropdown Dropdown{
        get {
            if (m_dropdown == null)
            {
                m_dropdown = GetComponent<Dropdown>();

            }
            return m_dropdown;
        }

    }

    public Action<Achievements> onValueChanged;

    private void Start()
    {

        Dropdown.onValueChanged.AddListener(HandleDropdown);
       
    }



    [ContextMenu("UpdateOptions()")]
    public void UpdateOptions(){
        Dropdown.options.Clear();
        var values = Enum.GetValues(typeof(Achievements));
        foreach (Achievements achievement in values){
            Dropdown.options.Add(new Dropdown.OptionData(achievement.ToString()));
        }
        Dropdown.RefreshShownValue();

    
    }

    private void HandleDropdown(int value){
        if (onValueChanged != null){
            onValueChanged((Achievements)value);
        }
    }

}
