using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetByClick : MonoBehaviour
{
    private Vector3 originalPosition;
    private Quaternion originalRotation;
    private Rigidbody rb;
    
    void Start()
    {
        originalPosition = gameObject.transform.position;
        originalRotation = gameObject.transform.rotation;
    }

    void OnMouseOver()
    {
        if (Input.GetMouseButton(1))
        {
            rb = GetComponent<Rigidbody>();
            gameObject.transform.position = originalPosition;
            rb.velocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;
            rb.rotation = originalRotation;
        }
    }

    
}
