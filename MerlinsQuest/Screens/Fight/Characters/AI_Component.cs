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
    class AI_Component : DrawableGameComponent
    {
        private SpriteBatch spriteBatch;
        public Vector2 position;

        private Vector2 positionMissile;
        private Vector2 origin;
        private Vector2 originMissile;
        private Vector2 speed;

        private Texture2D missileTemp;


        public Texture2D spriteWalk1;
        public Texture2D spriteWalk2;


        private Texture2D currentSprite;

         private Texture2D spriteDamaged1;
        private Texture2D spriteDamaged2;
        private Texture2D spriteDead;

        public SpriteEffects mainSpriteEffect;
        private bool direction;

        private SoundEffect death;

        public AI_Component(Game game,
            SpriteBatch spriteBatch,
            Vector2 position,
            Texture2D spriteWalk1, Texture2D spriteWalk2,
          Texture2D spriteDamaged1, Texture2D spriteDamaged2, Texture2D spriteDead,
            SpriteEffects mainSpriteEffect, bool direction, SoundEffect death
          
            )
            : base(game)
        {
            this.spriteBatch = spriteBatch;
            this.position = position;
        
       

            this.spriteWalk1 = spriteWalk1;
            this.spriteWalk2 = spriteWalk2;

            this.spriteDamaged1 = spriteDamaged1;
            this.spriteDamaged2 = spriteDamaged2;
            this.spriteDead = spriteDead;

            currentSprite = spriteWalk1;
            this.mainSpriteEffect = mainSpriteEffect;
            this.direction = direction;

            this.death = death;


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

        public bool goblinMoving = false;
    

        public override void Initialize()
        {

            base.Initialize();
        }

        KeyboardState previous_KS;

        int counterGoblinWalk = 0;
        int counterAttack = 0;
        int counterRange = 0;
        bool melee = false;
        bool range = false;
        bool missileFire = false;
        public bool goblinHit = false;

        public float wizPosDifAI;
        int deathTimer = 0;

        public float aiVelocity = 3;
        public SpriteEffects tempEffect;

        public bool isDisposed = false;

        public bool wizFalling = false;



        public override void Update(GameTime gameTime)
        {


            counterGoblinWalk++;

            if (isDisposed == true)
            {
                currentSprite = spriteWalk1;
                goblinHit = false;
                deathTimer = 0;
                isDisposed = false;

          

            }
         
            if (direction == true)
            {
                
                    if (goblinHit == true)
                    {
                        if (tempEffect == SpriteEffects.FlipHorizontally)
                        {
                            position.X -= wizPosDifAI;

                        }
                        else
                        {
                            position.X += wizPosDifAI;
                        }

                        deathTimer++;
                        if (deathTimer == 1)
                        {
                            death.Play();
                        }
                        if (deathTimer < 20)
                        {
                            currentSprite = spriteDamaged1;
                        }
                        else if (deathTimer > 20 && deathTimer < 40)
                        {
                            currentSprite = spriteDamaged2;
                        }
                        else if (deathTimer > 40)
                        {
                            currentSprite = spriteDead;
                        }



                    }
                    else
                    {
                        
                            if (counterGoblinWalk < 20)
                            {
                                currentSprite = spriteWalk1;
                                position.X -= aiVelocity;

                            }
                            else if (counterGoblinWalk > 20)
                            {
                                currentSprite = spriteWalk2;
                                position.X -= aiVelocity;
                                if (counterGoblinWalk > 40)
                                    counterGoblinWalk = 0;


                            }
                       
                       
                    }


               
            }
            else
            {
               
                    if (goblinHit == true)
                    {
                        if (tempEffect == SpriteEffects.FlipHorizontally)
                        {
                            position.X -= wizPosDifAI;

                        }
                        else
                        {
                            position.X += wizPosDifAI;
                        }

                        deathTimer++;
                        if(deathTimer == 1)
                        {
                            death.Play();
                        }
                        if (deathTimer < 20)
                        {
                            currentSprite = spriteDamaged1;
                        }
                        else if (deathTimer > 20 && deathTimer < 40)
                        {
                            currentSprite = spriteDamaged2;
                        }
                        else if (deathTimer > 40)
                        {
                            currentSprite = spriteDead;
                        }



                    }
                    else
                    {
                        
                            if (counterGoblinWalk < 20)
                            {
                                currentSprite = spriteWalk1;
                                position.X += aiVelocity;

                            }
                            else if (counterGoblinWalk > 20)
                            {
                                currentSprite = spriteWalk2;
                                position.X += aiVelocity;
                                if (counterGoblinWalk > 40)
                                    counterGoblinWalk = 0;


                            }
                      
                      
                    }


               
            }
     
      
         
            base.Update(gameTime);
        }

     
        public override void Draw(GameTime gameTime)
        {
            spriteBatch.Begin();

        
                spriteBatch.Draw(currentSprite, position, null, Color.White, 0f, Vector2.Zero, 2f, mainSpriteEffect, 1f);

            

            spriteBatch.End();

            base.Draw(gameTime);
        }

    }
}
