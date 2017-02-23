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
    public class VictoryComponent : DrawableGameComponent
    {
        private SpriteBatch spriteBatch;
        private SpriteFont regularFont;
        private Texture2D back;
        private string str1;
        private string str2;


  
        private Vector2 position;
        private Color regularColor = Color.Black;
        private KeyboardState oldState;

        public VictoryComponent(Game game,
         SpriteBatch spriteBatch,
         SpriteFont regularFont,
         Texture2D back,
            string str1,
            string str2)
            : base(game)
        {
            this.spriteBatch = spriteBatch;
            this.regularFont = regularFont;
            this.back = back;
            this.str1 = str1;
            this.str2 = str2;
 

        }

        private List<Texture2D> chars = new List<Texture2D>();

        public bool storyOver = false;

        public override void Initialize()
        {
            base.Initialize();
        }

        string currentString = "";
        int timer = 0;
        public bool navMain = false;
        public override void Update(GameTime gameTime)
        {
            KeyboardState ks = Keyboard.GetState();
            timer++;
            currentString = str1;
            if(timer > 100)
            {
                currentString = str2;
            }
            if(timer > 200)
            {
                currentString = "Press Enter for Main Menu";

                if(ks.IsKeyDown(Keys.Enter))
                {
                    navMain = true;
                }
            }
         
            base.Update(gameTime);
        }

        public override void Draw(GameTime gameTime)
        {

            spriteBatch.Begin();

            spriteBatch.Draw(back, new Rectangle(0, 0, GraphicsDevice.Viewport.Bounds.Width, GraphicsDevice.Viewport.Bounds.Height), Color.White);


            spriteBatch.DrawString(regularFont, currentString, new Vector2((int)GraphicsDevice.Viewport.Bounds.Width / 2 - regularFont.MeasureString(currentString).Length() / 2, (int)GraphicsDevice.Viewport.Bounds.Height / 2 - (int)regularFont.LineSpacing / 2), Color.White);


            spriteBatch.End();


            base.Draw(gameTime);
        }
    }
}
