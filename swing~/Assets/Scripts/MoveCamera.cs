using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    public Transform CameraPosition;
    // 在第一帧前调用
    void Start()
    {
        
    }

    // 每帧都调用
    void Update()
    {
        transform.position = CameraPosition.position;
    }
}
