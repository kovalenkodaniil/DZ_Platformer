using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using Unity.VisualScripting;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float _duration;
    [SerializeField] private Transform _endZone;

    private void Start()
    {
        transform.DOMove(_endZone.position, _duration).SetLoops(-1, LoopType.Yoyo).SetEase(Ease.Linear);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent<Player>(out Player player))
        {
            Destroy(player.GameObject());
        }
    }
}
