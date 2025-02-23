using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class RockCounter : MonoBehaviour
{
    public static RockCounter instance;
    private TextMeshProUGUI texto;
    public int rocksDestroyed;

    private void Start()
    {
        texto = GetComponent<TextMeshProUGUI>();

        if (instance == null)
        {
            instance = this;
        }
    }

    void Update()
    {
        texto.text = "x " + rocksDestroyed;
    }

    public void AddMeteorites()
    {
        rocksDestroyed++;
    }
}
