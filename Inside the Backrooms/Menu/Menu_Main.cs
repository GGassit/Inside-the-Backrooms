using Il2Cpp;
using Inside_the_Backrooms;
using System;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

namespace Inside_the_Backrooms
{
    public class Menu_Main
    {
        public static void OnGUI()
        {
            if (Menu.MenuVisible)
            {   
                GUI.backgroundColor = Render.ToColor(35f, 32f, 39f, 255f);
                window_Main = GUI.Window(1, window_Main, (GUI.WindowFunction)onWindow, "<size=15><b><color=#00FFFF>鸡你太美</color></b></size>");
            }


        }
        public static void onWindow(int ID)
        {
            GUILayout.Box("<b><color=red>[玩家功能/Ins显隐]</color></b>", new GUILayoutOption[0]);

            GUILayout.Label(string.Format("走路速度:{0}", Math.Round(Menu_Main.WalkSpeed, 1)), new GUILayoutOption[0]);
            Menu_Main.WalkSpeed = GUILayout.HorizontalSlider(Menu_Main.WalkSpeed, 1, 100, new GUILayoutOption[0]);
            GUILayout.Label(string.Format("奔跑速度:{0}", Math.Round(Menu_Main.RunSpeed, 1)), new GUILayoutOption[0]);
            Menu_Main.RunSpeed = GUILayout.HorizontalSlider(Menu_Main.RunSpeed, 1, 100, new GUILayoutOption[0]);
            GUILayout.Label(string.Format("蹲下速度:{0}", Math.Round(Menu_Main.crouchWalkSpeed, 1)), new GUILayoutOption[0]);
            Menu_Main.crouchWalkSpeed = GUILayout.HorizontalSlider(Menu_Main.crouchWalkSpeed, 1, 999, new GUILayoutOption[0]);
            GUILayout.Label(string.Format("辐射修改:{0}", Math.Round(Menu_Main.Radiation, 1)), new GUILayoutOption[0]);
            Menu_Main.Radiation = GUILayout.HorizontalSlider(Menu_Main.Radiation, 0, 100, new GUILayoutOption[0]);
            //↑玩家控制器
            Menu_Main.InfiniteHealth = GUILayout.Toggle(Menu_Main.InfiniteHealth, "无限血量", new GUILayoutOption[0]);
            Menu_Main.InfiniteStamina = GUILayout.Toggle(Menu_Main.InfiniteStamina, "无限耐力", new GUILayoutOption[0]);
            Menu_Main.NoAnxiety = GUILayout.Toggle(Menu_Main.NoAnxiety, "没有焦虑", new GUILayoutOption[0]);
            Menu_Main.InfiniteRadiation = GUILayout.Toggle(Menu_Main.InfiniteRadiation, "辐射修改开关", new GUILayoutOption[0]);
            //↑玩家属性
            GUILayout.Box("<b><color=yellow>[ESP（All）]</color></b>", new GUILayoutOption[0]);
            Menu_Main.EspPlayer = GUILayout.Toggle(Menu_Main.EspPlayer, "透视玩家", new GUILayoutOption[0]);
            Menu_Main.EspAi = GUILayout.Toggle(Menu_Main.EspAi, "透视全部实体", new GUILayoutOption[0]);
            Menu_Main.EspElevator = GUILayout.Toggle(Menu_Main.EspElevator, "透视全部电梯", new GUILayoutOption[0]);
            Menu_Main.EspDoor = GUILayout.Toggle(Menu_Main.EspDoor, "透视全部门", new GUILayoutOption[0]);
            Menu_Main.EspPartygoerAI = GUILayout.Toggle(Menu_Main.EspPartygoerAI, "透视派对客", new GUILayoutOption[0]);
            Menu_Main.EspSmilerAI = GUILayout.Toggle(Menu_Main.EspSmilerAI, "透视笑魇", new GUILayoutOption[0]);
            Menu_Main.EspSkinStealerAI = GUILayout.Toggle(Menu_Main.EspSkinStealerAI, "透视窃皮者", new GUILayoutOption[0]);
            Menu_Main.EspClumpsAI = GUILayout.Toggle(Menu_Main.EspClumpsAI, "透视肢团", new GUILayoutOption[0]);
            Menu_Main.EspAbstractEntityAI = GUILayout.Toggle(Menu_Main.EspAbstractEntityAI, "透视细菌人", new GUILayoutOption[0]);
            Menu_Main.EspDeathRatAI = GUILayout.Toggle(Menu_Main.EspDeathRatAI, "透视老鼠", new GUILayoutOption[0]);
            Menu_Main.EspDeathRatBabyAI = GUILayout.Toggle(Menu_Main.EspDeathRatBabyAI, "透视小老鼠", new GUILayoutOption[0]);
            Menu_Main.EspHumanDogAI = GUILayout.Toggle(Menu_Main.EspHumanDogAI, "透视狗哥", new GUILayoutOption[0]);
            Menu_Main.EspCabinet = GUILayout.Toggle(Menu_Main.EspCabinet, "透视物品柜子", new GUILayoutOption[0]);
            Menu_Main.EspClockPuzzle = GUILayout.Toggle(Menu_Main.EspClockPuzzle, "透视时钟", new GUILayoutOption[0]);
            Menu_Main.EspFlowerpot = GUILayout.Toggle(Menu_Main.EspFlowerpot, "透视花瓶", new GUILayoutOption[0]);
            GUILayout.Box("<b><color=purple>[关闭功能]</color></b>", new GUILayoutOption[0]);
            Menu_Main.open = GUILayout.Toggle(Menu_Main.open, "总开关(退出游戏内点一下)", new GUILayoutOption[0]);
            Menu_Main.DrawLine = GUILayout.Toggle(Menu_Main.DrawLine, "关闭线条透视", new GUILayoutOption[0]);
            //↑ESP
            if (open == true)
            {
                InfiniteRadiation = false;
                InfiniteHealth = false;
                InfiniteStamina = false;
                NoAnxiety = false;
                EspPlayer = false;
                EspAi = false;
                EspElevator = false;
                EspDoor = false;
                EspPartygoerAI = false;
                EspSmilerAI = false;
                EspHumanDogAI = false;
                EspSkinStealerAI = false;
                EspClumpsAI = false;
                EspAbstractEntityAI = false;
                EspDeathRatAI = false;
                EspDeathRatBabyAI = false;
                EspCabinet = false;
                EspClockPuzzle = false;
                EspFlowerpot = false;
    }
            GUI.DragWindow();
            //↑控制开关

        }
        //↓全局变量
        //玩家
        public static float WalkSpeed = 1.5f;
        public static float RunSpeed = 8.0f;
        public static float crouchWalkSpeed = 1.0f;
        public static float Radiation = 0.0f;
        public static bool InfiniteRadiation = false;
        public static bool InfiniteHealth = false;
        public static bool InfiniteStamina = false;
        public static bool NoAnxiety = false;
        public static bool open = false;//关闭功能
        public static bool DrawLine = false;//关闭线条
        //透视
        public static bool EspPlayer = false;
        public static bool EspAi = false;
        public static bool EspElevator = false;
        public static bool EspDoor = false;
        public static bool EspPartygoerAI = false;
        public static bool EspSmilerAI = false;
        public static bool EspHumanDogAI = false;
        public static bool EspSkinStealerAI = false;
        public static bool EspClumpsAI = false;
        public static bool EspAbstractEntityAI = false;
        public static bool EspDeathRatAI = false;
        public static bool EspDeathRatBabyAI = false;
        //物品透视
        public static bool EspCabinet = false;//柜子
        public static bool EspClockPuzzle = false;//时钟
        public static bool EspFlowerpot = false;//花盆
        public static Rect window_Main = new Rect(10f, 10f, 250f, 800f);
    }
}

