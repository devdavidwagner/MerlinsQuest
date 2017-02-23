using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;


namespace MerlinsQuest.Screens.Fight.Platform
{
    class PlatformComponent : DrawableGameComponent
    {

        SpriteBatch spriteBatch;
        public Texture2D platform;
        public Vector2 position;
        public Rectangle rect;

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

        public Texture2D Platform
        {
            get
            {
                return platform;
            }
            set
            {
                platform = value;
            }
        }


        public PlatformComponent(Game game,
            SpriteBatch spriteBatch,
            Texture2D platform
            ) : base(game)
        {

            this.spriteBatch = spriteBatch;
            this.platform = platform;

            rect = new Rectangle(300, 700, platform.Width, platform.Height);
            position = new Vector2(0, 700);

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

            spriteBatch.Draw(platform, position, null, Color.White, 0f, Vector2.Zero, 1f, SpriteEffects.None, 1f);

            spriteBatch.End();
            base.Draw(gameTime);
        }
            

    }
}
