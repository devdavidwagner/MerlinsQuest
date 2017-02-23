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
    public class Story : GameScene
    {
        private StoryComponent story;


        public StoryComponent StoryComp
        {
            get
            {
                return story;
            }

            set
            {
                story = value;
            }
        }

        private SpriteBatch spriteBatch;
        string[]storyText = { "King Arthur has been captured by \n the Dark Lord Mordred",
                                "You must travel through \n the Dark Lands to save him!",
                                "Please.... Merlin... \n the Wise Wizard of the West",
                                "You are his only hope!" };

        public Story(Game game, SpriteBatch spriteBatch)
            : base(game)
        {
            this.spriteBatch = spriteBatch;
            //check this code very carefully how game reference coming
            // through the constructor is used to acess the Content.
            story = new StoryComponent(game, spriteBatch,
                game.Content.Load<SpriteFont>("Font/regularFont"),
                game.Content.Load<Texture2D>("Images/darkLand"),
                storyText
                );

            // never write game.Components.Add()

            this.Components.Add(story);


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
