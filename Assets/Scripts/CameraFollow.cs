using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    // Start is called before the first frame updateusing UnityEngine;

public Transform cam;
void Update()
{
  transform.LookAt(cam);
}
}
