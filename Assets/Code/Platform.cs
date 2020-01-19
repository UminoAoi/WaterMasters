using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    public WaterState state = WaterState.None;
    public GameObject currentImage;
    public GameObject[] particleImages; //We need multiple particle images to reduce drawcalls

    public static float speed = 1f;
    public static float fallingSpeed = 10f;

    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        if (state != WaterState.None)
        {
            currentImage.SetActive(false);
            currentImage = particleImages[(int)state];
            currentImage.SetActive(true);
        }
        if (state == WaterState.Steam)
        {
            Vector2 target = new Vector2(transform.position.x, transform.position.y + 1);
            transform.position = Vector2.MoveTowards(transform.position, target, speed * Time.deltaTime);

        }
        if (state == WaterState.Liquid)
        {
            animator.SetTrigger();
            Vector2 target = new Vector2(transform.position.x, transform.position.y - 5);
            transform.position = Vector2.MoveTowards(transform.position, target, fallingSpeed * Time.deltaTime);

        }
    }

    public void ChangeState(WaterState newState)
    {
        state = newState;
    }
}
