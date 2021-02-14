using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dice : Movement
{
    private Sprite[] diceSides;
    private SpriteRenderer rend;
    [SerializeField] GameObject text;

    // Use this for initialization
    private void Start()
    {
        Players[0] = play1;
        Players[1] = play2;
        Players[2] = play3;
        Players[3] = play4;
        // Assign Renderer component
        rend = GetComponent<SpriteRenderer>();
        // Load dice sides sprites to array from DiceSides subfolder of Resources folder
        diceSides = Resources.LoadAll<Sprite>("Dice/");
    }
    //Rolls a random number
    public int roll()
    {
        var rolled = Random.Range(1, 7);

        return rolled;
    }
    // When the Dice is click, Start rolling the dice
    private void OnMouseDown()
    {
        StartCoroutine("RollTheDice");
    }
    //RolltheDice() changes the sprite to its other variants to appearing roll
    // When the roll stops that is the number they roll by
    private IEnumerator RollTheDice()
    {
        int rolled = roll();
        for (int i = 0; i <= 20; i++)
        {
            rend.sprite = diceSides[roll() - 1];
            yield return new WaitForSeconds(0.05f);
        }
        rend.sprite = diceSides[rolled - 1];
        if ((rolled + Players[currentPlayer%4].getLoc()) <= 100)
            for (int i = 0; i < rolled; i++)
                Players[currentPlayer%4].move(false);
        rollText(currentPlayer%4,rolled);
        currentPlayer++;
    }
    //Display the Player rolled value
    private void rollText(int person, int rolled)
    {
        if (person == 0)
        {
            text.GetComponent<UnityEngine.UI.Text>().text = "Ant Rolls\n"+ rolled + "!";
        }
        if (person == 1)
        {
            text.GetComponent<UnityEngine.UI.Text>().text = "Hungry Rolls\n" + rolled + "!";
        }
        if (person == 2)
        {
            text.GetComponent<UnityEngine.UI.Text>().text = "Snail Rolls\n" + rolled + "!";
        }
        if (person == 3)
        {
            text.GetComponent<UnityEngine.UI.Text>().text = "Worm Rolls\n" + rolled + "!";
        }
    }

}
