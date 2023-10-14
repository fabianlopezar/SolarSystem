using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DraggObject3D : MonoBehaviour
{
    Vector3 mOffset;
    float coorZ;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void OnMouseDrag()
    {
        transform.position = GetMPosition() - mOffset;

    }

    private void OnMouseDown()
    {
        if (rb && rb.useGravity)
        {
            rb.useGravity = false;
        }

        coorZ = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;
        mOffset = gameObject.transform.position - GetMPosition();
    }

    private Vector3 GetMPosition()
    {
        Vector3 mouseP = Input.mousePosition;
        mouseP.z = coorZ;
        return Camera.main.ScreenToWorldPoint(mouseP);
    }

    void Update()
    {

    }
}
/*
 public class DraggObject3D : MonoBehaviour
{
    Vector3 mOffset;
    float coorZ;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void OnMouseDrag()
    {
        transform.position = GetMPosition() - mOffset;

    }

    private void OnMouseDown()
    {
        if(rb && rb.useGravity)
        {
            rb.useGravity = false;
        }

        coorZ = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;
        mOffset = gameObject.transform.position - GetMPosition();
    }

    private Vector3 GetMPosition()
    {
        Vector3 mouseP = Input.mousePosition;
        mouseP.z = coorZ;
        return Camera.main.ScreenToWorldPoint(mouseP);
    }

    void Update()
    {
        
    }
}*/