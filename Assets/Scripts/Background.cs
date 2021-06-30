// Created by Binh Bui on 06, 30, 2021

using UnityEngine;

public class Background : MonoBehaviour
{
    public float parallaxEffect;
    private float _length, _startPos;
    private readonly float _speed = 10;

    private void Start()
    {
        _startPos = transform.position.x;
        _length = GetComponent<SpriteRenderer>().bounds.size.x;
    }

    private void Update()
    {
        Move();
        ResetPos();
    }

    private void Move()
    {
        transform.position += Vector3.left * (_speed * parallaxEffect * Time.deltaTime);
    }

    private void ResetPos()
    {
        if (transform.position.x <= _startPos - _length)
        {
            transform.position = new Vector3(_startPos, transform.position.y);
        }
    }
}