﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManualLinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejemplo de lista enlazada simple");
            MyLinkedList myLinkedList = new MyLinkedList("Mi primer lista enlazada");

            Node firtsNode = new Node("Mi primer nodo");
            Node secondNode = new Node("Segundo nodo");
            Node thirdNode = new Node("Tercer nodo");
            Node cuartoNode = new Node ("Cuarto nodo :D");

            Node quintoNode = new Node("Quinto Nodo");

            myLinkedList.Add(firtsNode);
            myLinkedList.Add(secondNode);
            myLinkedList.Add(thirdNode);
 
            myLinkedList.Add(cuartoNode);

            myLinkedList.Add(quintoNode);
            myLinkedList.Print();

            Console.WriteLine("Presione una tecla para finalizar");
            Console.ReadLine();
        }
    }
}
