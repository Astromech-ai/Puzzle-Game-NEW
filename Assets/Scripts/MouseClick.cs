using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseClick : MonoBehaviour
{
    Camera cam;
    RaycastHit2D hit;

    // Start is called before the first frame update
    void Start()
    {
        cam = GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
        hit = Physics2D.Raycast(mousePos, Vector3.zero);
        if (hit.transform != null)
        {
            if (Input.GetMouseButtonDown(0) && hit.transform.GetComponent(typeof(IClickable)) != null)
            {
                IClickable celeb = hit.transform.GetComponent(typeof(IClickable)) as IClickable;
                celeb.Click();
            }
        }
            

        
    }
}

