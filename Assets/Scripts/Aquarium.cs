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

        public void KeepFishButton() //Yovan
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

        public void ReleaseButton() //Luka
        {
            Destroy(newFish.gameObject);

            AddFish();
            counter++;

            RoundCounter();

        }
        public void AddFish() //Dylan
        {
            newFishStart = Instantiate(fishPrefab, transform);
            newFish = newFishStart.GetComponent<Fish>();
        }

        private void RoundCounter() //Yovan
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
