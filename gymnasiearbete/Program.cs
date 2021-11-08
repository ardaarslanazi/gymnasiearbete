using System;
using Raylib_cs;
using System.Numerics;
namespace gymnasiearbete
{
    class Program
    {
        static void Main(string[] args)
        {

            Raylib.InitWindow(1920, 1080, "Gamestate testing");

            Texture2D triangel1 = Raylib.LoadTexture("andy_trekant.png");
            Texture2D fyrkant1 = Raylib.LoadTexture("Michael_fyrkant.png");
            Texture2D cirkel1 = Raylib.LoadTexture("john_rund.png");
            Texture2D triangel2 = Raylib.LoadTexture("shneed_trekant.png");
            Texture2D fyrkant2 = Raylib.LoadTexture("stanly_fyrkant_Ny.png");
            Texture2D cirkel2 = Raylib.LoadTexture("randy_rund.png");
            Texture2D triangel3 = Raylib.LoadTexture("trekanty.png");
            Texture2D fyrkant3 = Raylib.LoadTexture("fyrkanty.png");
            Texture2D cirkel3 = Raylib.LoadTexture("rundy.png");


            int mouseX = 0;
            int mouseY = 0;
            int scene = 1;

            while (!Raylib.WindowShouldClose())
            {

                mouseX = Raylib.GetMouseX();
                mouseY = Raylib.GetMouseY();
                Raylib.BeginDrawing();
                if (Raylib.IsKeyPressed(KeyboardKey.KEY_SPACE))
                {
                    scene++;
                }

                Raylib.ClearBackground(Color.WHITE);

                if (scene == 1)
                {
                    Raylib.DrawText("Vem skulle du ta med dig till en strid?", 450, 50, 50, Color.BLACK);


                    Raylib.DrawTextureEx(triangel1, new Vector2(0, 200), 0, 0.25f, Color.WHITE);
                    Raylib.DrawTextureEx(fyrkant1, new Vector2(600, 200), 0, 0.25f, Color.WHITE);
                    Raylib.DrawTextureEx(cirkel1, new Vector2(1200, 200), 0, 0.25f, Color.WHITE);



                    if (mouseX >= 600 && mouseX <= 1200 && mouseY >= 100 && mouseY <= 1000)
                    {
                        Raylib.DrawText("gaming", 100, 100, 50, Color.BLACK);

                    }
                    if (mouseX >= 1300 && mouseX <= 1800 && mouseY >= 100 && mouseY <= 1000)
                    {
                        Raylib.DrawText("gaming", 100, 100, 50, Color.BLACK);

                    }

                }
                if (scene == 2)
                {
                    Raylib.DrawText("Vem skulle du förlora mot i en stavningstävling?", 450, 50, 50, Color.BLACK);
                    Raylib.DrawTextureEx(triangel2, new Vector2(0, 200), 0, 0.25f, Color.WHITE);
                    Raylib.DrawTextureEx(fyrkant2, new Vector2(600, 200), 0, 0.25f, Color.WHITE);
                    Raylib.DrawTextureEx(cirkel2, new Vector2(1200, 200), 0, 0.25f, Color.WHITE);




                    if (mouseX >= 600 && mouseX <= 1200 && mouseY >= 100 && mouseY <= 1000)
                    {
                        Raylib.DrawText("gaming", 100, 100, 50, Color.BLACK);

                    }
                    if (mouseX >= 1300 && mouseX <= 1800 && mouseY >= 100 && mouseY <= 1000)
                    {
                        Raylib.DrawText("gaming", 100, 100, 50, Color.BLACK);

                    }

                }
                if (scene == 3)
                {
                    Raylib.DrawText("Vem skulle du låna ut 100 kr till?", 450, 50, 50, Color.BLACK);
                    Raylib.DrawTextureEx(triangel3, new Vector2(0, 200), 0, 0.25f, Color.WHITE);
                    Raylib.DrawTextureEx(fyrkant3, new Vector2(600, 200), 0, 0.25f, Color.WHITE);
                    Raylib.DrawTextureEx(cirkel3, new Vector2(1200, 200), 0, 0.25f, Color.WHITE);


                    if (mouseX >= 600 && mouseX <= 1200 && mouseY >= 100 && mouseY <= 1000)
                    {
                        Raylib.DrawText("gaming", 100, 100, 50, Color.BLACK);

                    }
                    if (mouseX >= 1300 && mouseX <= 1800 && mouseY >= 100 && mouseY <= 1000)
                    {
                        Raylib.DrawText("gaming", 100, 100, 50, Color.BLACK);

                    }

                }
                if (scene == 4)
                {
                    Raylib.DrawText("Vilken tycker du ser mer snäll ut?", 450, 50, 50, Color.BLACK);
                    Raylib.DrawTextureEx(triangel2, new Vector2(0, 200), 0, 0.25f, Color.WHITE);
                    Raylib.DrawTextureEx(fyrkant1, new Vector2(600, 200), 0, 0.25f, Color.WHITE);
                    Raylib.DrawTextureEx(cirkel3, new Vector2(1200, 200), 0, 0.25f, Color.WHITE);


                    if (mouseX >= 600 && mouseX <= 1200 && mouseY >= 100 && mouseY <= 1000)
                    {
                        Raylib.DrawText("gaming", 100, 100, 50, Color.BLACK);

                    }
                    if (mouseX >= 1300 && mouseX <= 1800 && mouseY >= 100 && mouseY <= 1000)
                    {
                        Raylib.DrawText("gaming", 100, 100, 50, Color.BLACK);

                    }

                }
                if (scene == 5)
                {
                    Raylib.DrawText("Vilken tycker du ser mer snäll ut?", 450, 50, 50, Color.BLACK);
                    Raylib.DrawTextureEx(triangel3, new Vector2(0, 200), 0, 0.25f, Color.WHITE);
                    Raylib.DrawTextureEx(fyrkant1, new Vector2(600, 200), 0, 0.25f, Color.WHITE);
                    Raylib.DrawTextureEx(cirkel2, new Vector2(1200, 200), 0, 0.25f, Color.WHITE);


                    if (mouseX >= 600 && mouseX <= 1200 && mouseY >= 100 && mouseY <= 1000)
                    {
                        Raylib.DrawText("gaming", 100, 100, 50, Color.BLACK);

                    }
                    if (mouseX >= 1300 && mouseX <= 1800 && mouseY >= 100 && mouseY <= 1000)
                    {
                        Raylib.DrawText("gaming", 100, 100, 50, Color.BLACK);

                    }

                }
                if (scene == 6)
                {
                    Raylib.DrawText("Vem skulle du förlora mot i en frågesport?", 450, 50, 50, Color.BLACK);
                    Raylib.DrawTextureEx(triangel1, new Vector2(0, 200), 0, 0.25f, Color.WHITE);
                    Raylib.DrawTextureEx(fyrkant3, new Vector2(600, 200), 0, 0.25f, Color.WHITE);
                    Raylib.DrawTextureEx(cirkel2, new Vector2(1200, 200), 0, 0.25f, Color.WHITE);


                    if (mouseX >= 600 && mouseX <= 1200 && mouseY >= 100 && mouseY <= 1000)
                    {
                        Raylib.DrawText("gaming", 100, 100, 50, Color.BLACK);

                    }
                    if (mouseX >= 1300 && mouseX <= 1800 && mouseY >= 100 && mouseY <= 1000)
                    {
                        Raylib.DrawText("gaming", 100, 100, 50, Color.BLACK);

                    }

                }
                Raylib.EndDrawing();
            }

        }
    }
}
