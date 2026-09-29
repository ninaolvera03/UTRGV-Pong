using UnityEngine;
using UnityEngine.InputSystem;

public class PaddleController : MonoBehaviour
{
    public Key upKey = Key.W;
    public Key downKey = Key.S;
    public float speed = 8f;
    public float yLimit = 4f;
    
    // Update is called once per frame
    void Update()
    {
        var kb = Keyboard.current;
        if (kb == null) return;

        float dir = 0f;
        if (kb[upKey].isPressed)   dir += 1f;
        if (kb[downKey].isPressed) dir -= 1f;

        Vector3 pos = transform.position;
        pos.y = Mathf.Clamp(pos.y + dir * speed * Time.deltaTime, -yLimit, yLimit);
        transform.position = pos;
    }
}
