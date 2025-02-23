using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;    
    public Sound[] sounds;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }

        foreach(Sound s in sounds)
        { //agrega el audiosource y le pasa los valores que nosotros pusimos en el arreglo
            s.source = gameObject.AddComponent<AudioSource>();

            s.source.clip = s.clip;
            s.source.loop = s.loop;
            s.source.volume = s.volume;
        }
    }

    public void Play(string nombre)
    {
        foreach(Sound s in sounds)
        {
            if(s.name == nombre)
            {
                s.source.Play();
                return;
            }
        }
        Debug.Log("La cancion " + nombre + " no se encontro");
    }

    public void Stop(string nombre)
    {
        foreach (Sound s in sounds)
        {
            if (s.name == nombre)
            {
                s.source.Stop();
                return;
            }
        }
        Debug.Log("La cancion " + nombre + " no se encontro");
    }
}
