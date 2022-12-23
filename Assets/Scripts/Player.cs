using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    private int _coinCount;

    public void AddCoin()
    {
        _coinCount ++;
        Debug.Log($"Монет: {_coinCount}");
    }
}
