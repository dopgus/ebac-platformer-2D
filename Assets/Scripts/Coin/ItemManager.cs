using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Ebac.Core.Singleton;

public class ItemManager : Singleton<ItemManager>
{
    public int coinValue;


    private void Start()
    {
        Reset();
    }

    private void Reset()
    {
        coinValue = 1;
    }

    public void AddCoins(int amount = 1)
    {
        coinValue += amount;
    }
}
