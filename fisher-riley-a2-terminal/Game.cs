// Include code libraries you need below (use the namespace).
using Raylib_cs;
using System;
using System.Numerics;

// The namespace your code is in.
namespace Game10003
{
    /// <summary>
    ///     Your game code goes inside this class!
    /// </summary>
    public class Game
    {
        // Place your variables here:
        private Color color;
        private Color fillColor;
        private int eyePlacement1;
        private int eyePlacement2;

        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            Window.SetTitle("Interactive Terminal");
            Window.SetSize(800, 600);

            color = Random.Color();
            fillColor = Color.OffWhite;
            eyePlacement1 = Random.Integer(250, 350);
            eyePlacement2 = Random.Integer(400, 650);
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {


            Window.ClearBackground(Color.OffWhite);

            Draw.LineSize = 2;
            Draw.FillColor = fillColor;

            if (Input.IsMouseButtonDown(MouseInput.Left))
            {
                Draw.FillColor = color;
            }

            Draw.Circle(400, 300, 250);

            Draw.Circle(eyePlacement1, 250, 75);
            Draw.Circle(eyePlacement1, 250, 50);

            Draw.Circle(eyePlacement2, 250, 75);
            Draw.Circle(eyePlacement2, 250, 50);

            Draw.Ellipse(400, 400, 150, 75);

        }
    }
}
