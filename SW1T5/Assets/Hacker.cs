using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour {
    int level;
    enum Screen { MainMenu, Password, Win };
    string[] level1password = { "one", "uno", "isa" };
    string[] level2password = { "two", "dos", "dalawa" };
    string[] level3password = {"three", "tres", "tatlo"};
    Screen currentScreen = Screen.MainMenu;

	// Use this for initialization
	void Start () {
        ShowMainMenu();
    
    }

    void ShowMainMenu() {
        currentScreen = Screen.MainMenu;
        Terminal.WriteLine("SW2T5");
        Terminal.WriteLine("What would you like to hack into?");
        Terminal.WriteLine("Press 1 for the local library");
        Terminal.WriteLine("Press 2 for the police station");
        Terminal.WriteLine("Press 3 for the NASA system");
        Terminal.WriteLine("Enter Your Selection");
    }
	void OnUserInput (string input) {
        if (input == "007")
            Terminal.WriteLine("Hello Mr. James Bond");
        else if (input == "menu") {
            ShowMainMenu();
        }
        else if(currentScreen == Screen.MainMenu)
        {
            RunMainMenu(input);
        }
        else if(currentScreen == Screen.Password)
        {
            CheckPassword(input);
        }

    }

    private void CheckPassword(string input)
    {
        
        throw new NotImplementedException();
    }

    void RunMainMenu(string input)
    {
        if (input == "1")
        {
            level = 1;
            StartGame(level);
        }
        else if (input == "2")
        {
            level = 2;
            StartGame(level);
        }
        else if (input == "3")
        {
            level = 3;
            StartGame(level);
        }
        else
            Terminal.WriteLine("Please choose a valid level");
    }

    void StartGame(int level)
    {
        currentScreen = Screen.Password;
        Terminal.ClearScreen();
        Terminal.WriteLine("Level " + level);
        Terminal.WriteLine("Please Enter password");

    }
}
