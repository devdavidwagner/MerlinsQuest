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
    class AI_Component_Fly : DrawableGameComponent
    {
        private SpriteBatch spriteBatch;
        public Vector2 position;

        private Vector2 positionMissile;
        private Vector2 origin;
        private Vector2 originMissile;
        private Vector2 speed;

        private Texture2D missileTemp;


        public Texture2D spriteFly1;
        public Texture2D spriteFly2;
        public Texture2D fireBolt;
        public Texture2D fireBoltTemp;

        public Vector2 firePos;

        private SoundEffect death;
        private SoundEffect fire;


        public Texture2D currentSprite;

       private Texture2D spriteDamaged;
      //  private Texture2D spriteDamaged2;
     //   private Texture2D spriteDead;

        private SpriteEffects mainSpriteEffect;

        public bool dragonHit = false;
        public bool direction = false;


        public AI_Component_Fly(Game game,
            SpriteBatch spriteBatch,
            Vector2 position,
            Vector2 speed,
            Texture2D spriteFly1, Texture2D spriteFly2,
            Texture2D spriteDamaged, Texture2D fireBolt,
            bool direction, SoundEffect death, SoundEffect fire


            )
            : base(game)
        {
            this.spriteBatch = spriteBatch;
            this.position = position;
            this.speed = speed;
            

            this.spriteFly1 = spriteFly1;
            this.spriteFly2 = spriteFly2;
            this.spriteDamaged = spriteDamaged;
            this.fireBolt = fireBolt;

            this.direction = direction;
            this.death = death;
            this.fire = fire;


            currentSprite = spriteFly1;
            mainSpriteEffect = SpriteEffects.None;






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



        Random rndHeight = new Random();

        int flyTime = 0;
        public float velocityX = 5f;

        public bool isDisposed = false;
        public bool dragonMoving = false;
        int fireTimer = 0;
        int drawTimer = 0;
        public bool drawFire = false;
        int deathTimer = 0;
        public override void Update(GameTime gameTime)
        {
            if(isDisposed == true)
            {
                fireTimer = 0;
            }
            if (direction == true)
            {
                mainSpriteEffect = SpriteEffects.None;
                if (drawFire == true)
                {
                    firePos.X -= 10;
                    firePos.Y += 5;



                    drawTimer++;
                    if (drawTimer > 50)
                    {
                        drawFire = false;
                        fireTimer = 0;
                        drawTimer = 0;
                    }
                }

                if (dragonHit == false)
                {
                    deathTimer = 0;
                    if (isDisposed == false)
                    {

                        flyTime++;
                        if (drawFire == false)
                        {
                            fireTimer++;
                            if(fireTimer == 10)
                            {
                                fire.Play();
                            }
                            if (fireTimer > 10)
                            {
                                firePos = position;
                                firePos.X = firePos.X + 10;

                                drawFire = true;

                            }
                        }


                        if (flyTime < 20)
                        {
                            currentSprite = spriteFly1;
                        }
                        else if (flyTime > 20)
                        {
                            currentSprite = spriteFly2;
                            if (flyTime > 40)
                                flyTime = 0;
                        }

                        position.X -= velocityX;
                    }
                    else
                    {
                        currentSprite = spriteFly1;


                        isDisposed = false;

                        currentSprite = spriteFly2;
                        position = new Vector2(1200, rndHeight.Next(200, 600));
                    }


                }
                else
                {
                    deathTimer++;
                    if(deathTimer == 1)
                    {
                        death.Play();
                    }
                    currentSprite = spriteDamaged;
                    position.X -= velocityX;
                    position.Y += 10;

                }
            }


            if(direction == false)
            {
                mainSpriteEffect = SpriteEffects.FlipHorizontally;
                if (drawFire == true)
                {
                    firePos.X += 10;
                    firePos.Y += 5;



                    drawTimer++;
                    if (drawTimer > 50)
                    {
                        drawFire = false;
                        fireTimer = 0;
                        drawTimer = 0;
                    }
                }

                if (dragonHit == false)
                {
                    deathTimer = 0;
                    if (isDisposed == false)
                    {

                        flyTime++;
                        if (drawFire == false)
                        {
                            fireTimer++;
                            if (fireTimer == 1)
                            {
                                fire.Play();
                            }
                            if (fireTimer > 40)
                            {
                                firePos = position;
                                firePos.X = firePos.X + currentSprite.Width +100;

                                drawFire = true;

                            }
                        }


                        if (flyTime < 20)
                        {
                            currentSprite = spriteFly1;
                        }
                        else if (flyTime > 20)
                        {
                            currentSprite = spriteFly2;
                            if (flyTime > 40)
                                flyTime = 0;
                        }

                        position.X += velocityX;
                    }
                    else
                    {
                        currentSprite = spriteFly1;


                        isDisposed = false;

                        currentSprite = spriteFly2;
                        position = new Vector2(0, rndHeight.Next(200, 600));
                    }


                }
                else
                {
                    currentSprite = spriteDamaged;
                    position.X += velocityX;
                    position.Y += 10;

                    deathTimer++;
                    if (deathTimer == 1)
                    {
                        death.Play();
                    }

                }






            }
            base.Update(gameTime);
        }
        public override void Draw(GameTime gameTime)
        {
            spriteBatch.Begin();


            spriteBatch.Draw(currentSprite, position, null, Color.White, 0f, Vector2.Zero, 2f, mainSpriteEffect, 1f);


           


            if (drawFire == true)
            {
                spriteBatch.Draw(fireBolt, firePos, null, Color.White, 0.5f , Vector2.Zero, 2f, mainSpriteEffect, 1f);
            }


            spriteBatch.End();

            base.Draw(gameTime);
        }

    }
}
