using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace инопланетянин
{
    public class Alien
    {
        string name; //имя инопланетянина
        string planet; //планета
        double minheight; //минимальный возможный рост
        double maxheight; //максимально возможный рост
        double height; //его рост
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Planet
        {
            get { return planet; }
            set { planet = value; }
        }
        public double Minheight
        {
            get { return minheight; }
            set { minheight = value; }
        }
        public double Maxheight
        {
            get { return maxheight; }
            set { maxheight = value; }
        }
        public double Height
        {
            get { return height; }
            set { height = value; }
        }
        /// <summary>
        /// метод вычисляет отклонение от среднего роста
        /// </summary>
        /// <returns>возвращает значение отклонения от среднего роста</returns>
        public double Otclonenie()
        {
            return height - ((maxheight + minheight) / 2);
        }
        /// <summary>
        /// метод изменяет рост на заданное отклонение
        /// </summary>
        /// <param name="Otclonenie1"></param>
        /// <returns>возвращает значение роста</returns>
        public double Change(double Otclonenie1)
        {
            height += Otclonenie1;
            if (height > maxheight) return maxheight;
            if (height < minheight) return minheight;
            return height;
        }
        public virtual string Info()
        {
            return "Имя: " + name + "\nПланета: " + planet + "\nМин. рост: " + minheight + "\nМакс. рост: " + maxheight + "\nРост: " + height + "\n";
        }
    }
    public class Humanoid : Alien
    {
        double weight; //вес
        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        public override string Info()
        {
            return "Имя: " + Name + "\nПланета: " + Planet + "\nМин. рост: " + Minheight + "\nМакс. рост: " + Maxheight + "\nРост: " + Height + "\nВес: " + Weight + "\n";
        }
    }
    public class Reptiloid : Alien
    {
        int numOfTails; //кол-во хвостов
        public int NumOfTails
        {
            get { return numOfTails; }
            set { numOfTails = value; }
        }

        public override string Info()
        {
            return "Имя: " + Name + "\nПланета: " + Planet + "\nМин. рост: " + Minheight + "\nМакс. рост: " + Maxheight + "\nРост: " + Height + "\nКолличество хвостов: " + numOfTails + "\n";
        }
    }
}