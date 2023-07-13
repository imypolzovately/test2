using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermove : MonoBehaviour
{
    public float speed = 10f;
    private Rigidbody rb;
    public float speedRotate = 10f;
    public Transform cameraTransform;
    public bool isGrounded;
    public float spaceY = 200f;

    void OnCollisionEnter()
    {
        isGrounded = true;
    }
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
     

        float inputHorizontal = Input.GetAxis("Horizontal");
        float inputVertical = Input.GetAxis("Vertical");
        float inputMouseX = Input.GetAxis("Mouse X");
        float inputMouseY = Input.GetAxis("Mouse Y");


        transform.Rotate(0, inputMouseX * speedRotate, 0);
        rb.MovePosition(rb.position + (transform.forward * inputVertical + transform.right * inputHorizontal) * speed * Time.deltaTime);
        cameraTransform.Rotate(-inputMouseY * speedRotate, 0, 0);
        if (Input.GetKeyDown(KeyCode.Space)&& isGrounded)
        {
            isGrounded = false;
            GetComponent<Rigidbody>().AddForce(new Vector3(0, spaceY, 0));

        }

        
        
            
       




    }
}
