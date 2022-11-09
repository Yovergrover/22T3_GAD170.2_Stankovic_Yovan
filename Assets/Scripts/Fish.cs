using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime.Misc;
using UnityEngine;

namespace YovanStankovic
{
    enum Species {SeaButterfly, Anchovy, SnappingTurtle, Koi, Crawfish, Tadpole, Pike};
    public class Fish : MonoBehaviour
    {
        public string species;
        public float length = 0f;
        public int value;

        [SerializeField] private string[] speciesArray = new string[7]; //{"Sea Butterfly", "Anchovy", "Snapping Turtle", "Koi", "Crawfish", "Tadpole", "Pike" }

        public Fish(string newSpecies, float newLength, int newValue)
        {
            species = newSpecies;
            length = newLength;
            value = newValue;
        }

        void Start()
        {
            Stats();

            speciesArray[0] = "Sea Butterfly";
            speciesArray[1] = "Anchovy";
            speciesArray[2] = "Snapping Turtle";
            speciesArray[3] = "Koi";
            speciesArray[4] = "Crawfish";
            speciesArray[5] = "Tadpole";
            speciesArray[6] = "Pike";
        }

        private void Stats()
        {
            string randomSpecies = speciesArray[Random.Range(0, speciesArray.Length)];

            Debug.Log(randomSpecies);

            species = randomSpecies;

            length += Random.Range(1f, 100f);

            value += Random.Range(10, 100);


        }
    }
}

