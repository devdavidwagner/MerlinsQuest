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
    class Wizard : GameScene
    {
        private SpriteBatch spriteBatch;
        private Texture2D spriteWalk1;
        private Texture2D spriteWalk2;
        private Texture2D spriteCast1;
        private Texture2D spriteCast2;
        private Texture2D spriteCast3;
        private Texture2D spriteCast4;

        private Texture2D spriteRange1;
        private Texture2D spriteRange2;
        private Texture2D spriteRange3;
        private Texture2D spriteRange4;

        private Texture2D spriteDamaged1;
        private Texture2D spriteDamaged2;
        private Texture2D spriteDead;

        private Texture2D spriteJump;

        private Texture2D missile;

        private Texture2D lightningCloud;
        private Texture2D lightningBolt1;
        private Texture2D lightningBolt2;
        
        private SoundEffect death;
        private SoundEffect lightning;
        private SoundEffect laser;
        private SoundEffect jump1snd;
        private SoundEffect jump2snd;

        private Vector2 position;
        private Vector2 speed;

   

        private Characters.CharacterComponent wizComp;

        public Characters.CharacterComponent WizComp
        {
            get
            {
                return wizComp;
            }
            set
            {
                wizComp = value;
            }

        }

        public const float STAGE_HEIGHT = 650;


        public Wizard(Game game,
            SpriteBatch spriteBatch)
            : base(game)
        {

            this.spriteBatch = spriteBatch;
            spriteWalk1 =  game.Content.Load<Texture2D>("Images/wizardWalk1");
            spriteWalk2 = game.Content.Load<Texture2D>("Images/wizardWalk2");
            spriteCast1 = game.Content.Load<Texture2D>("Images/wizardCast1");
            spriteCast2 = game.Content.Load<Texture2D>("Images/wizardCast2");
            spriteCast3 = game.Content.Load<Texture2D>("Images/wizardCast3");

            spriteRange1 = game.Content.Load<Texture2D>("Images/wizardRange1");
            spriteRange2 = game.Content.Load<Texture2D>("Images/wizardRange2");
            spriteRange3 = game.Content.Load<Texture2D>("Images/wizardRange3");
            spriteRange4 = game.Content.Load<Texture2D>("Images/wizardRange4");

            spriteDamaged1 = game.Content.Load<Texture2D>("Images2/wizardDamaged1");
            spriteDamaged2 = game.Content.Load<Texture2D>("Images2/wizardDamaged2");

            spriteDead = game.Content.Load<Texture2D>("Images2/wizardDead");

            missile = game.Content.Load<Texture2D>("Images/missile");

            spriteJump = game.Content.Load<Texture2D>("Images2/wizardJump");

            lightningCloud = game.Content.Load<Texture2D>("Images2/clouds");
            lightningBolt1 = game.Content.Load<Texture2D>("Images2/lightningCloud22");

             death = game.Content.Load<SoundEffect>("Sound/death");
             lightning = game.Content.Load<SoundEffect>("Sound/lightning");
             laser = game.Content.Load<SoundEffect>("Sound/laser");
             jump1snd = game.Content.Load<SoundEffect>("Sound/jump1");
             jump2snd = game.Content.Load<SoundEffect>("Sound/jump2");

            position = new Vector2(GraphicsDevice.Viewport.Bounds.Width / 2, STAGE_HEIGHT - spriteWalk1.Height);
            wizComp = new Characters.CharacterComponent(game, spriteBatch,
                position, 
                speed,
               spriteWalk1,
               spriteWalk2,
               spriteRange1,
               spriteRange2,
               spriteRange3,
               spriteRange4,
               spriteDamaged1,
               spriteDamaged2,
                spriteDead,
               lightningCloud,
               lightningBolt1,
               spriteCast1,
               spriteCast2,
               spriteCast3,
              
               spriteJump,
               missile,
               death,lightning,laser,jump1snd,jump2snd

                );

            this.Components.Add(wizComp);
           

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
