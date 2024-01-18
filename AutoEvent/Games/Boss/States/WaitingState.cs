﻿using System;
using UnityEngine;

namespace AutoEvent.Games.Boss;

public class WaitingState : IBossState
{
    private Vector3 _newPos;
    public string Name { get; } = "Waiting";
    public string Description { get; } = "The transitional state between all states";
    public TimeSpan Timer { get; set; }

    public void Init()
    {

    }

    public void Update()
    {

    }

    public void Deinit()
    {

    }
}
