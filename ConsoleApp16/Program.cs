using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//- ArDeco
//	- Modern
//	- Victorian
namespace ConsoleApp16
{
    interface IChair
    {
        bool sitOn();
        bool haslegs();
    }
    class ArdecoChair : IChair
    {
        public bool haslegs()
        {
            return true;
        }

        public bool sitOn()
        {
            return true;
        }
    }
    class ModernChair : IChair
    {
        public bool haslegs()
        {
            return true;
        }

        public bool sitOn()
        {
            return true;
        }
    }
    class VictorianChair : IChair
    {
        public bool haslegs()
        {
            return false;
        }

        public bool sitOn()
        {
            return true;
        }
    }
    interface ITable
    {
        bool sitOn();
        bool haslegs();
    }
    class ArdecoTable : ITable
    {
        public bool haslegs()
        {
            return false;
        }

        public bool sitOn()
        {
            return true;
        }
    }
    class ModernTable : ITable
    {
        public bool haslegs()
        {
            return true;
        }
        public bool sitOn()
        {
            return true;
        }
    }
    class VictorianTable : ITable
    {
        public bool haslegs()
        {
            return false;
        }

        public bool sitOn()
        {
            return true;
        }
    }
    interface ISofa
    {
        bool sitOn();
        bool haslegs();
    }
    class ArdecoSofa : ISofa
    {
        public bool haslegs()
        {
            return false;
        }

        public bool sitOn()
        {
            return true;
        }
    }
    class ModernSofa : ISofa
    {
        public bool haslegs()
        {
            return true;
        }
        public bool sitOn()
        {
            return true;
        }
    }
    class VictorianSofa : ISofa
    {
        public bool haslegs()
        {
            return false;
        }

        public bool sitOn()
        {
            return true;
        }
    }
    interface IFurnitureFactory
    {
        IChair createChair();
        ITable createTable();
        ISofa createSofa();
        void Show();
    }
    class ModernFurniture : IFurnitureFactory
    {
        public IChair createChair()
        {
            return new ModernChair();
        }

        public ISofa createSofa()
        {
            return new ModernSofa();
        }

        public ITable createTable()
        {
            return new ModernTable();
        }

        public void Show()
        {
            Console.WriteLine("Modern");
        }
    }
    class VictorinaFurniture : IFurnitureFactory
    {
        public IChair createChair()
        {
            return new VictorianChair();
        }

        public ISofa createSofa()
        {
            return new VictorianSofa();
        }

        public ITable createTable()
        {
            return new VictorianTable();
        }

        public void Show()
        {
            Console.WriteLine("Victorina");
        }
    }
    class ArdecoFurniture : IFurnitureFactory
    {
        public IChair createChair()
        {
            return new ArdecoChair();
        }

        public ISofa createSofa()
        {
            return new ArdecoSofa();
        }
        public ITable createTable()
        {
            return new ArdecoTable();
        }

        public void Show()
        {
            Console.WriteLine("Ardeco");
        }
    }

    class Controller
    {
        public void Run()
        {
            VictorinaFurniture furniture = new VictorinaFurniture();
            furniture.Show();
            ArdecoFurniture ardeco = new ArdecoFurniture();
            ardeco.Show();
            ModernFurniture modern = new ModernFurniture();
            modern.Show();
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Controller controller = new Controller();
            controller.Run();
        }
    }
}
