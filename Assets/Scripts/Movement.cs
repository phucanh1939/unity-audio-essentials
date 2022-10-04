using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private Vector3 _startMovement;

    private Transform _transform;
    private Vector3 _movement;

    private void Awake()
    {
        _transform = transform;
        _movement = _startMovement;
    }

    // Update is called once per frame
    private void Update()
    {
        _transform.position += _movement * Time.deltaTime;
    }
}
