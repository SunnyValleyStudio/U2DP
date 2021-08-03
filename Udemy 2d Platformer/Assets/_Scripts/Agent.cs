using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using WeaponSystem;

public class Agent : MonoBehaviour
{
    public AgentDataSO agentData;

    public Rigidbody2D rb2d;
    public IAgentInput agentInput;
    public AgentAnimation animationManager;
    public AgentRenderer agentRenderer;
    public GroundDetector groundDetector;
    public ClimbingDetector climbingDetector;

    public State curretSate = null, previousState = null;
    public State IdleState;

    [HideInInspector]
    public AgentWeaponManager agentWeapon;

    public StateFactory stateFactory;
    private Damagable damagable;

    [Header("State debugging:")]
    public string stateName = "";

    [field: SerializeField]
    private UnityEvent OnRespawnRequired { get; set; }
    [field: SerializeField]
    public UnityEvent OnAgentDie { get; set; }

    private void Awake()
    {
        agentInput = GetComponentInParent<IAgentInput>();
        rb2d = GetComponent<Rigidbody2D>();
        animationManager = GetComponentInChildren<AgentAnimation>();
        agentRenderer = GetComponentInChildren<AgentRenderer>();
        groundDetector = GetComponentInChildren<GroundDetector>();
        climbingDetector = GetComponentInChildren<ClimbingDetector>();
        agentWeapon = GetComponentInChildren<AgentWeaponManager>();
        stateFactory = GetComponentInChildren<StateFactory>();
        damagable = GetComponent<Damagable>();

        stateFactory.InitializeStates(this);
    }

    private void Start()
    {
        agentInput.OnMovement += agentRenderer.FaceDirection;
        InitializeAgent();

        agentInput.OnWeaponChange += SwapWeapon;
    }

    private void SwapWeapon()
    {
        if (agentWeapon == null)
            return;
        agentWeapon.SwapWeapon();
    }

    private void InitializeAgent()
    {
        TransitionToState(IdleState);
        damagable.Initialize(agentData.health);
    }

    public void AgentDied()
    {
        if(damagable.CurrentHealth > 0)
        {
            OnRespawnRequired?.Invoke();
        }
        else
        {
            curretSate.Die();
        }
        
    }

    public void GetHit()
    {
        curretSate.GetHit();
    }

    

    internal void TransitionToState(State desiredState)
    {
        if (desiredState == null)
            return;
        if (curretSate != null)
            curretSate.Exit();

        previousState = curretSate;
        curretSate = desiredState;
        curretSate.Enter();

        DisplayState();

    }

    private void DisplayState()
    {
        if(previousState == null || previousState.GetType() != curretSate.GetType())
        {
            stateName = curretSate.GetType().ToString();
        }
    }

    private void Update()
    {

        curretSate.StateUpdate();
    }

    private void FixedUpdate()
    {
        groundDetector.CheckIsGrounded();
        curretSate.StateFixedUpdate();
    }

    public void PickUp(WeaponData weaponData)
    {
        if (agentWeapon == null)
            return;
        agentWeapon.PickUpWeapon(weaponData);
    }
}
