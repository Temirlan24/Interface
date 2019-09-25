using System;
using System.Collections.Generic;
using System.Text;

namespace House
{
    public class TeamLeader
    {
        private Basement basement = new Basement();

        private Door door = new Door();

        private Roof roof = new Roof();

        private Wall Wall = new Wall();

        private Window window = new Window();
        public string ShowWork()
        {
            return "Основа:" + basement.IsBuilt + "\n Дверь: " + door.IsBuilt + "\n Крыша:" + roof.IsBuilt + "\n Стены: " + Wall.IsBuilt + "\n Окна:" + window.IsBuilt;
        }
        public void CheckHouse(House house)
        {
            if (house.Basement.IsBuilt)
                basement.IsBuilt = true;

            if (house.Door.IsBuilt)
                door.IsBuilt = true;

            if (house.Wall.IsBuilt)
                Wall.IsBuilt = true;

            if (house.Window.IsBuilt)
                window.IsBuilt = true;

            if (house.Roof.IsBuilt)
                roof.IsBuilt = true;
        }

        public bool Check(IPart part)
        {
            if (part.IsBuilt)
            {
                if (part.GetType() == basement.GetType())
                {
                    basement.IsBuilt = true;
                }
                else if (part.GetType() == door.GetType())
                {
                    door.IsBuilt = true;
                }
                else if (part.GetType() == roof.GetType())
                {
                    roof.IsBuilt = true;
                }
                else if (part.GetType() == Wall.GetType())
                {
                    Wall.IsBuilt = true;
                }
                else if (part.GetType() == window.GetType())
                {
                    window.IsBuilt = true;
                }

                return true;
            }
            return false;
        }
    }
}
