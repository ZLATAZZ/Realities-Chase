using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


public class Drag3D : MonoBehaviour
{
    [HideInInspector]
    public bool isMove = false;
    [HideInInspector]
    public bool isDrag;

    private Vector3 offset;

    private void Start()
    {
        isDrag = true;
    }
    private void OnMouseDown()
    {
        if (isDrag == true)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitRay;
            if (Physics.Raycast(ray, out hitRay))
            {
                if (hitRay.collider != null)
                {
                    isMove = true;

                    //callculate the offset between object, and ray point, from the cursor
                    offset = transform.position - hitRay.point;
                }
                Debug.DrawLine(ray.origin, hitRay.point);

            }

        }
        

    }

    private void OnMouseDrag()
    {
        if (isMove && isDrag) {

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitRay;

            if (Physics.Raycast(ray, out hitRay))
            {

                //transform.position = hitRay.point + offset;
                transform.position = new Vector3(hitRay.point.x + offset.x, hitRay.point.y + offset.y, transform.position.z);
                Debug.DrawLine(ray.origin, hitRay.point);


            }

        }
    }
    private void OnMouseUp()
    {
        isMove=false;
    }

}
