using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missile : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Rock"))
        {
            RockCounter.instance.AddMeteorites();
            AudioManager.instance.Play("Destroy");
            Destroy(other.gameObject);
            Destroy(this.gameObject);
        }
    }
}
