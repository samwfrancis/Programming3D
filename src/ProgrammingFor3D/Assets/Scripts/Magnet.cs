using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Magnet : MonoBehaviour
{
    public float force = 200f;

    List<Rigidbody> rgObjects = new List<Rigidbody>();

    Transform magnetPoint;
    
    void Start()
    {
        magnetPoint = GetComponent<Transform>(); 
    }

    private void FixedUpdate()
    {
        foreach(Rigidbody rgObject in rgObjects)
        {
            rgObject.AddForce((magnetPoint.position - rgObject.position) * force * Time.fixedDeltaTime);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball"))
            rgObjects.Add(other.GetComponent<Rigidbody>());
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Ball"))
            rgObjects.Remove(other.GetComponent<Rigidbody>());
    }
}
