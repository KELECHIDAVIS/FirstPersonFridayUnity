using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveMent : MonoBehaviour
{
    public CharacterController controller;
    public float speed = 12;
   

    Vector3 velocity; 
    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right *x + transform.forward * z ;
        controller.Move(move*speed*Time.deltaTime);
        
    }
}
