using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCollectableCoins : CollectableBase
{
    protected override void OnCollect()
    {
        base.OnCollect();
        ItemManager.Instance.AddCoins();
    }
}
