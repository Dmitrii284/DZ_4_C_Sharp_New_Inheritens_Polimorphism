using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_4_C_Sharp_New_Inheritens_Polimorphism
{
    public class Device
    {
        protected string _name;
        public Device(string name) { _name = name; }

        public virtual void Saund()
        {
            Console.Write("Устройство издает звук: ");
        }

        public virtual void Show() { Console.Write("Название устройства: " + _name); }

        public virtual void Desc()
        {
            Console.WriteLine("Описание устройства: ");
        }

    }

    public class Teapot : Device
    {        
        public Teapot(string name) : base(name) { }
        public override void Saund() {
            base.Saund();
            Console.WriteLine($"{_name } !!!!!Свистит!!!!"); 
        }
        public override void Show() { 
            base.Show();
            Console.WriteLine();
        }
        public override void Desc() {
            base.Desc();
            Console.WriteLine("Это чайник, используется для кипячения воды.");
        }

    }
    public class Nuke : Device
    {
        public Nuke(string name) : base(name) { }

        public override void Desc()
        {
            base.Desc();
            Console.WriteLine("Это микроволновка, используется для разогрева и приготовления пищи.");
        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine();
        }
        public override void Saund()
        {
            base.Saund();
            Console.WriteLine(_name + "!!!! Пищит !!!!\n\n");
        }
        
    }

    public class Car : Device
    {
        public Car(string name) : base(name) { }

        public override void Saund()
        {
            Console.WriteLine("Автомобиль издает звук двигателя !!!!!!!! PPPPP  !!!!!!!!!!!\n");
        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine();
        }
        public override void Desc()
        {
            base.Desc();
            Console.WriteLine("Это автомобиль, используется для перевозки людей и грузов.");
        }
    }
     public class Steamboat : Device
    {
        public Steamboat(string name) : base(name) { }

        public override void Show()
        {
            base.Show();
            Console.WriteLine();
        }
        public override void Saund()
        {
            Console.WriteLine("Пароход издает звук паровой машины !!!!!! Чух Чух Чух !!!!!");
        }
        public override void Desc()
        {
            base.Desc();
            Console.WriteLine("Это пароход, используется для перевозки людей и грузов по воде.");
        }

    }


}
