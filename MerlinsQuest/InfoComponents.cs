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
    public class InfoComponents : DrawableGameComponent
    {
        private SpriteBatch spriteBatch;



        private Texture2D infoBack;

 
        private Vector2 position;
        private Color regularColor = Color.Black;
        private KeyboardState oldState;

        public InfoComponents(Game game,
         SpriteBatch spriteBatch,
         Texture2D infoBack)
            : base(game)
        {
            this.spriteBatch = spriteBatch;
            this.infoBack = infoBack;


        }

        private List<Texture2D> chars = new List<Texture2D>();



        public override void Initialize()
        {
            base.Initialize();
        }

        string currentString = "";
        int timer = 0;
        public override void Update(GameTime gameTime)
        {
          
            base.Update(gameTime);

        }

        int space = 0;

        public override void Draw(GameTime gameTime)
        {

            spriteBatch.Begin();

            spriteBatch.Draw(infoBack, new Rectangle(0, 0, infoBack.Width, infoBack.Height), Color.White);

            spriteBatch.DrawString(Game.Content.Load<SpriteFont>("font/regularFont"), "ESCAPE TO RETURN TO MAIN MENU", new Vector2(infoBack.Width / 2 - Game.Content.Load<SpriteFont>("font/regularFont").MeasureString("ESCAPE TO RETURN TO MAIN MENU").Length() / 2, 900), Color.Blue);


            spriteBatch.End();


            base.Draw(gameTime);
        }
    }
}
