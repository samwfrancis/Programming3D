using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int playerScore = 0;
    bool achievedGoal = true;

    int playerDifficulty = 1;

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
}