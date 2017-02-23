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
    class Dragon2 : GameScene
    {
        private SpriteBatch spriteBatch;
        private Texture2D spriteFly1;
        private Texture2D spriteFly2;
        private Texture2D fireBolt;

        private Texture2D missile;
        private Texture2D spriteDamaged1;
        private Texture2D spriteDamaged2;
        private Texture2D spriteDead;
        private Vector2 position;
        private Vector2 speed;

        private SoundEffect death;
        private SoundEffect fire;

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


        private Characters.AI_Component_Fly dragonComp;

        public Characters.AI_Component_Fly DragonComp
        {
            get
            {
                return dragonComp;
            }
            set
            {
                dragonComp = value;
            }

        }

        public const float STAGE_HEIGHT = 650;

        Random rndHeight = new Random();

        public Dragon2(Game game,
            SpriteBatch spriteBatch)
            : base(game)
        {

            this.spriteBatch = spriteBatch;
            spriteFly1 = game.Content.Load<Texture2D>("images/dragonFly1");
            spriteFly2 = game.Content.Load<Texture2D>("images/dragonFly2");


            spriteDamaged1 = game.Content.Load<Texture2D>("Images/dragonHurt");
            fireBolt = game.Content.Load<Texture2D>("Images2/fireBolt");
            death = game.Content.Load<SoundEffect>("Sound/dragDeath");
            fire = game.Content.Load<SoundEffect>("Sound/fire");



            position = new Vector2(GraphicsDevice.Viewport.Bounds.Width / 2, STAGE_HEIGHT - spriteFly1.Height);
            dragonComp = new Characters.AI_Component_Fly(game, spriteBatch,
                position = new Vector2(0, rndHeight.Next(200, 600)),
                speed,
               spriteFly1,
               spriteFly2,
               spriteDamaged1,
               fireBolt,
               false,
               death,
               fire
                );

            this.Components.Add(dragonComp);


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
