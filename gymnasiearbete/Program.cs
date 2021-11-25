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
            Texture2D frame = Raylib.LoadTexture("frame.png");



            int mouseX = 0;
            int mouseY = 0;
            int scene = 1;
            int first = 0;
            int second = 0;
            int third = 0;
            int fourth = 0;
            int fifth = 0;
            int sixth = 0;
            int seventh = 0;
            int eighth = 0;
            int ninth = 0;
            int tenth = 0;

            while (!Raylib.WindowShouldClose())
            {

                mouseX = Raylib.GetMouseX();
                mouseY = Raylib.GetMouseY();
                Raylib.BeginDrawing();
                if (Raylib.IsKeyPressed(KeyboardKey.KEY_SPACE))
                {
                    scene++;
                }
                if (Raylib.IsKeyPressed(KeyboardKey.KEY_DELETE))
                {
                    scene--;
                }

                /*if (scene == 2)
               {
                   if (mouseX >= 0 && mouseX <= 600 && mouseY >= 100 && mouseY <= 1000)
                   {
                       if (Raylib.IsMouseButtonPressed(MouseButton.MOUSE_LEFT_BUTTON))
                       {
                           second++;
                           scene++;

                       }
                   }
               } */


                if (scene == 1)
                {
                    if ((mouseX >= 600 && mouseX <= 1200 && mouseY >= 100 && mouseY <= 1000))
                    {
                        if (Raylib.IsMouseButtonPressed(MouseButton.MOUSE_LEFT_BUTTON))
                        {
                            first = 2;

                        }
                        if (scene == 1)
                        {
                            if (mouseX >= 0 && mouseX <= 600 && mouseY >= 100 && mouseY <= 1000)
                            {
                                if (Raylib.IsMouseButtonDown(MouseButton.MOUSE_LEFT_BUTTON))
                                {
                                    first++;
                                    scene++;

                                }
                            }
                        }
                    }
                }

                Raylib.ClearBackground(Color.WHITE);

                if (mouseX >= 0 && mouseX <= 600 && mouseY >= 100 && mouseY <= 1000)
                {
                    Raylib.DrawTextureEx(frame, new Vector2(0, 150), 0, 0.62f, Color.WHITE);


                }
                if (mouseX >= 600 && mouseX <= 1200 && mouseY >= 100 && mouseY <= 1000)
                {
                    Raylib.DrawTextureEx(frame, new Vector2(600, 150), 0, 0.62f, Color.WHITE);

                }
                if (mouseX >= 1300 && mouseX <= 1800 && mouseY >= 100 && mouseY <= 1000)
                {
                    Raylib.DrawTextureEx(frame, new Vector2(1200, 150), 0, 0.62f, Color.WHITE);


                }


                if (scene == 1)
                {
                    Raylib.DrawText("Vem skulle du ta med dig till en strid?", 450, 50, 50, Color.BLACK);


                    Raylib.DrawTextureEx(triangel1, new Vector2(0, 200), 0, 0.25f, Color.WHITE);
                    Raylib.DrawTextureEx(fyrkant1, new Vector2(600, 200), 0, 0.25f, Color.WHITE);
                    Raylib.DrawTextureEx(cirkel1, new Vector2(1200, 200), 0, 0.25f, Color.WHITE);


                    if (mouseX >= 0 && mouseX <= 600 && mouseY >= 100 && mouseY <= 1000 && scene == 1)
                    {
                        if (Raylib.IsMouseButtonDown(MouseButton.MOUSE_LEFT_BUTTON))
                        {
                            first++;
                            scene++;
                            Raylib.ClearBackground(Color.WHITE);

                        }
                    }


                    if (mouseX >= 600 && mouseX <= 1200 && mouseY >= 100 && mouseY <= 1000)
                    {
                        if (Raylib.IsMouseButtonDown(MouseButton.MOUSE_LEFT_BUTTON))
                        {
                            first = 2;
                            scene++;

                        }
                    }
                    if (mouseX >= 1300 && mouseX <= 1800 && mouseY >= 100 && mouseY <= 1000)
                    {
                        if (Raylib.IsMouseButtonPressed(MouseButton.MOUSE_LEFT_BUTTON))
                        {
                            first = 3;
                            scene++;

                        }
                    }





                }
                if (scene == 2)
                {

                    Raylib.DrawText("Vem skulle du förlora mot i en stavningstävling?", 450, 50, 50, Color.BLACK);
                    Raylib.DrawTextureEx(triangel2, new Vector2(0, 200), 0, 0.25f, Color.WHITE);
                    Raylib.DrawTextureEx(fyrkant2, new Vector2(600, 200), 0, 0.25f, Color.WHITE);
                    Raylib.DrawTextureEx(cirkel2, new Vector2(1200, 200), 0, 0.25f, Color.WHITE);

                    if (mouseX >= 0 && mouseX <= 600 && mouseY >= 100 && mouseY <= 1000 && scene == 2)
                    {
                        if (Raylib.IsMouseButtonPressed(MouseButton.MOUSE_LEFT_BUTTON))
                        {
                            first++;
                            scene++;

                        }
                    }


                    if (mouseX >= 600 && mouseX <= 1200 && mouseY >= 100 && mouseY <= 1000)
                    {
                        if (Raylib.IsMouseButtonPressed(MouseButton.MOUSE_LEFT_BUTTON))
                        {
                            first = 2;
                            scene++;

                        }
                    }
                    if (mouseX >= 1300 && mouseX <= 1800 && mouseY >= 100 && mouseY <= 1000)
                    {
                        if (Raylib.IsMouseButtonPressed(MouseButton.MOUSE_LEFT_BUTTON))
                        {
                            first = 3;
                            scene++;

                        }
                    }






                    /*if (mouseX >= 600 && mouseX <= 1200 && mouseY >= 100 && mouseY <= 1000)
                    {
                        if (Raylib.IsMouseButtonPressed(MouseButton.MOUSE_LEFT_BUTTON))
                        {
                            second = 2;
                            scene++;

                        }
                    }
                    if (mouseX >= 1300 && mouseX <= 1800 && mouseY >= 100 && mouseY <= 1000)
                    {
                        if (Raylib.IsMouseButtonPressed(MouseButton.MOUSE_LEFT_BUTTON))
                        {
                            second = 3;
                            scene++;

                        }
                    } */

                }




                if (scene == 3)
                {
                    Raylib.DrawText("Vem skulle du låna ut 100 kr till?", 450, 50, 50, Color.BLACK);
                    Raylib.DrawTextureEx(triangel3, new Vector2(0, 200), 0, 0.25f, Color.WHITE);
                    Raylib.DrawTextureEx(fyrkant3, new Vector2(600, 200), 0, 0.25f, Color.WHITE);
                    Raylib.DrawTextureEx(cirkel3, new Vector2(1200, 200), 0, 0.25f, Color.WHITE);




                }
                if (scene == 4)
                {
                    Raylib.DrawText("Vilken tycker du ser mer snäll ut?", 450, 50, 50, Color.BLACK);
                    Raylib.DrawTextureEx(triangel2, new Vector2(0, 200), 0, 0.25f, Color.WHITE);
                    Raylib.DrawTextureEx(fyrkant1, new Vector2(600, 200), 0, 0.25f, Color.WHITE);
                    Raylib.DrawTextureEx(cirkel3, new Vector2(1200, 200), 0, 0.25f, Color.WHITE);






                }
                if (scene == 5)
                {
                    Raylib.DrawText("Vilken tycker du ser mer snäll ut?", 450, 50, 50, Color.BLACK);
                    Raylib.DrawTextureEx(triangel3, new Vector2(0, 200), 0, 0.25f, Color.WHITE);
                    Raylib.DrawTextureEx(fyrkant1, new Vector2(600, 200), 0, 0.25f, Color.WHITE);
                    Raylib.DrawTextureEx(cirkel2, new Vector2(1200, 200), 0, 0.25f, Color.WHITE);




                }
                if (scene == 6)
                {
                    Raylib.DrawText("Vem skulle du förlora mot i en frågesport?", 450, 50, 50, Color.BLACK);
                    Raylib.DrawTextureEx(triangel1, new Vector2(0, 200), 0, 0.25f, Color.WHITE);
                    Raylib.DrawTextureEx(fyrkant3, new Vector2(600, 200), 0, 0.25f, Color.WHITE);
                    Raylib.DrawTextureEx(cirkel2, new Vector2(1200, 200), 0, 0.25f, Color.WHITE);




                }
                if (scene == 7)
                {
                    Raylib.DrawText("Vem skulle komma sent till ett evenemang ni har planerat?", 250, 50, 50, Color.BLACK);
                    Raylib.DrawTextureEx(triangel3, new Vector2(0, 200), 0, 0.25f, Color.WHITE);
                    Raylib.DrawTextureEx(fyrkant2, new Vector2(600, 200), 0, 0.25f, Color.WHITE);
                    Raylib.DrawTextureEx(cirkel1, new Vector2(1200, 200), 0, 0.25f, Color.WHITE);




                }
                if (scene == 8)
                {
                    Raylib.DrawText("vem frågar du hjälp för matte?", 250, 50, 50, Color.BLACK);
                    Raylib.DrawTextureEx(triangel2, new Vector2(0, 200), 0, 0.25f, Color.WHITE);
                    Raylib.DrawTextureEx(fyrkant3, new Vector2(600, 200), 0, 0.25f, Color.WHITE);
                    Raylib.DrawTextureEx(cirkel1, new Vector2(1200, 200), 0, 0.25f, Color.WHITE);




                }
                if (scene == 9)
                {
                    Raylib.DrawText("Vem frågar du hjälp för att planera idrottslektion?", 250, 50, 50, Color.BLACK);
                    Raylib.DrawTextureEx(triangel1, new Vector2(0, 200), 0, 0.25f, Color.WHITE);
                    Raylib.DrawTextureEx(fyrkant2, new Vector2(600, 200), 0, 0.25f, Color.WHITE);
                    Raylib.DrawTextureEx(cirkel3, new Vector2(1200, 200), 0, 0.25f, Color.WHITE);




                }
                if (scene == 10)
                {
                    Raylib.DrawText("Vem skulle du förlora mot i en löpningstävling?", 250, 50, 50, Color.BLACK);
                    Raylib.DrawTextureEx(triangel3, new Vector2(0, 200), 0, 0.25f, Color.WHITE);
                    Raylib.DrawTextureEx(fyrkant3, new Vector2(600, 200), 0, 0.25f, Color.WHITE);
                    Raylib.DrawTextureEx(cirkel2, new Vector2(1200, 200), 0, 0.25f, Color.WHITE);





                }
                /*     if (scene == 1)
                    {
                        if (mouseX >= 0 && mouseX <= 600 && mouseY >= 100 && mouseY <= 1000)
                        {
                            if (Raylib.IsMouseButtonPressed(MouseButton.MOUSE_LEFT_BUTTON))
                            {
                                first++;
                                scene++;

                            }
                        }
                    }
                    if (scene == 2)
                    {
                        if (mouseX >= 0 && mouseX <= 600 && mouseY >= 100 && mouseY <= 1000)
                        {
                            if (Raylib.IsMouseButtonPressed(MouseButton.MOUSE_LEFT_BUTTON))
                            {
                                second++;
                                scene++;

                            }
                        }
                    }
                    if (scene == 3)
                    {
                        if (mouseX >= 0 && mouseX <= 600 && mouseY >= 100 && mouseY <= 1000)
                        {
                            if (Raylib.IsMouseButtonPressed(MouseButton.MOUSE_LEFT_BUTTON))
                            {
                                third++;
                                scene++;

                            }
                        }
                    }
                    if (scene == 4)
                    {
                        if (mouseX >= 0 && mouseX <= 600 && mouseY >= 100 && mouseY <= 1000)
                        {
                            if (Raylib.IsMouseButtonPressed(MouseButton.MOUSE_LEFT_BUTTON))
                            {
                                fourth++;
                                scene++;

                            }
                        }
                    }
                    if (scene == 5)
                    {
                        if (mouseX >= 0 && mouseX <= 600 && mouseY >= 100 && mouseY <= 1000)
                        {
                            if (Raylib.IsMouseButtonPressed(MouseButton.MOUSE_LEFT_BUTTON))
                            {
                                fifth++;
                                scene++;

                            }
                        }
                    }
                    if (scene == 6)
                    {
                        if (mouseX >= 0 && mouseX <= 600 && mouseY >= 100 && mouseY <= 1000)
                        {
                            if (Raylib.IsMouseButtonPressed(MouseButton.MOUSE_LEFT_BUTTON))
                            {
                                sixth++;
                                scene++;

                            }
                        }
                    }
                    if (scene == 7)
                    {
                        if (mouseX >= 0 && mouseX <= 600 && mouseY >= 100 && mouseY <= 1000)
                        {
                            if (Raylib.IsMouseButtonPressed(MouseButton.MOUSE_LEFT_BUTTON))
                            {
                                seventh++;
                                scene++;

                            }
                        }
                    }
                    if (scene == 8)
                    {
                        if (mouseX >= 0 && mouseX <= 600 && mouseY >= 100 && mouseY <= 1000)
                        {
                            if (Raylib.IsMouseButtonPressed(MouseButton.MOUSE_LEFT_BUTTON))
                            {
                                eighth++;
                                scene++;

                            }
                        }
                    }
                    if (scene == 9)
                    {
                        if (mouseX >= 0 && mouseX <= 600 && mouseY >= 100 && mouseY <= 1000)
                        {
                            if (Raylib.IsMouseButtonPressed(MouseButton.MOUSE_LEFT_BUTTON))
                            {
                                ninth++;
                                scene++;

                            }
                        }
                    }
                    if (scene == 10)
                    {
                        if (mouseX >= 0 && mouseX <= 600 && mouseY >= 100 && mouseY <= 1000)
                        {
                            if (Raylib.IsMouseButtonPressed(MouseButton.MOUSE_LEFT_BUTTON))
                            {
                                tenth++;
                                scene++;

                            }
                        }
                    } */
                Raylib.EndDrawing();
            }

        }
    }

}
