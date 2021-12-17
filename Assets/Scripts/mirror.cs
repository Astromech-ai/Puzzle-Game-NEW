using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mirror : MonoBehaviour
{
    [SerializeField] private float defDistanceRay = 100;
    public Transform laserFirePoint;
    public LineRenderer m_lineRenderer;
    void Draw2DRay(Vector2 startPos, Vector2 endPos)
    {
        m_lineRenderer.SetPosition(0, startPos);
        m_lineRenderer.SetPosition(1, endPos);

    }
    public void Mirror()
    {

        if (Physics2D.Raycast(laserFirePoint.position, transform.right))
        {

            RaycastHit2D hit = Physics2D.Raycast(laserFirePoint.position, transform.right);
            Draw2DRay(laserFirePoint.position, hit.point);
            if (hit.transform.tag == "Mirror" && hit.transform.gameObject != gameObject)
            {
                hit.transform.GetComponent<mirror>().Mirror();
            }
        }
        else
        {
            Draw2DRay(laserFirePoint.position, laserFirePoint.transform.right * defDistanceRay);
        }

      
    }

 
}
