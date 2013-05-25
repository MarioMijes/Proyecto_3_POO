using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Snake_Game
{
    class Piedra
    {
        private Random RPiedras = new Random();
        private Rectangle[] Arreglo_Piedras;
        private SolidBrush brush;
        private int x, y, width, height;

        public Rectangle[] arreglo_Piedras
        {
            get { return Arreglo_Piedras; }
        }

        public Piedra()
        {
            Arreglo_Piedras = new Rectangle[1];
            brush = new SolidBrush(Color.Red);
            x = RPiedras.Next(0, 29) * 10;
            y = RPiedras.Next(0, 29) * 10;
            width = 10;
            height = 10;
        }

        public void Dibuja_Piedra(Graphics papel) 
        {
            foreach (Rectangle piedras in Arreglo_Piedras)
            {
                for (int i = Arreglo_Piedras.Length - 1; i > 0; i--)
                {
                    papel.FillRectangle(brush, piedras);
                }
            }
        }

        public void Agregar_Obstaculo()
        {
            int x = RPiedras.Next(0, 29) * 10;
            int y = RPiedras.Next(0, 29) * 10;
            List<Rectangle> piedras = Arreglo_Piedras.ToList();
            piedras.Add(new Rectangle(x, y, width, height));
            Arreglo_Piedras = piedras.ToArray();
        }
    }
}
