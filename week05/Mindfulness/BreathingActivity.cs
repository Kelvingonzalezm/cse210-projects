using System;

public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        _name = "Breathing Activity";
        _description = "This activity helps your body and mind by guiding you through slow, intentional breathing.";
    }

    public void Run()
    {
        DisplayStartingMessage();

        int timePassed = 0;

        while (timePassed < _duration)
        {
            Console.WriteLine("Inhale slowly...");
            ShowCountDown(4);
            timePassed += 4;

            if (timePassed >= _duration)
            {
                break;
            }

            Console.WriteLine("Exahle gently...");
            ShowCountDown(4);
            timePassed += 4;
        }

        DisplayEndingMessage();
    }
}