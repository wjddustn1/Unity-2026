using UnityEngine;
using UnityEngine.Rendering;

public class PlayerController : MonoBehaviour
{
    public float moverSpeed = 10f;
    public float ratationSpeed = 1f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    // Update is called once per frame
    void Update()
    {
        float xInput = Input.GetAxis("Horizontal");
        float zInput = Input.GetAxis("");   

        float xSpeed = xInput * rotationSpeed * Time.deltaTime;
        float ySpeed = yInput * rotationSpeed * Time.deltaTime;
    }
}
