using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class personajescript : MonoBehaviour
{
[SerializeField] float movementSpeed = 5f;
float currentSpeed;
Rigidbody rb;
Vector3 direction;

    // Start is called before the first frame update
    void Start()
    {
      rb= GetComponent<Rigidbody>();
        currentSpeed = movementSpeed;   
    }

    // Update is called once per frame
    void Update()
    {
      float MoveHorizontal = Input.GetAxis("Horizontal");
       float MoveVertical= Input.GetAxis("Vertical"); 
       direction = new Vector3(MoveHorizontal, 0, MoveVertical);
       direction=transform.TransformDirection(direction);  
    }

    void fixedUpdate()
    {
      rb.MovePosition(transform.position + direction * currentSpeed * Time.deltaTime);
    }
}
