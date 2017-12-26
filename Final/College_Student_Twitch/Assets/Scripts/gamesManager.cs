using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Net.Sockets;
using System.IO;		
using UnityEngine.UI;

public class gamesManager : MonoBehaviour
{

    private TcpClient twitchClient;
    private StreamReader reader;
    private StreamWriter writer;
    public Text chatBox;
    public Text leftText;
    public Text rightText;
    public int leftCounter;
    public int rightCounter;
    public float timeLeft = 15.0f;


    public string username, password, channelName; // Get the login infoand name odf my channel

    public Rigidbody player;
    public int speed;
    public bool letsGo = false;
    public bool timerstart = false;

    //Items in the scene

    public GameObject startScreen;
    public GameObject mainChara;
    public GameObject Room;
    public GameObject Work;
    public GameObject School;
    public GameObject Sky;

    public bool imAtWork = false;
    public bool imOnRoad = false;
    public bool imSchool = false;
    public bool imHome = false;



    // Use this for initialization
    void Start()
    {
        Connect();
    }

    // Update is called once per frame
    void Update()
    {
        if (!twitchClient.Connected)
        {
            Connect();

        }
        ReadChat();
        Directions();
        Choices();
        inTime();
        Tally();


    }

    private void Connect()
    {

        twitchClient = new TcpClient("irc.chat.twitch.tv", 6667);
        reader = new StreamReader(twitchClient.GetStream());
        writer = new StreamWriter(twitchClient.GetStream());

        writer.WriteLine("PASS " + password);
        writer.WriteLine("NICK " + username);
        writer.WriteLine("USER " + username + " 8 * :" + username);
        writer.WriteLine("JOIN #" + channelName);
        writer.Flush();
    }
    private void ReadChat()
    {

        if (twitchClient.Available > 0)
        {
            var message = reader.ReadLine();

            if (message.Contains("PRIVMSG"))
            {
                //Get the users name by splitting it from the string
                var splitPoint = message.IndexOf("!", 1);
                var chatName = message.Substring(0, splitPoint);
                chatName = chatName.Substring(1);

                //Get the users message by splitting it from the string
                splitPoint = message.IndexOf(":", 1);
                message = message.Substring(splitPoint + 1);
                print(String.Format("{0}: {1}", chatName, message));
                chatBox.text = chatBox.text + "\n" + String.Format("{0}: {1}", chatName, message);

                //Run the instructions to control the game

                //	GameInputs (message);
                Decision(message);

            }

        }
    }
    private void Decision(string Inputs)
    {
        //Start the game
        if (Inputs.ToLower() == "adminstart")
        {
            startScreen.SetActive(false);
            Debug.Log("True");
            letsGo = true;
        }
        if(letsGo == true)
        {
            timeLeft = 15f;
            imHome = true;
            letsGo = false;
        }

        //Reads inputs

        if (imHome == true)
        {
            if (Inputs.ToLower() == "work")
            {
                leftCounter++;
            }
            if (Inputs.ToLower() == "school")
            {
                rightCounter++;
            }
        }
        if (imAtWork == true)
        {
            if (Inputs.ToLower() == "home")
            {
                leftCounter++;
            }
            if (Inputs.ToLower() == "school")
            {
                rightCounter++;
            }
        }
        if (imSchool == true)
        {
            if (Inputs.ToLower() == "work")
            {
                leftCounter++;
            }
            if (Inputs.ToLower() == "home")
            {
                rightCounter++;
            }
        }

    }
    private void Directions()
    {
        //Home
        if (imHome == true)
        {
            leftText.text = "Work: " + leftCounter;
            rightText.text = "School: " + rightCounter;
        }
        //Work
        if (imAtWork == true)
        {
            leftText.text = "Home: " + leftCounter;
            rightText.text = "School: " + rightCounter;
        }
        //School
        if (imSchool == true)
        {
            leftText.text = "Work: " + leftCounter;
            rightText.text = "Home: " + rightCounter;
        }
    }
    private void Choices ()
    {
        if(imHome == true)
        {
               //Turn on and off

            

            Room.SetActive(true);
            mainChara.SetActive(true);
            Work.SetActive(false);
            School.SetActive(false);

        }
        if (imAtWork == true)
        {
            //Turn on and off

          

            Room.SetActive(false);
            mainChara.SetActive(false);
            Work.SetActive(true);
            School.SetActive(false);

        }
        if (imSchool == true)
        {
            //Turn on and off


            Room.SetActive(false);
            mainChara.SetActive(false);
            Work.SetActive(false);
            School.SetActive(true);

        }

    }
    private void Tally()
    {
       
        if (leftCounter > rightCounter && imHome &&timeLeft <0 )
        {
            Debug.Log("works/kinda");
            imHome = false;
            imAtWork = true;

            leftCounter = 0;
            rightCounter = 0;
            timeLeft = 15f;
        }
        if (leftCounter < rightCounter && imHome && timeLeft < 0)
        {
            Debug.Log("Test this");
            imHome = false;
            imSchool = true;

            leftCounter = 0;
            rightCounter = 0;
            timeLeft = 15f;
        }
        if (leftCounter > rightCounter && imSchool && timeLeft < 0)
        {
            imSchool = false    ;
            imAtWork = true;
            Debug.Log("y tho");

            leftCounter = 0;
            rightCounter = 0;
            timeLeft = 15f;
        }
        if (leftCounter < rightCounter && imSchool && timeLeft < 0)
        {
            imSchool = false;
            imHome = true;
            Debug.Log("y tho");

            leftCounter = 0;
            rightCounter = 0;
            timeLeft = 15f;
        }
       
        if (leftCounter > rightCounter && imAtWork && timeLeft < 0)
        {
            imAtWork = false;
            imHome = true;
            Debug.Log("y tho");

            leftCounter = 0;
            rightCounter = 0;
            timeLeft = 15f;

        }
        
        if (leftCounter < rightCounter && imAtWork && timeLeft < 0)
        {
            imAtWork = false;
            imSchool = true;
            Debug.Log("y tho");

            leftCounter = 0;
            rightCounter = 0;
            timeLeft = 15f;
        }
        if(leftCounter == rightCounter)
        {
            timeLeft = 15f;
        }
        
    }
    private void inTime()
    {
        timeLeft -= Time.deltaTime;
        if (timeLeft < 0)
        {
            Debug.Log(timeLeft);
            
        }
    }
}
