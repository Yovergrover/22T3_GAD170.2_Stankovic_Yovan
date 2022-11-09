using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace YovanStankovic
{
    public class Aquarium : MonoBehaviour
    {
        [SerializeField] List<Fish> Fish = new List<Fish>();
        [SerializeField] private string[] species = {"SeaButterfly", "Anchovy", "SnappingTurtle", "Koi", "Crawfish", "Tadpole", "Pike"};
        private Fish smallestLength;
        private float totalValue;
        public float length;

        [SerializeField] private GameObject fishPrefab;
        public Fish newFish;
        public Fish fishEaten;

        private GameObject newFishStart;

        void Start()
        {
            newFishStart = Instantiate(fishPrefab, transform);
            newFish = newFishStart.GetComponent<Fish>();

            Debug.Log("Fish found");
        }

        public void KeepFishButton()
        {
            Fish.Add(newFish);
            totalValue += newFish.value;

            Instantiate(fishPrefab, transform);
        }

        void LengthOfSpecies()
        {
            for (int i = 0; i < species.Length; i++)
            {
                if (species[i] == "SeaButterfly" || species[i] == "Anchovy")
                {
                    length += Random.Range(1f, 100f);
                }
                if (species[i] == "SnappingTurtle" || species[i] == "Koi")
                {
                    length += Random.Range(1f, 100f);
                }
                if (species[i] == "Crawfish")
                {
                    length += Random.Range(1f, 100f);
                }
                if (species[i] == "Tadpole")
                {
                    length += Random.Range(1f, 100f);
                }
                if (species[i] == "Pike")
                {
                    length += Random.Range(1f, 100f);
                }
            }
        }

        void ValueOfSpecies()
        {
            for (int i = 0; i < species.Length; i++)
            {
                if (species[i] == "SeaButterfly")
                {
                    totalValue += Random.Range(10, 100);
                }
                if (species[i] == "Anchovy")
                {
                    totalValue += Random.Range(10, 300);
                }
                if (species[i] == "SnappingTurtle")
                {
                    totalValue += Random.Range(500, 5000);
                }
                if (species[i] == "Koi")
                {
                    totalValue += Random.Range(10, 1000);
                }
                if (species[i] == "Crawfish")
                {
                    totalValue += Random.Range(10, 2000);
                }
                if (species[i] == "Tadpole")
                {
                    totalValue += Random.Range(10, 500);
                }
                if (species[i] == "Pike")
                {
                    totalValue += Random.Range(10, 600);
                }
            }
        }
    }
}
