using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SizeEnlarger : MonoBehaviour
{
    [SerializeField] private float _changeScaleSpeed;
    [SerializeField] private float _incrementSizeStep;

    private float _initialScaleSpeed;

    private void Start()
    {
        _initialScaleSpeed = _changeScaleSpeed;
    }

    private void Update()
    {
        if (_changeScaleSpeed <= 0)
        {
            transform.localScale += new Vector3(_incrementSizeStep, _incrementSizeStep, _incrementSizeStep);
            _changeScaleSpeed = _initialScaleSpeed;
        }

        _changeScaleSpeed -= Time.deltaTime;
    }
}
