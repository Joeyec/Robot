using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonCtr : MonoBehaviour
{
    private bool isShow = false;
    public GameObject Description;
  

    public void ClickButton()
    {
        
        Description.SetActive(!isShow);
        isShow = !isShow;
    }

    

}
