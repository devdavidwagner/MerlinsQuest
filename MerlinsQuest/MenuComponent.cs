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
    public class MenuComponent : DrawableGameComponent
    {
        private SpriteBatch spriteBatch;
        private SpriteFont regularFont, hilightFont;
        private List<string> menuItems;
        private int selectedIndex = 0;
        private Texture2D backTex;
       

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
        private Color regularColor = Color.Black;
        private Color hilightColor = Color.DarkBlue;
        private KeyboardState oldState;

        public MenuComponent(Game game,
         SpriteBatch spriteBatch,
         SpriteFont regularFont,
         SpriteFont hilightFont,
         Texture2D backTex,
         string[] menus)
            : base(game)
        {
            this.spriteBatch = spriteBatch;
            this.regularFont = regularFont;
            this.hilightFont = hilightFont;
            this.backTex = backTex;
            menuItems = menus.ToList();
            position = new Vector2(GraphicsDevice.Viewport.Bounds.Width / 2,
                GraphicsDevice.Viewport.Bounds.Height / 2);
        }

        private List<Texture2D> chars = new List<Texture2D>();

        //overloaded contstructor for char selection
   

        public override void Initialize()
        {
            base.Initialize();
        }

        public override void Update(GameTime gameTime)
        {
            KeyboardState ks = Keyboard.GetState();
            if (chars.Count > 0)
            {

                if (ks.IsKeyDown(Keys.Left) && oldState.IsKeyUp(Keys.Left))
                {
                    selectedIndex++;
                    if (selectedIndex == menuItems.Count)
                    {
                        selectedIndex = 0;
                    }

                }
                if (ks.IsKeyDown(Keys.Right) && oldState.IsKeyUp(Keys.Right))
                {
                    selectedIndex--;
                    if (selectedIndex == -1)
                    {
                        selectedIndex = menuItems.Count - 1;
                    }
                }

            }
            else
            { 
                if (ks.IsKeyDown(Keys.Down) && oldState.IsKeyUp(Keys.Down))
                {
                    selectedIndex++;
                    if (selectedIndex == menuItems.Count)
                    {
                        selectedIndex = 0;
                    }

                }
                if (ks.IsKeyDown(Keys.Up) && oldState.IsKeyUp(Keys.Up))
                {
                    selectedIndex--;
                    if (selectedIndex == -1)
                    {
                        selectedIndex = menuItems.Count - 1;
                    }
                }
            }
            oldState = ks;

            base.Update(gameTime);
        }

        public override void Draw(GameTime gameTime)
        {
            Vector2 tempPos = position;
            Vector2 imgPos;
            int tempInt = 0;
            spriteBatch.Begin();
          
            spriteBatch.Draw(backTex, new Rectangle(0, 0, backTex.Width, backTex.Height), Color.White);
            
            for (int i = 0; i < menuItems.Count; i++)
            {
                if (selectedIndex == i)
                {
                    if (chars.Count > 0)
                    {
                        tempInt += 350;
                        tempPos.X = GraphicsDevice.Viewport.Bounds.Width - tempInt;
                      

                       
                     

                        spriteBatch.DrawString(hilightFont, menuItems[i],
                            tempPos, hilightColor);


                        imgPos.X = GraphicsDevice.Viewport.Bounds.Width / 2 + ((chars[i].Width / 2) / 2);
                        imgPos.Y = tempPos.Y - 50;
                        spriteBatch.Draw(chars[i], imgPos, null, Color.White, 0f, imgPos, 0.5f, SpriteEffects.None, 1f);

                    }
                    else
                    {
                        tempPos.X = (GraphicsDevice.Viewport.Bounds.Width / 2) - hilightFont.MeasureString(menuItems[i]).Length() / 2;

                        spriteBatch.DrawString(hilightFont, menuItems[i],
                            tempPos, hilightColor);
                        tempPos.Y += hilightFont.LineSpacing;
                    
                    }
                   

                  
                    
                }
                else
                {
                    if (chars.Count > 0)
                    {

                        tempInt += 350;
                        tempPos.X = GraphicsDevice.Viewport.Bounds.Width - tempInt;

                        spriteBatch.DrawString(regularFont, menuItems[i],
                            tempPos, regularColor);

                        imgPos.X = GraphicsDevice.Viewport.Bounds.Width / 2 - chars[i].Width / 2; 
                        imgPos.Y = tempPos.Y - 50;


                        spriteBatch.Draw(chars[i], imgPos, null, Color.White, 0f, imgPos, 0f, SpriteEffects.None, 1f);

                    }
                    else
                    {
                        tempPos.X = (GraphicsDevice.Viewport.Bounds.Width / 2) - regularFont.MeasureString(menuItems[i]).Length() / 2;
                        spriteBatch.DrawString(regularFont, menuItems[i],
                            tempPos, regularColor);
                        tempPos.Y += regularFont.LineSpacing;
                    }
                  

                }
            }
            spriteBatch.End();


            base.Draw(gameTime);
        }
    }
}
