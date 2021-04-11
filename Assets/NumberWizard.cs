using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    int max;
    int min;
    int guess;

	void Start ()
    {
        StartGame();
    }

    private void StartGame()
    {
        max = 1000;
        min = 1;
        guess = 500;

        max = max + 1;

        print("=========================");
        print("Welcome to Number Wizard");
        print("Pick a Number in your head, but don't tell me");

        print("The highest number you can pick is " + max);
        print("The lowest number you can pick is " + min);

        print("Is the number higher or lower than " + guess);
        print("Up = higher, down = lower, return = equal");
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            //print("Up arrow pressed");
            min = guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            //print("Down arrow pressed");
            max = guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            print("I won!");
            Start();
        }
    }

    private void NextGuess()
    {
        guess = (min + max) / 2;
        print("Higher or lower than " + guess);
        print("Up = higher, down = lower, return = equal");
    }
}
