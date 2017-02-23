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


namespace MerlinsQuest.Screens.Fight.Characters
{
    class CharacterComponent : DrawableGameComponent 
    {
        private SpriteBatch spriteBatch;

        SpriteFont myFont;
        public Vector2 position;
        public Vector2 positionMissile;
        private Vector2 origin;
        private Vector2 originMissile;
        private Vector2 speed;
        public Vector2 positionLight;

        private Texture2D missileTemp;


        public Texture2D spriteWalk1;
        public Texture2D spriteWalk2;

        private Texture2D spriteRange1;
        private Texture2D spriteRange2;
        private Texture2D spriteRange3;
        private Texture2D spriteRange4;


        private Texture2D spriteCast1;
        private Texture2D spriteCast2;
        private Texture2D spriteCast3;

        public Texture2D lightningTemp;
        private Texture2D lightningCloud; 
        public Texture2D lightningBolt;




        private Texture2D spriteDamaged1;
        private Texture2D spriteDamaged2;
        private Texture2D spriteDead;
        private Texture2D spriteJump;
    

        public Texture2D rangeMissile;
        public Texture2D currentSprite;

        private SoundEffect death;
        private SoundEffect lightning;
        private SoundEffect laser;
        public SoundEffect jump1snd;
        public SoundEffect jump2snd;

        private SpriteEffects mainSpriteEffect;

        public SpriteEffects MainSpriteEffect
        {
            get
            {
                return mainSpriteEffect;
            }
            set
            {
                mainSpriteEffect = value;
            }
        }

        public Vector2 Position
        {
            get
            {
                return position;
            }
            set
            {
                position = value;
            }
        }
    


        public CharacterComponent(Game game,
            SpriteBatch spriteBatch,
            Vector2 position,
            Vector2 speed,
            Texture2D spriteWalk1, Texture2D spriteWalk2,
            Texture2D spriteRange1, Texture2D spriteRange2, Texture2D spriteRange3, Texture2D spriteRange4,
            Texture2D spriteDamaged1, Texture2D spriteDamaged2, Texture2D spriteDead,
            Texture2D lightningCloud, Texture2D lightningBolt, 
            Texture2D spriteCast1, Texture2D spriteCast2, Texture2D spriteCast3,
            Texture2D spriteJump,
            Texture2D rangeMissile,
            SoundEffect death, SoundEffect lightning, SoundEffect laser,
            SoundEffect jump1snd, SoundEffect jump2snd
            ) : base(game)
        {
            this.spriteBatch = spriteBatch;
            this.position = position;
            this.speed = speed;
            this.origin = origin;

            this.spriteWalk1 = spriteWalk1;
            this.spriteWalk2 = spriteWalk2;

            this.spriteDamaged1 = spriteDamaged1;
            this.spriteDamaged2 = spriteDamaged2;

            this.lightningCloud = lightningCloud;
            this.lightningBolt = lightningBolt;


            currentSprite = spriteWalk1;
            mainSpriteEffect = SpriteEffects.FlipHorizontally;
         

         this.spriteRange1 = spriteRange1;
         this.spriteRange2 = spriteRange2; ;
         this.spriteRange3 = spriteRange3; ;
         this.spriteRange4 = spriteRange4; ;


         this.spriteCast1 = spriteCast1;
         this.spriteCast2 = spriteCast2;
         this.spriteCast3 = spriteCast3;
 

            this.spriteJump = spriteJump;

            this.jump1snd = jump1snd;
            this.jump2snd = jump2snd;

            this.lightning = lightning;
            this.laser = laser;
            this.death = death;


            
       //  this.spriteBlock1 = spriteBlock1;
       //  this.spriteBlock2 = spriteBlock2; 
       //  this.spriteBlock3 = spriteBlock3; 
       //  this.spriteBlock4 = spriteBlock4; 

       this.spriteDead = spriteDead;

       this.rangeMissile = rangeMissile;

       myFont = game.Content.Load<SpriteFont>("Font/regularFont");
        }
       
        public override void Initialize()
        {

            base.Initialize();
        }

        KeyboardState previous_KS;

        int counterWalk = 0;
        int counterAttack = 0;
        int counterRange = 0;
        bool cast = false;
        public bool range = false;
        bool missileFire = false;
        public bool drawMissile = false;
        private float oldWizPosX = 0;
        private float curWizPosX = 0;
        public Vector2 positionFake;

        int oneCount = 0;
        public Vector2 realMissilePos;

        Texture2D lastWalkSprite;

        public Vector2 PositionFake
        {
            get
            {
                return positionFake;
            }
            set
            {
                positionFake = value;
            }
        }

        public float OldWizPosX
        {
            get
            {
                return oldWizPosX;
            }
            set
            {
                oldWizPosX = value;
            }
        }

        public float CurWizPosx
        {
            get
            {
                return curWizPosX;
            }
            set
            {
                curWizPosX = value;
            }

        }

        public bool damaged = false;
        public bool characterDead = false;
        int damageCounter = 0;

        private Texture2D oldSprite;

        SpriteEffects tempEffect;

        public float velocityX = 4f, velocityY = 10f;     // Velocity of the character
        float gravity = 0.5f;

        public bool jump = false;
        public bool initalJump = false;
        public bool falling = false;
        public bool falling2 = false;
        public bool fallingOffBrick1 = false;
        public bool fallingOffBrick2 = false;
        public bool fallingOffBrick3 = false;
        public bool fallingOffBrick4 = false;
        public bool fallingOffBrick5 = false;
        public bool fallingOffBrick6 = false;

        bool lightningCast = false;
        public bool drawLightning = false;
        Vector2 lastPosition;
        Vector2 staticPos;

        int heightJumped = 0;
        int lightningTimer = 0;

        static Vector2 preCastPos;
        static Vector2 preCastPos2;

        public bool navMenu = false;
        public bool RESTART_GAME = false;

      

        public override void Update(GameTime gameTime)
        {
           

            #region restart

            RESTART_GAME = false;
           
           if(characterDead == true)
           {
               KeyboardState dead_KS = Keyboard.GetState();

               if(dead_KS.IsKeyDown(Keys.Enter))
               {
                   
                   //resets game
                  
                   currentSprite = spriteWalk1;
                   position = new Vector2(GraphicsDevice.Viewport.Bounds.Width / 2, Wizard.STAGE_HEIGHT - spriteWalk1.Height);
                   score = 0;
                  
                   characterDead = false;
                   
                   RESTART_GAME = true;
               }

               if (dead_KS.IsKeyDown(Keys.Escape))
               {

                   //resets game

                   currentSprite = spriteWalk1;
                   position = new Vector2(GraphicsDevice.Viewport.Bounds.Width / 2, Wizard.STAGE_HEIGHT - spriteWalk1.Height);
                   score = 0;

                   characterDead = false;

                   navMenu = true;
               }
            
           }
#endregion
           KeyboardState current_KS = Keyboard.GetState();

            oldWizPosX = positionFake.X;

       
           
            //damage

            #region damage
            if (damaged == true)
            {
               
                
                currentSprite = spriteDamaged1;
                damageCounter++;
                if(damageCounter == 1)
                {
                    death.Play();
                }
                if(damageCounter > 10 && damageCounter < 30)
                {
                    currentSprite = spriteDamaged2;
                }
                else if(damageCounter > 30 )
                {
                    currentSprite = spriteDead;
                    characterDead = true;
                }
            }
            #endregion
         
            if (characterDead == false)
            {

            



                //setting missile pos

                if (drawMissile == false)
                {
                    positionMissile.Y = 0;
                    positionMissile.X = 0;
                    missileTemp = null;
                }

                if (falling == true )
                {
                      position.Y += velocityY * gravity;
                      if (position.Y > Wizard.STAGE_HEIGHT - spriteWalk1.Height)
                      {

                          falling = false;
                       
                      }
                }

                //walking logic
                #region walking
                //WALKING LOGIC
                if (cast == false && range == false)
                {
                    counterWalk++;
                   
                      

                        if (current_KS.IsKeyDown(Keys.A))
                        {
                            counterWalk++;
                            mainSpriteEffect = SpriteEffects.None;
                            if (counterWalk > 20)
                            {
                                currentSprite = spriteWalk2;
                                if (counterWalk > 40)
                                    counterWalk = 0;

                            }
                            else
                            {
                                currentSprite = spriteWalk1;
                            }


                            positionFake.X -= velocityX;

                        }

                        if (current_KS.IsKeyDown(Keys.D))
                        {
                            counterWalk++;
                            mainSpriteEffect = SpriteEffects.FlipHorizontally;
                            if (counterWalk > 20)
                            {
                                currentSprite = spriteWalk2;

                                if (counterWalk > 40)
                                    counterWalk = 0;
                            }
                            else
                            {
                                currentSprite = spriteWalk1;
                            }

                            positionFake.X += velocityX;

                        }
                    
               
                    lastWalkSprite = currentSprite;
                }
             

                #endregion

           
                //CAST ATTACK LOGIC
                #region attacking
                if (current_KS.IsKeyDown(Keys.F))
                {
                    cast = true;
                    preCastPos = position;
                    preCastPos2 = position;
                    //Console.WriteLine(preCastPos.ToString());
                }
                if (cast == true)
                {
                 
                    counterAttack++;
                    if (counterAttack < 5)
                    {
                        currentSprite = spriteCast1;
                  
                    }
                    else if (counterAttack > 5 && counterAttack < 10)
                    {
                        currentSprite = spriteCast2;
                   

                        positionLight.Y = position.Y - 300;
                        if (mainSpriteEffect == SpriteEffects.FlipHorizontally)
                        {
                            positionLight.X = position.X + 100;
                        }
                        else
                        {
                            positionLight.X = position.X - 200;
                        }
                        lightningCast = true;
                    }
                    else if (counterAttack > 15 && counterAttack < 20)
                    {
                        currentSprite = spriteCast3;
                    

                       
                    }
                    else if (counterAttack > 25 && counterAttack < 30)
                    {
                        currentSprite = spriteCast2;
                 

                    }
                    else if (counterAttack > 30)
                    {
                  
                    
                        currentSprite = spriteWalk1;
                        counterAttack = 0;
                        cast = false;
                    }
                  
                }


                #endregion

                //RANGE LOGIC
                #region range

                if (current_KS.IsKeyDown(Keys.R))
                {
                    range = true;
                }
                if (range == true)
                {
                    counterRange++;
                    if (counterRange < 5)
                    {
                        currentSprite = spriteRange1;
                    }
                    else if (counterRange > 5 && counterRange < 10)
                    {
                        currentSprite = spriteRange2;
                    }
                    else if (counterRange > 15 && counterRange < 20)
                    {
                        currentSprite = spriteRange3;
                    }
                    else if (counterRange > 25 && counterRange < 30)
                    {
                        currentSprite = spriteRange4;
                        missileFire = true;
                        tempEffect = mainSpriteEffect;

                    }
                    else if (counterRange > 30)
                    {
                        currentSprite = spriteWalk1;
                        counterRange = 0;
                        range = false;
                    }
                }

                #endregion

                //missile logic
                #region Missile
                if (missileFire == true)
                {
                  
                    if (oneCount < 1)
                    {
                        oneCount++;
                        positionMissile.Y = position.Y + 80;
                        positionMissile.X = position.X + 10;
                        laser.Play();
            
                    }
                    if (distanceTraveled < MISSILE_RANGE)
                    {
                        missileTemp = rangeMissile;
                        drawMissile = true;
                        if (tempEffect == SpriteEffects.None)
                        {
                            missileSpriteEffect = SpriteEffects.FlipHorizontally;
                            if (missileCounter < 3)
                            {

                                positionMissile.Y = position.Y + 80;
                                positionMissile.X = position.X - 10;
                            }
                            else
                            {
                                prevPos = positionMissile.X;
                                positionMissile.X -= 10;
                                currentPos = positionMissile.X;
                            }
                        }
                        else
                        {
                            missileSpriteEffect = SpriteEffects.None;
                            if (missileCounter < 1)
                            {
                                positionMissile.Y = position.Y + 80;
                                positionMissile.X = position.X + 10;
                            }
                            else if (missileCounter > 1)
                            {
                                prevPos = positionMissile.X;
                                positionMissile.X += 10;
                                currentPos = positionMissile.X;


                            }
                        }


                        missileCounter++;

             
                        distanceTraveled += Math.Abs(currentPos - prevPos);
                    }
                    else
                    {
                        distanceTraveled = 0;
                        missileFire = false;
                        drawMissile = false;
                        oneCount = 0;
                        missileTemp = null;

                        oneCount = 0;

                    }


                }
                #endregion


                //jumping logic
                #region jumping
          
                if (falling2 == false)
                {
                    if (current_KS.IsKeyDown(Keys.Space) && previous_KS.IsKeyUp(Keys.Space))
                    {
                        initalJump = true;
                     
                    }

                }
                    if (initalJump == true )
                    {

                        position.Y -= velocityY - (velocityY * gravity);


                        currentSprite = spriteJump;
                        heightJumped++;
                        if(heightJumped == 1)
                        {
                            jump1snd.Play();
                        }
                       
                        if (heightJumped > 37)
                        {
                        
                            heightJumped = 0;
                            jump = true;
                            initalJump = false;
                        }

                    }
                
                    if (jump == true)
                    {
                       falling2 = true;
                        currentSprite = spriteJump;
                        position.Y += velocityY + (velocityY * gravity);
                        if (position.Y > Wizard.STAGE_HEIGHT - spriteWalk1.Height)
                        {
                            jump2snd.Play();
                            position.Y = Wizard.STAGE_HEIGHT - spriteWalk1.Height;
                            jump = false;
                           falling2 = false;
                            currentSprite = spriteWalk1;

                        }


                    }


               
                #endregion



                //gaps


                //LIGHTINING
                #region lightning
                if (lightningCast == true)
                {
                     lightningTemp = lightningCloud;
                  
                  
                    lightningTimer++;
                    if(lightningTimer == 1)
                    {
                        lightning.Play();
                    }
                    drawLightning = true;

                    if (lightningTimer > 10 && lightningTimer <30)
                    {
                        lightningTemp = lightningBolt;
                    }
                
                  
                    if (lightningTimer >30)
                    {
                        lightningTemp = null;
                        lightningTimer = 0;
                        lightningCast = false;
                        drawLightning = false;
                    }


                }

                #endregion

                current_KS = previous_KS;

                curWizPosX = positionFake.X;

                oldSprite = currentSprite;
            }
            base.Update(gameTime);
        }

        int missileCounter = 0;
        private SpriteEffects missileSpriteEffect;
        const float MISSILE_RANGE = 350;
        public float distanceTraveled = 0;
        public float prevPos = 0;
        public float currentPos = 0;

        public int score = 0;
        public override void Draw(GameTime gameTime)
        {
            spriteBatch.Begin();
            missileSpriteEffect = SpriteEffects.None;

            spriteBatch.Draw(currentSprite, position, null, Color.White, 0f, Vector2.Zero, 2f, mainSpriteEffect, 1f);

         





            if (drawMissile == true)
            {
               // missileTemp = rangeMissile ;
                spriteBatch.Draw(missileTemp, positionMissile, null, Color.White, 0f, Vector2.Zero, 2f, missileSpriteEffect, 1f);

            }

           if(characterDead == true)
           {

               Texture2D texture = new Texture2D(spriteBatch.GraphicsDevice, 1, 1);

               texture.SetData(new[] { Color.IndianRed });
               Rectangle obj1Rect = new Rectangle((int)GraphicsDevice.Viewport.Bounds.Width / 2 -(int) myFont.MeasureString("GAME OVER!\n SCORE = " + score.ToString() + " \n Enter to Restart \n Esc to Return to Menu").Length() / 2,
                   (int)GraphicsDevice.Viewport.Bounds.Width / 2 + 150, (int)myFont.MeasureString("GAME OVER!\n SCORE = " + score.ToString() + " \n Enter to Restart \n Esc to Return to Menu").Length(), myFont.LineSpacing * 4);

               spriteBatch.Draw(texture, obj1Rect, Color.IndianRed);
               spriteBatch.DrawString(myFont, "GAME OVER!\n SCORE = " + score.ToString() + " \n Enter to Restart \n Esc to Return to Menu", new Vector2(GraphicsDevice.Viewport.Bounds.Width / 2 - myFont.MeasureString("GAME OVER!\n SCORE = " + score.ToString() + " \n Enter to Restart \n Esc to Return to Menu").Length() / 2,
                  GraphicsDevice.Viewport.Bounds.Width / 2 + 150), Color.Black);
           }

           if (drawLightning == true)
            {
                spriteBatch.Draw(lightningTemp, positionLight, null, Color.White, 0f, Vector2.Zero, 2f, SpriteEffects.None, 1f);

               


            }

           Texture2D textureRect = new Texture2D(spriteBatch.GraphicsDevice, 1, 1);

           textureRect.SetData(new[] { Color.IndianRed });
           Rectangle fontBack = new Rectangle((int)myFont.MeasureString("SCORE: " + score.ToString()).Length() / 2, (int)myFont.LineSpacing / 2, (int)myFont.MeasureString("SCORE: " + score.ToString()).Length(), myFont.LineSpacing);

           spriteBatch.Draw(textureRect, fontBack, Color.White);

           spriteBatch.DrawString(myFont, "SCORE: " + score.ToString(), new Vector2(myFont.MeasureString("SCORE: " + score.ToString()).Length() / 2,  myFont.LineSpacing /2 ), Color.Black);

            spriteBatch.End();



            base.Draw(gameTime);
        }

    }
}
