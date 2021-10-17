using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hw4._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a =Convert.ToDouble (textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);
            double c = Convert.ToDouble(textBox3.Text);
            double alfa = Convert.ToDouble(textBox4.Text);
            Triangle t1 = new Triangle(a, b, c, alfa);
            Rhombus r1 = new Rhombus(a, alfa);
            Circle c1 = new Circle(a);
            MessageBox.Show("For triangle: Perimetr = "+t1.Perimeter()+" Square = "+t1.Square()+"\nFor rhombus: Perimetr = "
                +r1.Perimeter()+" Square = "+r1.Square()+ "\nFor circle : Perimetr = "+ c1.Perimeter()+" Square = "+ c1.Square());
        }
    }
    abstract class Figure
    {
        public virtual double Perimeter() {
            return 0;
        }
        public virtual double Square()
        {
            return 0;
        }
    }
    class Triangle : Figure
    {
        double a, b,c, alfa;
        public Triangle(double a, double b,double c,double alfa)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.alfa = alfa;
        }
        public override double Perimeter()
        {
            return (a+b+c);
        }
        public override double Square()
        {
            return (b*c*Math.Sin(alfa));
        }
    }
    class SquareFig : Figure
    {
        double a;
        public SquareFig(double a)
        {
            this.a = a;
        }
        public override double Perimeter()
        {
            return 4*a;
        }
        public override double Square()
        {
            return a*a;
        }
    }
    class Rectangle : Figure
    {
        double a, b;
        public Rectangle(double a,double b)
        {
            this.a = a;
            this.b = b;
        }
        public override double Square()
        {
            return a*b;
        }
        public override double Perimeter()
        {
            return 2*(a+b);
        }
    }
    class Circle : Figure
    {
        double r;
        public Circle(double r)
        {
            this.r = r;
        }
        public override double Perimeter()
        {
            return Math.PI*2*r;
        }
        public override double Square()
        {
            return Math.Pow(r,2)*Math.PI;
        }
    }
    class Rhombus : Figure
    {
        double a, alfa;
        public Rhombus(double a, double alfa)
        {
            this.a = a;
            this.alfa = alfa;
        }
        public override double Perimeter()
        {
            return 4*a;
        }
        public override double Square()
        {
            return a*a*Math.Sin(alfa);
        }
    }
   
}
