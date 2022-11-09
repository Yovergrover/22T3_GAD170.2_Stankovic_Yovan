using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace YovanStankovic
{
    public class MenuOptions : MonoBehaviour
    {
        public void Begin()
        {
            SceneManager.LoadScene(1);
        }

        public void Quit()
        {
            Application.Quit();
            print("hahaha bye bye");
        }

        public void Return()
        {
            SceneManager.LoadScene(0);
        }

    }
}

