using MelonLoader;
namespace Inside_the_Backrooms
{
    public class Main : MelonMod
    {


        public override void OnUpdate()
        {
            Render.Initialize();
            Menu.Update();
            Players.Update();
        }

        public override void OnGUI()
        {
            Menu_Main.OnGUI();
            Esp.OnGUI();
        }

        public override void OnFixedUpdate()
        {
            Esp.FixedUpdate();
        }
    }
}
   

