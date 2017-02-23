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
    public class StoryComponent : DrawableGameComponent
    {
        private SpriteBatch spriteBatch;
        private SpriteFont regularFont;
        private List<string> storyLines;
        private int selectedIndex = 0;
        private Texture2D storyBack;

        public int SelectedIndex
        {
            get
            {
                return selectedIndex;
            }

            set
            {
                selectedIndex = value;
            }
        }
        private Vector2 position;
        private Color regularColor = Color.White;
        private KeyboardState oldState;

        public StoryComponent(Game game,
         SpriteBatch spriteBatch,
         SpriteFont regularFont,
         Texture2D storyBack,
         string[] story)
            : base(game)
        {
            this.spriteBatch = spriteBatch;
            this.regularFont = regularFont;
            this.storyBack = storyBack;
      
            storyLines = story.ToList();
      
        }


        public bool storyOver = false;

        public override void Initialize()
        {
            base.Initialize();
        }

        string currentString = "";
        int timer = 0;
        public override void Update(GameTime gameTime)
        {
            KeyboardState ks = Keyboard.GetState();
            timer++;
            if(timer > 50)
            {
                currentString = storyLines[0];
            }
            if (timer >200)
            {
                currentString = storyLines[1];

            }
            if (timer > 350)
            {
                currentString = storyLines[2];
  
            }
            if (timer > 500)
            {
                currentString = storyLines[3];
   
            }
            if (timer > 600)
            {
                storyOver = true;
            }
            
            base.Update(gameTime);
        }

        public override void Draw(GameTime gameTime)
        {
        
            spriteBatch.Begin();

            spriteBatch.Draw(storyBack, new Rectangle(0, 0, storyBack.Width, storyBack.Height), Color.White);


            position = new Vector2(100, storyBack.Height/ 2 + regularFont.LineSpacing);
            spriteBatch.DrawString(regularFont, currentString, position, regularColor);
          
          

            spriteBatch.End();


            base.Draw(gameTime);
        }
    }
}
