using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Snake_Game
{
    public partial class Snake_Game : Form
    {

        //Creación del Juego (Serpiente Inicial, Comida, Matriz 29x29)
        Random RPiedras = new Random();
        Random RComida = new Random();
        Graphics papel;
        Snake snake = new Snake();
        Comida comida;
        Piedra piedra = new Piedra();
        public int puntos_archivo;
        public List<string> Lista_Puntos = new List<string>();

        //Variables de Movimiento
        bool izq = false;
        bool der = false;
        bool abajo = false;
        bool arriba = false;

        int puntos = 0;
        int Nivel = 1;
        int lvl = 0;

        public Snake_Game()
        {
            InitializeComponent();
            comida = new Comida(RComida);
        }

        //Evento Paint (Graficos, Comida, Snake)
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            papel = e.Graphics;
            comida.Dibuja_Comida(papel);
            snake.Dibuja_Snake(papel);
            piedra.Dibuja_Piedra(papel);
        }

        //Eventos de movimiento
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //Tecla espacio, inicia el juego)
            if(timer1.Enabled == false)
            {

            if(e.KeyData == Keys.Space)
                {
                    cmd_archivo.Visible = false;
                    lbl_nombre.Visible = false;
                    nombre.Visible = false;
                    timer1.Enabled = true;
                    Start.Text = "";
                    abajo = false;
                    arriba = false;
                    izq = false;
                    der = true;
                }
            }

            //Tecla Abajo, Mueve abajo
            if(e.KeyData == Keys.Down && arriba == false )
            {
                abajo = true;
                arriba = false;
                der = false;
                izq = false;
            }

            //Tecla Arriba, Mueve arriba
            if (e.KeyData == Keys.Up && abajo == false )
            {
                abajo = false;
                arriba = true;
                der = false;
                izq = false;
            }

            //Tecla Izquiera, Mueve izquierda
            if (e.KeyData == Keys.Left && der == false )
            {
                abajo = false;
                arriba = false;
                der = false;
                izq = true;
            }

            //Tecla Derecha, Mueve derecha
            if (e.KeyData == Keys.Right && izq == false  )
            {
                abajo = false;
                arriba = false;
                der = true;
                izq = false;
            }

            if(e.KeyData == Keys.Escape)
            {
                Close();
            }


        }

        //Timer, Cliclo infinito de las instrucciones dentro de este.
        private void timer1_Tick(object sender, EventArgs e)
        {
            Puntos_Snake.Text = Convert.ToString(puntos);
            nivel.Text = Convert.ToString(Nivel);

            //Llamada a los metodos de movimiento
            if (abajo) { snake.mov_Abajo(); }
            if (arriba) { snake.mov_Arriba(); }
            if (izq) { snake.mov_Izquierda(); }
            if (der) { snake.mov_Derecha(); }

            //Cremicimiento al intersectar con la comida
            for (int i = 0; i < snake.Snakerec.Length; i++)
            {
                if (snake.Snakerec[i].IntersectsWith(comida.Comidarec))
                {
                    lvl += 1;

                    if(lvl == 10)
                    {
                        lvl = 0;
                         Nivel += 1;
                    }

                    if(lvl == 5 || lvl == 0)
                    {
                        //piedra = new Piedra();
                        piedra.Agregar_Obstaculo();
                    }

                    puntos += 10;
                    snake.Crecimiento_Snake();
                    comida.Lugar_Comida(RComida);
                    if(timer1.Interval >= 10)
                    {
                        timer1.Interval -= 1;
                    }
                }
            }

            Choque();

            this.Invalidate();
        }

        //Metodo para llamar a Comienzo despues de perder
        public void Choque()
        {

            for (int i = 1; i < piedra.arreglo_Piedras.Length; i++)
            {
                if (snake.Snakerec[0].IntersectsWith(piedra.arreglo_Piedras[i]))
                {
                    Comienzo();
                }
            }

            for (int i = 1; i < snake.Snakerec.Length; i++ ) 
            {
                if(snake.Snakerec[0].IntersectsWith(snake.Snakerec[i]))
                {
                    Comienzo();
                }
            }

            //if(snake.Snakerec[0].IntersectsWith(piedra.Piedrarec))
            //{
            //    Comienzo();
            //}

            if (snake.Snakerec[0].X < 0 || snake.Snakerec[0].X > 290)
            {
                Comienzo();
            }

            if (snake.Snakerec[0].Y < 0 || snake.Snakerec[0].Y > 290)
            {
                Comienzo();
            }
        }

        //Metodo usado para avisar el termino del juego, los puntos y el nuevo inicio
        public void Comienzo()
        {
            timer1.Enabled = false;
            timer1.Interval = 150;
            MessageBox.Show("GAME OVER. Tus Puntos : " + puntos);
            puntos_archivo = puntos;
            cmd_archivo.Enabled = true;
            nombre.Enabled = true;
            cmd_archivo.Visible = true;
            lbl_nombre.Visible = true;
            nombre.Visible = true;
            nombre.Focus();
            Puntos_Snake.Text = "0";

            //Inicio del Nivel
            lvl = 0;
            Nivel = 1;
            nivel.Text = "1";

            puntos = 0;
            Start.Text = "Presiona Barra para empezar";
            snake = new Snake();
            piedra = new Piedra();
        }

        //Evento usado para que el intervalo del timer siempre inicie desde 100
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 150;
            MessageBox.Show("Ultimo Proyecto de Programación Orientada a objetos\n Proyecto: Snake Game\n\n Equipo:\n Alvarez Rodriguez Evelyn\n Lopez Hernandez Adrian\n Mijes Cruz Mario Humberto\n Salcedo Jackez Juan Pablo");
            cmd_archivo.Visible = false;
            lbl_nombre.Visible = false;
            nombre.Visible = false;
            StreamWriter stream_puntos = new StreamWriter(new FileStream(@"c:\Users\MHMC777\Desktop\Snake Scores.txt", FileMode.OpenOrCreate, FileAccess.Write));
        }

        private void cmd_archivo_Click(object sender, EventArgs e)
        {
            
            //Input_Box.ActiveForm.Activate();
            MessageBox.Show("Guardando puntos...");
            cmd_archivo.Visible = false;
            lbl_nombre.Visible = false;
            nombre.Visible = false;
            StreamWriter stream_puntos = new StreamWriter(new FileStream(@"c:\Users\MHMC777\Desktop\Snake Scores.txt", FileMode.Append, FileAccess.Write));
            //StreamReader stream_puntos_leer = new StreamReader(new FileStream(@"c:\Users\MHMC777\Desktop\Snake Scores.txt", FileMode.Open, FileAccess.Read));
            //stream_puntos.Write(nombre.Text + puntos_archivo + "\n");
            stream_puntos.Write("|" + nombre.Text + "|");
            stream_puntos.WriteLine("");
            stream_puntos.Write("|" + puntos_archivo + "|");
            stream_puntos.WriteLine("");
            stream_puntos.WriteLine("-------------------------------------");
            stream_puntos.WriteLine("");
            stream_puntos.Close();
            cmd_archivo.Enabled = false;
            nombre.Enabled = false;
            nombre.Text = "";
        }
    }
}