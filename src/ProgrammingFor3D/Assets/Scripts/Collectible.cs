using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    public GameObject myManager;
    GameManager manager;

    void Start(){
        manager = myManager.GetComponent<GameManager>();
    }
    private void OnTriggerEnter(Collider other){
        if(other.CompareTag("Ball")){
            manager.SetPlayerScore(1);
            Debug.Log(manager.GetPlayerScore());
            Destroy(gameObject);
        }
            
    }
}
