using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Wahadlo_projekt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Bitmap scene; // Bitmapa do rysowania
        Graphics gScene; 
        Bitmap trajectory; // Bitmapa do rysowania
        Graphics gTrajectory; // Obiekt Graphics związany z bitmapą
        private void Form1_Load(object sender, EventArgs e)
        {
            // Tworzymy bitmapę wielkości panelu i obiekt Graphics do rysowania na niej
            scene = new Bitmap(panel.Width, panel.Height);
            gScene = Graphics.FromImage(scene);
            trajectory=new Bitmap(panel.Width, panel.Height);
            gTrajectory = Graphics.FromImage(trajectory);

            // Wyczyść początkową bitmapę
            gScene.Clear(Color.White);
            gTrajectory.Clear(Color.White);
            initilizePendulums();
            //panel.Invalidate();

        }
        private void initilizePendulums()
        {
            double mass1, angle1, length1, mass2, angle2, length2;
            try
            {
                mass1 = Convert.ToDouble(trbMass1.Value);
                angle1 = Convert.ToDouble(tbAngle1.Text) * Math.PI / 180;
                length1 = Convert.ToDouble(tbLength1.Text);
                mass2 = Convert.ToDouble(tbMass2.Text);
                angle2 = Convert.ToDouble(tbAngle2.Text) * Math.PI / 180;
                length2 = Convert.ToDouble(tbLength2.Text);
            }
            catch
            {
                MessageBox.Show("Sprawdź wszystkie dane");
                return;
            }
            pendulum1 = new Pendulum(length1, mass1, angle1, new Point(150, 150), true);
            pendulum2 = new Pendulum(length2, mass2, angle2, pendulum1.end, false);
            gScene.Clear(bgColor);
            gTrajectory.Clear(bgColor);
            //changePendulumColor();
            pendulum1.drawPendulum(gScene);
            pendulum2.drawPendulum(gScene);
            changeTrajectoryColor();
            panel.Invalidate();
            //MessageBox.Show("Gotowe");
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

        //    System.Drawing.Graphics g = e.Graphics; 
            //initilizePendulums();
            e.Graphics.DrawImage(scene, 0, 0);

        }
        Pendulum pendulum1;
        Pendulum pendulum2;
        bool stopSimulation = false;
        Color bgColor = Color.White;
        double G = 1;
        private void simulateDoublePendulum(Pendulum pendulum1, Pendulum pendulum2,int duration)
        {
            stopSimulation = false;
            
            
            double a1;
            double a2;
            double a1_v=0;
            double a2_v=0;
            double a1_a;
            double a2_a;
            double m1 = pendulum1.getMass();
            double m2 = pendulum2.getMass();
            double l1 = pendulum1.getLength();
            double l2 = pendulum2.getLength();
            double temp_a1;
            double temp_a2;
            for (int i=0;i<duration;i+=16)
            {
                if (stopSimulation)
                    return;
                gScene.Clear(bgColor); 
                pendulum2.drawTrajectory(gTrajectory);
                gScene.DrawImage(trajectory, 0, 0);
                pendulum1.drawPendulum(gScene);
                pendulum2.drawPendulum(gScene);
                panel.CreateGraphics().DrawImage(scene, 0, 0);
                a1 = pendulum1.getAngle();
                a1 = a1 % (2 * Math.PI);
                a2 = pendulum2.getAngle();
                a2= a2 % (2 * Math.PI);
                a1_a = (-G * (2 * m1 + m2) * Math.Sin(a1) - m2 * G * Math.Sin(a1 - 2 * a2) - 2 * Math.Sin(a1 - a2) * m2 * (a2_v * a2_v * l2 + a1_v * a1_v * l1 * Math.Cos(a1 - a2))) /
                    (l1 * (2 * m1 + m2 - m2 * Math.Cos(2 * a1 - 2 * a2)));
                a2_a =(2*Math.Sin(a1-a2)*(a1_v*a1_v*l1*(m1+m2)+G*(m1+m2)*Math.Cos(a1)+a2_v*a2_v*l2*m2*Math.Cos(a1-a2)))/(l2*(2*m1+m2-m2*Math.Cos(2*a1-2*a2)));
                a1_v += a1_a;
                a2_v += a2_a;
                //a1_v *= 0.999;
                //a2_v *= 0.999;
                //MessageBox.Show($"a1: {a1},\na1_a: {a1_a},\na1_v: {a1_v},\na2: {a2},\na2_a: {a2_a},\na2_v: {a2_v}");
                temp_a1 = pendulum1.getAngle() + a1_v;
                temp_a1 = temp_a1 % (2 * Math.PI);
                temp_a2 = pendulum2.getAngle() + a2_v;
                temp_a2 = temp_a2 % (2 * Math.PI);
                try
                {
                    pendulum1.changeAngleOfPendulum(temp_a1,pendulum2);
                    pendulum2.setAngle(temp_a2);
                }
                catch  
                {
                    stopSimulation = true;
                    MessageBox.Show("Przekroczono możliwości obliczeniowe programu");
                    return;
                }
                
                Thread.Sleep(16);
            }
            this.Invoke((MethodInvoker)(() => UpdateButtonsState(false)));
        }
        private void savePaintedTrajectroy(string filePath)
        {
            try
            {

                if (trajectory != null)
                {
                    trajectory.Save(filePath, System.Drawing.Imaging.ImageFormat.Png);
                    MessageBox.Show("Obraz został zapisany");
                }
                else
                {
                    MessageBox.Show("Nie ma trajektorii");
                }
            }
            catch
            {
                MessageBox.Show("Błąd przy zapisie");
            }
        }
        
        
        private void DrawFunction(Series series, Func<double, double> function, double xMin, double xMax, double step)
        {
            for (double x = xMin; x <= xMax; x += step)
            {
                double y = function(x); // Oblicz wartość funkcji
                series.Points.AddXY(x, y); // Dodaj punkt do serii
            }
        }
        private void UpdateButtonsState(bool isSimulationRunning)
        {
            gbPendulum1.Enabled = !isSimulationRunning;
            gbPendulum2.Enabled = !isSimulationRunning;
            btSimulate.Enabled = !isSimulationRunning;
            btStopSimulation.Enabled = isSimulationRunning;
            btSaveGraphic.Enabled = !isSimulationRunning;
            tbTimeDuration.Enabled = !isSimulationRunning;
        }
        private void btSimualte_Click(object sender, EventArgs e)
        {
            //System.Drawing.Graphics g = panel.CreateGraphics();
            
         
                
            gTrajectory.Clear(bgColor);
            int duration;
            try
            {
                duration = Convert.ToInt32(tbTimeDuration.Text);
            }
            catch
            {
                MessageBox.Show("Wprowadź czas");
                return;
            }
            initilizePendulums();
                
            UpdateButtonsState(true);
            Task.Run(()=> 
            {
                simulateDoublePendulum(pendulum1, pendulum2, duration);
                this.Invoke((MethodInvoker)(() => UpdateButtonsState(false)));
            });
                
            
        }

        private void btStopSimulation_Click(object sender, EventArgs e)
        {
            stopSimulation = true;
            UpdateButtonsState(false);

        }

        private void tbR_Scroll(object sender, EventArgs e)
        {
            //changePendulumColor(); 
            changeTrajectoryColor();
        }

        private void tbG_Scroll(object sender, EventArgs e)
        {
            //changePendulumColor(); 
            changeTrajectoryColor();
        }

        private void tbB_Scroll(object sender, EventArgs e)
        {
            //changePendulumColor(); 
            changeTrajectoryColor();
           
        }
        //private void changePendulumColor()
        //{
        //    int r = tbR.Value;
        //    int g = tbG.Value;
        //    int b = tbB.Value;
        //    pendulum1.changeColor(r, g, b);
        //    pendulum2.changeColor(r, g, b);
        //}
        private void changeTrajectoryColor()
        {
            int r = tbR.Value;
            int g = tbG.Value;
            int b = tbB.Value;
            pendulum2.changeColor(r, g, b);
            panelColor.BackColor=Color.FromArgb(255,r,g,b);
        }

        private void trbMass1_Scroll(object sender, EventArgs e)
        {
            
            tbMass1.Text = $"{trbMass1.Value}"; 
            initilizePendulums();
        }

        private void trbLength1_Scroll(object sender, EventArgs e)
        {
            tbLength1.Text = $"{trbLength1.Value}";
            initilizePendulums();

        }

        private void trbAngle1_Scroll(object sender, EventArgs e)
        {
            tbAngle1.Text = $"{trbAngle1.Value}";
            initilizePendulums();

        }

        private void trbMass2_Scroll(object sender, EventArgs e)
        {
            tbMass2.Text = $"{trbMass2.Value}";
            initilizePendulums();

        }

        private void trbLength2_Scroll(object sender, EventArgs e)
        {
            tbLength2.Text = $"{trbLength2.Value}";
            initilizePendulums();

        }

        private void trbAngle2_Scroll(object sender, EventArgs e)
        {
            tbAngle2.Text = $"{trbAngle2.Value}";
            initilizePendulums();

        }

        private void btSaveGraphic_Click(object sender, EventArgs e)
        {
            try
            {
                string fileName = tbFileName.Text;
                string catalogPath=tbCatologPath.Text;
                if (fileName.Equals("")|| catalogPath.Equals(""))
                {
                    MessageBox.Show("Nie wprowadziłeś adresu katalogu lub nazwy pliku");
                    return;
                }
                savePaintedTrajectroy($"{catalogPath}\\{fileName}.png");
            }
            catch
            {
                MessageBox.Show("Błąd");
            }
        }

        private void rbBrightBg_CheckedChanged(object sender, EventArgs e)
        {
            bgColor = Color.White;
            initilizePendulums();
        }

        private void rbDarkBg_CheckedChanged(object sender, EventArgs e)
        {
            bgColor= Color.FromArgb(255,20,20,20);
            initilizePendulums();
        }

        
    }
}
