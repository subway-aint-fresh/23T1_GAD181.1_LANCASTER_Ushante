using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Toolkit.ObjectFound
{
    public class DeactivateIcon : MonoBehaviour
    {
        //image variable for icon
        public GameObject icon;

        //method that deactivates icon on click
        public void IconDeactivation()
        {
            icon.SetActive(false);
            Destroy(gameObject);
        }
    }
}


