using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CylinderRotate : MonoBehaviour
{
    Touch touch;
    Quaternion rotationY;
    public float rotateSpeed;
    private void Update()
    {
        if (Input.touchCount > 0)
        {
            touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Moved)
            {
                rotationY = Quaternion.Euler(0f, -touch.deltaPosition.x * rotateSpeed, 0f);
                transform.rotation = rotationY*transform.rotation;
            }
        }
    }
}
