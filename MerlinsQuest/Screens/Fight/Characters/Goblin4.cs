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
    class Goblin4 : GameScene
    {
        private SpriteBatch spriteBatch;
        private Texture2D spriteWalk1;
        private Texture2D spriteWalk2;


        private Texture2D missile;
        private Texture2D spriteDamaged1;
        private Texture2D spriteDamaged2;
        private Texture2D spriteDead;
        private Vector2 position;
        private Vector2 speed;

        private SoundEffect death;

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


        private Characters.AI_Component goblinComp;

        public Characters.AI_Component GoblinComp
        {
            get
            {
                return goblinComp;
            }
            set
            {
                goblinComp = value;
            }

        }

        public const float STAGE_HEIGHT = 650;


        public Goblin4(Game game,
            SpriteBatch spriteBatch)
            : base(game)
        {

            this.spriteBatch = spriteBatch;
            spriteWalk1 = game.Content.Load<Texture2D>("Images/goblinWalk1");
            spriteWalk2 = game.Content.Load<Texture2D>("Images/goblinWalk2");


            spriteDamaged1 = game.Content.Load<Texture2D>("Images2/goblinDamaged1");
            spriteDamaged2 = game.Content.Load<Texture2D>("Images2/goblinDamaged2");
            spriteDead = game.Content.Load<Texture2D>("Images2/goblinDead");
            death = game.Content.Load<SoundEffect>("Sound/gobDeath");


            position = new Vector2(GraphicsDevice.Viewport.Bounds.Width / 2, STAGE_HEIGHT - spriteWalk1.Height);
            goblinComp = new Characters.AI_Component(game, spriteBatch,
                position = new Vector2(1200, 586),
               spriteWalk1,
               spriteWalk2,
               spriteDamaged1,
               spriteDamaged2,
               spriteDead,
               SpriteEffects.FlipHorizontally,
               true,
               death
                );

            this.Components.Add(goblinComp);


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
