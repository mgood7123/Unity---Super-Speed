using System.Collections;
using System.Collections.Generic;
using StarterAssets;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(PlayerInput))]
public class TimeManager : MonoBehaviour
{
    [Header("Time")]
    public float player_speed = 1.0f;
    public float world_speed = 1.0f;
    // things break at 0.0006f or lower
    //public float SUPER_SPEED_VALUE = 0.0007f;

    // safe value
    public float SUPER_SPEED_VALUE = 0.2f;

    public StarterAssetsInputs _input;

    public Chronos.Timeline getTime(Component component)
    {
        return component.GetComponent<Chronos.Timeline>();
    }

    // Start is called before the first frame update
    void Start()
    {
        _input = GetComponent<StarterAssetsInputs>();
    }

    // Update is called once per frame
    void Update()
    {
        if (_input.focus)
        {
            world_speed = SUPER_SPEED_VALUE;
            if (_input.super_speed)
            {
                player_speed = 1.0f / SUPER_SPEED_VALUE;
            }
            else
            {
                player_speed = 1.0f;
            }
        }
        else
        {
            world_speed = 1.0f;
            if (_input.super_speed)
            {
                player_speed = 1.0f / 0.5f;
            }
            else
            {
                player_speed = 1.0f;
            }
        }

        Chronos.Clock playerClock;
        Chronos.Clock worldClock;

        bool hasPlayerClock = Chronos.Timekeeper.instance.HasClock("Player");
        Debug.Log("has Player Clock: " + hasPlayerClock);

        bool hasWorldClock = Chronos.Timekeeper.instance.HasClock("World");
        Debug.Log("has World Clock: " + hasWorldClock);

        if (hasPlayerClock)
        {
            playerClock = Chronos.Timekeeper.instance.Clock("Player");
            playerClock.localTimeScale = player_speed;
        }

        if (hasWorldClock)
        {
            worldClock = Chronos.Timekeeper.instance.Clock("World");
            worldClock.localTimeScale = world_speed;
        }

        //Time.timeScale = world_speed;
        // update physics callback speed
        //Time.fixedDeltaTime = 0.02f * world_speed;
    }
}
