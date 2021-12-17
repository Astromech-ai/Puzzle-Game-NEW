using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour, IClickable
{
    float newrot;

    public void Click()
    {
        newrot += 15;
        if (newrot > 360)
        {
            newrot = 0;
        }

    }

    void Update()
    {
        Quaternion rot = transform.rotation;
        rot = Quaternion.RotateTowards(rot, Quaternion.Euler(0, 0, newrot), 2);
        transform.rotation = rot;
    }

    public void RightClick()
    {
        newrot -= 15;
        if (newrot < 0)
        {
            newrot = 360;
        }
    }




}