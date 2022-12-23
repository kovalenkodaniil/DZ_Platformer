using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatrolZone : MonoBehaviour
{
    [SerializeField] private float _duration;
    [SerializeField] private Transform _endZone;

    private void Start()
    {
        transform.DOMove(_endZone.position, _duration).SetLoops(-1, LoopType.Yoyo).SetEase(Ease.Linear);
    }
}
