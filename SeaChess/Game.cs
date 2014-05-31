using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeaChess
{
    public class Game
    {
        public void Play()
        {
            int chek = 0;
            do
            {
                chek++;
                FieldRenderer.Render();
            } while(chek == 0); 
        }

        private void Turn()
        { 
            
        }
    }
}
