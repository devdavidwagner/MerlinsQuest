using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
  
namespace SAMF
{
    public class CharacterSelection : GameScene
    {
        private MenuComponent menu;
        private Texture2D backTex;
        private List<Texture2D> chars;
        private Vector2 pos;

        Texture2D wizard;
        Texture2D knight;
        Texture2D dwarf;

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
        string[] menuItems = {  "WIZARD",
                                "KNIGHT",
                                "DWARF"};

        public CharacterSelection(Game game, SpriteBatch spriteBatch)
            : base(game)
        {
            this.spriteBatch = spriteBatch;
            //check this code very carefully how game reference coming
            // through the constructor is used to acess the Content.


            wizard = game.Content.Load<Texture2D>("Images/wizard");
            knight = game.Content.Load<Texture2D>("Images/knight");
            dwarf = game.Content.Load<Texture2D>("Images/dwarf");

            chars = new List<Texture2D>() { wizard, knight, dwarf };


            menu = new MenuComponent(game, spriteBatch,
                game.Content.Load<SpriteFont>("Font/regularFont"),
                game.Content.Load<SpriteFont>("Font/hilightFont"),
                game.Content.Load<Texture2D>("Images/SELECT_FIGHTER"),
                chars,
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
