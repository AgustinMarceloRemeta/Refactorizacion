using UnityEngine;

public class Ejercicio01 : MonoBehaviour
{
    public float force;
    private Rigidbody2D rb2d;
    private void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        Movement();

    }

    private void Movement()
    {
        float movHorizontal = Input.GetAxis("Horizontal");
        float movVertical = Input.GetAxis("Verical");

        Vector2 speed = new Vector2(movHorizontal, movVertical);

        rb2d.AddForce(speed * force * Time.deltaTime);
    }
}