using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IInputCommand
{
    void Execute(Player plObject);
}

public class RotateRight_Command : IInputCommand
{
    public void Execute(Player plObject)
    {
        plObject.RotateRight();
    }
}

public class RotateLeft_Command : IInputCommand
{
    public void Execute(Player plObject)
    {
        plObject.RotateLeft();
    }
}

public class RunUp_Command : IInputCommand
{
    public void Execute(Player plObject)
    {
        plObject.RunForward();
    }
}

public class RunBack_Command : IInputCommand
{
    public void Execute(Player plObject)
    {
        plObject.RunBack();
    }
}

public class Shoot_Command : IInputCommand
{
    public void Execute(Player plObject)
    {
        plObject.Shoot();
    }
}