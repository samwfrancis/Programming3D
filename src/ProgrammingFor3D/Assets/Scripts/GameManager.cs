using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    int playerScore = 0;
    bool achievedGoal = true;

    public int GetPlayerScore(){
        return playerScore;
    }

    public void SetPlayerScore(int num){
        playerScore =+ num;
    }
}