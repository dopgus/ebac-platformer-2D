using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ItemCollectableCoins : CollectableBase
{
    public static ItemCollectableCoins instance;
    public TextMeshProUGUI text;
    int score;
    public Collider2D collider;

    void Start()
    {
        if(instance == null)
        {
            instance = this;
        }
    }

    protected override void OnCollect()
    {
        base.OnCollect();
        ItemManager.Instance.AddCoins();
        collider.enabled = false;
    }

    public void ChangeScore(int coinValue)
    {
        score += coinValue;
        text.text = "X" + score.ToString();
    }

}
