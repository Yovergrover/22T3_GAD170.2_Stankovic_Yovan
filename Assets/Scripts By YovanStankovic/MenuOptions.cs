using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace YovanStankovic
{
    public class MenuOptions : MonoBehaviour
    {
        public void Begin() //I had exisiting code for a CIM project I am working on so I figured I would just reuse it for the title screen, this loads the game scene
        {
            SceneManager.LoadScene(1);
        }

        public void Quit() //Same as the "Begin" method, this was also from my CIM project and has been repurposed for quiting the game
        {
            Application.Quit();
            print("hahaha bye bye");
        }

    }
}

