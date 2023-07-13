using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class target : MonoBehaviour
{
    public Transform Target;
    public float speedT = 10f;

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp (transform.position,Target.position,speedT * Time.deltaTime);
        transform.LookAt(Target);
    }
}
