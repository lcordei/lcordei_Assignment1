using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraAngleByButton : MonoBehaviour
{
    private bool angle1 = true;
    private bool angle2 = false;
   void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            angle1 = !angle1;
            angle2 = !angle2;
        }
        if (angle1 == true)
        {
            gameObject.transform.position = new Vector3(0, 10, 22);
            gameObject.transform.rotation = Quaternion.Euler(20, 180, 0);
        }
        else if (angle2==true)
        {
            gameObject.transform.position = new Vector3(0, 20, 0);
            gameObject.transform.rotation = Quaternion.Euler(90, 180, 0);
        }
    }
}
