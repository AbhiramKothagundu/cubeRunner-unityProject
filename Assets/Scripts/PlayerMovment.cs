using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovment : MonoBehaviour
{
    [SerializeField] private float playerSpeed;
    [SerializeField] Rigidbody rb;
    private void FixedUpdate()
    {
        //float xMov = Input.GetAxisRaw("Horizontal");
        //float zMov = Input.GetAxisRaw("Vertical");
        //transform.position += new Vector3(xMov * playerSpeed * Time.deltaTime, 0, zMov * playerSpeed * Time.deltaTime);


        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(-playerSpeed * Time.deltaTime, 0, 0, ForceMode.Impulse);
        }else if(Input.GetKey(KeyCode.D))
        {
            rb.AddForce(playerSpeed * Time.deltaTime, 0,0, ForceMode.Impulse);
        }else if (Input.GetKey(KeyCode.W)) 
        {
            rb.AddForce(0, 0, playerSpeed * Time.deltaTime, ForceMode.Impulse);
        }else if( Input.GetKey(KeyCode.S))
        {
            rb.AddForce(0, 0, -playerSpeed * Time.deltaTime, ForceMode.Impulse);
        }

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "void")
        {
            SceneManager.LoadScene(0);
        }
    }
}
