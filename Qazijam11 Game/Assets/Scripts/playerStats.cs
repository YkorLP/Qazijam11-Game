using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class playerStats : MonoBehaviour
{
    public bool takeDamageDebug;

    public Slider healthSlider;
    public GameObject deathUI;

    public int health;

    public void TakeDamage ()
    {
        health -= Random.Range(4, 8);
    }

    private void Update()
    {
        healthSlider.value = health;

        if (health <= 0)
        {
            deathUI.SetActive(true);
            Time.timeScale = 0;
            Cursor.visible = true;
        }
    }

    public void Restart ()
    {
        SceneManager.LoadScene(0);
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
