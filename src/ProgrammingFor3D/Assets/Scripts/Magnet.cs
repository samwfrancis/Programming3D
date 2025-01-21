using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Magnet : MonoBehaviour
{
    [SerializeField] private AudioSource magnetise;
    [SerializeField] private AudioClip magnetiseAudio;

    public float force = 200f;

    List<Rigidbody> rgObjects = new List<Rigidbody>();
    

    Transform magnetPoint;

    public GameObject magnet;
    
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
            PlayMagnetAudio();
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Ball"))
            rgObjects.Remove(other.GetComponent<Rigidbody>());
            StopMagnetAudio();
    }

    public void PlayMagnetAudio(){
        magnetise.PlayOneShot(magnetiseAudio);
    }

    public void StopMagnetAudio(){
        magnetise.Stop();
    }
}