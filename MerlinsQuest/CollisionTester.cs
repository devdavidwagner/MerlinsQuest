using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;


namespace MerlinsQuest
{
    class CollisionTester
    {
       
        public static void drawRect(Rectangle rect, Color color, SpriteBatch spriteBatch)
        {


            Texture2D texture = new Texture2D(spriteBatch.GraphicsDevice, 1, 1);

            texture.SetData(new[] { Color.Black });
            Rectangle obj1Rect = new Rectangle((int)rect.X, (int)rect.Y, rect.Width * 2, rect.Height * 2);
    
            spriteBatch.Draw(texture, obj1Rect, Color.Black);
          


        }



    }
}
