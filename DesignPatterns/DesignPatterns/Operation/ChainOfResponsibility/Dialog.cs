﻿using System;

namespace DesignPatterns.Operation.ChainOfResponsibility
{
    public class Dialog : Widget
    {
        public Dialog(HandlerBase handler) : base(handler)
        {
        }

        public override void Draw()
        {
            Console.WriteLine("Draw dialog");
        }
    }
}
