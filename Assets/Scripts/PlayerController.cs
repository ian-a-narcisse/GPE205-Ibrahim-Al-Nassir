using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : Controller
{
    /// <summary>
    /// Button to move Forward
    /// </summary>
    public KeyCode moveForwardKey;
    /// <summary>
    /// Button to move Backward
    /// </summary>
    public KeyCode moveBackwardKey;
    /// <summary>
    /// Button to turn Clockwise
    /// </summary>
    public KeyCode turnClockwiseKey;
    /// <summary>
    /// Button to turn CountClockwise
    /// </summary>
    public KeyCode turnCounterClockwiseKey;
 



    // Start is called before the first frame update
    public override void Start()
    {
        base.Start();
    }

    // Update is called once per frame
    public override void Update()
    {
        //Reads controller inputs and then returns to business as usual//

        ReadInputs();
        base.Update();

    }


    public void ReadInputs()
    {
        if (Input.GetKey(moveForwardKey))
        {
            pawn.MoveForward();
        }

        if (Input.GetKey(moveBackwardKey))
        {
            pawn.MoveBackward();
        }

        if (Input.GetKey(turnClockwiseKey))
        {
            pawn.TurnClockwise();
        }

        if (Input.GetKey(turnCounterClockwiseKey))
        {
            pawn.TurnCounterClockwise();
        }
    }

}
