﻿using System;
using System.Collections.Generic;

namespace PoliticianCrusade
{
    public class Umbrella : StaticObject, IResource
    {
        private static int xCoord = 81;
        private static int yCoord = 34;

        public readonly int Price = 150;
       
        public Umbrella() 
                : base(xCoord, yCoord)
        {
            this.RemainingPower = 100;
        }

        #region Properties
        public int RemainingPower { get; set; }
        public ResourceType Type
        {
            get { return ResourceType.Weapon; }
        }

        #endregion

        #region DrawImageMethods
        public override char[,] GetImage()
        {



            return new char[,] { 
                                 { ' ', '_', ' ' } ,
                                 { ' ', '|' , ' '} ,
                                 { '_', '_', '_' } ,
                                 { '\\', '|', '/'} ,
                                 { ' ', '|' , ' '} ,
                                 
                                 
            };
        }

        public override void RenderImg()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            base.RenderImg();
        } 
        #endregion
    }
}
