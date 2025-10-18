using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Timers;

    public class Game : MonoBehaviour
    {

        //Clicker
        public Text scoreText;
        public float currentScore;
        public float hitPower;

        //Super
        public Text SuperClickText;
        public Text SuperScoreText;
        public float SuperClick;
        public float SuperScore;
        public float SuperCost;
        public float a;

        //Multiplier
        public Text MultiplierClickText;
        public Text MultiplierScoreText;
        public float MultiplierClick;
        public float MultiplierScore;
        public float MultiCost;
        public float b;

        //Factory
        public int shop1prize;
        public Text shop1text;
        public Text amount1Text;
        public int amount1;
        public double amountProfit1;
    public double scoreIncreasePerTenSeconds;
    public double x;

    //Machine
    public int shop2prize;
        public Text shop2text;
        public Text amount2Text;
        public int amount2;
        public double amountProfit2;
    public double scoreIncreasePerFiveSeconds;
    public double z;

    //Efficient
    public Button button3;
    public float EfficientClick;

    //AllWork
    public Button button2;
    public float AllWorkClick;

    //NewManagement
        public Button button1;
        public float NewManagementClick;
        public float w;


        // Start is called before the first frame update
        void Start()
        {
            //Clicker
            currentScore = 0;
            hitPower = 1;
            scoreIncreasePerTenSeconds = 0.1;
            scoreIncreasePerFiveSeconds = 0.4;

            //Super
            a = 2;

            //Multiplier
            b = 1;

        }

        // Update is called once per frame
        void Update()
        {
            //Clicker
            scoreText.text = (int)currentScore + "Score";
            scoreIncreasePerTenSeconds = x * Time.deltaTime;
            currentScore = currentScore + ((float)scoreIncreasePerTenSeconds);
            scoreIncreasePerFiveSeconds = z * Time.deltaTime;
            currentScore = currentScore + ((float)scoreIncreasePerFiveSeconds);

            //Super
            SuperClickText.text = (int)SuperClick + "";
            SuperScoreText.text = "Tier:" + (int)SuperScore + "";

            //Multiplier
            MultiplierClickText.text = (int)MultiplierClick + "";
            MultiplierScoreText.text = "Tier:" + (int)MultiplierScore + "";

            //Factory
            shop1text.text = " " + shop1prize + " ";
            amount1Text.text = "Tier:" + amount1 + "arts:" + amountProfit1 + "/s";

            //Machine
            shop2text.text = " " + shop2prize + " ";
            amount2Text.text = "Tier:" + amount2 + "arts:" + amountProfit2 + "/s";

        }
        //Hit
        public void Hit()
        {
            currentScore += hitPower;

        }
        //Super
        public void Super()
        {
            if (currentScore >= SuperCost)
            {
                currentScore -= SuperCost;
                SuperCost = SuperCost + a;
                SuperClick = SuperCost;
                SuperScore = a;
                hitPower = a;
                a += 1;
            }
        }

        //Multiplier
        public void Multi()
        {
            if (currentScore >= MultiCost)
            {
                currentScore = currentScore * 2;
                MultiCost = MultiCost * 2;
                MultiplierClick = MultiCost;
                MultiplierScore = b;
                b += 1;
            }
        }

        //Factory
        public void Factory()
        {
            if (currentScore >= shop1prize)
            {
                currentScore -= shop1prize;
                amount1 += 1;
                amountProfit1 += 0.1;
                x += 0.1;
                shop1prize = shop1prize * 3 / 2;

            }
        }

        //Machine
        public void Machine()
        {
            if (currentScore >= shop2prize)
            {
                currentScore -= shop2prize;
                amount2 += 1;
                amountProfit2 += 0.4;
                z += 0.4;
                shop2prize = shop2prize * 6 / 5;

            }
        }

        //Efficient
        public void Efficient()
        {
            if (currentScore >= EfficientClick)
            {         
                x = x + 1;
            button3.enabled = false;
            }
        }

        //AllWork
        public void AllWork()
        {
            if (currentScore >= AllWorkClick)
            {
                x = amount1 * x;
            button2.enabled = false;
            }
        }

        //NewManagement
        public void NewManagement()
        {
            if (currentScore >= NewManagementClick)
            {          
                w = currentScore * 1 / 10;
                currentScore += w;
            button1.enabled = false;
            }
        }
    }

