using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime.Misc;
using UnityEngine;

namespace YovanStankovic
{
    enum Species {SeaButterfly, Anchovy, SnappingTurtle, Koi, Crawfish, Tadpole, Pike}; //Yovan
    public class Fish : MonoBehaviour
    {
        public string species;
        public float length = 0f;
        public int value;

        [SerializeField] private string[] speciesArray = new string[7]; //{"Sea Butterfly", "Anchovy", "Snapping Turtle", "Koi", "Crawfish", "Tadpole", "Pike" }

        void Start()
        {
            Stats();
        }

        private void Stats() //Yovan
        {
            string randomSpecies = speciesArray[Random.Range(0, speciesArray.Length)];

            Debug.Log(randomSpecies);

            species = randomSpecies;

            length += Random.Range(1f, 100f);

            value += Random.Range(10, 100);

        }
    }
}

