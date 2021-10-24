using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//TODO: add namespace areas

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public Vector3 userOffset;
    private Vector3 offset;
    
    [Range(0.01f, 1.0f)] public float smooth = 0.5f;

    public bool lookAtTarget;
    public bool autoUpdate;

    void Start()
    {
        SetCameraOffset();
    }

    void LateUpdate()
    {
        Vector3 newPos = target.position + offset;
        transform.position = Vector3.Slerp(transform.position, newPos, smooth);

        if (lookAtTarget)
            transform.LookAt(target);
    }
    public void UpdateCameraOffset()
    {
        transform.position = userOffset;
        SetCameraOffset();
        
        if (lookAtTarget)
            transform.LookAt(target);
    }

    void SetCameraOffset()
    {
        offset = transform.position - target.position;
    }
}
