using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankPawn : Pawn
{
   

    // Start is called before the first frame update
    public override void Start()
    {

        base.Start();
        
    }

    // Update is called once per frame
    public override void Update()
    {

        base.Start();

    }



    //Tank Controls && Debugging//
    public override void MoveForward()
    {
        Debug.Log("Move Forward!");
    }
    public override void MoveBackward()
    {
        Debug.Log("Move Backward!");
    }
    public override void TurnClockwise()
    {
        Debug.Log("Turn Wisely!");
    }
    public override void TurnCounterClockwise()
    {
        Debug.Log("Turn Counter-Wisely!");
    }
    //Tank Controls && Debugging//
}
