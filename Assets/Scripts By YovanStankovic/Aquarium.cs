using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace YovanStankovic
{
    public class Aquarium : MonoBehaviour
    {
        [SerializeField] List<Fish> listOfFish = new List<Fish>();
        public float totalValue;

        [SerializeField] private GameObject fishPrefab;
        private GameObject newFishStart;

        public bool fishRemoved = false;
        public Fish newFish;

        public GameObject activeGameUI;
        public GameObject gameOverUI;
        public int counter;


        private void Start()
        {
            AddFish();
        }

        public void KeepFishButton() //I made a boolean so that we could recognise when we actually caught the fish
        {
            fishRemoved = false;
            for (int i = 0; i < listOfFish.Count; i++)
            {
                if (newFish.length >= listOfFish[i].length && fishRemoved == false)
                {
                    Debug.Log("Fish is Gone Brother");
                    totalValue -= listOfFish[i].value;
                    listOfFish.Remove(listOfFish[i]);

                    fishRemoved = true;
                }
            }

            listOfFish.Add(newFish);
            totalValue += newFish.value;

            AddFish();
            counter++;
            Debug.Log(counter);

            RoundCounter();

        }

        public void ReleaseButton() //Luka made the release fish buttons method using a destroy gameobject and adding that action to the round counter
        {
            Destroy(newFish.gameObject);

            AddFish();
            counter++;

            RoundCounter();

        }
        public void AddFish() //Dylan had looked into Instantiates which helped us actually add our fish to the aquarium
        {
            newFishStart = Instantiate(fishPrefab, transform);
            newFish = newFishStart.GetComponent<Fish>();
        }

        private void RoundCounter() //I used a roundcounter to put a limit on how many times you can get/throw away a fish before the game ends
        {
            if (counter == 10)
            {
                activeGameUI.SetActive(false);
                gameOverUI.SetActive(true);
                Debug.Log("Game Over");
            }
        }
    }
}
