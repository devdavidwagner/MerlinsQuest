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
    public class VictoryScreen : GameScene
    {
        private VictoryComponent vicComp;


        public VictoryComponent VicComp
        {
            get
            {
                return vicComp;
            }

            set
            {
                vicComp = value;
            }
        }

        private SpriteBatch spriteBatch;


        public VictoryScreen(Game game, SpriteBatch spriteBatch)
            : base(game)
        {
            this.spriteBatch = spriteBatch;
            //check this code very carefully how game reference coming
            // through the constructor is used to acess the Content.
            vicComp = new VictoryComponent(game, spriteBatch,
                game.Content.Load<SpriteFont>("Font/regularFont"),
                game.Content.Load<Texture2D>("Images2/arthur"),
                "You saved the King!",
                "Thank you Merlin!"
                );

            // never write game.Components.Add()

            this.Components.Add(vicComp);


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
