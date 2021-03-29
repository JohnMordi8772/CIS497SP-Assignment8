/* 
 * John Mordi 
 * HealingItem.cs 
 * Assignment #8
 * Handles the specific function for a healing item interactables
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealingItem : Interactables
{
    bool activated = true;
    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log(this.GetType());
    }

    // Update is called once per frame
    void Update()
    {
       if(Input.GetKeyDown(KeyCode.Alpha2))
        {
            activated = !activated;
        }
    }

    public override IEnumerator CountDown()
    {
        for (int i = 1; i <= 3; i++)
        {
            gameObject.GetComponent<Rigidbody>().AddTorque(new Vector3(0, 20*i, 0), ForceMode.Acceleration);
            yield return new WaitForSeconds(1);
        }

        gameObject.GetComponent<Rigidbody>().AddTorque(new Vector3(0, -30, 0), ForceMode.Acceleration);

        yield break;
    }

    public override bool IsActivated()
    {
        return activated;
    }
}
