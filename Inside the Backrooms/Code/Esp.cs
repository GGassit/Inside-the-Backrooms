using Il2Cpp;
using Il2CppRootMotion.Demos;
using Il2CppSystem.Globalization;
using Inside_the_Backrooms;
using System;
using System.Collections.Generic;
using UnityEngine;
using Harmony;
using UnityEngine.Rendering;
using UnityEngine.PlayerLoop;
using Il2CppRootMotion.FinalIK;
using Il2CppRootMotion;
using UnityEngine.Events;
using System.ComponentModel.Design;
using System.Security.Cryptography;
using Il2CppInternal;
using System.ComponentModel;
using UnityEngine.InputSystem.XR;
using UnityEngine.Windows.WebCam;
using Il2CppSubtitlesSystem;



//li2cpp
namespace Inside_the_Backrooms
{
    public class Esp
    {
       //LegIK
       //LimbIK
       //LookAtIK
       //添加
        public static readonly float CachePlayerListInterval = 5f;
        public static float _nextPlayerListCacheTime;
        public static void FixedUpdate()
        {
            if (Time.time >= _nextPlayerListCacheTime)
            {

                    Esp._Player.Clear();
                foreach (PlayerStats player in UnityEngine.Object.FindObjectsOfType<PlayerStats>())
                {
                    if (player != null && !player.isDead)
                    {
                        if (player.isLocalPlayer)
                        {
                            Esp._LocalPlayer = player;
                        }
                        else
                        {
                            Esp._Player.Add(player);
                        }
                    }
                }

                if (Esp._LocalPlayer != null)
                {
                    Esp._Camera = Esp._LocalPlayer.components.Camera.CameraComponent;
                }

                Esp._BaseAIEntity.Clear();
                if (Menu_Main.EspAi)
                {
                    foreach (BaseAIEntity baseAIEntity in UnityEngine.Object.FindObjectsOfType<BaseAIEntity>())
                    {
                        if (baseAIEntity != null)
                        {
                            Esp._BaseAIEntity.Add(baseAIEntity);
                        }
                    }
                }
        
                Esp._Elevator.Clear();
                if (Menu_Main.EspElevator)
                {
                    foreach (Elevator elevator in UnityEngine.Object.FindObjectsOfType<Elevator>())
                    {
                        if (elevator != null)
                        {
                            Esp._Elevator.Add(elevator);
                        }
                    }
                }

                Esp._Door.Clear();
                if (Menu_Main.EspDoor)
                {
                    foreach (Door door in UnityEngine.Object.FindObjectsOfType<Door>())
                    {
                        if (door != null)
                        {
                            Esp._Door.Add(door);
                        }
                    }
                }

                //笑脸
                Esp._EspSmilerAI.Clear();
                if (Menu_Main.EspSmilerAI)
                {

                    foreach (SmilerAI EspSmilerAI in UnityEngine.Object.FindObjectsOfType<SmilerAI>())
                    {
                        if (EspSmilerAI != null)
                        {
                            Esp._EspSmilerAI.Add(EspSmilerAI);
                        }
                    }
                }
                //派对客
                Esp._EspPartygoerAI.Clear();
                if (Menu_Main.EspPartygoerAI)
                {

                    foreach (PartygoerAI EspPartygoerAI in UnityEngine.Object.FindObjectsOfType<PartygoerAI>())
                    {
                        if (EspPartygoerAI != null)
                        {
                            Esp._EspPartygoerAI.Add(EspPartygoerAI);
                        }
                    }
                }
                //狗哥
                Esp._EspHumanDogAI.Clear();
                if (Menu_Main.EspHumanDogAI)
                {

                    foreach (HumanDogAI EspHumanDogAI in UnityEngine.Object.FindObjectsOfType<HumanDogAI>())
                    {
                        if (EspHumanDogAI != null)
                        {
                            Esp._EspHumanDogAI.Add(EspHumanDogAI);
                        }
                    }
                }
                //窃皮
                //public static List<SkinStealerAI> _EspSkinStealerAI = new List<SkinStealerAI>();
                Esp._EspSkinStealerAI.Clear();
                if (Menu_Main.EspSkinStealerAI)
                {

                    foreach (SkinStealerAI EspSkinStealerAI in UnityEngine.Object.FindObjectsOfType<SkinStealerAI>())
                    {
                        if (EspSkinStealerAI != null)
                        {
                            Esp._EspSkinStealerAI.Add(EspSkinStealerAI);
                        }
                    }
                }
                //肢团
                Esp._EspClumpsAI.Clear();
                if (Menu_Main.EspClumpsAI)
                {

                    foreach (ClumpsAI EspClumpsAI in UnityEngine.Object.FindObjectsOfType<ClumpsAI>())
                    {
                        if (EspClumpsAI != null)
                        {
                            Esp._EspClumpsAI.Add(EspClumpsAI);
                        }
                    }
                }
                //细菌人
                Esp._EspAbstractEntityAI.Clear();
                if (Menu_Main.EspAbstractEntityAI)
                {

                    foreach (AbstractEntityAI EspAbstractEntityAI in UnityEngine.Object.FindObjectsOfType<AbstractEntityAI>())
                    {
                        if (EspAbstractEntityAI != null)
                        {
                            Esp._EspAbstractEntityAI.Add(EspAbstractEntityAI);
                        }
                    }
                }
                //老鼠
                Esp._EspDeathRatAI.Clear();
                if (Menu_Main.EspDeathRatAI)
                {

                    foreach (DeathRatAI EspDeathRatAI in UnityEngine.Object.FindObjectsOfType<DeathRatAI>())
                    {
                        if (EspDeathRatAI != null)
                        {
                            Esp._EspDeathRatAI.Add(EspDeathRatAI);
                        }
                    }
                }
                //小老鼠
                Esp._EspDeathRatBabyAI.Clear();
                if (Menu_Main.EspDeathRatBabyAI)
                {

                    foreach (DeathRatBabyAI EspDeathRatBabyAI in UnityEngine.Object.FindObjectsOfType<DeathRatBabyAI>())
                    {
                        if (EspDeathRatBabyAI != null)
                        {
                            Esp._EspDeathRatBabyAI.Add(EspDeathRatBabyAI);
                        }
                    }
                }
                //public static List<Cabinet> _EspCabinet = new List<Cabinet>();//柜子
                Esp._EspCabinet.Clear();
                if (Menu_Main.EspCabinet)
                {

                    foreach (Cabinet EspCabinet in UnityEngine.Object.FindObjectsOfType<Cabinet>())
                    {
                        if (EspCabinet != null)
                        {
                            Esp._EspCabinet.Add(EspCabinet);
                        }
                    }
                }
                //public static List<ClockPuzzle> _EspClockPuzzle = new List<ClockPuzzle>();//时钟
                Esp._EspClockPuzzle.Clear();
                if (Menu_Main.EspClockPuzzle)
                {

                    foreach (ClockPuzzle EspClockPuzzle in UnityEngine.Object.FindObjectsOfType<ClockPuzzle>())
                    {
                        if (EspClockPuzzle != null)
                        {
                            Esp._EspClockPuzzle.Add(EspClockPuzzle);
                        }
                    }
                }

       

                // public static List<Flowerpot> _EspFlowerpot = new List<Flowerpot>();//花盆
                Esp._EspFlowerpot.Clear();
                if (Menu_Main.EspFlowerpot)
                {

                    foreach (Flowerpot EspFlowerpot in UnityEngine.Object.FindObjectsOfType<Flowerpot>())
                    {
                        if (EspFlowerpot != null)
                        {
                            Esp._EspFlowerpot.Add(EspFlowerpot);
                        }
                    }
                }

                _nextPlayerListCacheTime = Time.time + CachePlayerListInterval;
            }
        }
        //开始绘制
        public static void OnGUI()
        {
            Render.DrawString(5, 10, "<b><color=red>一个真正的man，一个真正的男人，他清楚自己要做什么，如果你真的想要看这个人，是一个男孩还是男人？不要去看他的body，看他的心。</color></b>", false);
            Render.DrawString(5, 40, "<b><color=blue>Mono注入成功！</color></b>", false);
            //玩家
            if (Menu_Main.EspPlayer)
            {
                foreach (PlayerStats player in Esp._Player)
                {
                    //判断有没有玩家且没有死

                    if (player != null && !player.isDead)
                    {

                        float num = Vector3.Distance(player.transform.position, Esp._Camera.transform.position);
                        //获取玩家位置WTS
                        Vector3 Root = Esp._Camera.WorldToScreenPoint(player.transform.position);
                        //获取线位置
                        Vector2 Roots = Esp._Camera.WorldToViewportPoint(player.transform.right);
                        if (Root.z >= 0f)
                        {
                            Root.y = Screen.height - Root.y;

                            Render.DrawString(Root.x, Root.y, string.Format("<size=11><b>[{0}米]<color=green>{1}</color></b></size>", Math.Round(num), player.components.Info.PlayerName));
                            if (Menu_Main.DrawLine == true)
                            {
                                Render.DrawLine(Roots, Root);
                            }
                        }
                    }
                }
            }
            //全部AI实体
            if (Menu_Main.EspAi)
            {
                foreach (BaseAIEntity baseAIEntity in Esp._BaseAIEntity)
                {


                    if (baseAIEntity != null)
                    {
                        float num = Vector3.Distance(baseAIEntity.transform.position, Esp._Camera.transform.position);
                        Vector3 Root = Esp._Camera.WorldToScreenPoint(baseAIEntity.transform.position);
                        Vector2 Roots = Esp._Camera.WorldToViewportPoint(baseAIEntity.transform.right);
                        if (Root.z >= 0f)
                        {
                            Root.y = Screen.height - Root.y;


                            Render.DrawString(Root.x, Root.y, string.Format("<size=11><b>[{0}米]<color=#FFD700>（屎稳神）</color></b></size>", Math.Round(num)));
                            if (Menu_Main.DrawLine == true)
                            {
                                Render.DrawLine(Roots, Root);
                            }
                          
                        }
                    }
                }
            }
            //电梯
            if (Menu_Main.EspElevator)
            {
                foreach (Elevator elevator in Esp._Elevator)
                {
                    if (elevator != null)
                    {
                        float num = Vector3.Distance(elevator.transform.position, Esp._Camera.transform.position);
                        Vector3 Root = Esp._Camera.WorldToScreenPoint(elevator.transform.position);
                        Vector2 Roots = Esp._Camera.WorldToViewportPoint(elevator.transform.right);
                        if (Root.z >= 0f)
                        {
                            Root.y = Screen.height - Root.y;

                            Render.DrawString(Root.x, Root.y, string.Format("<size=11><b>[{0}米]<color=#2E8B57>电梯</color></b></size>", Math.Round(num)));
                            if (Menu_Main.DrawLine == true)
                            {
                                Render.DrawLine(Roots, Root);
                            }
           
                        }
                    }
                }
            }
            //派对客
            if (Menu_Main.EspPartygoerAI)
            {

                foreach (PartygoerAI EspPartygoerAI in Esp._EspPartygoerAI)
                {


                    if (EspPartygoerAI != null)
                    {

                        float num = Vector3.Distance(EspPartygoerAI.transform.position, Esp._Camera.transform.position);
                        Vector3 Root = Esp._Camera.WorldToScreenPoint(EspPartygoerAI.transform.position);
                        Vector2 Roots = Esp._Camera.WorldToViewportPoint(EspPartygoerAI.transform.right);
                        if (Root.z >= 0f)
                        {
                            Root.y = Screen.height - Root.y;

                            Render.DrawString(Root.x, Root.y, string.Format("<size=11><b>[{0}米]<color=#00BFFF>派对客!</color></b></size>", Math.Round(num)));

                            if (Menu_Main.DrawLine == true)
                            {
                                Render.DrawLine(Roots, Root);
                            }
                        }


                    }

                }
            }
            //窃皮
            if (Menu_Main.EspSkinStealerAI)
            {

                foreach (SkinStealerAI EspSkinStealerAI in Esp._EspSkinStealerAI)
                {


                    if (EspSkinStealerAI != null)
                    {

                        float num = Vector3.Distance(EspSkinStealerAI.transform.position, Esp._Camera.transform.position);
                        Vector3 Root = Esp._Camera.WorldToScreenPoint(EspSkinStealerAI.transform.position);
                        Vector2 Roots = Esp._Camera.WorldToViewportPoint(EspSkinStealerAI.transform.right);
                        if (Root.z >= 0f)
                        {
                            Root.y = Screen.height - Root.y;

                            Render.DrawString(Root.x, Root.y, string.Format("<size=11><b>[{0}米]<color=#9932CC>窃皮!</color></b></size>", Math.Round(num)));

                            if (Menu_Main.DrawLine == true)
                            {
                                Render.DrawLine(Roots, Root);
                            }
                        }


                    }

                }
            }
            //SmilerAI  笑脸
            if (Menu_Main.EspSmilerAI)
            {

                foreach (SmilerAI EspSmilerAI in Esp._EspSmilerAI)
                {


                    if (EspSmilerAI != null)
                    {

                        float num = Vector3.Distance(EspSmilerAI.transform.position, Esp._Camera.transform.position);
                        Vector3 Root = Esp._Camera.WorldToScreenPoint(EspSmilerAI.transform.position);
                        Vector2 Roots = Esp._Camera.WorldToViewportPoint(EspSmilerAI.transform.right);
                        if (Root.z >= 0f)
                        {
                            Root.y = Screen.height - Root.y;

                            Render.DrawString(Root.x, Root.y, string.Format("<size=11><b>[{0}米]<color=#DC143C>笑脸!</color></b></size>", Math.Round(num)));

                            if (Menu_Main.DrawLine == true)
                            {
                                Render.DrawLine(Roots, Root);
                            }
                        }


                    }


                }
            }
            //HumanDogAI  狗哥
            if (Menu_Main.EspHumanDogAI)
            {
                foreach (HumanDogAI EspHumanDogAI in Esp._EspHumanDogAI)
                {


                    if (EspHumanDogAI != null)
                    {

                        float num = Vector3.Distance(EspHumanDogAI.transform.position, Esp._Camera.transform.position);
                        Vector3 Root = Esp._Camera.WorldToScreenPoint(EspHumanDogAI.transform.position);
                        Vector2 Roots = Esp._Camera.WorldToViewportPoint(EspHumanDogAI.transform.right);
                        if (Root.z >= 0f)
                        {
                            Root.y = Screen.height - Root.y;
                            Render.DrawString(Root.x, Root.y, string.Format("<size=11><b>[{0}米]<color=#B8860B>狗哥!</color></b></size>", Math.Round(num)));

                            if (Menu_Main.DrawLine == true)
                            {
                                Render.DrawLine(Roots, Root);
                            }
                        }
                    }
                }
            }
            //ClumpsAI  肢团
            if (Menu_Main.EspClumpsAI)
            {

                foreach (ClumpsAI EspClumpsAI in Esp._EspClumpsAI)
                {


                    if (EspClumpsAI != null)
                    {

                        float num = Vector3.Distance(EspClumpsAI.transform.position, Esp._Camera.transform.position);
                        Vector3 Root = Esp._Camera.WorldToScreenPoint(EspClumpsAI.transform.position);

                        Vector2 Roots = Esp._Camera.WorldToViewportPoint(EspClumpsAI.transform.right);
                        if (Root.z >= 0f)
                        {
                            Root.y = Screen.height - Root.y;
                            Render.DrawString(Root.x, Root.y, string.Format("<size=11><b>[{0}米]<color=#0000FF>肢团!</color></b></size>", Math.Round(num)));

                            if (Menu_Main.DrawLine == true)
                            {
                                Render.DrawLine(Roots, Root);
                            }
                        }
                    }
                }
            }
            // public static List<AbstractEntityAI> _EspAbstractEntityAI = new List<AbstractEntityAI>();
            //细菌人
            if (Menu_Main.EspAbstractEntityAI)
            {

                foreach (AbstractEntityAI EspAbstractEntityAI in Esp._EspAbstractEntityAI)
                {


                    if (EspAbstractEntityAI != null)
                    {

                        float num = Vector3.Distance(EspAbstractEntityAI.transform.position, Esp._Camera.transform.position);
                        Vector3 Root = Esp._Camera.WorldToScreenPoint(EspAbstractEntityAI.transform.position);
                        Vector2 Roots = Esp._Camera.WorldToViewportPoint(EspAbstractEntityAI.transform.right);
                        if (Root.z >= 0f)
                        {
                            Root.y = Screen.height - Root.y;
                            Render.DrawString(Root.x, Root.y, string.Format("<size=11><b>[{0}米]<color=#000000>细菌人!</color></b></size>", Math.Round(num)));
                            if (Menu_Main.DrawLine == true)
                            {
                                Render.DrawLine(Roots, Root);
                            }
                        }
                    }
                }
            }
            //老鼠
            //public static List<DeathRatAI> _EspDeathRatAI = new List<DeathRatAI>();
            if (Menu_Main.EspDeathRatAI)
            {

                foreach (DeathRatAI EspDeathRatAI in Esp._EspDeathRatAI)
                {
                    if (EspDeathRatAI != null)
                    {
                        float num = Vector3.Distance(EspDeathRatAI.transform.position, Esp._Camera.transform.position);
                        Vector3 Root = Esp._Camera.WorldToScreenPoint(EspDeathRatAI.transform.position);
                        Vector2 Roots = Esp._Camera.WorldToViewportPoint(EspDeathRatAI.transform.right);
                        if (Root.z >= 0f)
                        {
                            Root.y = Screen.height - Root.y;
                            Render.DrawString(Root.x, Root.y, string.Format("<size=11><b>[{0}米]<color=#D2691E>老鼠!</color></b></size>", Math.Round(num)));
                            if (Menu_Main.DrawLine == true)
                            {
                                Render.DrawLine(Roots, Root);
                            }
                        }
                    }
                }
            }
            //小老鼠
            //  public static List<DeathRatBabyAI> _EspDeathRatBabyAI = new List<DeathRatBabyAI>();
            if (Menu_Main.EspDeathRatBabyAI)
            {

                foreach (DeathRatBabyAI EspDeathRatBabyAI in Esp._EspDeathRatBabyAI)
                {
                    if (EspDeathRatBabyAI != null)
                    {

                        float num = Vector3.Distance(EspDeathRatBabyAI.transform.position, Esp._Camera.transform.position);
                        Vector3 Root = Esp._Camera.WorldToScreenPoint(EspDeathRatBabyAI.transform.position);
                        Vector2 Roots = Esp._Camera.WorldToViewportPoint(EspDeathRatBabyAI.transform.right);
                        if (Root.z >= 0f)
                        {
                            Root.y = Screen.height - Root.y;
                            Render.DrawString(Root.x, Root.y, string.Format("<size=11><b>[{0}米]<color=#FF7F50>小老鼠!</color></b></size>", Math.Round(num)));

                            if (Menu_Main.DrawLine == true)
                            {
                                Render.DrawLine(Roots, Root);
                            }
                        }
                    }
                }
            }

            //public static List<Cabinet> _EspCabinet = new List<Cabinet>();//柜子
            if (Menu_Main.EspCabinet)
            {

                foreach (Cabinet EspCabinet in Esp._EspCabinet)
                {
                    if (EspCabinet != null)
                    {

                        float num = Vector3.Distance(EspCabinet.transform.position, Esp._Camera.transform.position);
                        Vector3 Root = Esp._Camera.WorldToScreenPoint(EspCabinet.transform.position);
                        Vector2 Roots = Esp._Camera.WorldToViewportPoint(EspCabinet.transform.right);
                        if (Root.z >= 0f)
                        {
                            Root.y = Screen.height - Root.y;
                            Render.DrawString(Root.x, Root.y, string.Format("<size=11><b>[{0}米]<color=#22d893>物品柜子!</color></b></size>", Math.Round(num)));

                            if (Menu_Main.DrawLine == true)
                            {
                                Render.DrawLine(Roots, Root);
                            }
                        }
                    }
                }
            }
            //public static List<ClockPuzzle> _EspClockPuzzle = new List<ClockPuzzle>();//时钟
            if (Menu_Main.EspClockPuzzle)
            {

                foreach (ClockPuzzle EspClockPuzzle in Esp._EspClockPuzzle)
                {
                    if (EspClockPuzzle != null)
                    {

                        float num = Vector3.Distance(EspClockPuzzle.transform.position, Esp._Camera.transform.position);
                        Vector3 Root = Esp._Camera.WorldToScreenPoint(EspClockPuzzle.transform.position);
                        Vector2 Roots = Esp._Camera.WorldToViewportPoint(EspClockPuzzle.transform.right);
                        if (Root.z >= 0f)
                        {
                            Root.y = Screen.height - Root.y;
                            Render.DrawString(Root.x, Root.y, string.Format("<size=11><b>[{0}米]<color=#daa3cd>时钟!</color></b></size>", Math.Round(num)));

                            if (Menu_Main.DrawLine == true)
                            {
                                Render.DrawLine(Roots, Root);
                            }
                        }
                    }
                }
            }
    
      
            // public static List<Flowerpot> _EspFlowerpot = new List<Flowerpot>();//花盆
            if (Menu_Main.EspFlowerpot)
            {

                foreach (Flowerpot EspFlowerpot in Esp._EspFlowerpot)
                {
                    if (EspFlowerpot != null)
                    {

                        float num = Vector3.Distance(EspFlowerpot.transform.position, Esp._Camera.transform.position);
                        Vector3 Root = Esp._Camera.WorldToScreenPoint(EspFlowerpot.transform.position);
                        Vector2 Roots = Esp._Camera.WorldToViewportPoint(EspFlowerpot.transform.right);
                        if (Root.z >= 0f)
                        {
                            Root.y = Screen.height - Root.y;
                            Render.DrawString(Root.x, Root.y, string.Format("<size=11><b>[{0}米]<color=#6566ad>花瓶!</color></b></size>", Math.Round(num)));

                            if (Menu_Main.DrawLine == true)
                            {
                                Render.DrawLine(Roots, Root);
                            }
                        }
                    }
                }
            }
            //门
            if (Menu_Main.EspDoor)
            {
                foreach (Door door in Esp._Door)
                {
                    if (door != null)
                    {
                        float num = Vector3.Distance(door.transform.position, Esp._Camera.transform.position);
                        Vector3 Root = Esp._Camera.WorldToScreenPoint(door.transform.position);

                        Vector2 Position = Esp._Camera.WorldToScreenPoint(door.transform.position);
                        Vector2 Roots = Esp._Camera.WorldToViewportPoint(door.transform.right);

                        if (Root.z >= 0f)
                        {
                            Root.y = Screen.height - Root.y;
                            Render.DrawString(Root.x, Root.y, string.Format("<size=11><b>[{0}米]<color=#008B8B>门</color></b></size>", Math.Round(num)));
                            Position.y = Screen.height - Position.y;
                            if (Menu_Main.DrawLine == true)
                            {
                                Render.DrawLine(Roots, Root);
                            }
                            //Render.Draw2DBox(Position, Roots);
                        }
                    }
                }
            }
        }

        //AI 类名
        //anxiety
        //AbstractEntityAI  细菌人
        //DeathRatAI 死亡鼠
        //DeathRatBabyAI  死亡鼠（小）
        //PasswordDeriveBytes
        //EspHumanDogAI
        //WorldToScreenPoint     WTS  
        //获取坐标


        //转储   解决静态问题。
        public static Camera _Camera = null;
        public static PlayerStats _LocalPlayer = null;
        public static List<PlayerStats> _Player = new List<PlayerStats>();
        public static List<BaseAIEntity> _BaseAIEntity = new List<BaseAIEntity>();
        public static List<Elevator> _Elevator = new List<Elevator>();
        public static List<Door> _Door = new List<Door>();
        public static List<PartygoerAI> _EspPartygoerAI = new List<PartygoerAI>();
        public static List<SmilerAI> _EspSmilerAI = new List<SmilerAI>();
        public static List<HumanDogAI> _EspHumanDogAI = new List<HumanDogAI>();
        public static List<SkinStealerAI> _EspSkinStealerAI = new List<SkinStealerAI>();
        public static List<ClumpsAI> _EspClumpsAI = new List<ClumpsAI>();
        public static List<AbstractEntityAI> _EspAbstractEntityAI = new List<AbstractEntityAI>();
        public static List<DeathRatAI> _EspDeathRatAI = new List<DeathRatAI>();
        public static List<DeathRatBabyAI> _EspDeathRatBabyAI = new List<DeathRatBabyAI>();   
        public static List<Eyes> _EspEyes = new List<Eyes>();
        
        //物品类
        public static List<Cabinet> _EspCabinet = new List<Cabinet>();//物品柜子
        public static List<ClockPuzzle> _EspClockPuzzle = new List<ClockPuzzle>();//时钟
        public static List<Flowerpot> _EspFlowerpot = new List<Flowerpot>();//花盆
        public static List<Giftbox> _EspGiftbox = new List<Giftbox>();//礼品盒
        //ExtinguisherSmoke  灭火器
        //Flowerpot 花盆
       // PlayerGear
       //  AirVent
    }

}
