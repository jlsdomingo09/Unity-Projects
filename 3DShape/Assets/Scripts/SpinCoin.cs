using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinCoin : MonoBehaviour
{
    public float RotateSpeed;

    void Update()
    {
        transform.Rotate(transform.up, 360 * RotateSpeed * Time.deltaTime);
    }
}
