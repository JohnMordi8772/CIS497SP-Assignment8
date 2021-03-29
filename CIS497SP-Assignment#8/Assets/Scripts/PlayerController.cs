/* 
 * John Mordi 
 * PlayerController.cs 
 * Assignment #8
 * Gives control of an object to the player
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W))
        {
            gameObject.transform.Translate(Vector3.left * 15 * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.A))
        {
            gameObject.transform.Translate(Vector3.back * 15 * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.S))
        {
            gameObject.transform.Translate(Vector3.right * 15 * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.D))
        {
            gameObject.transform.Translate(Vector3.forward * 15 * Time.deltaTime);
        }
        if(Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
