using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnManager : MonoBehaviour {

    private MinionManager minionMan;

    public enum Turns
    {
        PickCommandCard,
        PlayCommandLine,
        MinionSpawn,
        MinionMove,
        MinionAttack
    };

    public Turns currentTurn = Turns.PickCommandCard;

    private void Start()
    {
        minionMan = GetComponent<MinionManager>();
        TurnStateCheck();
    }

    private void Update()
    {
        ChangeTurnDevKit(); 
    }

    private void TurnStateCheck()
    {
        Debug.Log("Changed to: " + currentTurn);
        switch (currentTurn)
        {
            case Turns.PickCommandCard:
                break;
            case Turns.PlayCommandLine:
                break;
            case Turns.MinionMove:
                minionMan.MinionMove();
                break;
            case Turns.MinionSpawn:
                minionMan.MinionSpawn();
                break;
            case Turns.MinionAttack:
                minionMan.MinionAttack();
                break;
        }
    }

    private void ChangeTurnDevKit()
    {
        if (Input.GetKeyDown(KeyCode.Keypad1))
        {
            currentTurn = Turns.PickCommandCard;
            TurnStateCheck();
        }
        else if (Input.GetKeyDown(KeyCode.Keypad2))
        {
            currentTurn = Turns.PlayCommandLine;
            TurnStateCheck();
        }
        else if (Input.GetKeyDown(KeyCode.Keypad3))
        {
            currentTurn = Turns.MinionMove;
            TurnStateCheck();
        }
        else if (Input.GetKeyDown(KeyCode.Keypad4))
        {
            currentTurn = Turns.MinionSpawn;
            TurnStateCheck();
        }
        else if (Input.GetKeyDown(KeyCode.Keypad5))
        {
            currentTurn = Turns.MinionAttack;
            TurnStateCheck();
        }
    }
}
