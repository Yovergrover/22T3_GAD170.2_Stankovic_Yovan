using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace YovanStankovic
{
    public class TextDisplay : MonoBehaviour
    {
        public GameObject textDisplaySpecies;
        public GameObject textDisplayLength;
        public GameObject textDisplayDollarValue;
        public GameObject textDisplayTotalAmount;
        public Aquarium AQ;
        public Fish FSH;

        void Update() // Luka
        {
            textDisplaySpecies.GetComponent<TextMeshProUGUI>().text = "SPECIES: " + AQ.newFish.species;
            textDisplayLength.GetComponent<TextMeshProUGUI>().text = "LENGTH OF FISH: " + AQ.newFish.length + " cm";
            textDisplayDollarValue.GetComponent<TextMeshProUGUI>().text = "VALUE: $" + AQ.newFish.value;
            textDisplayTotalAmount.GetComponent<TextMeshProUGUI>().text = "TOTAL AMOUNT = $" + AQ.totalValue;
        }
    }

}