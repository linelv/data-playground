using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JewelryFollow : MonoBehaviour
{
    public Transform wristPosition;
    public float followSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float step = followSpeed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, wristPosition.position, step);
    }
}
