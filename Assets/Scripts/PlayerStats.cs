﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public static int Money;
    public int startMoney = 1000;

    public static int Lives;
    public int startLives = 20;

    private void Awake()
    {
        Lives = startLives;
        Money = startMoney;
    }
  
}
