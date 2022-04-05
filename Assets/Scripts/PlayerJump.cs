using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;


public class PlayerJump : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody rb;

    private Vector3 playerVelocity;
    private bool grounded;
    public float jumpHeight = 25.0f;
    private Vector3 gravity = new Vector3 (0.0f, -9.81f,0.0f);

    private bool dbl_jump;


    void Start()
    {
        rb = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update(){
        
    }
    bool isGround(){
        return Physics.Raycast(transform.position, Vector3.down, 0.5f);
    }
  

    void OnJump(){

   
        if(isGround()){
            grounded = true;
            Debug.Log("Grounded");
        }
        else{
            grounded = false;
            Debug.Log("Not Grounded");

        }

        if(grounded){
            Vector3 movement = new Vector3 (0.0f, jumpHeight,0.0f);
		    rb.AddForce (movement * -1.0f * -9.81f);
            dbl_jump = true;
        }
        
        else if (dbl_jump){
                Vector3 movement2 = new Vector3 (0.0f, jumpHeight,0.0f);
		        rb.AddForce (movement2 * -1.0f * -9.81f);
                dbl_jump = false;

            }

        
    }
}
    

        


