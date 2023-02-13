using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

    public class DeactivateIcon : MonoBehaviour
    {

        //win screen image
        public GameObject winScreen;

        //icon
        public GameObject icon;

        //score
        private int currentPoints;
        private int pointsToWin;

        private void Start()
        {
            pointsToWin = 6;
            currentPoints = 0;
        }

        private void Update()
        {
            if (currentPoints >= pointsToWin)
            {
                //end game, show win screen
                //stop timer
                winScreen.SetActive(true);

            }
        }

        //method that deactivates icon on click

        public void IconDeactivation()
        {
            Debug.Log("clicked");
            //icon.SetActive(false);

            //destroy the button clicked
            Destroy (icon);
            
            currentPoints++;
            Debug.Log(currentPoints);
        }

    }


