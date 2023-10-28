using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerController : MonoBehaviour
{
    public bool isGrabbing = false;
    public  GameObject grabbedObject;
    private Bottle bottle;

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // 鼠标左键按下,抓取
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.CompareTag("Material"))
                {
                    isGrabbing = true;
                    grabbedObject = hit.collider.gameObject;
                    grabbedObject.GetComponent<Rigidbody>().isKinematic = true;
                }
            }
        }
        else if (Input.GetMouseButtonUp(0)) // 鼠标左键松开
        {
            if (isGrabbing)
            {
                if (bottle != null)
                {
                    bottle.AddMaterial(grabbedObject);
                }
                grabbedObject.GetComponent<Rigidbody>().isKinematic = false;
                isGrabbing = false;
            }
        }
    }

    public void SetBottle(Bottle _bottle)
    {
        bottle = _bottle;
    }
}
