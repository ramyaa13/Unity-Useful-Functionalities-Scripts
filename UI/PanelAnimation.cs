using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelAnimation : MonoBehaviour
{
    public GameObject Panel;
    bool x = true;
    public void Start()
    {
        Panel.SetActive(false);
        x = true;
    }
    public void OpenPanel()
    {
        if (x == true)
        {
            Panel.SetActive(true);
            x = false;
        }
        else
        {
            Panel.SetActive(false);
            x = true;
        }
        //if (Panel != null)
        //{
        //    Animator anim = Panel.GetComponent<Animator>();
        //    if(anim != null)
        //    {
        //        bool isOpen = anim.GetBool("open");
        //        anim.SetBool("open", !isOpen);
        //    }


    }

}

