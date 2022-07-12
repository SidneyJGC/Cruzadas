using System;
using System.Collections.Generic;
using System.Linq;

namespace examenfinal
{
    class Program
    {
        static void Main(string[] args)
        {
            Nodo DesembRey = new Nodo() { City = "DesembRey" };
            Nodo Volantis = new Nodo() { City = "Volantis" };
            Nodo Braavos = new Nodo() { City = "Braavos" };
            Nodo Qarth = new Nodo() { City = "Qarth" };
            Nodo Asshai = new Nodo() { City = "Asshai" };
            Nodo Meereen = new Nodo() { City = "Meereen" };
            Nodo Pentos = new Nodo() { City = "Pentos" };

            DesembRey.Caminos.Add(new Camino() { Nodo = Volantis, Cost = 1600, CostoTotalMuertos = 6 });
            DesembRey.Caminos.Add(new Camino() { Nodo = Braavos, Cost = 1200, CostoTotalMuertos = 7 });
            DesembRey.Caminos.Add(new Camino() { Nodo = Qarth, Cost = 1900, CostoTotalMuertos = 9 });
            DesembRey.Caminos.Add(new Camino() { Nodo = Asshai, Cost = 1050, CostoTotalMuertos = 1 });
            DesembRey.Caminos.Add(new Camino() { Nodo = Meereen, Cost = 900, CostoTotalMuertos = 3 });
            DesembRey.Caminos.Add(new Camino() { Nodo = Pentos, Cost = 950, CostoTotalMuertos = 4 });

            Volantis.Caminos.Add(new Camino() { Nodo = DesembRey, Cost = 1600, CostoTotalMuertos = 6 });
            Volantis.Caminos.Add(new Camino() { Nodo = Braavos, Cost = 1000, CostoTotalMuertos = 2 });
            Volantis.Caminos.Add(new Camino() { Nodo = Qarth, Cost = 1050, CostoTotalMuertos = 3 });
            Volantis.Caminos.Add(new Camino() { Nodo = Asshai, Cost = 1100, CostoTotalMuertos = 8 });
            Volantis.Caminos.Add(new Camino() { Nodo = Meereen, Cost = 1600, CostoTotalMuertos = 1 });
            Volantis.Caminos.Add(new Camino() { Nodo = Pentos, Cost = 800, CostoTotalMuertos = 3 });

            Braavos.Caminos.Add(new Camino() { Nodo = DesembRey, Cost = 1200, CostoTotalMuertos = 7 });
            Braavos.Caminos.Add(new Camino() { Nodo = Volantis, Cost = 1000, CostoTotalMuertos = 2 });
            Braavos.Caminos.Add(new Camino() { Nodo = Qarth, Cost = 1900, CostoTotalMuertos = 11 });
            Braavos.Caminos.Add(new Camino() { Nodo = Asshai, Cost = 1000, CostoTotalMuertos = 12 });
            Braavos.Caminos.Add(new Camino() { Nodo = Meereen, Cost = 1800, CostoTotalMuertos = 2 });
            Braavos.Caminos.Add(new Camino() { Nodo = Pentos, Cost = 1300, CostoTotalMuertos = 4 });

            Qarth.Caminos.Add(new Camino() { Nodo = DesembRey, Cost = 1900, CostoTotalMuertos = 9 });
            Qarth.Caminos.Add(new Camino() { Nodo = Volantis, Cost = 1050, CostoTotalMuertos = 3 });
            Qarth.Caminos.Add(new Camino() { Nodo = Braavos, Cost = 1900, CostoTotalMuertos = 11 });
            Qarth.Caminos.Add(new Camino() { Nodo = Asshai, Cost = 500, CostoTotalMuertos = 7 });
            Qarth.Caminos.Add(new Camino() { Nodo = Meereen, Cost = 700, CostoTotalMuertos = 6 });
            Qarth.Caminos.Add(new Camino() { Nodo = Pentos, Cost = 1200, CostoTotalMuertos = 3 });

            Asshai.Caminos.Add(new Camino() { Nodo = DesembRey, Cost = 1050, CostoTotalMuertos = 1 });
            Asshai.Caminos.Add(new Camino() { Nodo = Volantis, Cost = 1100, CostoTotalMuertos = 8 });
            Asshai.Caminos.Add(new Camino() { Nodo = Braavos, Cost = 1000, CostoTotalMuertos = 12 });
            Asshai.Caminos.Add(new Camino() { Nodo = Qarth, Cost = 500, CostoTotalMuertos = 7 });
            Asshai.Caminos.Add(new Camino() { Nodo = Meereen, Cost = 300, CostoTotalMuertos = 5 });
            Asshai.Caminos.Add(new Camino() { Nodo = Pentos, Cost = 1100, CostoTotalMuertos = 2 });

            Meereen.Caminos.Add(new Camino() { Nodo = DesembRey, Cost = 900, CostoTotalMuertos = 3 });
            Meereen.Caminos.Add(new Camino() { Nodo = Volantis, Cost = 1600, CostoTotalMuertos = 1 });
            Meereen.Caminos.Add(new Camino() { Nodo = Braavos, Cost = 1800, CostoTotalMuertos = 2 });
            Meereen.Caminos.Add(new Camino() { Nodo = Qarth, Cost = 700, CostoTotalMuertos = 6 });
            Meereen.Caminos.Add(new Camino() { Nodo = Asshai, Cost = 300, CostoTotalMuertos = 5 });
            Meereen.Caminos.Add(new Camino() { Nodo = Pentos, Cost = 200, CostoTotalMuertos = 15 });

            Pentos.Caminos.Add(new Camino() { Nodo = DesembRey, Cost = 950, CostoTotalMuertos = 4 });
            Pentos.Caminos.Add(new Camino() { Nodo = Volantis, Cost = 800, CostoTotalMuertos = 3 });
            Pentos.Caminos.Add(new Camino() { Nodo = Braavos, Cost = 1300, CostoTotalMuertos = 4 });
            Pentos.Caminos.Add(new Camino() { Nodo = Qarth, Cost = 1200, CostoTotalMuertos = 3 });
            Pentos.Caminos.Add(new Camino() { Nodo = Asshai, Cost = 1100, CostoTotalMuertos = 2 });
            Pentos.Caminos.Add(new Camino() { Nodo = Meereen, Cost = 200, CostoTotalMuertos = 15 });

            List<Nodo> graph = new List<Nodo>()
            {
                DesembRey, Volantis, Braavos, Qarth, Asshai, Meereen, Pentos
            };

            var algorithm = new Algoritmo(graph, 720, DesembRey);
            algorithm.Run();
            Console.WriteLine(algorithm.GetAllRoutes);
        }

    }

    public class Nodo
    {
        public string City { get; set; }
        public List<Camino> Caminos { get; set; }
        public Nodo()
        {
            Caminos = new List<Camino>();
        }


    }
    public struct Camino
    {
        public Nodo Nodo { get; set; }
        public int Cost { get; set; }
        public int CostoTotalMuertos { get; set; }
    }

    public class Route
    {
        public List<Nodo> Nodos { get; set; }
        public int TotalCost { get; set; }
        public int Totalsoldadosvivos { get; set; }
        public Route()
        {
            Nodos = new List<Nodo>();
            TotalCost = 0;
        }
    }

    public class Algoritmo
    {
        private List<Nodo> _graph { get; set; }
        private int _n;
        private Nodo _origin { get; set; }
        private List<Route> _solutions { get; set; }

        public string GetAllRoutes
        {
            get
            {
                int i = 1;
                string result = "";

                foreach (var route in _solutions)
                {
                    result += i + ": ";
                    foreach (var node in route.Nodos)
                    {
                        result += node.City + "-";
                    }
                    result += "Gasto en Oro => " + route.TotalCost + " Saldo Soldados =>" + route.Totalsoldadosvivos + "\n";
                    i++;
                }
                return result;

            }
        }

        public Algoritmo(List<Nodo> graph, int n, Nodo origin)
        {
            _graph = graph;
            _n = n;
            _origin = origin;
        }

        public void Run()
        {
            _solutions = new List<Route>();

            for (int i = 0; i < _n; i++)
            {
                _solutions.Add(Generate());
            }

            _solutions = _solutions.OrderByDescending(d => d.Totalsoldadosvivos).ToList();

        }

        private Route Generate()
        {
            int TotalOro = 20000;
            int TotalSoldados = 1000;
            var solution = new Route();

            solution.Nodos.Add(_origin);
            Nodo current = _origin;

            for (int i = 0; i < _graph.Count - 1; i++)
            {
                Nodo next = null;
                do
                {
                    next = NodoSiguiente(current);
                } while (solution.Nodos.Contains(next));

                solution.Nodos.Add(next);
                solution.TotalCost += current.Caminos.Where(d => d.Nodo.City == next.City).First().Cost;
                int totalmuertos = current.Caminos.Where(d => d.Nodo.City == next.City).First().CostoTotalMuertos;
                int soladosvivos = TotalSoldados - (totalmuertos * TotalSoldados) / 100;
                TotalSoldados = soladosvivos;

                solution.Totalsoldadosvivos = TotalSoldados;
                current = next;
            }
            solution.Nodos.Add(_origin);
            solution.TotalCost += current.Caminos.Where(d => d.Nodo.City == _origin.City).First().Cost;
            solution.TotalCost = TotalOro - solution.TotalCost;
            return solution;
        }

        private Nodo NodoSiguiente(Nodo current)
        {
            int nextNode = new Random().Next(0, _graph.Count - 1);
            return current.Caminos[nextNode].Nodo;
        }
    }


}
