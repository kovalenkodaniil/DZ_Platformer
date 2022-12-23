using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
[RequireComponent(typeof(SpriteRenderer))]

public class Movement : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _jumpPower;

    private float _moveDirection;
    private SpriteRenderer _spriteRenderer;
    private Animator _animator;
    private Vector3 _move;

    private void Start()
    {
        _animator = GetComponent<Animator>();
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        _moveDirection = Input.GetAxis("Horizontal");

        if (_moveDirection != 0)
        {
            _move = new Vector3(_moveDirection, 0, 0) * _speed;
            _spriteRenderer.flipX = _moveDirection > 0;
            _animator.SetBool(PlaeyrsAnimation.Params.RunHash, true);
        }
        else 
        {
            _animator.SetBool(PlaeyrsAnimation.Params.RunHash, false);
        }

        if (Input.GetKey(KeyCode.Space))
        {
            _move.y = _jumpPower;
        }

        transform.position += _move * Time.deltaTime;
    }
}
public static class PlaeyrsAnimation
{
    public static class Params 
    {
        public static int RunHash = Animator.StringToHash("Run"); 
    }
}
