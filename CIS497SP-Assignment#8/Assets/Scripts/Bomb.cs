/* 
 * John Mordi 
 * Bomb.cs 
 * Assignment #8
 * Handles the specific function for a bomb interactables
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : Interactables
{
    bool activated = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            activated = !activated;
        }
    }

    public override IEnumerator CountDown()
    {
        gameObject.GetComponent<MeshRenderer>().material.color = Color.white;
        yield return new WaitForSeconds(1f);
        gameObject.GetComponent<MeshRenderer>().material.color = Color.black;
        yield return new WaitForSeconds(0.5f);
        gameObject.GetComponent<MeshRenderer>().material.color = Color.white;
        yield return new WaitForSeconds(0.5f);
        gameObject.GetComponent<MeshRenderer>().material.color = Color.black;
        yield return new WaitForSeconds(0.25f);
        gameObject.GetComponent<MeshRenderer>().material.color = Color.white;
        yield return new WaitForSeconds(0.25f);
        gameObject.GetComponent<MeshRenderer>().material.color = Color.black;
        yield return new WaitForSeconds(0.25f);
        gameObject.GetComponent<MeshRenderer>().material.color = Color.white;
        yield return new WaitForSeconds(0.25f);
        gameObject.GetComponent<MeshRenderer>().material.color = Color.black;


        yield break;
    }

    public override bool IsActivated()
    {
        return activated;
    }
}
