using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Follow : MonoBehaviour
{
    public Transform target;

    public Vector3 position_set;

    void LateUpdate()
    {
        transform.position = target.position + position_set;
    }
}
