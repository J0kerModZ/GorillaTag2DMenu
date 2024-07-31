using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Gorilla_Tag_2d_Mod.MenuMods
{
    public class Mods : MonoBehaviour
    {

        public static void FinishLevel()
        {
            GameObject.Find("FinishFlag").transform.localScale = new Vector3(1000f, 1000f, 1000f);
        }

        public static void BananaGun()
        {
            GameObject.Find("Player/Body/Arm/bone_1/bone_2/bone_3/BananaGun").SetActive(true);
        }

        public static void NoDelay()
        {
            GameObject.Find("Player/Body/Arm/bone_1/bone_2/bone_3/BananaGun").GetComponent<Gun>().WaitTime = 0;
        }

        public static void Strength()
        {
            GameObject.Find("Player").GetComponent<PlayerController>()._force = 1000f;
            GameObject.Find("Player").GetComponent<PlayerController>().strength = 1000f;
        }

        public static void MainMenu()
        {
            SceneManager.LoadScene("Menu");
        }

    }
}
