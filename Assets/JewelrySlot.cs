using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Microsoft.MixedReality.Toolkit.UI;

public class JewelrySlot : MonoBehaviour
{
    private Vector3 originalScale = Vector3.zero;
    public ObjectManipulator objectManipulator;
    
    private float attachCooldown = 0.1f;
    private bool cooldownRunning = false;
    public GameObject currentPocket;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (cooldownRunning == true)
        {
            attachCooldown -= Time.deltaTime;
            Debug.Log(attachCooldown);
        }

        if (attachCooldown <= 0)
        {
            cooldownRunning = false;
            attachCooldown = 0.1f;
        }
    }

    private void OnTriggerEnter(Collider other)
    {


        if (other.CompareTag("Pocket") && cooldownRunning == false && currentPocket == null)
        {
            Debug.Log("Pocket Entered.");
            objectManipulator = other.GetComponent<ObjectManipulator>();
            objectManipulator.ForceEndManipulation();

            currentPocket = other.gameObject;
            other.transform.SetParent(transform, true);
            other.transform.localPosition = new Vector3(0f, -0.02f, 0f);
            originalScale = other.transform.localScale;
            other.transform.localScale = new Vector3(0.05f, 0.05f, 0.05f);
            cooldownRunning = true;

        }


    }

    private void OnTriggerExit(Collider other)
    {
        

        if (other.gameObject == currentPocket && cooldownRunning == false)
        {
            Debug.Log("Pocket Exited.");
            
            currentPocket = null;
            other.transform.SetParent(null, true);
            other.transform.localScale = originalScale;
            cooldownRunning = true;

        } else if (other.gameObject != currentPocket)
        {
            return;
        }
    }
}
