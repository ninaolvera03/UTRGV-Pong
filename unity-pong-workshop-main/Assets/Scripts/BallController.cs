using UnityEngine;

public class BallController : MonoBehaviour
{
    public float speed = 7f;
    Rigidbody2D rb;
    Vector2 startPos;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        startPos = transform.position;
        Launch();
    }

    void Launch() {
        transform.position = startPos;
        float x = Random.value<.5f ? -1 : 1;
        float y = Random.Range(-.5f,.5f);
        rb.linearVelocity =
        new Vector2(x,y).normalized*speed;
    }

    void FixedUpdate() {           // keep speed
        if (rb.linearVelocity.sqrMagnitude>.01f)
        rb.linearVelocity =
            rb.linearVelocity.normalized*speed;
    }
    
    public void ResetBall(){ Launch(); }
}
