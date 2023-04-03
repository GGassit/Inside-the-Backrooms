using UnityEngine;
using UnityEngine.InputSystem;

namespace Inside_the_Backrooms
{
    public class Menu
    {
        public static bool MenuVisible = true;

        public static void Update()
        {
            Keyboard keyboard = Keyboard.current;
            if (keyboard.insertKey.wasPressedThisFrame)
            {
                Menu.MenuVisible = !Menu.MenuVisible;
            }
        }
    }
}