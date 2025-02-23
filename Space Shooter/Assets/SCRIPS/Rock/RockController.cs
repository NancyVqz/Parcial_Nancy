using UnityEngine;

public class RockController : MonoBehaviour
{
    [SerializeField]
    private GameObject rock;

    void Start()
    {
        InvokeRepeating("AppearRock", InvokeTime(), InvokeRate());
    }

    public float InvokeTime()
    {
        return Random.Range(1f, 5f);
    }

    public float InvokeRate()
    {
        return Random.Range(1f, 5f);
    }

    void AppearRock()
    {
        Vector3 rockpos = new Vector3(Random.Range(-13.2f, 13.2f), 61f, 6.9f);
        Instantiate(rock, rockpos, Quaternion.identity);
    }
}
