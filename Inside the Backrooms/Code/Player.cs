using Il2Cpp;

namespace Inside_the_Backrooms
{
    public class Players
    {
        public static void Update()
        {
            if (Esp._LocalPlayer != null)
            {
                //无限血量
                if (Menu_Main.InfiniteHealth)
                {
                    Esp._LocalPlayer.health = 100f;
                }
                //无限耐力
                if (Menu_Main.InfiniteStamina)
                {
                    //public unsafe float Stamina
                    Esp._LocalPlayer.Stamina = 100f;

           
                }
                //辐射
                if (Menu_Main.InfiniteRadiation)
                {

                    Esp._LocalPlayer.m_Radiation = Menu_Main.Radiation;



                }
                //无焦虑
                if (Menu_Main.NoAnxiety)
                {
                    Esp._LocalPlayer.anxiety = 0f;
                }

                if (Esp._LocalPlayer.components != null)
                {

                    PlayerController playerController = Esp._LocalPlayer.components.GetComponent<PlayerController>();
                    if (playerController != null)
                    {


        
                        //蹲下 站起
                        playerController.walkSpeed = Menu_Main.WalkSpeed;  //1.5f
                        playerController.runSpeed = Menu_Main.RunSpeed;  //8.0f
                        playerController.crouchWalkSpeed = Menu_Main.crouchWalkSpeed;//1.0f
                    }
                }
            }
        }
    }
}
