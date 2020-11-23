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

        private void Clear_button_Click(object sender, EventArgs e)
        {
            Circle_Panel.Refresh();
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
