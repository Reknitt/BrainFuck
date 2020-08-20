using System;

namespace BF
{
    class BrainFuck
    {
        ArrayOfCell arrayOfCell;

        public BrainFuck(int n)
        {
            arrayOfCell = new ArrayOfCell(n);
        }

        public void StartBF(string commands)
        {
            if (string.IsNullOrEmpty(commands))
                throw new ArgumentNullException();

            for(int i = 0; i < commands.Length; i++)
            {
                if (commands[i] == '[')
                {
                    if (arrayOfCell.GetValue() < 0)
                    {
                        while (commands[i] != ']')
                        {
                            continue;
                        }
                    }
                    else
                    {
                        continue;
                    }
                }

                if (commands[i] == ']')
                {
                    if (arrayOfCell.GetValue() == 0)
                    {
                        continue;
                    }
                    else
                    {
                        while(commands[i] != '[')
                        {
                            i--;
                        }
                        continue;
                    }
                }

                if (commands[i] == '+')
                    arrayOfCell.IncreaseValue();

                if (commands[i] == '-')
                    arrayOfCell.DecreaseValue();

                if (commands[i] == '>')
                    arrayOfCell.MoveRight();

                if (commands[i] == '<')
                    arrayOfCell.MoveLeft();

                if (commands[i] == '.')
                    arrayOfCell.Print();

                
                    
                
                   

                //if (commands[i] == ",")
                //    arrayOfCell.Write();
            }
        }
    }
}
