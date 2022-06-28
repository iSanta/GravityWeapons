using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    [SerializeField] Transform cameraPos;

    void Update()
    {
        transform.position = cameraPos.position;
    }
}
