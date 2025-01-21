using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    [SerializeField] private AudioSource coin;
    [SerializeField] private AudioClip coinAudio;
    public GameObject myManager;
    GameManager manager;

    void Start(){
        myManager = GameObject.Find("Game Manager");
        manager = myManager.GetComponent<GameManager>();
    }
    private void OnTriggerEnter(Collider other){
        if(other.CompareTag("Ball")){
            manager.SetPlayerScore(1);
            coin.PlayOneShot(coinAudio);
            Debug.Log("Coin");
            Destroy(gameObject);
        }
            
    }
}
