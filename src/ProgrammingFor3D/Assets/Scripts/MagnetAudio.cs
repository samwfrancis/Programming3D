using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagnetAudio : MonoBehaviour
{
    [SerializeField] private AudioSource magnetise;
    [SerializeField] private AudioClip magnetiseAudio;

    public void PlayMagnetAudio(){
        magnetise.PlayOneShot(magnetiseAudio);
    }
}
