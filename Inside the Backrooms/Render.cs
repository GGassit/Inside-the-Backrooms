using System;
using UnityEngine;

namespace Inside_the_Backrooms
{
    public class Render
    {
        public const int TRIANGLES = 4;
        public const int TRIANGLE_STRIP = 5;
        public const int QUADS = 7;
        public const int LINES = 1;
        public const int LINE_STRIP = 2;

        public static void Initialize()
        {
            if (Render.LineMaterial == null)
            {
                Material material = new Material(Shader.Find("Hidden/Internal-Colored"));
                material.hideFlags = HideFlags.HideAndDontSave;
                Render.LineMaterial = material;
                Render.LineMaterial.SetInt("_SrcBlend", 5);
                Render.LineMaterial.SetInt("_DstBlend", 10);
                Render.LineMaterial.SetInt("_Cull", 0);
                Render.LineMaterial.SetInt("_ZWrite", 0);
            }
        }

        public static Color ToColor(float r, float g, float b, float a = 255f)
        {
            return new Color(r / 255f, g / 255f, b / 255f, a / 255f);
        }

        //绘制文字
        public static void DrawString(float x, float y, string text, bool center = true)
        {
            Vector2 TextSize = GUI.skin.label.CalcSize(new GUIContent(text));
            if (center)
            {
                x -= TextSize.x / 2;
            }
            GUI.Label(new Rect(x, y, TextSize.x, TextSize.y), text);
        }

        //绘制直线
        public static void DrawLine(Vector2 a1, Vector2 a2)
        {
            GL.PushMatrix(); //保存当前Matirx
            Render.LineMaterial.SetPass(0); //刷新当前材质
            //GL.LoadPixelMatrix();//设置Matrix  
            GL.LoadPixelMatrix(0, Screen.width, Screen.height, 0);//设置Matrix  
            GL.Begin(Render.LINES);
            GL.Color(Render.ToColor(50f, 205f, 50f, 255f));
            GL.Vertex3(a1.x, a1.y, 0f);
            GL.Vertex3(a2.x, a2.y, 0f);
            GL.End();
            GL.PopMatrix();  //读取之前的Matrix
        }

        //绘制方框
        public static void Draw2DBox(Vector3 Head, Vector3 Root)
        {
            float BoxHeight = Math.Abs(Root.y - Head.y);
            float BoxWidth = BoxHeight / 2f;
            float xVal = Head.x - (BoxWidth / 2f);

            GL.PushMatrix(); //保存当前Matirx
            Render.LineMaterial.SetPass(0); //刷新当前材质
            //GL.LoadPixelMatrix();//设置Matrix  
            GL.LoadPixelMatrix(0, Screen.width, Screen.height, 0);//设置Matrix  
            GL.Begin(Render.LINES);
            GL.Color(ToColor(35f, 32f, 39f, 255f));

            GL.Vertex3(xVal, Head.y, 0f);
            GL.Vertex3(xVal, Head.y + BoxHeight, 0f);
            GL.Vertex3(xVal, Head.y, 0f);
            GL.Vertex3(xVal + BoxWidth, Head.y, 0f);
            GL.Vertex3(xVal + BoxWidth, Head.y, 0f);
            GL.Vertex3(xVal + BoxWidth, Head.y + BoxHeight, 0f);
            GL.Vertex3(xVal, Head.y + BoxHeight, 0f);
            GL.Vertex3(xVal + BoxWidth, Head.y + BoxHeight, 0f);

            GL.End();
            GL.PopMatrix();  //读取之前的Matrix
        }



        public static Material LineMaterial = null;
    }
}
