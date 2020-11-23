using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba4_OOP_CCircle
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Circle_Panel_MouseMove(object sender, MouseEventArgs e)
        {
            Coord_label.Text = "X: " + e.X + " Y: " + e.Y;
        }


        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            Coord_label.Text = "";
        }

        static int amtCells = 1;
        int CountElem = 0;
        int item = 0;
        static readonly Color DefaultColor = Color.Aquamarine;
        static readonly Color SelectedColor = Color.DarkBlue;
        myStorage storage = new myStorage(amtCells);

        private void Clear_button_Click(object sender, EventArgs e)
        {
            Circle_Panel.Refresh();
            for (int i=0; i<amtCells; ++i)
                if (!storage.Empty(i))
                {
                    storage.objects[i].Is_Drawn = false;
                    storage.objects[i].color = DefaultColor;
                }
        }

        private void Del_button_Click(object sender, EventArgs e)
        {
            if (storage.OccupiedCells(amtCells) != 0)
                for (int i = 0; i < amtCells; ++i)
                    if (storage.Empty(i) == false && storage.objects[i].color == SelectedColor)
                        storage.DeleteObj(ref i);
            Clear_button_Click(sender, e);
            ShowCircle_button_Click(sender, e);
        }

        private void СlearStorage_button_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < amtCells; ++i)
                storage.DeleteObj(ref i);
            CountElem = 0;
        }


        private void ShowCircle_button_Click(object sender, EventArgs e)
        {
            Circle_Panel.Refresh();
            if (storage.OccupiedCells(amtCells)!=0)
                for (int i=0; i<amtCells; ++i)
                {
                    DrawingCircles(ref storage, i);
                    if (!storage.Empty(i))
                        storage.objects[i].Is_Drawn = true;
                }

        }

        private void DrawingCircles (ref myStorage storage, int CountElem)
        {
            if (storage.objects[CountElem]!=null)
            {
                Pen pen = new Pen(storage.objects[CountElem].color, 3);
                Circle_Panel.CreateGraphics().DrawEllipse(pen, storage.objects[CountElem].x,
                    storage.objects[CountElem].y, storage.objects[CountElem].R * 2, storage.objects[CountElem].R * 2);
            }
        }

        private void SelectionRemove(ref myStorage storage)
        {
            for (int i=0; i<amtCells; ++i)
                if (!storage.Empty(i))
                {
                    storage.objects[i].color = DefaultColor;
                    if (storage.objects[i].Is_Drawn == true)
                        DrawingCircles(ref storage, i);
                }
        }

        private int CheckCircle(ref myStorage storage, int Size, int x, int y)
        {
            if (storage.OccupiedCells(Size)!=0)
            {
                for (int i=0; i< Size; ++i)
                    if (!storage.Empty(i))
                    {
                        if (Math.Sqrt((x - storage.objects[i].x) + (y - storage.objects[i].y)) <= storage.objects[i].R)
                            return i;
                    }
            }
            return -1;
        }


        public class CCircle
        {
            public int R = 50;
            public int x, y;
            public Color color = DefaultColor;
            public bool Is_Drawn = true;

            public CCircle ()
            {
                x = 0;
                y = 0;
            }

            public CCircle(int x, int y, Color color)
            {
                this.x = x - R;
                this.y = y - R;
                this.color = color;
            }

            ~CCircle() { }
        }

        class myStorage
        {
            public CCircle[] objects;
            public myStorage(int amt)
            {
                objects = new CCircle[amt];
                for (int i = 0; i < amt; ++i)
                    objects[i] = null;
            }

            public void Allocation(int amt)
            {
                objects = new CCircle[amt];
                for (int i = 0; i < amt; ++i)
                    objects[i] = null;
            }

            public void AddObj (int index, ref CCircle NewObj, ref int Count, ref int item)
            {
                myStorage NewStorage = new myStorage(Count + 1);
                for (int i = 0; i < Count; ++i)
                    NewStorage.objects[i] = objects[i];
                for (int i = Count; i<(Count+1)-1;++i)
                {
                    NewStorage.objects[i] = null;
                }

                Count = Count + 1;
                Allocation(Count);
                for (int i = 0; i < Count; ++i)
                    objects[i] = NewStorage.objects[i];
                objects[index] = NewObj;

                item = index;
            }

            public void DeleteObj(ref int amtElem)
            {
                if (objects[amtElem]!=null)
                {
                    objects[amtElem] = null;
                    amtElem--;
                }
            }

            public bool Empty(int CountElem)
            {
                if (objects[CountElem] == null)
                    return true;
                else return false;
            }

            public int OccupiedCells(int Size)
            {
                int amtOccupied = 0;
                for (int i = 0; i < Size; ++i)
                    if (!Empty(i))
                        ++amtOccupied;
                return amtOccupied;
            }

            ~myStorage() { }
        };
    }
}
