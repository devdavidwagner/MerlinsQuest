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
    public class Help : GameScene
    {
        private InfoComponents info;


        public InfoComponents InfoCOmp
        {
            get
            {
                return info;
            }

            set
            {
                info = value;
            }
        }

        private SpriteBatch spriteBatch;


        public Help(Game game, SpriteBatch spriteBatch)
            : base(game)
        {
            this.spriteBatch = spriteBatch;
            //check this code very carefully how game reference coming
            // through the constructor is used to acess the Content.
            info = new InfoComponents(game, spriteBatch,
               game.Content.Load<Texture2D>("Images/help")
               );

            // never write game.Components.Add()

            this.Components.Add(info);


        }

        public override void Initialize()
        {
            base.Initialize();
        }

        public bool navMenu = false;
        public override void Update(GameTime gameTime)
        {
            KeyboardState current_ks = Keyboard.GetState();

            if (current_ks.IsKeyDown(Keys.Escape))
            {
                navMenu = true;
            }
            base.Update(gameTime);
        }
        public override void Draw(GameTime gameTime)
        {
            base.Draw(gameTime);
        }
    }
}
