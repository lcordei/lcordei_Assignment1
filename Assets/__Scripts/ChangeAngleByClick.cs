using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeAngleByClick : MonoBehaviour
{
    void OnMouseDown()
    {
        
            gameObject.transform.rotation = Quaternion.Euler(Random.value*20, Random.value*20, Random.value*-20);
        
    }
}
