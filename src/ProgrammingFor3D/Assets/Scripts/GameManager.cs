using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Timeline;

public class GameManager : MonoBehaviour
{
    public GameObject collectible;
    public GameObject enemy1;
    public GameObject enemy2;
    public int playerScore = 0;
    bool achievedGoal = true;

    public bool activateEnemies = true;

    public static int playerDifficulty = 1;

    public int GetPlayerScore(){
        return playerScore;
    }

    public void SetPlayerScore(int num){
        playerScore =+ num;
    }

    public int GetPlayerDifficulty(){
        return playerDifficulty;
    }

    public void SetPlayerDifficulty(int num){
        playerDifficulty = num;
    }

    public bool GetPlayerGoal(){
        return achievedGoal;
    }

    public void SetPlayerGoal(bool input){
        achievedGoal = input;
    }
    void Start(){
        if (activateEnemies){
            Instantiate(enemy1, new Vector3(53, 0, 60), Quaternion.identity);
            Instantiate(enemy2, new Vector3(57, 0, 60), Quaternion.identity);
        }
        Instantiate(collectible, new Vector3(90, 0, 6), Quaternion.identity);
        Instantiate(collectible, new Vector3(47, 0, 7), Quaternion.identity);
        Instantiate(collectible, new Vector3(83, 5.3f, 14), Quaternion.identity);
        Instantiate(collectible, new Vector3(82.5f, 8, 26), Quaternion.identity);
        Instantiate(collectible, new Vector3(47, 0, 10.5f), Quaternion.identity);
        Instantiate(collectible, new Vector3(30, 0, 26.5f), Quaternion.identity);
        Instantiate(collectible, new Vector3(64, 0, 14), Quaternion.identity);
        Instantiate(collectible, new Vector3(68, 0, 43), Quaternion.identity);
        Instantiate(collectible, new Vector3(30, 0, 43), Quaternion.identity);
        if (playerDifficulty == 2){
            Instantiate(collectible, new Vector3(13.6f, 0, 28.7f), Quaternion.identity);
            Instantiate(collectible, new Vector3(84, 0, 46), Quaternion.identity);
            Instantiate(collectible, new Vector3(84, 0, 34), Quaternion.identity);
            Instantiate(collectible, new Vector3(84, 0, 20), Quaternion.identity);
            Instantiate(collectible, new Vector3(2.5f, 1.25f, 57), Quaternion.identity);
            Instantiate(collectible, new Vector3(12, 1.25f, 47), Quaternion.identity);
            }
        if (playerDifficulty == 3){
            Instantiate(collectible, new Vector3(14.5f, 1.25f, 52.25f), Quaternion.identity);
            Instantiate(collectible, new Vector3(4, 1.25f, 43), Quaternion.identity);
            Instantiate(collectible, new Vector3(23, 1.35f, 11), Quaternion.identity);
            Instantiate(collectible, new Vector3(18.5f, 0.2f, 11), Quaternion.identity);
            Instantiate(collectible, new Vector3(82, 9, 42), Quaternion.identity);
            Instantiate(collectible, new Vector3(13.6f, 0, 28.7f), Quaternion.identity);
            Instantiate(collectible, new Vector3(84, 0, 46), Quaternion.identity);
            Instantiate(collectible, new Vector3(84, 0, 34), Quaternion.identity);
            Instantiate(collectible, new Vector3(84, 0, 20), Quaternion.identity);
            Instantiate(collectible, new Vector3(2.5f, 1.25f, 57), Quaternion.identity);
            Instantiate(collectible, new Vector3(12, 1.25f, 47), Quaternion.identity);
        }
    }
}
