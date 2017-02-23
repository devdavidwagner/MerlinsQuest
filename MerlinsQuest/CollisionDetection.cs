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
    class CollisionDetection : DrawableGameComponent
    {
       private SpriteBatch spriteBatch;
    

      private Rectangle obj1Rect;
      private  Rectangle obj2Rect;

   


      public CollisionDetection(Game game,
            SpriteBatch spriteBatch
           ) :base(game)
        {
            this.spriteBatch = spriteBatch;
        
        }

        bool collided = false;
        bool playedOnce = false;
      
        public bool Collided(Texture2D obj1, Texture2D obj2, Vector2 objPos1, Vector2 objPos2)
        {

            obj1Rect = new Rectangle((int)objPos1.X, (int)objPos1.Y, obj1.Width, obj1.Height);
            obj2Rect = new Rectangle((int)objPos2.X, (int)objPos2.Y, obj2.Width, obj2.Height);

            collided = false;

   
            
            if (obj2Rect.Intersects(obj1Rect) || obj1Rect.Intersects(obj2Rect))
            {
               collided = true;
        
            }

          


            return collided;

        }

        public bool CollidedScaled(Texture2D obj1, Texture2D obj2, Vector2 objPos1, Vector2 objPos2)
        {

            obj1Rect = new Rectangle((int)objPos1.X, (int)objPos1.Y, obj1.Width*2, obj1.Height * 2);
            obj2Rect = new Rectangle((int)objPos2.X, (int)objPos2.Y, obj2.Width * 2, obj2.Height * 2);

            collided = false;



            if (obj2Rect.Intersects(obj1Rect) || obj1Rect.Intersects(obj2Rect))
            {
                collided = true;

            }




            return collided;

        }

        public bool CollidedBrick(Texture2D obj1, Texture2D obj2, Vector2 objPos1, Vector2 objPos2, Boolean jumping)
        {

            obj1Rect = new Rectangle((int)objPos1.X, (int)objPos1.Y, obj1.Width, obj1.Height);
            obj2Rect = new Rectangle((int)objPos2.X, (int)objPos2.Y, obj2.Width, obj2.Height);

            collided = false;

            if (obj2Rect.Bottom < obj1Rect.Top && obj2Rect.Left < obj1Rect.Right && obj2Rect.Right > obj1Rect.Left)
            {
                collided = true;
            }

          
            
           


            return collided;

        }
     


        public override void Initialize()
        {
            base.Initialize();
        }
        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
        }
        public override void Draw(GameTime gameTime)
        {

   
           
            base.Draw(gameTime);
        }



         
    }
}
