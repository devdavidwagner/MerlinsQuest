﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;


namespace MerlinsQuest.Screens.Fight.Platform
{
    class ObstacleComponent : DrawableGameComponent
    {

        SpriteBatch spriteBatch;
        public Texture2D obstacle;
        public Vector2 position;

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

        public Texture2D Obstacle
        {
            get
            {
                return obstacle;
            }
            set
            {
                obstacle = value;
            }
        }


        public ObstacleComponent(Game game,
            SpriteBatch spriteBatch,
            Texture2D obstacle
            )
            : base(game)
        {

            this.spriteBatch = spriteBatch;
            this.obstacle = obstacle;
            

            

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
            spriteBatch.Begin();

            spriteBatch.Draw(obstacle, position, null, Color.White, 0f, Vector2.Zero, 1f, SpriteEffects.None, 1f);
         
            spriteBatch.End();
            base.Draw(gameTime);
        }


    }
}
