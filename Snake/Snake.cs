using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Snake
    {
        Board mainBoard;
        List<Position> body;
        public Snake(Board mainBoard)
        {
            this.mainBoard = mainBoard;

            body = new List<Position>();

            body.Add(new Position(0, 2));
            body.Add(new Position(0, 1));
            body.Add(new Position(0, 0));

            
            
        }
        public void move(string direction)
        {
            Position currentHeadPosition = body[0];
            Position newHeadPosition = null;

            switch (direction)
            {
                case "UP":
                    if (currentHeadPosition.getRowNo() > mainBoard.getMinRowNo())
                    {
                        newHeadPosition = new Position(currentHeadPosition.getRowNo() - 1, currentHeadPosition.getColNo());
                    }
                    else if(currentHeadPosition.getRowNo() == mainBoard.getMinRowNo())
                    {
                        newHeadPosition = new Position(mainBoard.getMaxRowNo(),currentHeadPosition.getColNo());
                    }
                    break;
                case "DOWN":
                    if (currentHeadPosition.getRowNo() < mainBoard.getMaxRowNo())
                    {
                        newHeadPosition = new Position(currentHeadPosition.getRowNo() + 1, currentHeadPosition.getColNo());
                    }
                    else if (currentHeadPosition.getRowNo() == mainBoard.getMaxRowNo())
                    {
                        newHeadPosition = new Position(mainBoard.getMinRowNo(),currentHeadPosition.getColNo());
                    }
                    break;
                case "LEFT":
                    if (currentHeadPosition.getColNo() > mainBoard.getMinColNo())
                    {
                        newHeadPosition = new Position(currentHeadPosition.getRowNo(), currentHeadPosition.getColNo() - 1);
                    }
                    else if (currentHeadPosition.getColNo() == mainBoard.getMinColNo())
                    {
                        newHeadPosition = new Position(currentHeadPosition.getRowNo(),mainBoard.getMaxColNo());
                    }
                    break;
                case "RIGHT":
                    if (currentHeadPosition.getColNo() < mainBoard.getMaxColNo())
                    {
                        newHeadPosition = new Position(currentHeadPosition.getRowNo(), currentHeadPosition.getColNo() + 1);
                    }
                    else if (currentHeadPosition.getColNo() == mainBoard.getMaxColNo())
                    {
                        newHeadPosition = new Position(currentHeadPosition.getRowNo(), mainBoard.getMinColNo());
                    }
                    break;
                    
            }

            if (newHeadPosition != null)
            {
                body.Insert(0, newHeadPosition); //Add a new head positon 0
                body.RemoveAt(body.Count-1); //Remove the last position
            }


        }
        public void draw()
        {
            for (int i=1;i<body.Count;i++)
            {
                mainBoard.draw(body[i], Properties.Resources.Body);
            }
            mainBoard.draw(body[0], Properties.Resources.headright);
            ////right
            //if (body[0].getColNo() < mainBoard.getMaxColNo())
            //{
            //    mainBoard.draw(body[0], Properties.Resources.headright); //Index 0 is always the head
            //}
            ////down
            //if(body[0].getRowNo() < mainBoard.getMaxRowNo())
            //{
            //    mainBoard.draw(body[0], Properties.Resources.headdown); //Index 0 is always the head
            //}
            ////up
            //if(body[0].getRowNo() > mainBoard.getMinRowNo())
            //{
            //    mainBoard.draw(body[0], Properties.Resources.headup); //Index 0 is always the head

            //}
            ////left
            //if(body[0].getColNo() > mainBoard.getMinColNo())
            //{
            //    mainBoard.draw(body[0], Properties.Resources.headleft); //Index 0 is always the head
            //}

        }

        public Boolean checkEatItself()
        {
            Boolean result = false;

            if (body.Count > 1) //If snake is shorter then 1, sure won't eat itself
            {
                //Check if body[0] is at the same position as any one of the remaining body parts
                for (int i = 1; i < body.Count; i++)
                {
                    if (body[0].getRowNo() == body[i].getRowNo() && body[0].getColNo() == body[i].getColNo())
                    {
                        result = true;
                    }
                }
            }
            return result;
        }

        public Position getHeadPosition()
        {
            return body[0];
        }
        public Position GetPosition()
        {
            return body[1];
        }
        public void addToTail(Position p)
        {
            body.Add(p);
        }

        public void extendBody()
        {
            Position p = new Position(body[0].getRowNo(), body[0].getColNo());
            body.Insert(1, p);
        }
        


    }
}
