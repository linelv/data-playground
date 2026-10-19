using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Microsoft.MixedReality.Toolkit.UI;

public class JewelryAttach : MonoBehaviour
{
    public ObjectManipulator objectManipulator;

    private float attachCooldown = 2f;
    private bool cooldownRunning = false;

    // Start is called before the first frame update
    void Start()
    {
        objectManipulator = GetComponent<ObjectManipulator>();

        if (objectManipulator != null )
        {
            objectManipulator.OnManipulationEnded.AddListener(HandleManipulationEnded);
        }
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
            attachCooldown = 2f;
        }
    }

    private void HandleManipulationEnded(ManipulationEventData eventData)
    {
        Debug.Log($"Manipulation ended on: {gameObject.name}");
    }
}
