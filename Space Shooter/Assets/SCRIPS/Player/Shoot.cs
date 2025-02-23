using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    [SerializeField]
    private GameObject missile;
    [SerializeField]
    private Transform shootPoint;
    [SerializeField]
    private float speedMissile;

    private float machineCont = 0;

    void Update()
    {
        ShootMissile();
    }

    void ShootMissile()
    {
        if (ShootInputPressed() && machineCont <= 0)
        {
            AudioManager.instance.Play("Shoot");
            MissileSpawn();
            machineCont = 1f;
        }
        machineCont -= Time.deltaTime;
    }
    public bool ShootInputPressed()
    {
        return Input.GetKeyDown(KeyCode.Space);
    }

    void MissileSpawn()
    {
        GameObject mis = Instantiate(missile, shootPoint.position, missile.transform.rotation);
        mis.GetComponent<Rigidbody>().AddForce(transform.forward * speedMissile);
    }
}
