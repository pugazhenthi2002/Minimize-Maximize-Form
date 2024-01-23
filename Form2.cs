using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsDraft
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private int sizeX = 1936, sizeY=1056;
        private int startX = 0, startY=0;
        private int buttonsWidth = 0, buttonsHeight=0;
        private int buttonWidth = 0, buttonHeight=0;
        private bool isDropDownShown = false, isMaximised = false;
        private AddShapeDropDown addShapeDropDown;

        private void OnButtonSizeChanged(object sender, string e)
        {
            if(e == "close")
            {
                ;
            }
            else if(e=="Minimize")
            {
                Location = new Point((sizeX - 1000) / 2, (sizeY - 600) / 2);
                Size = new Size(1000, 600);

                buttonWidth = Width * 3 / 20;    buttonHeight = Height / 6;
                buttonsHeight = buttonHeight * 2 + 25;
                buttonsWidth = buttonWidth * 2 + 50;

                startX = (1000 - buttonsWidth) / 2;
                startY = (600 - buttonsHeight) / 2;

                rippleButton2.Location = new Point(startX, startY);
                rippleButton3.Location = new Point(startX + 200, startY);
                rippleButton1.Location = new Point(startX, startY + 125);
                rippleButton4.Location = new Point(startX + 200, startY + 125);

                rippleButton1.Size = new Size(buttonWidth, buttonHeight);
                rippleButton2.Size = new Size(buttonWidth, buttonHeight);
                rippleButton3.Size = new Size(buttonWidth, buttonHeight);
                rippleButton4.Size = new Size(buttonWidth, buttonHeight);

                isMaximised = false;
            }
            else
            {
                Location = new Point(0, 0);
                Size = new Size(sizeX, sizeY);

                buttonWidth = Width * 3 / 20; buttonHeight = Height / 6;
                buttonsHeight = buttonHeight * 2 + 50;
                buttonsWidth = buttonWidth * 2 + 100;

                startX = (sizeX - buttonsWidth) / 2;
                startY = (sizeY - buttonsHeight) / 2;

                rippleButton2.Location = new Point(startX, startY);
                rippleButton3.Location = new Point(startX + buttonWidth + 100, startY);
                rippleButton1.Location = new Point(startX, startY + buttonHeight + 50);
                rippleButton4.Location = new Point(startX + buttonWidth + 100, startY + buttonHeight + 50);

                rippleButton1.Size = new Size(buttonWidth, buttonHeight);
                rippleButton2.Size = new Size(buttonWidth, buttonHeight);
                rippleButton3.Size = new Size(buttonWidth, buttonHeight);
                rippleButton4.Size = new Size(buttonWidth, buttonHeight);

                isMaximised = true;
            }

            if (isDropDownShown)
            {
                isDropDownShown = false;
                addShapeDropDown.Dispose();
            }
        }

        private void FitShapes()
        {
            startX = (Width - 350) / 2;
            startY = (Height - 225) / 2;
            rippleButton2.Location = new Point(startX, startY);
            rippleButton3.Location = new Point(startX + 200, startY);
            rippleButton1.Location = new Point(startX, startY + 125);
            rippleButton4.Location = new Point(startX + 200, startY + 125);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Location = new Point((sizeX - 1000) / 2, (sizeY - 600) / 2);
            Size = new Size(1000, 600);
            FitShapes();
        }

        private void OnFormMouseUp(object sender, MouseEventArgs e)
        {
            if (!isDropDownShown && e.Button == MouseButtons.Right) 
            {
                isDropDownShown = true;
                string s = isMaximised ? "Minimize" :"Maximize";
                addShapeDropDown = new AddShapeDropDown(s);
                addShapeDropDown.Location = GetDropDownPoint(sender, e.X, e.Y);
                addShapeDropDown.ShapeDrawn += OnButtonSizeChanged;
                addShapeDropDown.Show();
            }
        }

        private void Form2_Move(object sender, EventArgs e)
        {
            if (isDropDownShown)
            {
                isDropDownShown = false;
                addShapeDropDown.Dispose();
            }
        }

        private void Form2_Resize(object sender, EventArgs e)
        {
            if (isDropDownShown)
            {
                isDropDownShown = false;
                addShapeDropDown.Dispose();
            }
        }

        private void OnButtonMouseUp(object sender, MouseEventArgs e)
        {

        }

        private void Form2_MouseDown(object sender, MouseEventArgs e)
        {
            if(isDropDownShown)
            {
                isDropDownShown = false;
                addShapeDropDown.Dispose();
            }
        }

        private Point GetDropDownPoint(object sender, int X, int Y)
        {
            Point newPoint = new Point(X, Y);

            if (sender is Button)
            {
                RippleButton r = sender as RippleButton;
                newPoint = r.PointToScreen(new Point(X, Y));
            }
            else
            {
                newPoint = PointToScreen(new Point(X, Y));
                if (addShapeDropDown.Height >= (Height - Y - 29))
                {
                    newPoint = new Point(newPoint.X, newPoint.Y - addShapeDropDown.Height);
                }
            }

            if (addShapeDropDown.Width >= (Width - X))
            {
                newPoint = new Point(newPoint.X - addShapeDropDown.Width, newPoint.Y);
            }
            return newPoint;
        }

    }
}
