using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinionManager : MonoBehaviour {

    [SerializeField] private GameObject[] spawners;
    [SerializeField] private GameObject minion;

    TurnManager tm;

    private void Start()
    {
        spawners = GameObject.FindGameObjectsWithTag("Spawner");
        tm = GetComponent<TurnManager>();
    }

    public void MinionMove()
    {

    }

    public void MinionAttack()
    {

    }

    public void MinionSpawn()
    {
        for(int i = 0; i < spawners.Length; i++)
        {
            Instantiate(minion, new Vector3(spawners[i].transform.position.x, spawners[i].transform.position.y), Quaternion.identity);
            Debug.Log(i);
            tm.currentTurn = TurnManager.Turns.MinionMove;
        }
    }
}
