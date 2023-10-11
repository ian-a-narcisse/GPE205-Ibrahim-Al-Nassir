using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Pawn : MonoBehaviour
{

    public float moveSpeed;
    /// <summary>
    /// Variable for pawn move speed
    /// </summary>
    public float turnSpeed;
    /// <summary>
    /// Variable for pawn turn speed
    /// </summary>

    // Start is called before the first frame update
    public virtual void Start()
    {
        
    }

    // Update is called once per frame
    public virtual void Update()
    {
        
    }

    public abstract void MoveForward();
    public abstract void MoveBackward();
    public abstract void TurnClockwise();
    public abstract void TurnCounterClockwise();

}
