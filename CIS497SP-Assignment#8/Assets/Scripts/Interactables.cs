/* 
 * John Mordi 
 * Interactables.cs 
 * Assignment #8
 * Handles the necessary functions for all interactables and sets abstract functions for all interactables 
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.UI;

public abstract class Interactables : MonoBehaviour
{
    public GameObject detonation;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
            StartCoroutine(Triggered());
    }

    public IEnumerator Triggered()
    {
        if (IsActivated())
        {
            StartCoroutine(CountDown());

            yield return new WaitForSeconds(3f);

            StartCoroutine(Detonate());
        }

        yield break;
    }

    public abstract IEnumerator CountDown();

    public IEnumerator Detonate()
    {
        detonation.SetActive(true);

        yield return new WaitForSeconds(0.5f);

        detonation.SetActive(false);

        yield break;
    }

    public virtual bool IsActivated()
    {
        return true;
    }
}
