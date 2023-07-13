using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooting : MonoBehaviour
{
    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            RaycastHit hit;
            if (Physics.Raycast(transform.position, transform.forward, out hit,100f))
            {
                Destroy(hit.collider.gameObject);
            }
        }
    }
}
