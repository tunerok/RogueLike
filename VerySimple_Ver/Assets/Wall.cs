﻿using UnityEngine;
using System.Collections;

namespace Completed
{
    public class Wall : MonoBehaviour
    {
        public AudioClip chopSound1;                //1 of 2 audio clips that play when the wall is attacked by the player.
        public AudioClip chopSound2;                //2 of 2 audio clips that play when the wall is attacked by the player.
        public Sprite dmgSprite;                    //Alternate sprite to display after Wall has been attacked by player.
        private Animator animator1;                                            //  public int hp = 3;                          //hit points for the wall.


        //Store a component reference to the attached SpriteRenderer.
        void Awake()
        {
            animator1 = GetComponent<Animator>();
        }

        //DamageWall is called when the player attacks a wall.
        public void DamageWall(int loss)
        {
            //Call the RandomizeSfx function of SoundManager to play one of two chop sounds.
            // SoundManager.instance.RandomizeSfx(chopSound1, chopSound2);

            //Set spriteRenderer to the damaged wall sprite.
            animator1.SetTrigger("bang");
            //Subtract loss from hit point total.
            //      hp -= loss;

            //If hit points are less than or equal to zero:
            //    if (hp <= 0)
            //Disable the gameObject.
            //        gameObject.SetActive(false);
            //  }
        }
    }
}
 