﻿using UnityEngine;
using System.Collections;

public class HashIDs : MonoBehaviour {
    [HideInInspector]
    public int dyingState;
    [HideInInspector]
    public int locomotionState;
    [HideInInspector]
    public int shoutState;
    [HideInInspector]
    public int deadBool;
    [HideInInspector]
    public int speedFloat;
    [HideInInspector]
    public int sneakingBool;
    [HideInInspector]
    public int shoutingBool;
    [HideInInspector]
    public int playerInSightBool;
    [HideInInspector]
    public int shotFloat;
    [HideInInspector]
    public int aimWeightFloat;
    [HideInInspector]
    public int angularSpeedFloat;
    [HideInInspector]
    public int openBool;

    private void Awake()
    {
        dyingState = Animator.StringToHash("Base Layer.Dying");
        locomotionState = Animator.StringToHash("Base Layer.Locomotion");
        shoutState = Animator.StringToHash("Shouting.Shout");
        deadBool = Animator.StringToHash("Dead");
        speedFloat = Animator.StringToHash("Speed");
        sneakingBool = Animator.StringToHash("Sneaking");
        shoutingBool = Animator.StringToHash("Shouting");
        playerInSightBool = Animator.StringToHash("PlayerInSight");
        shotFloat = Animator.StringToHash("Shot");
        aimWeightFloat = Animator.StringToHash("AinWeight");
        angularSpeedFloat = Animator.StringToHash("AngularSpeed");
        openBool = Animator.StringToHash("Open");
    }

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
