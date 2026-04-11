using UnityEngine;

public class roulettecontroler : MonoBehaviour
{
    public float startSpeed = 30f;
    public float decreaseRatio = 0.97f;
    float rotSpeed = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Application.targetFrameRate = 60; //맥시멈
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            rotSpeed = 10f;
        }

        transform.Rotate(0,0,this.rotSpeed);

        rotSpeed *= decreaseRatio;
    }
}
