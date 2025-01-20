using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour
{
    public GameObject gameManager;

    GameManager manager;

    void Start(){
        manager = gameManager.GetComponent<GameManager>();
    }
    void OnTriggerEnter(Collider other){
        if(other.CompareTag("Ball")){
            if(manager.GetPlayerDifficulty() == 1){
                if(manager.GetPlayerScore() == 10){
                    SceneManager.LoadScene("Winner");
                    manager.SetPlayerGoal(true);
                }
            }
            if(manager.GetPlayerDifficulty() == 2){
                if(manager.GetPlayerScore() == 15){
                    SceneManager.LoadScene("Winner");
                    manager.SetPlayerGoal(true);
                }
            }
            if(manager.GetPlayerDifficulty() == 3){
                if(manager.GetPlayerScore() == 20){
                    SceneManager.LoadScene("Winner");
                    manager.SetPlayerGoal(true);
                }
            }
        }
    }
}
