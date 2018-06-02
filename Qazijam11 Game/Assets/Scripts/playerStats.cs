using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerStats : MonoBehaviour
{
    public bool takeDamageDebug;

    public int hearts;

    public GameObject heart1;
    public GameObject heart2;
    public GameObject heart3;

    void TakeDamage ()
    {
        hearts-= 1;

    }

    void Update() // hate my life
    {
        if (hearts == 2)
        {
            heart3.GetComponent<Animation>().Play("LoseHealth");
        }
        if (hearts == 1)
        {
            heart2.GetComponent<Animation>().Play("LoseHealth");
        }
    }

    /*void FindFullHeart ()
    {
        if (heart1.GetComponent<heart>().full != false) //Finds full heart
        {
            if (heart2.GetComponent<heart>().full != false)
            {
                if (heart3.GetComponent<heart>().full != false)
                {
                    //Die
                }
                else
                {
                    GameObject fullHeart;
                    fullHeart = heart3.gameObject;
                    Animator animator = fullHeart.GetComponent<Animator>();
                    animator.SetTrigger("LoseHealth");
                    return;
                }
            }
            else
            {
                GameObject fullHeart;
                fullHeart = heart2.gameObject;
                Animator animator = fullHeart.GetComponent<Animator>();
                animator.SetTrigger("LoseHealth");
                return;
            }
        }
        else
        {
            GameObject fullHeart;
            fullHeart = heart1.gameObject;
            Animator animator = fullHeart.GetComponent<Animator>();
            animator.SetTrigger("LoseHealth");
            return;
        }

       
        
    }*/
}
