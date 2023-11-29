using System;
using System.Drawing.Drawing2D;
using System.Reflection;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace Planets
{
    public partial class Form1 : Form
    {
        private const int numberOfPlanets = 8;
        private const int orbitRadiusMultiplier = 30;
        private const int centerX = 600;
        private const int centerY = 500;
        private const int sunSize = 100; 
        private RoundButton sunButton;

        private Button[] planets = new Button[8];
        private Timer timer;

        public Form1()
        {
            InitializeComponent();
            InitializePlanets();
            InitializeTimer();
            InitializeSun();
        }

        private void InitializeSun()
        {
            sunButton = new RoundButton();
            sunButton.Width = sunButton.Height = sunSize;
            sunButton.BackColor = Color.Yellow; 
            sunButton.Image = Image.FromFile("D:\\Programming\\C#\\LabsZUT\\Planets\\2k_sun.jpg");
            sunButton.Location = new Point(centerX - sunSize / 2, centerY - sunSize / 2);
            this.Controls.Add(sunButton);
        }

        private void InitializePlanets()
        {
            int[] planetSizes = { 20, 25, 30, 28, 50, 45, 40, 35 };

            for (int i = 0; i < numberOfPlanets; i++)
            {
                RoundButton planetButton = new RoundButton();
                planetButton.Width = planetButton.Height = planetSizes[i];
                planetButton.BackColor = GetPlanetColor(i);
                planetButton.BorderColor = GetPlanetColor(i);
                planetButton.Image = GetPlanetImage(i);
                planetButton.Location = new Point(200 + i * 50, 200);
                this.Controls.Add(planetButton);
                planets[i] = planetButton;
            }

            UpdatePlanetPositions(); 
        }

        private Image GetPlanetImage(int index)
        {
            string[] imagePaths = 
            {
                "D:\\Programming\\C#\\LabsZUT\\Planets\\2k_mercury.jpg",
                "D:\\Programming\\C#\\LabsZUT\\Planets\\2k_venus_surface.jpg",
                "D:\\Programming\\C#\\LabsZUT\\Planets\\2k_earth_daymap.jpg",
                "D:\\Programming\\C#\\LabsZUT\\Planets\\2k_mars.jpg",
                "D:\\Programming\\C#\\LabsZUT\\Planets\\2k_jupiter.jpg",
                "D:\\Programming\\C#\\LabsZUT\\Planets\\2k_saturn.jpg",
                "D:\\Programming\\C#\\LabsZUT\\Planets\\2k_uranus.jpg",
                "D:\\Programming\\C#\\LabsZUT\\Planets\\2k_neptune.jpg"
            };

            if (index < imagePaths.Length)
            {
                try
                {
                    return Image.FromFile(imagePaths[index]);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error loading image: {ex.Message}");
                }
            }

            return null;
        }

        private Color GetPlanetColor(int index)
        {
            Color[] planetColors = { Color.Gray, Color.Orange, Color.Yellow, Color.Blue, Color.Red, Color.Brown, Color.Tan, Color.Gray };

            if (index < planetColors.Length)
                return planetColors[index];
            else
                return Color.Gray;
        }

        private void InitializeTimer()
        {
            timer = new Timer();
            timer.Interval = 1; 
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            UpdatePlanetPositions();
        }

        private void UpdatePlanetPositions()
        {
            double time = DateTime.Now.TimeOfDay.TotalSeconds;

            for (int i = 0; i < numberOfPlanets; i++)
            {
                int radius = 80 + i * orbitRadiusMultiplier;
                double angularVelocity = 7 * Math.PI / (60 * (i + 1)); 

                double angle = angularVelocity * time;

                int x = centerX + (int)(radius * Math.Cos(angle));
                int y = centerY + (int)(radius * Math.Sin(angle));

                planets[i].Location = new Point(x - planets[i].Width / 2, y - planets[i].Height / 2);
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen pen = new Pen(Color.White);

            for (int i = 1; i <= numberOfPlanets; i++)
            {
                int radius = 50 + i * orbitRadiusMultiplier;
                int x = centerX - radius;
                int y = centerY - radius;
                int diameter = 2 * radius;
                g.DrawEllipse(pen, x, y, diameter, diameter);
            }
        }
    }
}
