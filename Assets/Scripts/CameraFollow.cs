using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform cameraPoint;
    [SerializeField] private Vector3 mesafe;

    private void LateUpdate()
    {
        transform.position = cameraPoint.position + mesafe;
        transform.LookAt(cameraPoint);
    }
}
