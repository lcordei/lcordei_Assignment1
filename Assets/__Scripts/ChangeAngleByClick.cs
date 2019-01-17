using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeAngleByClick : MonoBehaviour
{
    private Quaternion newAngle;

    void OnMouseDown()
    {
        newAngle = Quaternion.Euler(Random.value * 20, Random.value * 20, Random.value * -20);
    }

    void Update()
    {
        if(transform.rotation!= newAngle)
        transform.rotation = Quaternion.RotateTowards(transform.rotation, newAngle, 0.1f);
    }
}
