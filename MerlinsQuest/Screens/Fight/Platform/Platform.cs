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
    class Platform : GameScene
    {
        SpriteBatch spriteBatch;
        Texture2D platform;

        PlatformComponent platComp;


        public PlatformComponent PlatComp
        {
            get
            {
                return platComp;
            }
            set
            {
                platComp = value;
            }

        }
        public Platform(Game game,
            SpriteBatch spriteBatch) : base(game)
        {
            this.spriteBatch = spriteBatch;
            platform = game.Content.Load<Texture2D>("Images2/platform");
        

            platComp = new PlatformComponent(game, spriteBatch,
                platform);

            this.Components.Add(platComp);



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
