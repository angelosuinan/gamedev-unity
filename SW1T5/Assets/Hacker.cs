using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour {
    int level;
    enum Screen { MainMenu, Password, Win };
    string[] level1password = { "ping pong", "pingpong", "table tennis" };
    string[] level2password = { "albus", "dumbledore", "albusdumbledore", "Albus Percival Wulfric Brian Dumbledore" };
    string[] level3password = {"angelonicholsuinan", "suinanangelo", "angelosuinan","angelo","suinan"};
    Screen currentScreen = Screen.MainMenu;
    String password;
	// Use this for initialization
	void Start () {
        ShowMainMenu();
    
    }

    void ShowMainMenu() {
        currentScreen = Screen.MainMenu;
        Terminal.WriteLine("SW2T5");
        Terminal.WriteLine("Guess the Password");
        Terminal.WriteLine("Press 1 for easy");
        Terminal.WriteLine("Press 2 for average");
        Terminal.WriteLine("Press 3 for HARD");
        Terminal.WriteLine("Enter Your Selection");
    }
	void OnUserInput (string input) {
        if (input == "I'm 18")
            Terminal.WriteLine(@"
        @@@
       @. .@
       @\=/@
       .- -.
      /(.|.)\
      \ ).( /
      '( v )`
        \|/  
        (|)
        '-`");
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

        if (input == password)
        {
            DisplayWinScreen();
        }
        else if (input == "exit")
        {
            ShowMainMenu();
        }
        else
        {
            StartGame();
        }
    }

    void RunMainMenu(string input)
    {
        if (input == "1")
        {
            level = 1;
            GeneratePassword();
            StartGame();
        }
        else if (input == "2")
        {
            level = 2;
            GeneratePassword();
            StartGame();
        }
        else if (input == "3")
        {
            level = 3;
            GeneratePassword();
            StartGame();
        }
        else
            Terminal.WriteLine("Please choose a valid level");
    }
    void GeneratePassword()
    {

        switch (level)
        {
            case 1:
                password= level1password[UnityEngine.Random.Range(0, level1password.Length)];
                break;
            case 2:
                password = level2password[UnityEngine.Random.Range(0, level2password.Length)];
                break;
            case 3:
                password = level3password[UnityEngine.Random.Range(0, level3password.Length)];
                break;
        }

    }
    void StartGame()
    {
        currentScreen = Screen.Password;
        Terminal.ClearScreen();

        if (level == 3)
        {
            Terminal.WriteLine("Level " + level);
            Terminal.WriteLine("Describe the abstract");
            Terminal.WriteLine(@"
                           O--,---,--O
   ._O_.     O--=-O-=--O     \ O /
O--<-+->--O      '-'          - -
     X            v            -
    / \          / )          / \
                            ");
        }
        else if (level == 1)
        {
            Terminal.WriteLine("Level " + level);
            Terminal.WriteLine("Describe the picture");
            Terminal.WriteLine(@"
                    o
     _ 0  .-----\-----.  ,_0 _
   o' / \ |\     \     \    \ `o
   __|\___|_`-----\-----`__ /|____
     / |     |          |  | \
             |          |
                            ");
        }
        else if (level == 2)
        {
            Terminal.WriteLine("Level " + level);
            Terminal.WriteLine("Describe the picture");
            Terminal.WriteLine(@"
___ __ ._`.*.|_._ ____ ____
 . +  * .o   |.* `.`. +.    .
*  . ' ' |\^/|  `. * .  * `
          \V/ . +
          /_\  .`.
======== _/ \_ =====::.*
                            ");
        }
    }
    void DisplayWinScreen()
    {
        currentScreen = Screen.Win;
        Terminal.WriteLine("YOU WIN! here's a cake for you!");
        Terminal.WriteLine(@"
                     )  (  )  (
                    (^)(^)(^)(^)
                    _i__i__i__i_
                   (____________)
                   |####|>o<|###| hjw
                   (____________)

                            ");
    }
}
