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
    public class Start: GameScene
    {
        private MenuComponent menu;
       

        public MenuComponent Menu
        {
            get
            {
                return menu;
            }

            set
            {
                menu = value;
            }
        }

        private SpriteBatch spriteBatch;
        string[] menuItems = {  "BEGIN YOUR QUEST",
                                "HOW TO PLAY",
                                "HELP",
                                "ABOUT",
                                "QUIT"};

        public Start(Game game, SpriteBatch spriteBatch) : base(game)
        {
            this.spriteBatch = spriteBatch;
            //check this code very carefully how game reference coming
            // through the constructor is used to acess the Content.
            menu = new MenuComponent(game, spriteBatch,
                game.Content.Load<SpriteFont>("Font/regularFont"),
                game.Content.Load<SpriteFont>("Font/hilightFont"),
                game.Content.Load<Texture2D>("Images/coverMerlin"),
                menuItems
                );

            // never write game.Components.Add()
           
            this.Components.Add(menu);


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
