using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Wahadlo_projekt
{
    public class Pendulum
    {
        private List<Point> pointList=new List<Point>();
        private double length;
        private double mass;
        private double angle;
        private bool isFirst;
        public Point start;
        public Point end;
        int iterator = 0;
        public Color trajectoryColor = Color.FromArgb(255, 255, 0, 0);
       
        public Pendulum(double length, double mass, double angle, bool isFirst)
        {
            this.length = length;
            this.mass = mass;
            this.angle = angle;
            this.isFirst = isFirst;
        }
        public Pendulum(double length, double mass, double angle,Point start,bool isFirst)
        {
            this.isFirst=isFirst;
            this.length = length;
            this.mass = mass;
            this.angle = angle;
            this.start = start;
            double endX=start.X+length*Math.Sin(angle);
            double endY=start.Y+length*Math.Cos(angle);
            //MessageBox.Show($"x:{start.X}+{length}*{Math.Sin(angle)}={endX}\ny:{start.Y}+{length}*{Math.Cos(angle)}={endY}");
            this.end=new Point(Convert.ToInt32(endX), Convert.ToInt32(endY));
        }
        public void changeColor(int r,int g,int b)
        {
            trajectoryColor = Color.FromArgb(r,g,b);
        }
        Pen wahadloPen;
        Pen trajectoryPen;
        SolidBrush wahadloBrush;
        public void drawPendulum(Graphics g) 
        {
            wahadloPen = new Pen(new SolidBrush(Color.SlateGray), 5);
            wahadloBrush = new SolidBrush(Color.SlateGray);

            g.DrawLine(wahadloPen, this.start, this.end);
            int circleSize = (int)this.mass;
            //g.DrawEllipse(wahadloPen, this.start.X - circleSize / 2, this.start.Y - circleSize / 2, circleSize, circleSize);
            g.DrawEllipse(wahadloPen, this.end.X - circleSize / 2, this.end.Y - circleSize / 2, circleSize, circleSize);
           // Rectangle rec1 = new Rectangle(this.start.X - circleSize / 2, this.start.Y - circleSize / 2, circleSize, circleSize);
            Rectangle rec2 = new Rectangle(this.end.X - circleSize / 2, this.end.Y - circleSize / 2, circleSize, circleSize);
          //  g.FillEllipse(wahadloBrush, rec1);
          
            g.FillEllipse(wahadloBrush, rec2);
        }
        public void drawTrajectory(Graphics g)
        {
            //MessageBox.Show($"{pointList.Count}");
            trajectoryPen=new Pen(new SolidBrush(trajectoryColor), 2);
            if (pointList.Count > 1)
                g.DrawLine(trajectoryPen, this.end, pointList.Last());
           // MessageBox.Show($"{this.end.X}, {this.end.Y}");
            pointList.Add(this.end);
        }
        public double getAngle()
        {
            return angle;
        }
        public double getMass()
        {
            return mass;
        }
        public double getLength()
        {
            return length;
        }
        public void setAngle(double angle)
        {
            this.angle = angle % (2 * Math.PI);
            if (this.angle < 0) this.angle += 2 * Math.PI;
            double endX = this.start.X + length * Math.Sin(this.angle);
            double endY = this.start.Y + length * Math.Cos(this.angle);
            this.end = new Point(Convert.ToInt32(endX), Convert.ToInt32(endY));
        }
        public void changeAngleOfPendulum(double newAngle,Pendulum pendulum2)
        {
            this.angle = newAngle % (2 * Math.PI);
            if (this.angle < 0) this.angle += 2 * Math.PI;
            double endX = this.start.X + length * Math.Sin(this.angle) ;
            double endY = this.start.Y + length * Math.Cos(this.angle);
            //try { 
            this.end = new Point(Convert.ToInt32(endX), Convert.ToInt32(endY));
            //}catch(Exception) 
            //{
            //    MessageBox.Show($"eX: {endX}, eY: {endY}, sX:{this.start.X}, l: {length}, na: {newAngle}, sin: {Math.Sin(newAngle)}, cos: {Math.Cos(newAngle)}");
            //}
            pendulum2.start = this.end;
            endX = pendulum2.start.X + length * Math.Sin(pendulum2.angle);
            endY = pendulum2.start.Y + length * Math.Cos(pendulum2.angle);
            pendulum2.end= new Point(Convert.ToInt32(endX), Convert.ToInt32(endY));


        }

    }
}
