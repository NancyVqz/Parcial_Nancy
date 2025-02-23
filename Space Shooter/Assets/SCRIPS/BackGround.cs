using UnityEngine;

public class BackGround : MonoBehaviour
{
    private float speed = 6f;
    private Vector3 startPos;

    private void Start()
    {
        startPos = transform.position;
    }

    private void Update()
    {
        MoveDown();
        Loop();
    }

    void MoveDown()
    {
        transform.Translate(translation: Vector3.down * speed * Time.deltaTime);
    }

    void Loop()
    {
        if (transform.position.y < -27f)
        {
            transform.position = startPos;
        }
    }
}
