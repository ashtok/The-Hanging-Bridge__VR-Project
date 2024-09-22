using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
namespace HangingBridge
{
    public class UIManager : MonoBehaviour
    {
        public GameObject endScreen;
        public List<GameObject> otherThings;
        public GameObject GameWonScreen;

        public TMP_Text performanceText;


        /// <summary>
        /// Shows end game screen if the player fails to complete the game and reloads the scene to allow them another chance
        /// </summary>
        public void EndGame()
        {
            endScreen.SetActive(true);
            foreach (var item in otherThings)
            {
                item.SetActive(false);
            }
            StartCoroutine(ReloadScene());
        }

        /// <summary>
        /// Shares details about the players performance and the experiment on game won 
        /// </summary>
        public void GameWon()
        {
            GameWonScreen.SetActive(true);
            float totalTimeTaken = GameManager.instance.gameTimer.StopTimer();
            Debug.Log("Total Time Taken in the Experiment");
            performanceText.text = CalculatePerformance(totalTimeTaken);
        }

        /// <summary>
        /// Calculates the player performance based on the total time elapsed during the experiment 
        /// and comparing it with values obtained during our study
        /// </summary>
        /// <param name="time"></param>
        /// <returns></returns>
        private string CalculatePerformance(float time)
        {
            return "Congratulations on completing the challenge. The total time was " + time + " seconds";
        }

        /// <summary>
        /// Reloads the Scene
        /// </summary>
        /// <returns></returns>
        IEnumerator ReloadScene()
        {
            yield return new WaitForSeconds(3.0f);
            Debug.Log("Reloading Scene");
            GameManager.instance.ReloadScene();
        }
    }
}