using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetByClick : MonoBehaviour
{
    public float x;
    public float y;
    public float z;
    private Rigidbody rb;

    void OnMouseOver()
    {
        if (Input.GetMouseButton(1))
        {
            rb = GetComponent<Rigidbody>();
            gameObject.transform.position = new Vector3(x, y, z);
            rb.velocity = new Vector3(0f, 0f, 0f);
            rb.angularVelocity = new Vector3(0f, 0f, 0f);
            rb.rotation = Quaternion.Euler(0f, 0f, 0f);
        }
    }

    
}
