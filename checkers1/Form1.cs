using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace checkers1
{
    public partial class Form1 : Form
    {
        //создаем размер доски для шашек
        const int mapSize = 8;

        //задаем размер клетки
        const int cellSize = 50;

        int[,] map = new int[mapSize, mapSize];

        Image imgWhiteFigure;
        Image imgBlackFigure;
        
        public Form1()
        {
            
            InitializeComponent();

            //поменяем название
            this.Text = "Checkers";

            Init();
        }

        //инициализируем 
        public void Init()
        {
            map = new int[mapSize, mapSize]
            {
                { 0, 1, 0, 1, 0, 1, 0, 1},
                { 1, 0, 1, 0, 1, 0, 1, 0},
                { 0, 1, 0, 1, 0, 1, 0, 1},
                { 0, 0, 0, 0, 0, 0, 0, 0},
                { 0, 0, 0, 0, 0, 0, 0, 0},
                { 2, 0, 2, 0, 2, 0, 2, 0},
                { 0, 2, 0, 2, 0, 2, 0, 2},
                { 2, 0, 2, 0, 2, 0, 2, 0}
            };

            CreateMap();
        }

        // создаем карту
        public void CreateMap()
        {
            this.Width = (mapSize+1) * cellSize;

            this.Height=(mapSize+1)* cellSize;

            //создаем поле 
            for (int i = 0; i < mapSize; i++)
            {
                for (int j = 0; j < mapSize; j++)
                {
                    //создаем кнопку

                    Button button = new Button();

                    //задаем ее положение

                    button.Location= new Point(j*cellSize,i*cellSize);

                    //задаем размер кнопок

                    button.Size = new Size(cellSize, cellSize);

                    if (map[i, j] == 1)
                    {
                        button.BackgroundImage = Image.FromFile("D:\\VSProjects\\checkers1\\checkers1\\images\\w.png");

                    }
                    else if (map[i, j] == 2) button.BackgroundImage = Image.FromFile("D:\\VSProjects\\checkers1\\checkers1\\images\\b.png");

                    // добавляем её на форму

                    this.Controls.Add(button);


                    /*switch (map[i,j])
                    {
                        case 1: map[i,j] = imgWhiteFigure;


                    }
                    */
                }
            }
        }

        
    }
}
