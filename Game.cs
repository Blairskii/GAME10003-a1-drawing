// Include the namespaces (code libraries) you need below.
using System;
using System.Numerics;
using Raylib_cs;

// The namespace your code is in.
namespace MohawkGame2D
{
    /// <summary>
    ///     Your game code goes inside this class!
    /// </summary>
    public class Game
    {
        // Place your variables here:
        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            //set window size
            Window.SetSize(width: 400, height: 400);
            //set window title
            Window.SetTitle("RedBull");
            //set target FPS
            Window.TargetFPS = 60;
        }
        //variables for objects and speed
        float circleX = 200;// start position(x axis)
        float circleY = 285;//start position (y axis)
        float circlespeed = 5f; //set horizontal and vertical speed
        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            //clear BG to blue for the sky 
            Window.ClearBackground(Color.Blue);
            
            //make Green foreground rectangle
            Draw.FillColor = Color.Green;
            Draw.LineColor = Color.Black;
            Draw.LineSize = 0.7f;
            Draw.Rectangle(0, 300, 400, 150);// green rectangle at the bottomm of the screen to simulate grass
            //call function to draw clouds in the sky
            drawCloud();
          
            {
            //move the circle right if the "right" arrow is pressed
                if (Input.IsKeyboardKeyDown(KeyboardInput.Right)) //if right arrow key is pressed
                {
                    circleX += circlespeed; //increase the x position for moving right
                }
//move the circle right if the "left" arrow is pressed
                if (Input.IsKeyboardKeyDown(KeyboardInput.Left))
                {
                    circleX -= circlespeed; //decrease the x position for moving left
                }
//move the circle up if the "up" arrow is pressed
                if (Input.IsKeyboardKeyDown(KeyboardInput.Up))
                {
                 circleY -= circlespeed; //decrease the Y position for downward movement   
                }
//move the circle down if the "down" arrow is pressed
                if (Input.IsKeyboardKeyDown(KeyboardInput.Down))
                {
                    circleY += circlespeed;//increase the y position for downward movement
                }
                // draw circle character at new position
                Draw.FillColor = Color.Red;
                Draw.LineColor = Color.Black;
                Draw.LineSize = 3.7f; 
              
                //draw eyes on circle
                Draw.Circle((int)circleX, circleY, 35);
                Draw.FillColor = Color.White;
                float eyeOffsetX = 12; // Horizontal offset of eyes from center of the circle
                float eyeOffsetY = -10; // Vertical offset from the center for eyes 

                // Left eye
                Draw.Circle((int)(circleX - eyeOffsetX), (int)(circleY + eyeOffsetY), 8);  // Left eye
                // Right eye
                Draw.Circle((int)(circleX + eyeOffsetX), (int)(circleY + eyeOffsetY), 8);  // Right eye

                // Draw the black pupils (smaller black circles)
                Draw.FillColor = Color.Black;
                float pupilOffsetX = 2; // Offset for pupils inside the eyes

                // Left pupil
                Draw.Circle((int)(circleX - eyeOffsetX), (int)(circleY + eyeOffsetY), 4);  // Left pupil
                // Right pupil
                Draw.Circle((int)(circleX + eyeOffsetX), (int)(circleY + eyeOffsetY), 4);  // Right pupil
                // Draw a yellow triangle below the circle's eyes
                Draw.FillColor = Color.Yellow;

                // Calculate the position for the triangle on circle
                float triangleBaseY = circleY + -5 + 10; 

                // Define the three points of the triangle (beak)
                Vector2 point1 = new Vector2(circleX - 20, triangleBaseY);  // Left point of the triangle
                Vector2 point2 = new Vector2(circleX + 20, triangleBaseY);  // Right point of the triangle
                Vector2 point3 = new Vector2(circleX, triangleBaseY + 30);  // Bottom point (tip of the triangle)

                // Draw the triangle(beak) from defined positions
                Draw.Triangle(point1, point2, point3);
                
               }
        }
//Draw clouds across the top of the screen
        void drawCloud()
        {
            //loop to draw clouds across the screen
            for (int i = 0; i < 4; i ++)
            {
                //x position for each full cloud
                int cloudX = 50 + i * 100;
                //draw a cloud using 3 circles
                int x = 50 + i * 100;
                Draw.FillColor = Color.White;
                Draw.LineSize = 0.7f;
                //draw the first circle of the cloud
                Draw.LineColor = Color.White;
                Draw.Circle(cloudX, 50, 20);
                //draw the second circle of the cloud
                Draw.Circle(cloudX + 20, 45, 25);
                //Drae the third circle of the cloud
                Draw.Circle(cloudX + 40, 50, 20);
            }
        }
    }


}
        
    
    
