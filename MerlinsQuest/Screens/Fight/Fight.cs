using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using Microsoft.Xna.Framework.Audio;

namespace MerlinsQuest.Screens.Fight
{
    class Fight : GameScene
    {
        private SpriteBatch spriteBatch;
        private string character;
        Texture2D backTex;
        Platform.Platform platform;
        Stage stage;
        Wizard wizard;
        Goblin goblin;
        Goblin2 goblin2;
        Goblin3 goblin3;
        Goblin4 goblin4;

    
        Dragon dragon;
        Dragon2 dragon2;
        Dragon3 dragon3;

        Platform.ObstacleBrick brick1;
        Platform.ObstacleBrick brick2;
        Platform.ObstacleBrick brick3;
        Platform.ObstacleBrick brick4;
        Platform.ObstacleBrick brick5;
        Platform.ObstacleBrick brick6;
        Platform.ObstacleBrick brick7;
        Platform.ObstacleBrick brick8;
        Platform.ObstacleBrick brick9;
        Platform.ObstacleBrick brick10;
        Platform.ObstacleBrick brick11;
        Platform.ObstacleBrick brick12;

        Texture2D brickTex1;
        Texture2D brickTex2;
        Texture2D brickTex3;
        Texture2D brickTex4;
        Texture2D brickTex5;
        Texture2D brickTex6;
        Texture2D brickTex7;
        Texture2D brickTex8;
        Texture2D brickTex9;
        Texture2D brickTex10;
        Texture2D brickTex11;
        Texture2D brickTex12;

        CollisionDetection collisionDetecter;
        CollisionDetection collisionDetecter2;
        CollisionDetection collisionDetecter3;
        CollisionDetection collisionDetecter4;
        CollisionDetection collisionDetecter5;
        CollisionDetection collisionDetecter6;
        CollisionDetection collisionDetecter7;
        CollisionDetection collisionDetecter8;
        CollisionDetection collisionDetecter9;
        CollisionDetection collisionDetecter10;
        CollisionDetection collisionDetecter11;
        CollisionDetection collisionDetecter12;
        CollisionDetection collisionDetecter13;
        CollisionDetection collisionDetecter14;
        CollisionDetection collisionDetecter15;
        CollisionDetection collisionDetecter16;
        CollisionDetection collisionDetecter17;

        EndObject door;

        public const float STAGE_HEIGHT = 700;

        

        public Fight(Game game,
            SpriteBatch spriteBatch)
            : base(game)
        {
            this.spriteBatch = spriteBatch;


            collisionDetecter = new CollisionDetection(game, spriteBatch);
            this.Components.Add(collisionDetecter);

            collisionDetecter2 = new CollisionDetection(game, spriteBatch);
            this.Components.Add(collisionDetecter2);
            collisionDetecter3= new CollisionDetection(game, spriteBatch);
            this.Components.Add(collisionDetecter3);
            collisionDetecter4 = new CollisionDetection(game, spriteBatch);
            this.Components.Add(collisionDetecter4);

            collisionDetecter5 = new CollisionDetection(game, spriteBatch);
            this.Components.Add(collisionDetecter5);

            collisionDetecter6 = new CollisionDetection(game, spriteBatch);
            this.Components.Add(collisionDetecter6);

            collisionDetecter7 = new CollisionDetection(game, spriteBatch);
            this.Components.Add(collisionDetecter7);

            collisionDetecter8 = new CollisionDetection(game, spriteBatch);
            this.Components.Add(collisionDetecter8);

            collisionDetecter9 = new CollisionDetection(game, spriteBatch);
            this.Components.Add(collisionDetecter9);
           
            collisionDetecter10 = new CollisionDetection(game, spriteBatch);
            this.Components.Add(collisionDetecter10);

            collisionDetecter11 = new CollisionDetection(game, spriteBatch);
            this.Components.Add(collisionDetecter11);

            collisionDetecter12 = new CollisionDetection(game, spriteBatch);
            this.Components.Add(collisionDetecter12);

            collisionDetecter13 = new CollisionDetection(game, spriteBatch);
            this.Components.Add(collisionDetecter13);

            collisionDetecter14 = new CollisionDetection(game, spriteBatch);
            this.Components.Add(collisionDetecter14);

            collisionDetecter15 = new CollisionDetection(game, spriteBatch);
            this.Components.Add(collisionDetecter15);

            collisionDetecter16 = new CollisionDetection(game, spriteBatch);
            this.Components.Add(collisionDetecter16);

            collisionDetecter17 = new CollisionDetection(game, spriteBatch);
            this.Components.Add(collisionDetecter17);

            stage = new Stage(game, spriteBatch);
            this.Components.Add(stage);
            stage.show();

            platform = new Platform.Platform(game, spriteBatch);
            this.Components.Add(platform);
            platform.show();

            door = new EndObject(game, spriteBatch);
            this.Components.Add(door);
            door.hide();

           
            brickTex1 = Game.Content.Load<Texture2D>("images2/Brick");
            brickTex2 = Game.Content.Load<Texture2D>("images2/Brick");
            brickTex3 = Game.Content.Load<Texture2D>("images2/Brick");
            brickTex4 = Game.Content.Load<Texture2D>("images2/Brick");
            brickTex5 = Game.Content.Load<Texture2D>("images2/Brick");
            brickTex6 = Game.Content.Load<Texture2D>("images2/Brick");
            brickTex7 = Game.Content.Load<Texture2D>("images2/Brick");
            brickTex8 = Game.Content.Load<Texture2D>("images2/Brick");
            brickTex9 = Game.Content.Load<Texture2D>("images2/Brick");
            brickTex10 = Game.Content.Load<Texture2D>("images2/Brick");
            brickTex11 = Game.Content.Load<Texture2D>("images2/Brick");
            brickTex12 = Game.Content.Load<Texture2D>("images2/Brick");

            brick1 = new Platform.ObstacleBrick(game, spriteBatch, brickTex1);
            brick2 = new Platform.ObstacleBrick(game, spriteBatch,  brickTex2);
            brick3 = new Platform.ObstacleBrick(game, spriteBatch, brickTex3);
            brick4 = new Platform.ObstacleBrick(game, spriteBatch, brickTex4);
            brick5 = new Platform.ObstacleBrick(game, spriteBatch, brickTex5);
            brick6 = new Platform.ObstacleBrick(game, spriteBatch, brickTex6);
            brick7 = new Platform.ObstacleBrick(game, spriteBatch, brickTex7);
            brick8 = new Platform.ObstacleBrick(game, spriteBatch, brickTex8);
            brick9 = new Platform.ObstacleBrick(game, spriteBatch, brickTex9);
            brick10 = new Platform.ObstacleBrick(game, spriteBatch, brickTex10);
            brick11 = new Platform.ObstacleBrick(game, spriteBatch, brickTex11);
            brick12 = new Platform.ObstacleBrick(game, spriteBatch, brickTex12);

            this.Components.Add(brick1);
            this.Components.Add(brick2);
            this.Components.Add(brick3);
            this.Components.Add(brick4);
            this.Components.Add(brick5);
            this.Components.Add(brick6);
            this.Components.Add(brick7);
            this.Components.Add(brick8);
            this.Components.Add(brick9);
            this.Components.Add(brick10);
            this.Components.Add(brick11);
            this.Components.Add(brick12);

            brick1.hide();
            brick2.hide();
            brick3.hide();
            brick4.hide();
            brick5.hide();
            brick6.hide();
            brick7.hide();
            brick8.hide();
            brick9.hide();
            brick10.hide();
            brick11.hide();
            brick12.hide();

            dragon = new Dragon(game, spriteBatch);
            this.Components.Add(dragon);
            dragon.hide();

            dragon2 = new Dragon2(game, spriteBatch);
            this.Components.Add(dragon2);
            dragon2.hide();

            dragon3 = new Dragon3(game, spriteBatch);
            this.Components.Add(dragon3);
            dragon3.hide();


            goblin = new Goblin(game, spriteBatch);
            this.Components.Add(goblin);
            goblin.show();

            goblin2 = new Goblin2(game, spriteBatch);
            this.Components.Add(goblin2);
            goblin2.hide();

            goblin3 = new Goblin3(game, spriteBatch);
            this.Components.Add(goblin3);
            goblin3.hide();

            goblin4 = new Goblin4(game, spriteBatch);
            this.Components.Add(goblin4);
            goblin4.hide();

            wizard = new Wizard(game, spriteBatch);
            this.Components.Add(wizard);
            wizard.show();
        }

        public bool isMoving = false;

        public override void Initialize()
        {
            base.Initialize();
        }
        int timer = 0;

        float wizPosDiff = 0;

        private int goblinDeathTimer = 0;
        public bool goblinIsDiposed = false;

        private int goblin2DeathTimer = 0;
        public bool goblin2IsDiposed = false;

        private int goblin3DeathTimer = 0;
        public bool goblin3IsDiposed = false;

        private int goblin4DeathTimer = 0;
        public bool goblin4IsDiposed = false;

        float gravity = 0.5f;

        string fallingSpot = "";


        private int dragonTimer = 0;
        public bool dragonIsDisposed = false;

        private int dragon2Timer = 0;
        public bool dragon2IsDisposed = false;

        private int dragon3Timer = 0;
        public bool dragon3IsDisposed = false;

        public bool onBrick1 = false;
        public bool onBrick2 = false;
        public bool onBrick3 = false;
        public bool onBrick4 = false;
        public bool onBrick5 = false;
        public bool onBrick6 = false;
        public bool onBrick7 = false;
        public bool onBrick8 = false;
        public bool onBrick9 = false;
        public bool onBrick10 = false;
        public bool onBrick11 = false;
        public bool onBrick12 = false;

    

        //first number = plat, second number = stage
        //every 2 groups = new falling spot
        //2nd group = max, 1st = min
        int[,] fallSpots = new int[,]{{-450, -448},{-568, -556},{-716, -704},{-808, -796},{-1336, -1324}, {-1962, -1950}, {-2672, -2660},
                                        {-3108 ,-3096}, {-3180, -3168}, {-3216, -3204}, {-3304, -3292}, {-3348, -3336}, {-4392, -4380}, {-4548, -4536}, {-4648, -4636}, {-4744, -4732}, {-4836, -4824}, {-4956, -4944}, {-5592, -5580},
                                        {-5770, -5758}, {-6232, -6220}, {-6712, -6700}, {-7536, -7524}, {-8864, -8852}};

        public bool RESTART_GAME = false;
        public bool falling = false;
 

        bool brick1Drawn = false;
        bool brick2Drawn = false;
        bool brick3Drawn = false;
        bool brick4Drawn = false;
        bool brick5Drawn = false;
        bool brick6Drawn = false;
        bool brick7Drawn = false;
        bool brick8Drawn = false;
        bool brick9Drawn = false;
        bool brick10Drawn = false;
        bool brick11Drawn = false;
        bool brick12Drawn = false;

        public bool gameWon = false;

        bool atSide = false;

        int scoreTimer = 0;

        public bool navMenu = false;

        Vector2 add = new Vector2(100, 0);

        Rectangle obj1Rect;
        Rectangle obj2Rect;
        public override void Update(GameTime gameTime)
        {
  
            atSide = false;
         
            #region falling coordinates

            if (wizard.WizComp.position.Y > platform.PlatComp.platform.Bounds.Top)
            {
                if (fallingSpot == "spot1")
                {


                    if (platform.PlatComp.position.X > fallSpots[0, 0] - wizard.WizComp.currentSprite.Width)
                    {
                        platform.PlatComp.position.X = fallSpots[0, 0] - wizard.WizComp.currentSprite.Width;
                        stage.StageComp.position.X = fallSpots[0, 1] - wizard.WizComp.currentSprite.Width;
                        atSide = true;

                    }
                    if (platform.PlatComp.position.X < fallSpots[1, 0] + wizard.WizComp.currentSprite.Width)
                    {
                        platform.PlatComp.position.X = fallSpots[1, 0] + wizard.WizComp.currentSprite.Width;
                        stage.StageComp.position.X = fallSpots[1, 1] + wizard.WizComp.currentSprite.Width;
                        atSide = true;
                    }

                }
                if (fallingSpot == "spot2")
                {

                    if (platform.PlatComp.position.X > fallSpots[2, 0] - wizard.WizComp.currentSprite.Width)
                    {
                        platform.PlatComp.position.X = fallSpots[2, 0] - wizard.WizComp.currentSprite.Width;
                        stage.StageComp.position.X = fallSpots[2, 1] - wizard.WizComp.currentSprite.Width;
                        atSide = true;

                    }
                    if (platform.PlatComp.position.X < fallSpots[3, 0] + wizard.WizComp.currentSprite.Width)
                    {
                        platform.PlatComp.position.X = fallSpots[3, 0] + wizard.WizComp.currentSprite.Width;
                        stage.StageComp.position.X = fallSpots[3, 1] + wizard.WizComp.currentSprite.Width;
                        atSide = true;
                    }
                }
                if (fallingSpot == "spot3")
                {

                    if (platform.PlatComp.position.X > fallSpots[4, 0] - wizard.WizComp.currentSprite.Width)
                    {
                        platform.PlatComp.position.X = fallSpots[4, 0] - wizard.WizComp.currentSprite.Width;
                        stage.StageComp.position.X = fallSpots[4, 1] - wizard.WizComp.currentSprite.Width;
                        atSide = true;

                    }
                    if (platform.PlatComp.position.X < fallSpots[5, 0] + wizard.WizComp.currentSprite.Width)
                    {
                        platform.PlatComp.position.X = fallSpots[5, 0] + wizard.WizComp.currentSprite.Width;
                        stage.StageComp.position.X = fallSpots[5, 1] + wizard.WizComp.currentSprite.Width;
                        atSide = true;
                    }
                }
                if (fallingSpot == "spot4")
                {
                    if (platform.PlatComp.position.X > fallSpots[6, 0] - wizard.WizComp.currentSprite.Width)
                    {
                        platform.PlatComp.position.X = fallSpots[6, 0] - wizard.WizComp.currentSprite.Width;
                        stage.StageComp.position.X = fallSpots[6, 1] - wizard.WizComp.currentSprite.Width;
                        atSide = true;

                    }
                    if (platform.PlatComp.position.X < fallSpots[7, 0] + wizard.WizComp.currentSprite.Width)
                    {

                        platform.PlatComp.position.X = fallSpots[7, 0] + wizard.WizComp.currentSprite.Width;
                        stage.StageComp.position.X = fallSpots[7, 1] + wizard.WizComp.currentSprite.Width;
                        atSide = true;
                    }
                }
                if (fallingSpot == "spot5")
                {

                    if (platform.PlatComp.position.X > fallSpots[8, 0] - wizard.WizComp.currentSprite.Width)
                    {
                        platform.PlatComp.position.X = fallSpots[8, 0] - wizard.WizComp.currentSprite.Width;
                        stage.StageComp.position.X = fallSpots[8, 1] - wizard.WizComp.currentSprite.Width;
                        atSide = true;

                    }
                    if (platform.PlatComp.position.X < fallSpots[9, 0] + wizard.WizComp.currentSprite.Width)
                    {
                        platform.PlatComp.position.X = fallSpots[9, 0] + wizard.WizComp.currentSprite.Width;
                        stage.StageComp.position.X = fallSpots[9, 1] + wizard.WizComp.currentSprite.Width;
                        atSide = true;
                    }
                }
                if (fallingSpot == "spot6")
                {

                    if (platform.PlatComp.position.X > fallSpots[10, 0] - wizard.WizComp.currentSprite.Width)
                    {
                        platform.PlatComp.position.X = fallSpots[10, 0] - wizard.WizComp.currentSprite.Width;
                        stage.StageComp.position.X = fallSpots[10, 1] - wizard.WizComp.currentSprite.Width;
                        atSide = true;
                    }
                    if (platform.PlatComp.position.X < fallSpots[11, 0] + wizard.WizComp.currentSprite.Width)
                    {
                        platform.PlatComp.position.X = fallSpots[11, 0] + wizard.WizComp.currentSprite.Width;
                        stage.StageComp.position.X = fallSpots[11, 1] + wizard.WizComp.currentSprite.Width;
                        atSide = true;
                    }
                }
                if (fallingSpot == "spot7")
                {

                    if (platform.PlatComp.position.X > fallSpots[12, 0] - wizard.WizComp.currentSprite.Width)
                    {
                        platform.PlatComp.position.X = fallSpots[12, 0] - wizard.WizComp.currentSprite.Width;
                        stage.StageComp.position.X = fallSpots[12, 1] - wizard.WizComp.currentSprite.Width;
                        atSide = true;

                    }
                    if (platform.PlatComp.position.X < fallSpots[13, 0] + wizard.WizComp.currentSprite.Width)
                    {
                        platform.PlatComp.position.X = fallSpots[13, 0] + wizard.WizComp.currentSprite.Width;
                        stage.StageComp.position.X = fallSpots[13, 1] + wizard.WizComp.currentSprite.Width;
                        atSide = true;
                    }
                }
                if (fallingSpot == "spot8")
                {

                    if (platform.PlatComp.position.X > fallSpots[14, 0] - wizard.WizComp.currentSprite.Width)
                    {
                        platform.PlatComp.position.X = fallSpots[14, 0] - wizard.WizComp.currentSprite.Width;
                        stage.StageComp.position.X = fallSpots[14, 1] - wizard.WizComp.currentSprite.Width;
                        atSide = true;

                    }
                    if (platform.PlatComp.position.X < fallSpots[15, 0] + wizard.WizComp.currentSprite.Width)
                    {
                        platform.PlatComp.position.X = fallSpots[15, 0] + wizard.WizComp.currentSprite.Width;
                        stage.StageComp.position.X = fallSpots[15, 1] + wizard.WizComp.currentSprite.Width;
                        atSide = true;
                    }
                }
                if (fallingSpot == "spot9")
                {

                    if (platform.PlatComp.position.X > fallSpots[16, 0] - wizard.WizComp.currentSprite.Width)
                    {
                        platform.PlatComp.position.X = fallSpots[16, 0] - wizard.WizComp.currentSprite.Width;
                        stage.StageComp.position.X = fallSpots[16, 1] - wizard.WizComp.currentSprite.Width;
                        atSide = true;

                    }
                    if (platform.PlatComp.position.X < fallSpots[17, 0] + wizard.WizComp.currentSprite.Width)
                    {
                        platform.PlatComp.position.X = fallSpots[17, 0] + wizard.WizComp.currentSprite.Width;
                        stage.StageComp.position.X = fallSpots[17, 1] + wizard.WizComp.currentSprite.Width;
                        atSide = true;
                    }
                }
                if (fallingSpot == "spot10")
                {

                    if (platform.PlatComp.position.X > fallSpots[18, 0] - wizard.WizComp.currentSprite.Width)
                    {
                        platform.PlatComp.position.X = fallSpots[18, 0] - wizard.WizComp.currentSprite.Width;
                        stage.StageComp.position.X = fallSpots[18, 1] - wizard.WizComp.currentSprite.Width;
                        atSide = true;

                    }
                    if (platform.PlatComp.position.X < fallSpots[19, 0] + wizard.WizComp.currentSprite.Width)
                    {
                        platform.PlatComp.position.X = fallSpots[19, 0] + wizard.WizComp.currentSprite.Width;
                        stage.StageComp.position.X = fallSpots[19, 1] + wizard.WizComp.currentSprite.Width;
                        atSide = true;
                    }
                }
                if (fallingSpot == "spot11")
                {

                    if (platform.PlatComp.position.X > fallSpots[20, 0] - wizard.WizComp.currentSprite.Width)
                    {
                        platform.PlatComp.position.X = fallSpots[20, 0] - wizard.WizComp.currentSprite.Width;
                        stage.StageComp.position.X = fallSpots[20, 1] - wizard.WizComp.currentSprite.Width;
                        atSide = true;
                    }
                    if (platform.PlatComp.position.X < fallSpots[21, 0] + wizard.WizComp.currentSprite.Width)
                    {
                        platform.PlatComp.position.X = fallSpots[21, 0] + wizard.WizComp.currentSprite.Width;
                        stage.StageComp.position.X = fallSpots[21, 1] + wizard.WizComp.currentSprite.Width;
                        atSide = true;
                    }
                }
                if (fallingSpot == "spot12")
                {

                    if (platform.PlatComp.position.X > fallSpots[22, 0] - wizard.WizComp.currentSprite.Width)
                    {
                        platform.PlatComp.position.X = fallSpots[22, 0] - wizard.WizComp.currentSprite.Width;
                        stage.StageComp.position.X = fallSpots[22, 1] - wizard.WizComp.currentSprite.Width;
                        atSide = true;

                    }
                    if (platform.PlatComp.position.X < fallSpots[23, 0] + wizard.WizComp.currentSprite.Width)
                    {
                        platform.PlatComp.position.X = fallSpots[23, 0] + wizard.WizComp.currentSprite.Width;
                        stage.StageComp.position.X = fallSpots[23, 1] + wizard.WizComp.currentSprite.Width;
                        atSide = true;
                    }
                }

            }


            #endregion

            timer++;
            if(timer > 300)
            {
                goblin2.show();
               
            }

            if(timer > 2000)
            {
                goblin3.show();
            }

      

            if(timer > 3500)
            {
                goblin4.show();
            }

           
            obj1Rect = new Rectangle((int)brick1.ObstComp.position.X, (int)brick1.ObstComp.position.Y, brickTex1.Width, brickTex1.Height);
            obj2Rect = new Rectangle((int)wizard.WizComp.position.X, (int)wizard.WizComp.position.Y, wizard.WizComp.currentSprite.Width, wizard.WizComp.currentSprite.Height);

            




          
                #region bricks

            #region brick1

            if (onBrick1 == true)
            {

                wizard.WizComp.falling2 = false;
                if (wizard.WizComp.Position.Y + 50 < brick1.ObstComp.position.Y  && wizard.WizComp.initalJump == false)
                {
                    wizard.WizComp.position.Y = brick1.ObstComp.position.Y - wizard.WizComp.currentSprite.Height - brick1.ObstComp.obstacle.Height;
                    onBrick1 = false;
                 
                }
               

                    if (!collisionDetecter7.CollidedBrick(brickTex1, wizard.WizComp.currentSprite,
                        brick1.ObstComp.position, wizard.WizComp.position, wizard.WizComp.initalJump))
                    {

                        onBrick1 = false;
                  

                    }
                  
                    
                       
                 
              

            }
          

            if (onBrick1 == false && wizard.WizComp.initalJump == false )
            {
                
                   
              
               
                    if (collisionDetecter7.CollidedBrick(brickTex1, wizard.WizComp.currentSprite,
                        brick1.ObstComp.position, wizard.WizComp.position, wizard.WizComp.initalJump))
                    {
                       
                        onBrick1 = true;
                        wizard.WizComp.falling = false;
                        wizard.WizComp.jump = false;

                    }
                  

               
                if (brick1Drawn == false)
                {
                    if (stage.StageComp.position.X < -800)
                    {

                        brick1.ObstComp.position.X = wizard.WizComp.position.X + 615;
                        brick1.ObstComp.position.Y = 600;
                        brick1.show();
                        brick1Drawn = true;

                    }
                }
                else
                {
                    if (isMoving == true && atSide == false )
                    {
                        if (wizard.WizComp.MainSpriteEffect == SpriteEffects.None)
                        {
                            brick1.ObstComp.position.X += wizPosDiff ;
                        }
                        else
                        {
                            brick1.ObstComp.position.X -= wizPosDiff;
                        }
                    }
              
                }
            }
            else
            {


             
              
                if (isMoving == true)
                {
                    if (wizard.WizComp.MainSpriteEffect == SpriteEffects.None)
                    {
                        brick1.ObstComp.position.X += wizPosDiff;
                    }
                    else
                    {
                        brick1.ObstComp.position.X -= wizPosDiff;
                    }
                }
                

            }
            #endregion
            #region brick2
            if (onBrick2 == true)
            {

                wizard.WizComp.falling2 = false;
                if (wizard.WizComp.Position.Y + 50 < brick2.ObstComp.position.Y && wizard.WizComp.initalJump == false)
                {
                    wizard.WizComp.position.Y = brick2.ObstComp.position.Y - wizard.WizComp.currentSprite.Height - brick2.ObstComp.obstacle.Height;
                    onBrick2 = false;

                }


                if (!collisionDetecter7.CollidedBrick(brickTex2, wizard.WizComp.currentSprite,
                    brick2.ObstComp.position, wizard.WizComp.position, wizard.WizComp.initalJump))
                {

                    onBrick2 = false;
            

                }






            }


            if (onBrick2 == false && wizard.WizComp.initalJump == false)
            {




                if (collisionDetecter7.CollidedBrick(brickTex2, wizard.WizComp.currentSprite,
                    brick2.ObstComp.position, wizard.WizComp.position, wizard.WizComp.initalJump))
                {

                    onBrick2 = true;
                    wizard.WizComp.falling = false;
                    wizard.WizComp.jump = false;

                }



                if (brick2Drawn == false)
                {
                    if (stage.StageComp.position.X < -1000)
                    {

                        brick2.ObstComp.position.X = wizard.WizComp.position.X + 615;
                        brick2.ObstComp.position.Y = 600;
                        brick2.show();
                        brick2Drawn = true;

                    }
                }
                else
                {
                    if (isMoving == true && atSide == false)
                    {
                        if (wizard.WizComp.MainSpriteEffect == SpriteEffects.None)
                        {
                            brick2.ObstComp.position.X += wizPosDiff;
                        }
                        else
                        {
                            brick2.ObstComp.position.X -= wizPosDiff;
                        }
                    }

                }
            }
            else
            {




                if (isMoving == true)
                {
                    if (wizard.WizComp.MainSpriteEffect == SpriteEffects.None)
                    {
                        brick2.ObstComp.position.X += wizPosDiff;
                    }
                    else
                    {
                        brick2.ObstComp.position.X -= wizPosDiff;
                    }
                }


            }
            #endregion

            #region brick3
            if (onBrick3 == true)
            {
                wizard.WizComp.falling2 = false;

                if (wizard.WizComp.Position.Y + 50 < brick3.ObstComp.position.Y  && wizard.WizComp.initalJump == false)
                {
                    wizard.WizComp.position.Y = brick3.ObstComp.position.Y - wizard.WizComp.currentSprite.Height - brick3.ObstComp.obstacle.Height;
                    onBrick3 = false;
                    
                }


                if (!collisionDetecter7.CollidedBrick(brickTex3, wizard.WizComp.currentSprite,
                    brick3.ObstComp.position, wizard.WizComp.position, wizard.WizComp.initalJump))
                {

                    onBrick3 = false;
                
                }






            }


            if (onBrick3 == false && wizard.WizComp.initalJump == false)
            {




                if (collisionDetecter7.CollidedBrick(brickTex3, wizard.WizComp.currentSprite,
                    brick3.ObstComp.position, wizard.WizComp.position, wizard.WizComp.initalJump))
                {

                    onBrick3 = true;
                    wizard.WizComp.falling = false;
                    wizard.WizComp.jump = false;

                }



                if (brick3Drawn == false)
                {
                    if (stage.StageComp.position.X < -1200)
                    {

                        brick3.ObstComp.position.X = wizard.WizComp.position.X + 615;
                        brick3.ObstComp.position.Y = 600;
                        brick3.show();
                        brick3Drawn = true;

                    }
                }
                else
                {
                    if (isMoving == true && atSide == false)
                    {
                        if (wizard.WizComp.MainSpriteEffect == SpriteEffects.None)
                        {
                            brick3.ObstComp.position.X += wizPosDiff;
                        }
                        else
                        {
                            brick3.ObstComp.position.X -= wizPosDiff;
                        }
                    }

                }
            }
            else
            {




                if (isMoving == true)
                {
                    if (wizard.WizComp.MainSpriteEffect == SpriteEffects.None)
                    {
                        brick3.ObstComp.position.X += wizPosDiff;
                    }
                    else
                    {
                        brick3.ObstComp.position.X -= wizPosDiff;
                    }
                }


            }
            #endregion

            #region brick4
            if (onBrick4 == true)
            {
                wizard.WizComp.falling2 = false;

                if (wizard.WizComp.Position.Y + 50 < brick4.ObstComp.position.Y && onBrick4 && wizard.WizComp.initalJump == false)
                {
                    wizard.WizComp.position.Y = brick4.ObstComp.position.Y - wizard.WizComp.currentSprite.Height - brick4.ObstComp.obstacle.Height;
                    onBrick4 = false;
                }


                if (!collisionDetecter7.CollidedBrick(brickTex4, wizard.WizComp.currentSprite,
                    brick4.ObstComp.position, wizard.WizComp.position, wizard.WizComp.initalJump))
                {

                    onBrick4 = false;
                 

                }






            }


            if (onBrick4 == false && wizard.WizComp.initalJump == false)
            {




                if (collisionDetecter7.CollidedBrick(brickTex4, wizard.WizComp.currentSprite,
                    brick4.ObstComp.position, wizard.WizComp.position, wizard.WizComp.initalJump))
                {

                    onBrick4 = true;
                    wizard.WizComp.falling = false;
                    wizard.WizComp.jump = false;

                }



                if (brick4Drawn == false)
                {
                    if (stage.StageComp.position.X < -2200)
                    {

                        brick4.ObstComp.position.X = wizard.WizComp.position.X + 615;
                        brick4.ObstComp.position.Y = 600;
                        brick4.show();
                        brick4Drawn = true;

                    }
                }
                else
                {
                    if (isMoving == true && atSide == false)
                    {
                        if (wizard.WizComp.MainSpriteEffect == SpriteEffects.None)
                        {
                            brick4.ObstComp.position.X += wizPosDiff;
                        }
                        else
                        {
                            brick4.ObstComp.position.X -= wizPosDiff;
                        }
                    }

                }
            }
            else
            {




                if (isMoving == true)
                {
                    if (wizard.WizComp.MainSpriteEffect == SpriteEffects.None)
                    {
                        brick4.ObstComp.position.X += wizPosDiff;
                    }
                    else
                    {
                        brick4.ObstComp.position.X -= wizPosDiff;
                    }
                }


            }
            #endregion

            #region brick5
            if (onBrick5 == true)
            {

                wizard.WizComp.falling2 = false;
                if (wizard.WizComp.Position.Y + 50 < brick5.ObstComp.position.Y && onBrick5 && wizard.WizComp.initalJump == false)
                {
                    wizard.WizComp.position.Y = brick5.ObstComp.position.Y - wizard.WizComp.currentSprite.Height - brick5.ObstComp.obstacle.Height;
                    onBrick5 = false;
                }


                if (!collisionDetecter7.CollidedBrick(brickTex5, wizard.WizComp.currentSprite,
                    brick5.ObstComp.position, wizard.WizComp.position, wizard.WizComp.initalJump))
                {

                    onBrick5 = false;
               

                }






            }


            if (onBrick5 == false && wizard.WizComp.initalJump == false)
            {




                if (collisionDetecter7.CollidedBrick(brickTex5, wizard.WizComp.currentSprite,
                    brick5.ObstComp.position, wizard.WizComp.position, wizard.WizComp.initalJump))
                {

                    onBrick5 = true;
                    wizard.WizComp.falling = false;
                    wizard.WizComp.jump = false;

                }



                if (brick5Drawn == false)
                {
                    if (stage.StageComp.position.X < -5700)
                    {

                        brick5.ObstComp.position.X = wizard.WizComp.position.X + 615;
                        brick5.ObstComp.position.Y = 600;
                        brick5.show();
                        brick5Drawn = true;

                    }
                }
                else
                {
                    if (isMoving == true && atSide == false)
                    {
                        if (wizard.WizComp.MainSpriteEffect == SpriteEffects.None)
                        {
                            brick5.ObstComp.position.X += wizPosDiff;
                        }
                        else
                        {
                            brick5.ObstComp.position.X -= wizPosDiff;
                        }
                    }

                }
            }
            else
            {




                if (isMoving == true)
                {
                    if (wizard.WizComp.MainSpriteEffect == SpriteEffects.None)
                    {
                        brick5.ObstComp.position.X += wizPosDiff;
                    }
                    else
                    {
                        brick5.ObstComp.position.X -= wizPosDiff;
                    }
                }


            }
            #endregion

            #region brick6
            if (onBrick6 == true)
            {

                wizard.WizComp.falling2 = false;
                if (wizard.WizComp.Position.Y + 50 < brick6.ObstComp.position.Y && onBrick6 && wizard.WizComp.initalJump == false)
                {
                    wizard.WizComp.position.Y = brick6.ObstComp.position.Y - wizard.WizComp.currentSprite.Height - brick6.ObstComp.obstacle.Height;
                    onBrick6 = false;
                }


                if (!collisionDetecter7.CollidedBrick(brickTex6, wizard.WizComp.currentSprite,
                    brick6.ObstComp.position, wizard.WizComp.position, wizard.WizComp.initalJump))
                {

                    onBrick6 = false;
                

                }






            }


            if (onBrick6 == false && wizard.WizComp.initalJump == false)
            {




                if (collisionDetecter7.CollidedBrick(brickTex6, wizard.WizComp.currentSprite,
                    brick6.ObstComp.position, wizard.WizComp.position, wizard.WizComp.initalJump))
                {

                    onBrick6 = true;
                    wizard.WizComp.falling = false;
                    wizard.WizComp.jump = false;

                }



                if (brick6Drawn == false)
                {
                    if (stage.StageComp.position.X < -5900)
                    {

                        brick6.ObstComp.position.X = wizard.WizComp.position.X + 615;
                        brick6.ObstComp.position.Y = 500;
                        brick6.show();
                        brick6Drawn = true;

                    }
                }
                else
                {
                    if (isMoving == true && atSide == false)
                    {
                        if (wizard.WizComp.MainSpriteEffect == SpriteEffects.None)
                        {
                            brick6.ObstComp.position.X += wizPosDiff;
                        }
                        else
                        {
                            brick6.ObstComp.position.X -= wizPosDiff;
                        }
                    }

                }
            }
            else
            {




                if (isMoving == true)
                {
                    if (wizard.WizComp.MainSpriteEffect == SpriteEffects.None)
                    {
                        brick6.ObstComp.position.X += wizPosDiff;
                    }
                    else
                    {
                        brick6.ObstComp.position.X -= wizPosDiff;
                    }
                }


            }
            #endregion

            #region brick7
            if (onBrick7 == true)
            {

                wizard.WizComp.falling2 = false;
                if (wizard.WizComp.Position.Y + 50 < brick7.ObstComp.position.Y  && wizard.WizComp.initalJump == false)
                {
                    wizard.WizComp.position.Y = brick7.ObstComp.position.Y - wizard.WizComp.currentSprite.Height - brick7.ObstComp.obstacle.Height;
                    onBrick7 = false;
                }


                if (!collisionDetecter7.CollidedBrick(brickTex7, wizard.WizComp.currentSprite,
                    brick7.ObstComp.position, wizard.WizComp.position, wizard.WizComp.initalJump))
                {

                    onBrick7 = false;
                

                }






            }


            if (onBrick7 == false && wizard.WizComp.initalJump == false)
            {




                if (collisionDetecter7.CollidedBrick(brickTex7, wizard.WizComp.currentSprite,
                    brick7.ObstComp.position, wizard.WizComp.position, wizard.WizComp.initalJump))
                {

                    onBrick7 = true;
                    wizard.WizComp.falling = false;
                    wizard.WizComp.jump = false;

                }



                if (brick7Drawn == false)
                {
                    if (stage.StageComp.position.X < -7000)
                    {

                        brick7.ObstComp.position.X = wizard.WizComp.position.X + 615;
                        brick7.ObstComp.position.Y = 600;
                        brick7.show();
                        brick7Drawn = true;

                    }
                }
                else
                {
                    if (isMoving == true && atSide == false)
                    {
                        if (wizard.WizComp.MainSpriteEffect == SpriteEffects.None)
                        {
                            brick7.ObstComp.position.X += wizPosDiff;
                        }
                        else
                        {
                            brick7.ObstComp.position.X -= wizPosDiff;
                        }
                    }

                }
            }
            else
            {




                if (isMoving == true)
                {
                    if (wizard.WizComp.MainSpriteEffect == SpriteEffects.None)
                    {
                        brick7.ObstComp.position.X += wizPosDiff;
                    }
                    else
                    {
                        brick7.ObstComp.position.X -= wizPosDiff;
                    }
                }


            }
            #endregion

            #region brick8
            if (onBrick8 == true)
            {

                wizard.WizComp.falling2 = false;
                if (wizard.WizComp.Position.Y + 50 < brick8.ObstComp.position.Y && onBrick8 && wizard.WizComp.initalJump == false)
                {
                    wizard.WizComp.position.Y = brick8.ObstComp.position.Y - wizard.WizComp.currentSprite.Height - brick8.ObstComp.obstacle.Height;
                    onBrick8 = false;
                }


                if (!collisionDetecter7.CollidedBrick(brickTex8, wizard.WizComp.currentSprite,
                    brick8.ObstComp.position, wizard.WizComp.position, wizard.WizComp.initalJump))
                {

                    onBrick8 = false;
                

                }






            }


            if (onBrick8 == false && wizard.WizComp.initalJump == false)
            {




                if (collisionDetecter7.CollidedBrick(brickTex8, wizard.WizComp.currentSprite,
                    brick8.ObstComp.position, wizard.WizComp.position, wizard.WizComp.initalJump))
                {

                    onBrick8 = true;
                    wizard.WizComp.falling = false;
                    wizard.WizComp.jump = false;

                }



                if (brick8Drawn == false)
                {
                    if (stage.StageComp.position.X < -7200)
                    {

                        brick8.ObstComp.position.X = wizard.WizComp.position.X + 615;
                        brick8.ObstComp.position.Y = 500;
                        brick8.show();
                        brick8Drawn = true;

                    }
                }
                else
                {
                    if (isMoving == true && atSide == false)
                    {
                        if (wizard.WizComp.MainSpriteEffect == SpriteEffects.None)
                        {
                            brick8.ObstComp.position.X += wizPosDiff;
                        }
                        else
                        {
                            brick8.ObstComp.position.X -= wizPosDiff;
                        }
                    }

                }
            }
            else
            {




                if (isMoving == true)
                {
                    if (wizard.WizComp.MainSpriteEffect == SpriteEffects.None)
                    {
                        brick8.ObstComp.position.X += wizPosDiff;
                    }
                    else
                    {
                        brick8.ObstComp.position.X -= wizPosDiff;
                    }
                }


            }
            #endregion

            #region brick9
            if (onBrick9 == true)
            {

                wizard.WizComp.falling2 = false;
                if (wizard.WizComp.Position.Y + 50 < brick9.ObstComp.position.Y && onBrick9 && wizard.WizComp.initalJump == false)
                {
                    wizard.WizComp.position.Y = brick9.ObstComp.position.Y - wizard.WizComp.currentSprite.Height - brick9.ObstComp.obstacle.Height;
                    onBrick9 = false;
                }


                if (!collisionDetecter7.CollidedBrick(brickTex9, wizard.WizComp.currentSprite,
                    brick9.ObstComp.position, wizard.WizComp.position, wizard.WizComp.initalJump))
                {

                    onBrick9 = false;
                

                }






            }


            if (onBrick9 == false && wizard.WizComp.initalJump == false)
            {




                if (collisionDetecter7.CollidedBrick(brickTex9, wizard.WizComp.currentSprite,
                    brick9.ObstComp.position, wizard.WizComp.position, wizard.WizComp.initalJump))
                {

                    onBrick9 = true;
                    wizard.WizComp.falling = false;
                    wizard.WizComp.jump = false;

                }



                if (brick9Drawn == false)
                {
                    if (stage.StageComp.position.X < -7400)
                    {

                        brick9.ObstComp.position.X = wizard.WizComp.position.X + 615;
                        brick9.ObstComp.position.Y = 400;
                        brick9.show();
                        brick9Drawn = true;

                    }
                }
                else
                {
                    if (isMoving == true && atSide == false)
                    {
                        if (wizard.WizComp.MainSpriteEffect == SpriteEffects.None)
                        {
                            brick9.ObstComp.position.X += wizPosDiff;
                        }
                        else
                        {
                            brick9.ObstComp.position.X -= wizPosDiff;
                        }
                    }

                }
            }
            else
            {




                if (isMoving == true)
                {
                    if (wizard.WizComp.MainSpriteEffect == SpriteEffects.None)
                    {
                        brick9.ObstComp.position.X += wizPosDiff;
                    }
                    else
                    {
                        brick9.ObstComp.position.X -= wizPosDiff;
                    }
                }


            }
            #endregion

            #region brick10
            if (onBrick10 == true)
            {

                wizard.WizComp.falling2 = false;
                if (wizard.WizComp.Position.Y + 50 < brick10.ObstComp.position.Y && onBrick10 && wizard.WizComp.initalJump == false)
                {
                    wizard.WizComp.position.Y = brick10.ObstComp.position.Y - wizard.WizComp.currentSprite.Height - brick10.ObstComp.obstacle.Height;
                    onBrick10 = false;
                }


                if (!collisionDetecter7.CollidedBrick(brickTex10, wizard.WizComp.currentSprite,
                    brick10.ObstComp.position, wizard.WizComp.position, wizard.WizComp.initalJump))
                {

                    onBrick10 = false;


                }






            }


            if (onBrick10 == false && wizard.WizComp.initalJump == false)
            {




                if (collisionDetecter7.CollidedBrick(brickTex10, wizard.WizComp.currentSprite,
                    brick10.ObstComp.position, wizard.WizComp.position, wizard.WizComp.initalJump))
                {

                    onBrick10 = true;
                    wizard.WizComp.falling = false;
                    wizard.WizComp.jump = false;

                }



                if (brick10Drawn == false)
                {
                    if (stage.StageComp.position.X < -7600)
                    {

                        brick10.ObstComp.position.X = wizard.WizComp.position.X + 615;
                        brick10.ObstComp.position.Y = 300;
                        brick10.show();
                        brick10Drawn = true;

                    }
                }
                else
                {
                    if (isMoving == true && atSide == false)
                    {
                        if (wizard.WizComp.MainSpriteEffect == SpriteEffects.None)
                        {
                            brick10.ObstComp.position.X += wizPosDiff;
                        }
                        else
                        {
                            brick10.ObstComp.position.X -= wizPosDiff;
                        }
                    }

                }
            }
            else
            {




                if (isMoving == true)
                {
                    if (wizard.WizComp.MainSpriteEffect == SpriteEffects.None)
                    {
                        brick10.ObstComp.position.X += wizPosDiff;
                    }
                    else
                    {
                        brick10.ObstComp.position.X -= wizPosDiff;
                    }
                }


            }
            #endregion

            #region brick11
            if (onBrick11 == true)
            {

                wizard.WizComp.falling2 = false;
                if (wizard.WizComp.Position.Y + 50 < brick11.ObstComp.position.Y && onBrick11 && wizard.WizComp.initalJump == false)
                {
                    wizard.WizComp.position.Y = brick11.ObstComp.position.Y - wizard.WizComp.currentSprite.Height - brick11.ObstComp.obstacle.Height;
                    onBrick11 = false;
                }


                if (!collisionDetecter7.CollidedBrick(brickTex11, wizard.WizComp.currentSprite,
                    brick11.ObstComp.position, wizard.WizComp.position, wizard.WizComp.initalJump))
                {

                    onBrick11 = false;


                }






            }


            if (onBrick11 == false && wizard.WizComp.initalJump == false)
            {




                if (collisionDetecter7.CollidedBrick(brickTex11, wizard.WizComp.currentSprite,
                    brick11.ObstComp.position, wizard.WizComp.position, wizard.WizComp.initalJump))
                {

                    onBrick11 = true;
                    wizard.WizComp.falling = false;
                    wizard.WizComp.jump = false;

                }



                if (brick11Drawn == false)
                {
                    if (stage.StageComp.position.X < -7800)
                    {

                        brick11.ObstComp.position.X = wizard.WizComp.position.X + 615;
                        brick11.ObstComp.position.Y = 400;
                        brick11.show();
                        brick11Drawn = true;

                    }
                }
                else
                {
                    if (isMoving == true && atSide == false)
                    {
                        if (wizard.WizComp.MainSpriteEffect == SpriteEffects.None)
                        {
                            brick11.ObstComp.position.X += wizPosDiff;
                        }
                        else
                        {
                            brick11.ObstComp.position.X -= wizPosDiff;
                        }
                    }

                }
            }
            else
            {




                if (isMoving == true)
                {
                    if (wizard.WizComp.MainSpriteEffect == SpriteEffects.None)
                    {
                        brick11.ObstComp.position.X += wizPosDiff;
                    }
                    else
                    {
                        brick11.ObstComp.position.X -= wizPosDiff;
                    }
                }


            }
            #endregion

            #region brick12
            if (onBrick12 == true)
            {

                wizard.WizComp.falling2 = false;
                if (wizard.WizComp.Position.Y + 50 < brick12.ObstComp.position.Y && onBrick12 && wizard.WizComp.initalJump == false)
                {
                    wizard.WizComp.position.Y = brick12.ObstComp.position.Y - wizard.WizComp.currentSprite.Height - brick12.ObstComp.obstacle.Height;
                    onBrick12 = false;
                }


                if (!collisionDetecter7.CollidedBrick(brickTex12, wizard.WizComp.currentSprite,
                    brick12.ObstComp.position, wizard.WizComp.position, wizard.WizComp.initalJump))
                {

                    onBrick12 = false;


                }






            }


            if (onBrick12 == false && wizard.WizComp.initalJump == false)
            {




                if (collisionDetecter7.CollidedBrick(brickTex12, wizard.WizComp.currentSprite,
                    brick12.ObstComp.position, wizard.WizComp.position, wizard.WizComp.initalJump))
                {

                    onBrick12 = true;
                    wizard.WizComp.falling = false;
                    wizard.WizComp.jump = false;

                }



                if (brick12Drawn == false)
                {
                    if (stage.StageComp.position.X < -8000)
                    {

                        brick12.ObstComp.position.X = wizard.WizComp.position.X + 615;
                        brick12.ObstComp.position.Y = 500;
                        brick12.show();
                        brick12Drawn = true;

                    }
                }
                else
                {
                    if (isMoving == true && atSide == false)
                    {
                        if (wizard.WizComp.MainSpriteEffect == SpriteEffects.None)
                        {
                            brick12.ObstComp.position.X += wizPosDiff;
                        }
                        else
                        {
                            brick12.ObstComp.position.X -= wizPosDiff;
                        }
                    }

                }
            }
            else
            {




                if (isMoving == true)
                {
                    if (wizard.WizComp.MainSpriteEffect == SpriteEffects.None)
                    {
                        brick12.ObstComp.position.X += wizPosDiff;
                    }
                    else
                    {
                        brick12.ObstComp.position.X -= wizPosDiff;
                    }
                }


            }
            #endregion

                #endregion


            #region dragon logic

            if (stage.StageComp.position.X < -600)
            {
                dragon.show();
            }

          
           
            if(isMoving == true && wizard.WizComp.falling == false)
            {
     
                if (wizard.WizComp.MainSpriteEffect == SpriteEffects.None)
                {
                    dragon.DragonComp.velocityX = 5 - wizPosDiff;
                    dragon.DragonComp.firePos.X += wizPosDiff;
                }
                else
                {
                    dragon.DragonComp.velocityX = 5 + wizPosDiff;
                    dragon.DragonComp.firePos.X -= wizPosDiff;
                }
       
            }
            else
            {
                if (wizard.WizComp.MainSpriteEffect == SpriteEffects.None)
                {
                    dragon.DragonComp.velocityX = 5;
                }
                else
                {
                    dragon.DragonComp.velocityX = 5;
                }
            }
         

            if (dragonIsDisposed == true)
            {
                dragonTimer++;
            }

            if (dragonTimer > 250)
            {

                dragon.show();

                dragonIsDisposed = false;
                dragon.DragonComp.isDisposed = false;
                dragon.DragonComp.dragonHit = false;
               
                dragonTimer = 0;
                dragon.DragonComp.position.X = wizard.WizComp.Position.X + 600;
                dragon.DragonComp.position.Y = 400;
             
            }

            if (dragon.DragonComp.position.Y > GraphicsDevice.Viewport.Bounds.Height)
            {
                dragon.hide();
                dragonIsDisposed = true;
                dragon.DragonComp.isDisposed = true;
                dragon.DragonComp.dragonHit = false;
            }

            if (dragon.DragonComp.Position.X < (wizard.WizComp.Position.X - 600))
            {
                dragon.hide();
                dragonIsDisposed = true;
                dragon.DragonComp.isDisposed = true;





            }


            #endregion
            
            #region dragon2
            if (stage.StageComp.position.X < -1200)
            {
                dragon2.show();
            }



            if (isMoving == true && wizard.WizComp.falling == false)
            {

                if (wizard.WizComp.MainSpriteEffect == SpriteEffects.None)
                {
                    dragon2.DragonComp.velocityX = 5 + wizPosDiff;
                    dragon2.DragonComp.firePos.X += wizPosDiff;
                }
                else
                {
                    dragon2.DragonComp.velocityX = 5 - wizPosDiff;
                    dragon2.DragonComp.firePos.X -= wizPosDiff;
                }

            }
            else
            {
                if (wizard.WizComp.MainSpriteEffect == SpriteEffects.None)
                {
                    dragon2.DragonComp.velocityX = 5;
                }
                else
                {
                    dragon2.DragonComp.velocityX = 5;
                }
            }


            if (dragon2IsDisposed == true)
            {
                dragon2Timer++;
            }

            if (dragon2Timer > 450)
            {

                dragon2.show();

                dragon2IsDisposed = false;
                dragon2.DragonComp.isDisposed = false;
                dragon2.DragonComp.dragonHit = false;

                dragon2Timer = 0;
                dragon2.DragonComp.position.X = wizard.WizComp.Position.X - 600;
                dragon2.DragonComp.position.Y = 600;

            }

            if (dragon2.DragonComp.position.Y > GraphicsDevice.Viewport.Bounds.Height)
            {
                dragon2.hide();
                dragon2IsDisposed = true;
                dragon2.DragonComp.isDisposed = true;
                dragon2.DragonComp.dragonHit = false;
            }

            if (dragon2.DragonComp.Position.X > (wizard.WizComp.Position.X + 600))
            {
                dragon2.hide();
                dragon2IsDisposed = true;
                dragon2.DragonComp.isDisposed = true;





            }

            #endregion 

            #region dragon3
            if (stage.StageComp.position.X < -3500)
            {
                dragon3.show();
            }



            if (isMoving == true && wizard.WizComp.falling == false)
            {

                if (wizard.WizComp.MainSpriteEffect == SpriteEffects.None)
                {
                    dragon3.DragonComp.velocityX = 5 - wizPosDiff;
                    dragon3.DragonComp.firePos.X += wizPosDiff;
                }
                else
                {
                    dragon3.DragonComp.velocityX = 5 + wizPosDiff;
                    dragon3.DragonComp.firePos.X -= wizPosDiff;
                }

            }
            else
            {
                if (wizard.WizComp.MainSpriteEffect == SpriteEffects.None)
                {
                    dragon3.DragonComp.velocityX = 5;
                }
                else
                {
                    dragon3.DragonComp.velocityX = 5;
                }
            }


            if (dragon3IsDisposed == true)
            {
                dragon3Timer++;
            }

            if (dragon3Timer > 450)
            {

                dragon3.show();

                dragon3IsDisposed = false;
                dragon3.DragonComp.isDisposed = false;
                dragon3.DragonComp.dragonHit = false;


                dragon3Timer = 0;
                dragon3.DragonComp.position.X = wizard.WizComp.Position.X - 600;
                dragon3.DragonComp.position.Y = 600;

            }

            if (dragon3.DragonComp.position.Y > GraphicsDevice.Viewport.Bounds.Height)
            {
                dragon3.hide();
                dragon3IsDisposed = true;
                dragon3.DragonComp.isDisposed = true;
                dragon3.DragonComp.dragonHit = false;
            }

            if (dragon3.DragonComp.Position.X < (wizard.WizComp.Position.X - 600))
            {
                dragon3.hide();
                dragon3IsDisposed = true;
                dragon3.DragonComp.isDisposed = true;





            }

            #endregion

            #region goblin logic

            if (goblinIsDiposed == true)
            {
                goblinDeathTimer++;
            }

            if (goblinDeathTimer > 150)
            {

                goblin.show();

                goblinIsDiposed = false;
                goblinDeathTimer = 0;
                goblin.GoblinComp.position.X = wizard.WizComp.Position.X + 600;
                goblin.GoblinComp.goblinHit = false;

            }



            if (goblin.GoblinComp.Position.X < (wizard.WizComp.Position.X - 600))
            {
                goblin.hide();
                goblinIsDiposed = true;
                goblin.GoblinComp.isDisposed = true;





            }


            if (isMoving == true)
            {
                goblin.GoblinComp.goblinMoving = true;
                if (wizard.WizComp.MainSpriteEffect == SpriteEffects.None)
                {
                    goblin.GoblinComp.aiVelocity = 3 - wizPosDiff;
                }
                else
                {
                    goblin.GoblinComp.aiVelocity = 3 + wizPosDiff;
                }
            }

            else
            {

                goblin.GoblinComp.aiVelocity = 3;

            }

            #endregion

            #region goblin2 logic

            if (goblin2IsDiposed == true)
            {
                goblin2DeathTimer++;
            }

            if (goblin2DeathTimer > 150)
            {

                goblin2.show();

                goblin2IsDiposed = false;
                goblin2DeathTimer = 0;
                goblin2.GoblinComp.position.X = wizard.WizComp.Position.X - 600;
                goblin2.GoblinComp.goblinHit = false;

            }



            if (goblin2.GoblinComp.Position.X < (wizard.WizComp.Position.X - 600) && goblin2.GoblinComp.goblinHit == true)
            {
                goblin2.hide();
                goblin2IsDiposed = true;
                goblin2.GoblinComp.isDisposed = true;





            }

           
                if (isMoving == true)
                {
                    goblin2.GoblinComp.goblinMoving = true;
                    if (wizard.WizComp.MainSpriteEffect == SpriteEffects.None)
                    {
                        goblin2.GoblinComp.aiVelocity = 3 + wizPosDiff;
                    }
                    else
                    {
                        goblin2.GoblinComp.aiVelocity = 3 - wizPosDiff;
                    }
                }

                else
                {

                    goblin2.GoblinComp.aiVelocity = 3;

                }
         
          



            #endregion
             
                #region goblin3 logic
                if (goblin3IsDiposed == true)
                {
                    goblin3DeathTimer++;
                }

                if (goblin3DeathTimer > 150)
                {

                    goblin3.show();

                    goblin3IsDiposed = false;
                    goblin3DeathTimer = 0;
                    goblin3.GoblinComp.position.X = wizard.WizComp.Position.X - 600;
                    goblin3.GoblinComp.goblinHit = false;

                }



                if (goblin3.GoblinComp.Position.X < (wizard.WizComp.Position.X - 600) && goblin3.GoblinComp.goblinHit == true)
                {
                    goblin3.hide();
                    goblin3IsDiposed = true;
                    goblin3.GoblinComp.isDisposed = true;





                }


                if (isMoving == true)
                {
                    goblin3.GoblinComp.goblinMoving = true;
                    if (wizard.WizComp.MainSpriteEffect == SpriteEffects.None)
                    {
                        goblin3.GoblinComp.aiVelocity = 3 + wizPosDiff;
                    }
                    else
                    {
                        goblin3.GoblinComp.aiVelocity = 3 - wizPosDiff;
                    }
                }

                else
                {

                    goblin3.GoblinComp.aiVelocity = 3;

                }
                #endregion

                #region goblin4 logic
                if (goblin4IsDiposed == true)
                {
                    goblin4DeathTimer++;
                }

                if (goblin4DeathTimer > 150)
                {

                    goblin4.show();

                    goblin4IsDiposed = false;
                    goblin4DeathTimer = 0;
                    goblin4.GoblinComp.position.X = wizard.WizComp.Position.X - 600;
                    goblin4.GoblinComp.goblinHit = false;

                }



                if (goblin4.GoblinComp.Position.X < (wizard.WizComp.Position.X - 600) && goblin4.GoblinComp.goblinHit == true)
                {
                    goblin4.hide();
                    goblin4IsDiposed = true;
                    goblin4.GoblinComp.isDisposed = true;





                }


                if (isMoving == true)
                {
                    goblin4.GoblinComp.goblinMoving = true;
                    if (wizard.WizComp.MainSpriteEffect == SpriteEffects.None)
                    {
                        goblin4.GoblinComp.aiVelocity = 3 - wizPosDiff;
                    }
                    else
                    {
                        goblin4.GoblinComp.aiVelocity = 3 + wizPosDiff;
                    }
                }

                else
                {

                    goblin4.GoblinComp.aiVelocity = 3;

                }
                #endregion

                #region wizard logic
                wizPosDiff = Math.Abs(wizard.WizComp.OldWizPosX - wizard.WizComp.CurWizPosx);
            if(wizPosDiff == 0)
            {
                isMoving = false;
            }
          

           
                if (wizard.WizComp.MainSpriteEffect == SpriteEffects.None)
                {
                    if (platform.PlatComp.position.X > -1)
                    {
                      
                        isMoving = false;
                        wizard.WizComp.positionFake.X = 0;
                    }
                 
                    else
                    {
                    stage.StageComp.position.X += wizPosDiff;
                    platform.PlatComp.position.X += wizPosDiff;
                     

                        if (wizPosDiff > 0)
                        {
                            isMoving = true;
                        }
                        else
                        {
                            isMoving = false;
                        }

                   

                    }

                  
                   
                    
                }
                else
                {
                    if (wizard.WizComp.positionFake.X > 15)
                    {
                        stage.StageComp.position.X -= wizPosDiff;
                    }
                     if (platform.PlatComp.position.X < -10400)
                    {
                     isMoving = false;

                    }
                    else
                    {
                        platform.PlatComp.position.X -= wizPosDiff;
                        if (wizPosDiff > 0)
                        {
                            isMoving = true;
                        }
                        else
                        {
                            isMoving = false;
                        }
                    }
               
                 
                
                }
            

            #endregion


             



            if (wizard.WizComp.RESTART_GAME == true)
            {
                RESTART_GAME = true;
                wizard.WizComp.characterDead = false;
            }
            else
            {
                RESTART_GAME = false;

            }


            if (wizard.WizComp.navMenu == true)
            {
                navMenu = true;
                wizard.WizComp.characterDead = false;
            }
            else
            {
                navMenu = false;

            }

            //dont look at this sabbir :) its coded well dont worry about it
            #region falling


            if (wizard.WizComp.initalJump == false && wizard.WizComp.jump == false && onBrick1 == false && onBrick2 == false && onBrick3 == false && onBrick4 == false && onBrick5 == false && onBrick6 == false
                 && onBrick7 == false && onBrick8 == false && onBrick9 == false && onBrick10 == false && onBrick11 == false && onBrick12 == false)
            {
              
                if (platform.PlatComp.position.X < fallSpots[0, 0] && platform.PlatComp.position.X > fallSpots[1, 0])
                {
                    wizard.WizComp.falling = true;
                    falling = true;
                    wizard.WizComp.falling2 = true;
                    fallingSpot = "spot1";
                   
                   
                    


                }
                if (platform.PlatComp.position.X > fallSpots[1, 0] && platform.PlatComp.position.X < fallSpots[2, 0])
                {

                    wizard.WizComp.falling = false;
                    falling = false;



                }

                if (platform.PlatComp.position.X < fallSpots[2, 0] && platform.PlatComp.position.X > fallSpots[3, 0])
                {
                    wizard.WizComp.falling = true;
                    falling = true;
                    wizard.WizComp.falling2 = true;
                    fallingSpot = "spot2";


                }
                if (platform.PlatComp.position.X > fallSpots[3, 0] && platform.PlatComp.position.X < fallSpots[4, 0])
                {
                    wizard.WizComp.falling = false;
                    falling = false;



                }

                if (platform.PlatComp.position.X < fallSpots[4, 0] && platform.PlatComp.position.X > fallSpots[5, 0])
                {
                    wizard.WizComp.falling = true;
                    falling = true;
                    wizard.WizComp.falling2 = true;
                    fallingSpot = "spot3";


                }
                if (platform.PlatComp.position.X > fallSpots[5, 0] && platform.PlatComp.position.X < fallSpots[6, 0])
                {
                    wizard.WizComp.falling = false;
                    falling = false;



                }

                if (platform.PlatComp.position.X < fallSpots[6, 0] && platform.PlatComp.position.X > fallSpots[7, 0])
                {
                    wizard.WizComp.falling = true;
                    falling = true;
                    wizard.WizComp.falling2 = true;
                    fallingSpot = "spot4";


                }
                if (platform.PlatComp.position.X > fallSpots[7, 0] && platform.PlatComp.position.X < fallSpots[8, 0])
                {
                    wizard.WizComp.falling = false;
                    falling = false;



                }

                if (platform.PlatComp.position.X < fallSpots[8, 0] && platform.PlatComp.position.X > fallSpots[9, 0])
                {
                    wizard.WizComp.falling = true;
                    falling = true;
                    wizard.WizComp.falling2 = true;
                    fallingSpot = "spot5";


                }
                if (platform.PlatComp.position.X > fallSpots[9, 0] && platform.PlatComp.position.X < fallSpots[10, 0])
                {
                    wizard.WizComp.falling = false;
                    falling = false;



                }

                if (platform.PlatComp.position.X < fallSpots[10, 0] && platform.PlatComp.position.X > fallSpots[11, 0])
                {
                    wizard.WizComp.falling = true;
                    falling = true;
                    wizard.WizComp.falling2 = true;
                    fallingSpot = "spot6";


                }
                if (platform.PlatComp.position.X > fallSpots[11, 0] && platform.PlatComp.position.X < fallSpots[12, 0])
                {
                    wizard.WizComp.falling = false;
                    falling = false;



                }
                if (platform.PlatComp.position.X < fallSpots[12, 0] && platform.PlatComp.position.X > fallSpots[13, 0])
                {
                    wizard.WizComp.falling = true;
                    falling = true;
                    wizard.WizComp.falling2 = true;
                    fallingSpot = "spot7";


                }
                if (platform.PlatComp.position.X > fallSpots[13, 0] && platform.PlatComp.position.X < fallSpots[14, 0])
                {
                    wizard.WizComp.falling = false;
                    falling = false;



                }

                if (platform.PlatComp.position.X < fallSpots[14, 0] && platform.PlatComp.position.X > fallSpots[15, 0])
                {
                    wizard.WizComp.falling = true;
                    falling = true;
                    wizard.WizComp.falling2 = true;
                    fallingSpot = "spot8";


                }
                if (platform.PlatComp.position.X > fallSpots[15, 0] && platform.PlatComp.position.X < fallSpots[16, 0])
                {
                    wizard.WizComp.falling = false;
                    falling = false;



                }
                if (platform.PlatComp.position.X < fallSpots[16, 0] && platform.PlatComp.position.X > fallSpots[17, 0])
                {
                    wizard.WizComp.falling = true;
                    falling = true;
                    wizard.WizComp.falling2 = true;
                    fallingSpot = "spot9";


                }
                if (platform.PlatComp.position.X > fallSpots[17, 0] && platform.PlatComp.position.X < fallSpots[18, 0])
                {
                    wizard.WizComp.falling = false;
                    falling = false;



                }

                if (platform.PlatComp.position.X < fallSpots[18, 0] && platform.PlatComp.position.X > fallSpots[19, 0])
                {
                    wizard.WizComp.falling = true;
                    falling = true;
                    wizard.WizComp.falling2 = true;
                    fallingSpot = "spot10";


                }
                if (platform.PlatComp.position.X > fallSpots[19, 0] && platform.PlatComp.position.X < fallSpots[20, 0])
                {
                    wizard.WizComp.falling = false;
                    falling = false;



                }

                if (platform.PlatComp.position.X < fallSpots[20, 0] && platform.PlatComp.position.X > fallSpots[21, 0])
                {
                    wizard.WizComp.falling = true;
                    falling = true;
                    wizard.WizComp.falling2 = true;
                    fallingSpot = "spot11";


                }
                if (platform.PlatComp.position.X > fallSpots[21, 0] && platform.PlatComp.position.X < fallSpots[22, 0])
                {
                    wizard.WizComp.falling = false;
                    falling = false;



                }

                if (platform.PlatComp.position.X < fallSpots[22, 0] && platform.PlatComp.position.X > fallSpots[23, 0])
                {
                    wizard.WizComp.falling = true;
                    falling = true;
                    wizard.WizComp.falling2 = true;
                    fallingSpot = "spot12";


                }


            }
         
           
               
         

               


               

         

            if(wizard.WizComp.position.Y > 900 )
            {
                wizard.WizComp.damaged = true;
                falling = false;
            }

            #endregion

            #region collisions 
            if (goblin.GoblinComp.goblinHit == false)
             {
                 if (collisionDetecter.Collided(goblin.GoblinComp.spriteWalk1, wizard.WizComp.spriteWalk1,
                          goblin.GoblinComp.Position, wizard.WizComp.Position) == true ||
                          collisionDetecter.Collided(goblin.GoblinComp.spriteWalk2, wizard.WizComp.spriteWalk2,
                          goblin.GoblinComp.Position, wizard.WizComp.Position) == true)
                 {

                     wizard.WizComp.damaged = true;


                 }


             }

             if (goblin2.GoblinComp.goblinHit == false)
             {
                 if (collisionDetecter5.Collided(goblin2.GoblinComp.spriteWalk1, wizard.WizComp.spriteWalk1,
                          goblin2.GoblinComp.Position, wizard.WizComp.Position) == true ||
                          collisionDetecter5.Collided(goblin2.GoblinComp.spriteWalk2, wizard.WizComp.spriteWalk2,
                          goblin2.GoblinComp.Position, wizard.WizComp.Position) == true)
                 {

                     wizard.WizComp.damaged = true;


                 }


             }

             if (goblin3.GoblinComp.goblinHit == false)
             {
                 if (collisionDetecter5.Collided(goblin3.GoblinComp.spriteWalk1, wizard.WizComp.spriteWalk1,
                          goblin3.GoblinComp.Position, wizard.WizComp.Position) == true ||
                          collisionDetecter5.Collided(goblin3.GoblinComp.spriteWalk2, wizard.WizComp.spriteWalk2,
                          goblin3.GoblinComp.Position, wizard.WizComp.Position) == true)
                 {

                     wizard.WizComp.damaged = true;


                 }


             }

             if (goblin4.GoblinComp.goblinHit == false)
             {
                 if (collisionDetecter5.Collided(goblin4.GoblinComp.spriteWalk1, wizard.WizComp.spriteWalk1,
                          goblin4.GoblinComp.Position, wizard.WizComp.Position) == true ||
                          collisionDetecter5.Collided(goblin2.GoblinComp.spriteWalk2, wizard.WizComp.spriteWalk2,
                          goblin4.GoblinComp.Position, wizard.WizComp.Position) == true)
                 {

                     wizard.WizComp.damaged = true;


                 }


             }


             Vector2 correctedPosMissile = new Vector2(wizard.WizComp.currentPos, wizard.WizComp.positionMissile.Y - goblin.GoblinComp.spriteWalk1.Height / 2);

             Vector2 correctedPosMissile2 = new Vector2(wizard.WizComp.prevPos, wizard.WizComp.positionMissile.Y - goblin.GoblinComp.spriteWalk1.Height / 2);
                
            if (wizard.WizComp.drawMissile == true)
             {


                 if (collisionDetecter2.Collided(goblin.GoblinComp.spriteWalk1, wizard.WizComp.rangeMissile,
                 goblin.GoblinComp.Position, correctedPosMissile) ||
                collisionDetecter2.Collided(goblin.GoblinComp.spriteWalk2, wizard.WizComp.rangeMissile,
                goblin.GoblinComp.Position, correctedPosMissile))
                 {

                 
                     scoreTimer++;
                     if (scoreTimer == 1 && goblin.GoblinComp.goblinHit == false)
                      {
                     wizard.WizComp.score += 10;
            
                     }

                     goblin.GoblinComp.goblinHit = true;
                     scoreTimer = 0;

                 }

                 if (goblin2.Enabled)
                 {
                     if (collisionDetecter6.Collided(goblin2.GoblinComp.spriteWalk1, wizard.WizComp.rangeMissile,
                     goblin2.GoblinComp.Position, correctedPosMissile) ||
                    collisionDetecter6.Collided(goblin2.GoblinComp.spriteWalk2, wizard.WizComp.rangeMissile,
                    goblin2.GoblinComp.Position, correctedPosMissile))
                     {

                      

                         scoreTimer++;
                         if (scoreTimer == 1 && goblin2.GoblinComp.goblinHit == false)
                         {
                             wizard.WizComp.score += 10;
                          
                         }
                         goblin2.GoblinComp.goblinHit = true;
                         scoreTimer = 0;

                     }
                 }
                     if(goblin3.Enabled)
                { 
                 if (collisionDetecter6.Collided(goblin3.GoblinComp.spriteWalk1, wizard.WizComp.rangeMissile,
                 goblin3.GoblinComp.Position, correctedPosMissile) ||
                collisionDetecter6.Collided(goblin3.GoblinComp.spriteWalk2, wizard.WizComp.rangeMissile,
                goblin3.GoblinComp.Position, correctedPosMissile))
                 {

                   
                     scoreTimer++;
                     if (scoreTimer == 1 && goblin3.GoblinComp.goblinHit == false)
                     {
                         wizard.WizComp.score += 10;
                      
                     }

                     goblin3.GoblinComp.goblinHit = true;
                     scoreTimer = 0;
                 }

                if(goblin4.Enabled)
                    { 
                     if (collisionDetecter6.Collided(goblin4.GoblinComp.spriteWalk1, wizard.WizComp.rangeMissile,
                     goblin4.GoblinComp.Position, correctedPosMissile) ||
                    collisionDetecter6.Collided(goblin4.GoblinComp.spriteWalk2, wizard.WizComp.rangeMissile,
                    goblin4.GoblinComp.Position, correctedPosMissile))
                         {

                           
                             scoreTimer++;
                             if (scoreTimer == 1 && goblin4.GoblinComp.goblinHit == false)
                             {
                                 wizard.WizComp.score += 10;
                                
                             }

                             goblin4.GoblinComp.goblinHit = true;
                             scoreTimer = 0;
                         }


                     }
            }


             }
             #region lightning
             if (wizard.WizComp.drawLightning == true)
             {
                

                 if (collisionDetecter3.CollidedScaled(wizard.WizComp.lightningTemp, dragon.DragonComp.currentSprite, 
                    wizard.WizComp.positionLight,  dragon.DragonComp.position))
                 {
                  
                     scoreTimer++;
                     if (scoreTimer == 1 && dragon.DragonComp.dragonHit == false)
                     {
                         wizard.WizComp.score += 15;
                         
                     }

                     dragon.DragonComp.dragonHit = true;
                     scoreTimer = 0;
                 }


                 if (collisionDetecter3.CollidedScaled(wizard.WizComp.lightningTemp, dragon.DragonComp.currentSprite,
                    wizard.WizComp.positionLight, dragon.DragonComp.position))
                 {
                   
                     scoreTimer++;
                     if (scoreTimer == 1 && dragon.DragonComp.dragonHit == false)
                     {
                         wizard.WizComp.score += 15;
                         
                     }

                     dragon.DragonComp.dragonHit = true;
                     scoreTimer = 0;
                 }

                 if (collisionDetecter3.CollidedScaled(wizard.WizComp.lightningTemp, dragon2.DragonComp.currentSprite,
                    wizard.WizComp.positionLight, dragon2.DragonComp.position))
                 {
                
                     scoreTimer++;
                     if (scoreTimer == 1 && dragon2.DragonComp.dragonHit == false)
                     {
                         wizard.WizComp.score += 15;
                        
                     }

                     dragon2.DragonComp.dragonHit = true;
                     scoreTimer = 0;
                 }


                 if (collisionDetecter3.CollidedScaled(wizard.WizComp.lightningTemp, dragon2.DragonComp.currentSprite,
                    wizard.WizComp.positionLight, dragon2.DragonComp.position))
                 {
                   
                     scoreTimer++;
                     if (scoreTimer == 1 && dragon2.DragonComp.dragonHit == false)
                     {
                         wizard.WizComp.score += 15;
                         
                     }

                     dragon2.DragonComp.dragonHit = true;
                     scoreTimer = 0;
                 }

                 if (collisionDetecter3.CollidedScaled(wizard.WizComp.lightningTemp, dragon3.DragonComp.currentSprite,
                    wizard.WizComp.positionLight, dragon3.DragonComp.position))
                 {
                     
                     scoreTimer++;
                     if (scoreTimer == 1 && dragon3.DragonComp.dragonHit == false)
                     {
                         wizard.WizComp.score += 15;
                        
                     }

                     dragon3.DragonComp.dragonHit = true;
                     scoreTimer = 0;
                 }


                 if (collisionDetecter3.CollidedScaled(wizard.WizComp.lightningTemp, dragon3.DragonComp.currentSprite,
                    wizard.WizComp.positionLight, dragon3.DragonComp.position))
                 {
                    
                       scoreTimer++;
                       if (scoreTimer == 1 && dragon3.DragonComp.dragonHit == false)
                      {
                     wizard.WizComp.score += 10;
                    
                     }

                       dragon3.DragonComp.dragonHit = true;
                       scoreTimer = 0;
                 }

                 if (collisionDetecter12.CollidedScaled(goblin.GoblinComp.spriteWalk1, wizard.WizComp.lightningTemp,
               goblin.GoblinComp.Position, wizard.WizComp.positionLight) ||
              collisionDetecter2.CollidedScaled(goblin.GoblinComp.spriteWalk2, wizard.WizComp.lightningTemp,
              goblin.GoblinComp.Position, wizard.WizComp.positionLight))
                 {

                 

                     scoreTimer++;
                     if (scoreTimer == 1 && goblin.GoblinComp.goblinHit == false)
                     {
                         wizard.WizComp.score += 10;
                         
                     }

                     goblin.GoblinComp.goblinHit = true;
                     scoreTimer = 0;
                 }


                 if (collisionDetecter13.CollidedScaled(goblin2.GoblinComp.spriteWalk1, wizard.WizComp.lightningTemp,
               goblin2.GoblinComp.Position, wizard.WizComp.positionLight) ||
              collisionDetecter2.CollidedScaled(goblin2.GoblinComp.spriteWalk2, wizard.WizComp.lightningTemp,
              goblin2.GoblinComp.Position, wizard.WizComp.positionLight))
                 {

                  

                     scoreTimer++;
                     if (scoreTimer == 1 && goblin2.GoblinComp.goblinHit == false)
                     {
                         wizard.WizComp.score += 10;
                         
                     }

                     goblin2.GoblinComp.goblinHit = true;
                     scoreTimer = 0;
                 }

                   if (collisionDetecter13.CollidedScaled(goblin3.GoblinComp.spriteWalk1, wizard.WizComp.lightningTemp,
               goblin3.GoblinComp.Position, wizard.WizComp.positionLight) ||
              collisionDetecter2.CollidedScaled(goblin3.GoblinComp.spriteWalk2, wizard.WizComp.lightningTemp,
              goblin3.GoblinComp.Position, wizard.WizComp.positionLight))
                 {

                  

                     scoreTimer++;
                     if (scoreTimer == 1 && goblin3.GoblinComp.goblinHit == false)
                     {
                         wizard.WizComp.score += 10;
                        
                     }

                     goblin3.GoblinComp.goblinHit = true;
                     scoreTimer = 0;
                 }

                   if (collisionDetecter13.CollidedScaled(goblin4.GoblinComp.spriteWalk1, wizard.WizComp.lightningTemp,
               goblin4.GoblinComp.Position, wizard.WizComp.positionLight) ||
              collisionDetecter2.CollidedScaled(goblin4.GoblinComp.spriteWalk2, wizard.WizComp.lightningTemp,
              goblin4.GoblinComp.Position, wizard.WizComp.positionLight))
                 {

              

                     scoreTimer++;
                     if (scoreTimer == 1 && goblin4.GoblinComp.goblinHit == false)
                     {
                         wizard.WizComp.score += 10;
                         
                     }
                     goblin4.GoblinComp.goblinHit = true;
                     scoreTimer = 0;
                 }


             }
             #endregion

             #region dragon1
             if(dragon.DragonComp.drawFire == true)
             {
                 if (collisionDetecter4.Collided(dragon.DragonComp.fireBolt, wizard.WizComp.currentSprite,
                 dragon.DragonComp.firePos, wizard.WizComp.position)  )
                 
                 {
                     wizard.WizComp.damaged = true;

                 }
             }

             if (dragon.DragonComp.isDisposed == false)
             {
                 if (collisionDetecter8.Collided(dragon.DragonComp.currentSprite, wizard.WizComp.currentSprite,
                 dragon.DragonComp.position, wizard.WizComp.position))
                 {
                     wizard.WizComp.damaged = true;

                 }
             }

             if (dragon.DragonComp.isDisposed == false)
             {
                 if (collisionDetecter11.Collided(dragon.DragonComp.currentSprite, wizard.WizComp.rangeMissile,
                 dragon.DragonComp.position, correctedPosMissile))
                 {
                    
                     scoreTimer++;
                     if (scoreTimer == 1 && dragon.DragonComp.dragonHit == false)
                     {
                         wizard.WizComp.score += 15;
                     
                     }
                     dragon.DragonComp.dragonHit = true;
                     scoreTimer = 0;
                 }
             }
             #endregion

             #region dragon2

             if (dragon2.DragonComp.drawFire == true)
             {
                 if (collisionDetecter4.Collided(dragon2.DragonComp.fireBolt, wizard.WizComp.currentSprite,
                 dragon2.DragonComp.firePos, wizard.WizComp.position))

                 {
                     wizard.WizComp.damaged = true;

                 }
             }

             if (dragon2.DragonComp.isDisposed == false)
             {
                 if (collisionDetecter8.Collided(dragon2.DragonComp.currentSprite, wizard.WizComp.currentSprite,
                 dragon2.DragonComp.position, wizard.WizComp.position))
                 {
                     wizard.WizComp.damaged = true;

                 }
             }

             if (dragon2.DragonComp.isDisposed == false)
             {
                 if (collisionDetecter11.Collided(dragon2.DragonComp.currentSprite, wizard.WizComp.rangeMissile,
                 dragon2.DragonComp.position, correctedPosMissile))
                 {
                   
                     scoreTimer++;
                     if (scoreTimer == 1 && dragon2.DragonComp.dragonHit == false)
                     {
                         wizard.WizComp.score += 15;
                         
                     }
                     dragon2.DragonComp.dragonHit = true;
                     scoreTimer = 0;
                 }
             }
             #endregion

               #region dragon3
            if (dragon3.DragonComp.drawFire == true)
             {
                 if (collisionDetecter4.Collided(dragon3.DragonComp.fireBolt, wizard.WizComp.currentSprite,
                 dragon3.DragonComp.firePos, wizard.WizComp.position))

                 {
                     wizard.WizComp.damaged = true;

                 }
             }

             if (dragon3.DragonComp.isDisposed == false)
             {
                 if (collisionDetecter8.Collided(dragon3.DragonComp.currentSprite, wizard.WizComp.currentSprite,
                 dragon3.DragonComp.position, wizard.WizComp.position))
                 {
                     wizard.WizComp.damaged = true;

                 }
             }

             if (dragon3.DragonComp.isDisposed == false)
             {
                 if (collisionDetecter11.Collided(dragon3.DragonComp.currentSprite, wizard.WizComp.rangeMissile,
                 dragon3.DragonComp.position, correctedPosMissile))
                 {
                
                     scoreTimer++;
                     if (scoreTimer == 1 && dragon3.DragonComp.dragonHit == false)
                     {
                         wizard.WizComp.score += 15;
                       
                     }
                     dragon3.DragonComp.dragonHit = true;
                     scoreTimer = 0;
                 }
             }
            #endregion
  

            #endregion



            if (wizard.WizComp.position.Y > platform.PlatComp.rect.Top)
            {
                wizard.WizComp.falling2 = true;
            }

            #region END-DOOR

            if(platform.PlatComp.position.X < -9800)
            {
                door.show();

                if (isMoving == true)
                {
                    if (wizard.WizComp.MainSpriteEffect == SpriteEffects.None)
                    {
                        door.ObjComp.position.X += wizPosDiff;
                    }
                    else
                    {
                        door.ObjComp.position.X -= wizPosDiff;
                    }
                }
            }

            if(collisionDetecter9.Collided(wizard.WizComp.currentSprite, door.ObjComp.endObject, wizard.WizComp.position, door.ObjComp.position))
            {
                gameWon = true;
            }






            #endregion




            goblin.GoblinComp.wizPosDifAI = wizPosDiff;
           goblin2.GoblinComp.wizPosDifAI = wizPosDiff;
            goblin.GoblinComp.tempEffect = wizard.WizComp.MainSpriteEffect;
            goblin2.GoblinComp.tempEffect = wizard.WizComp.MainSpriteEffect;

            goblin3.GoblinComp.wizPosDifAI = wizPosDiff;
            goblin3.GoblinComp.wizPosDifAI = wizPosDiff;
            goblin4.GoblinComp.tempEffect = wizard.WizComp.MainSpriteEffect;
            goblin4.GoblinComp.tempEffect = wizard.WizComp.MainSpriteEffect;
     
            base.Update(gameTime);
        }
        public override void Draw(GameTime gameTime)
        {

            base.Draw(gameTime);
        }

    }


}
