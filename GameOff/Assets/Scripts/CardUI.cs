using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardUI : MonoBehaviour {
    public Card card;

    public Text nameText;
    public Text letterText;
    public Text descriptionText;
    public Text damageText;
    public Image image;
	// Use this for initialization
	void Start () {

        nameText.text = card.name;
        letterText.text = card.letterCode;
        descriptionText.text = card.description;
        damageText.text = card.damage.ToString();
        image.sprite = card.image;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
