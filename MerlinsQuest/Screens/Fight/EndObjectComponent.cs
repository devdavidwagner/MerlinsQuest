using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;


namespace MerlinsQuest.Screens.Fight
{
    class EndObjectComponent : DrawableGameComponent
    {

        SpriteBatch spriteBatch;
        public Texture2D endObject;
        public Vector2 position;

        public Vector2 Position
        {
            get
            {
                return position;
            }
            set
            {
                position = value;
            }
        }

        public Texture2D EndObject
        {
            get
            {
                return endObject;
            }
            set
            {
                endObject = value;
            }
        }




        public EndObjectComponent(Game game,
            SpriteBatch spriteBatch,
            Texture2D endObject
            )
            : base(game)
        {

            this.spriteBatch = spriteBatch;
            this.endObject = endObject;


            position = new Vector2(1200, 465);

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
            spriteBatch.Begin();

            spriteBatch.Draw(endObject, position, null, Color.White, 0f, Vector2.Zero, 1f, SpriteEffects.None, 1f);

            spriteBatch.End();
            base.Draw(gameTime);
        }


    }
}
