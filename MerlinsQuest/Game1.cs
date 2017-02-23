using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using Microsoft.Xna.Framework.Audio;

namespace MerlinsQuest
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        
        
        SpriteBatch spriteBatch;
        private Start startMenu;
        private Story story;
        private Screens.Fight.Fight fight;
        private VictoryScreen victory;


        private About about;
        private HowToPlay howToPlay;
        private Help help;

        private Song song;

        private Song menuSong;
       
        




        

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            
            Content.RootDirectory = "Content";
            graphics.PreferredBackBufferWidth = 1200;
            graphics.PreferredBackBufferHeight = 1000;
            
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
         

            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        /// 
        private void hideAllScenes()
        {
            GameScene gs = null;
            foreach (GameComponent item in this.Components)
            {
                if (item is GameScene)
                {
                    gs = (GameScene)item;
                    gs.hide();
                }
            }
        }
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here


            //scenes

            startMenu = new MerlinsQuest.Start(this, spriteBatch);
            story = new Story(this, spriteBatch);
            fight = new MerlinsQuest.Screens.Fight.Fight(this, spriteBatch);
            victory = new VictoryScreen(this, spriteBatch);

        
            about = new About(this, spriteBatch);
            howToPlay = new HowToPlay(this, spriteBatch);
            help = new Help(this, spriteBatch);


            this.Components.Add(startMenu);
            this.Components.Add(story);
            this.Components.Add(fight);
            this.Components.Add(victory);
            this.Components.Add(about);
            this.Components.Add(howToPlay);
            this.Components.Add(help);

            this.song = Content.Load<Song>("Sound/merlinSong");

            this.menuSong = Content.Load<Song>("Sound/menuSong");

            MediaPlayer.Play(menuSong);
            MediaPlayer.IsRepeating = true;
      
          MediaPlayer.Volume = 0.5f;

            startMenu.show();
            story.hide();
            fight.hide();
            victory.hide();
            about.hide();
            howToPlay.hide();
            help.hide();
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// game-specific content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        /// 

        KeyboardState previous_ks;
        private Screens.Fight.Fight fight2;
        protected override void Update(GameTime gameTime)
        {
            KeyboardState current_ks = Keyboard.GetState();

        
            int selectedIndex = 0;
            if (startMenu.Enabled)
            {
              
                selectedIndex = startMenu.Menu.SelectedIndex;
                if (selectedIndex == 0 && current_ks.IsKeyDown(Keys.Enter) && previous_ks.IsKeyUp(Keys.Enter))
                {
                    startMenu.hide();
                   story.show();
   
          
                }
                if (selectedIndex == 1 && current_ks.IsKeyDown(Keys.Enter) && previous_ks.IsKeyUp(Keys.Enter))
                {
                    startMenu.hide();
                    howToPlay.show();
                }
                if (selectedIndex == 2 && current_ks.IsKeyDown(Keys.Enter) && previous_ks.IsKeyUp(Keys.Enter))
                {
                    startMenu.hide();
                    help.show();
                }
                if (selectedIndex == 3 && current_ks.IsKeyDown(Keys.Enter) && previous_ks.IsKeyUp(Keys.Enter))
                {
                    startMenu.hide();
                    about.show();
                }
                if (selectedIndex == 4 && current_ks.IsKeyDown(Keys.Enter) && previous_ks.IsKeyUp(Keys.Enter))
                {

                    Exit();
                }
                previous_ks = current_ks;
            }
            if(story.Enabled && story.StoryComp.storyOver == true)
           {
               story.hide();
               fight.show();
            
           }
            if(fight.Enabled && fight.gameWon == true)
            {
                fight.hide();
                victory.show();
            }


            if (howToPlay.Enabled && howToPlay.navMenu == true)
            {
                howToPlay.hide();

                startMenu = new Start(this, spriteBatch);
                this.Components.Add(startMenu);
                startMenu.show();

            }

            if (help.Enabled && help.navMenu == true)
            {
                help.hide();

                startMenu = new Start(this, spriteBatch);
                this.Components.Add(startMenu);
                startMenu.show();

            }

            if (about.Enabled && about.navMenu == true)
            {
                about.hide();

                startMenu = new Start(this, spriteBatch);
                this.Components.Add(startMenu);
                startMenu.show();

            }

            if(victory.Enabled && victory.VicComp.navMain == true )
            {
                this.Components.Remove(fight);
                this.Components.Remove(victory);
                hideAllScenes();
                fight = new Screens.Fight.Fight(this, spriteBatch);
                this.Components.Add(fight);
                fight.hide();
                fight.RESTART_GAME = false;

                victory = new VictoryScreen(this, spriteBatch);
                this.Components.Add(victory);
                victory.hide();

                startMenu = new Start(this, spriteBatch);
                this.Components.Add(startMenu);
                startMenu.show();

              
            }

            

            
            if (fight.RESTART_GAME == true)
            {
                this.Components.Remove(fight);
               
                hideAllScenes();
             
                fight = new Screens.Fight.Fight(this, spriteBatch);
                this.Components.Add(fight);
                fight.show();
                fight.RESTART_GAME = false;
                
            }

            if(fight.navMenu == true)
            {
                this.Components.Remove(fight);

                hideAllScenes();

                fight = new Screens.Fight.Fight(this, spriteBatch);
                this.Components.Add(fight);
                fight.hide();
                fight.navMenu = false;

                startMenu = new Start(this, spriteBatch);
                this.Components.Add(startMenu);
                startMenu.show();
            }

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
    }
}
