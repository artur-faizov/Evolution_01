using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// new test comment 5

namespace Evolution_01
{
    class LifeForm
    {
        public int ID;
        public float OldLocX;
        public float OldLocY;
        public float CurrentLocX;
        public float CurrentLocY;
        public float MoveAngle;
        public float MoveStep;
        public float X;

        public LifeForm(List<LifeForm> _Coloni, Random _rnd)
        {
            ID = _Coloni.Count + 1;
            CurrentLocX = _rnd.Next(0, 700);
            CurrentLocY = _rnd.Next(0, 500);
            MoveAngle = (float)(_rnd.Next(0, 360) * Math.PI / 180);
            X = MoveAngle;
            MoveStep = _rnd.Next(1, 3);
        }

        public void Move(int _MaxX, int _MaxY)
        {
            this.OldLocX = this.CurrentLocX;
            this.OldLocY = this.CurrentLocY;
            double NewX = this.CurrentLocX + this.MoveStep * Math.Sin(this.MoveAngle);
            double NewY = this.CurrentLocY + this.MoveStep * Math.Cos(this.MoveAngle);
            Random _rnd = new Random();
            while ((NewX < 0) || (NewX > _MaxX) || (NewY < 0) || (NewY > _MaxY))
            {
                this.MoveAngle = (float)(_rnd.Next(0, 360) * Math.PI / 180);
                NewX = this.CurrentLocX + this.MoveStep * Math.Sin(this.MoveAngle);
                NewY = this.CurrentLocY + this.MoveStep * Math.Cos(this.MoveAngle);
            }
                this.CurrentLocX = (float)NewX;
                this.CurrentLocY = (float)NewY;
        }

        public void Born(List<LifeForm> _Coloni, Random _rnd, int _ID)
        {
            _Coloni.Add(new LifeForm(_Coloni, _rnd));
            _Coloni[_Coloni.Count - 1].CurrentLocX = _Coloni[_ID].CurrentLocX;
            _Coloni[_Coloni.Count - 1].CurrentLocY = _Coloni[_ID].CurrentLocY;
        }
    }
}
