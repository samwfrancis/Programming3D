using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class EnemyNavigation : MonoBehaviour
{
    [SerializeField] private Transform movePositionTransform;

    private NavMeshAgent navMeshAgent;

    private void Awake(){
        navMeshAgent = GetComponent<NavMeshAgent>();
    }
    // Start is called before the first frame update
    void Start()
    {
        movePositionTransform = GameObject.Find("PlayerArmature").transform;
    }

    // Update is called once per frame
    void Update()
    {
        
        navMeshAgent.destination = movePositionTransform.position;
    }

    
}
