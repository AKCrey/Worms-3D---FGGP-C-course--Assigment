using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    [SerializeField] private float speed = 2f;
    [SerializeField] private Rigidbody characterBody;
    
    void Update()
    {
        if (Input.GetAxis("Horizontal") != 0)
        {
            transform.Translate(transform.right * speed * Time.deltaTime * Input.GetAxis("Horizontal"));
        }

        if (Input.GetAxis("Vertical") != 0)
        {
            transform.Translate(transform.forward * speed * Time.deltaTime * Input.GetAxis("Vertical"));
        }


        /*private bool IsTouchingFloor()
        {
            RaycastHit hit;
            
            //Parameters:
            // - The center from where we shoot
            // - Radius of the sphere
            // - Direction of the sphere
            // - hit parameter
            // - Distance the sphere
            return Physics.SphereCast(transform.position, 0.15f, -transform.up, out hit, 1f);
            
        }*/

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
        
        
    }
    private void Jump()
    {
        //characterBody.velocity = Vector3.up * 10f;
        characterBody.AddForce(Vector3.up * 500f);
    }
}
