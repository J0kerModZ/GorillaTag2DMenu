using BepInEx;
using Gorilla_Tag_2d_Mod.MenuMods;
using System.Diagnostics;
using UnityEngine;


namespace Gorilla_Tag_2d_Mod
{
    [BepInPlugin("com.J0ker.2d.Gtag", "Gtag 2D Cheat GUI", "1.0.0")]
    public class Main : BaseUnityPlugin
    {
        private bool ison;

        private void Update()
        {
            if (UnityInput.Current.GetKey(KeyCode.F1))
            {
                Cursor.visible = true;
            }

            if (UnityInput.Current.GetKey(KeyCode.F2))
            {
                Cursor.visible = false;
            }
        }

        private void OnGUI()
        {
            GUI.backgroundColor = Color.black;

            #region Labels
            GUI.Label(new Rect(0f, 15f, 160f, 20f), "<color=cyan>J0kers Gtag 2D Menu</color>");
            GUI.Label(new Rect(155f, 0f, 160f, 20f), "F1 - <color=green>Show Cursor</color>");
            GUI.Label(new Rect(155f, 15f, 160f, 20f), "F2 - <color=green>Hide Cursor</color>");
            #endregion

            #region Enable/Diisable UI
            if (!ison)
            {
                if (GUI.Button(new Rect(0f, 45f, 245f, 25f), "Open Menu"))
                {
                    ison = true;
                }
            }
            else
            {
                if (GUI.Button(new Rect(0f, 45f, 245f, 25f), "Close Menu"))
                {
                    ison = false;
                }
            }
            if (ison)
            {
                #endregion


                if (GUI.Button(new Rect(0f, 85f, 245f, 25f), "Quit Game"))
                {
                    Application.Quit();
                }

                if (GUI.Button(new Rect(0f, 125f, 120f, 25f), "Finish Level"))
                {
                    Mods.FinishLevel();
                }

                if (GUI.Button(new Rect(125f, 125f, 120f, 25f), "Banana Gun"))
                {
                    Mods.BananaGun();
                }

                if (GUI.Button(new Rect(0f, 155f, 245f, 25f), "No Delay Gun"))
                {
                    Mods.NoDelay();
                }

                if (GUI.Button(new Rect(0f, 185f, 120f, 25f), "Strength (1000)"))
                {
                    Mods.Strength();
                }

                if (GUI.Button(new Rect(125f, 185f, 120f, 25f), "Main Menu"))
                {
                    Mods.MainMenu();
                }

                if (GUI.Button(new Rect(0f, 225f, 245f, 25f), "<color=cyan>Join The Discord</color>"))
                {
                    Process.Start("https://discord.gg/Kdwqg2VUHc");
                }
            }
        }
    }
}