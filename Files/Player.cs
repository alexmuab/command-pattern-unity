using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    
    //private components
    private Transform _myTransform;
    public Rigidbody _myRigidBody;

    //private vars
    private float _flVertical;
    private float _flHorizontal;
    private float _flVelocityMultiplier;
    private float _flRotateMultiplier;
   
    #region INIT

    void Awake()
    {
        //getting elements before working with them
        _myTransform = transform;
        _myRigidBody = GetComponent<Rigidbody>();
    }

    void Start()
    {
        // assign game config values
        _flVelocityMultiplier = 5;
        _flRotateMultiplier = 3;
    }
    #endregion

    
    #region PLAYER ACTIONS

    /// <summary>
    /// Player goes forward
    /// </summary>
    public void RunForward()
    {
        _flHorizontal = 0;
        _flVertical = 1f;
        _myRigidBody.velocity = _myTransform.forward * _flVertical * _flVelocityMultiplier;
    }

    /// <summary>
    /// Player goes backwards
    /// </summary>
    public void RunBack()
    {
        _flHorizontal = 0;
        _flVertical = -1f;
        _myRigidBody.velocity = _myTransform.forward * _flVertical * _flVelocityMultiplier;
    }

    /// <summary>
    /// Player action rotate right
    /// </summary>
    public void RotateRight()
    {
        _flVertical = 0;
        _flHorizontal = 1f;
        _myTransform.Rotate(0, _flHorizontal * _flRotateMultiplier, 0);
    }

    /// <summary>
    /// Player action rotate left
    /// </summary>
    public void RotateLeft()
    {
        _flVertical = 0;
        _flHorizontal = -1f;
        _myTransform.Rotate(0, _flHorizontal * _flRotateMultiplier, 0);
    }

    /// <summary>
    /// Player shoots
    /// </summary>
    public void Shoot()
    {
        // Shooting
    }

    #endregion
    
}
