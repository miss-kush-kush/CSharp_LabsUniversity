using System;
using System.Drawing.Drawing2D;
using System.Reflection;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace Planets
{
    public partial class Form1 : Form
    {
        private const int numberOfOrbits = 8;
        private const int orbitRadiusMultiplier = 70;
        private const int planetSize = 35;
        private const int centerX = 600;
        private const int centerY = 600;
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
            sunButton.BackColor = Color.Yellow; // Set the color of the sun
            sunButton.Image = Image.FromFile("D:\\Programming\\C#\\LabsZUT\\Planets\\2k_sun.jpg");
            sunButton.Location = new Point(centerX - sunSize / 2, centerY - sunSize / 2);
            this.Controls.Add(sunButton);
        }

        private void InitializePlanets()
        {
            int baseSize = 30; // Base size for Earth
            double[] planetSizeRatios = { 0.382, 0.949, 1, 0.532, 2.209, 2.449, 1.007, 1.883 };

            for (int i = 0; i < 8; i++)
            {
                int planetSize = (int)(baseSize * planetSizeRatios[i]);
                RoundButton planetButton = new RoundButton();
                planetButton.Width = planetButton.Height = planetSize;
                planetButton.BackColor = GetPlanetColor(i);
                planetButton.BorderColor = GetPlanetColor(i);
                planetButton.Image = GetPlanetImage(i);
                this.Controls.Add(planetButton);
                planets[i] = planetButton;
            }

            UpdatePlanetPositions(); // Set initial planet positions
        }

        private Image GetPlanetImage(int index)
        {
            string[] imagePaths = 
            {
                "D:\\Programming\\C#\\LabsZUT\\Planets\\2k_mercury.jpg",
                "D:\\Programming\\C#\\LabsZUT\\Planets\\2k_venus.jpg",
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
                    // Handle the exception if the file can't be loaded
                    Console.WriteLine($"Error loading image: {ex.Message}");
                }
            }

            return null;
        }

        private Color GetPlanetColor(int index)
        {
            // Define colors for each planet
            Color[] planetColors = { Color.Gray, Color.Orange, Color.Yellow, Color.Blue, Color.Red, Color.Brown, Color.Tan, Color.Gray };

            if (index < planetColors.Length)
                return planetColors[index];
            else
                return Color.Gray;
        }

        private void InitializeTimer()
        {
            timer = new Timer();
            timer.Interval = 50; // Adjust the interval based on your preference
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

            for (int i = 0; i < 8; i++)
            {
                int radius = (i + 1) * orbitRadiusMultiplier;
                double angularVelocity = 2 * Math.PI / (60 * (i + 1)); // Adjust the divisor for different speeds

                double angle = angularVelocity * time;

                int x = centerX + (int)(radius * Math.Cos(angle));
                int y = centerY + (int)(radius * Math.Sin(angle));

                planets[i].Location = new Point(x - planetSize / 2, y - planetSize / 2);
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen pen = new Pen(Color.White);

            // Draw orbits
            for (int i = 1; i <= numberOfOrbits; i++)
            {
                int radius = i * orbitRadiusMultiplier;
                g.DrawEllipse(pen, centerX - radius, centerY - radius, 2 * radius, 2 * radius);
            }
        }
    }
}