using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class MoveForward : MonoBehaviour
{
    public float moveSpeed = 30.0f;
    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed);
    }
}