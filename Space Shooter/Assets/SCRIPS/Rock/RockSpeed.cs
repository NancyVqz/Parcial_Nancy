using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockSpeed : MonoBehaviour
{
    [SerializeField]
    private float speed;

    private void Update()
    {
        transform.Translate(Vector3.down * speed * Time.deltaTime);
    }
}
