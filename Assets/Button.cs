using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    public GameObject player;
    public void Hide()
    {   
        if (Hidding.disabled == false && gg.able_to_hide) Hidding.disabled = true;
        else Hidding.disabled = false;
        
     
    }

  


}
