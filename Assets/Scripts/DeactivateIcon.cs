using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace Toolkit.ObjectFound
{
    public class DeactivateIcon : MonoBehaviour
    {
        //variable for icon screen buttons
        //private GameObject icon;


        //win screen image
        public Image winScreen;

        //score
        private int currentPoints;
        private int pointsToWin;

        private void Start()
        {
            pointsToWin = 6;
        }

        private void Update()
        {
            if (currentPoints >= pointsToWin)
            {
                //end game, show win screen
                //stop timer
                winScreen.enabled = true;

            }
        }

        //method that deactivates icon on click

        public void IconDeactivation()
        {
            Debug.Log("clicked");
            //icon.SetActive(false);
            Destroy(gameObject);
            currentPoints++;
        }

    }
}


