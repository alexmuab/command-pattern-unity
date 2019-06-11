using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Class which has the Command pattern implemenatition
/// Using all the player commands
/// </summary>
class ExecuteInputs : MonoBehaviour
{
    // player object with command orders
    public Player plObject;

    // all commands
    private IInputCommand up_command;
    private IInputCommand down_command;
    private IInputCommand left_command;
    private IInputCommand right_command;
    private IInputCommand space_command;

    // the shoot rate
    private float _flShootRate;
    // flag who indicates if player can do some commands
    private bool _boolCanMove;

    void Awake()
    {
        // creating the commands objects
        up_command = new RunUp_Command();
        down_command = new RunBack_Command();
        left_command = new RotateLeft_Command();
        right_command = new RotateRight_Command();
        space_command = new Shoot_Command();

        _boolCanMove = false;
    }

    void Start()
    {
        // giving to shootrate a value
        _flShootRate = 10;
    }

    void Update()
    {
        if (_boolCanMove)
        {
            if (Input.GetKey(KeyCode.UpArrow))
                up_command.Execute(plObject);
            else if (Input.GetKey(KeyCode.DownArrow))
                down_command.Execute(plObject);

            if (Input.GetKey(KeyCode.RightArrow))
                right_command.Execute(plObject);
            else if (Input.GetKey(KeyCode.LeftArrow))
                left_command.Execute(plObject);

            if (Input.GetKey(KeyCode.Space))
            {
                if (Time.frameCount % _flShootRate == 0)
                    space_command.Execute(plObject);
            }
        }
    }

    /// <summary>
    /// Set enable controlls bool to true
    /// </summary>    
    private void EnableControls()
    {
        _boolCanMove = true;
    }

    /// <summary>
    /// Set enable controlls bool to false
    /// </summary>    
    private void DisableControls()
    {
        _boolCanMove = false;
    }
}