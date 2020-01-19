using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Human : MonoBehaviour
{
    HumanState state = HumanState.Ice;

    public Animator animator;

    public ParticleSystem steam;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject obj = collision.gameObject;
        if (obj.layer == 9 && obj.CompareTag("Steam"))
        {
            UnFroze();
        }
    }

    void UnFroze()
    {
        animator.SetTrigger("unfroze");
        StartCoroutine(Steam());
        state = HumanState.Normal;
    }

    IEnumerator Steam()
    {
        steam.Play();
        yield return new WaitForSeconds(1);
        steam.Stop();
    }
}

public enum HumanState
{
    Ice,
    Normal
}
